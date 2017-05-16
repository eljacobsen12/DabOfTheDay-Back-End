Module Module1
    Public conn As Common.DbConnection
    Public connectionString As String
    Public isConnected As Boolean = False
    'Web Server Username and Password here
    Private webUN As String = "eljacobsen12"
    Private webPW As String = "Look@me3times"

    'Disconnect from Database
    Public Sub disconnectDB()
        conn.Close()
        conn.Dispose()
        isConnected = False
    End Sub

    'Establish Connection to Database
    Public Sub connectDB()
        Dim server, user_id, password, database As String

        'server = localhost;user id=root;persistsecurityinfo=True;database=daboftheday
        database = "database=daboftheday"
        server = "server=localhost"    'Or 127.0.0.1
        user_id = "user id=root"
        password = "Pwd=Look@me3times"
        connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=daboftheday;password=Look@me3times"                'server & ";" & user_id & ";" & database
        conn = New MySql.Data.MySqlClient.MySqlConnection(connectionString)

        Try
            conn.Open()
            MessageBox.Show("Connection to the Database has been opened.")
            isConnected = True
        Catch myerror As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Cannot connect to the Database: " & myerror.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub postToWebsite(myObj As String)
        Dim myFile() As Byte
        Dim clsRequest As Net.FtpWebRequest
        If myObj = "Fact" Then
            'Set up Request
            clsRequest = DirectCast(Net.WebRequest.Create("ftp://daboftheday.com/Fact"), Net.FtpWebRequest)
            clsRequest.Credentials = New Net.NetworkCredential(webUN, webPW)
            clsRequest.Method = Net.WebRequestMethods.Ftp.UploadFile
            'Read in File
            myFile = IO.File.ReadAllBytes("C:\DabOfTheDay\DabOfTheDayHTML\Text\Fact.txt")     'HTML File Location
        ElseIf myObj = "Picture" Then
            clsRequest = DirectCast(Net.WebRequest.Create("ftp://daboftheday.com/Picture"), Net.FtpWebRequest)
            clsRequest.Credentials = New Net.NetworkCredential(webUN, webPW)
            clsRequest.Method = Net.WebRequestMethods.Ftp.UploadFile
            myFile = IO.File.ReadAllBytes("C:\DabOfTheDay\DabOfTheDayHTML\Text\Picture.txt")     'HTML File Location
        ElseIf myObj = "Highlight" Then
            clsRequest = DirectCast(Net.WebRequest.Create("ftp://daboftheday.com/Highlight"), Net.FtpWebRequest)
            clsRequest.Credentials = New Net.NetworkCredential(webUN, webPW)
            clsRequest.Method = Net.WebRequestMethods.Ftp.UploadFile
            myFile = IO.File.ReadAllBytes("C:\DabOfTheDay\DabOfTheDayHTML\Text\Highlight.txt")     'HTML File Location
        ElseIf myObj = "Quote" Then
            clsRequest = DirectCast(Net.WebRequest.Create("ftp://daboftheday.com/Quote"), Net.FtpWebRequest)
            clsRequest.Credentials = New Net.NetworkCredential(webUN, webPW)
            clsRequest.Method = Net.WebRequestMethods.Ftp.UploadFile
            myFile = IO.File.ReadAllBytes("C:\DabOfTheDay\DabOfTheDayHTML\Text\Quote.txt")     'HTML File Location
        ElseIf myObj = "Song" Then
            clsRequest = DirectCast(Net.WebRequest.Create("ftp://daboftheday.com/Song"), Net.FtpWebRequest)
            clsRequest.Credentials = New Net.NetworkCredential(webUN, webPW)
            clsRequest.Method = Net.WebRequestMethods.Ftp.UploadFile
            myFile = IO.File.ReadAllBytes("C:\DabOfTheDay\DabOfTheDayHTML\Text\Song.txt")     'HTML File Location
        ElseIf myObj = "Word" Then
            clsRequest = DirectCast(Net.WebRequest.Create("ftp://daboftheday.com/Word"), Net.FtpWebRequest)
            clsRequest.Credentials = New Net.NetworkCredential(webUN, webPW)
            clsRequest.Method = Net.WebRequestMethods.Ftp.UploadFile
            myFile = IO.File.ReadAllBytes("C:\DabOfTheDay\DabOfTheDayHTML\Text\Word.txt")     'HTML File Location
        Else
            myFile = Nothing
            clsRequest = Nothing
            MsgBox("Incorrect Object.")
        End If
        If Not myFile.Equals(Nothing) And Not clsRequest.Equals(Nothing) Then
            'Upload File
            Dim clsStream As IO.Stream = clsRequest.GetRequestStream()
            clsStream.Write(myFile, 0, myFile.Length)
            clsStream.Close()
            clsStream.Dispose()
        End If
    End Sub

    Private Sub createHTML(myObj As String)
        If myObj = "Fact" Then

        ElseIf myObj = "Picture" Then

        ElseIf myObj = "Highlight" Then

        ElseIf myObj = "Quote" Then

        ElseIf myObj = "Song" Then

        ElseIf myObj = "Word" Then

        End If
    End Sub

    Public Function createNewPost(myObj As String)
        Dim wordID, picID, quoteID, factID, highlightID, songID, IDcount As Integer
        Dim tags() As String = Nothing
        Dim idArray() As String = Nothing
        Dim tempTagArray() As String = Nothing
        Dim tempIDArray() As Integer = Nothing
        Dim hitcountArray() As Integer = Nothing
        Dim myNum As Integer = 0
        Dim myNum2 As Integer = 0
        wordID = Nothing
        picID = Nothing
        quoteID = Nothing
        factID = Nothing
        highlightID = Nothing
        songID = Nothing
        IDcount = Nothing
        Dim i As Integer = 0
        Dim bool As Boolean = False
        'Get current system date
        Dim currentDate As Date = Date.Today.ToString("mm-dd")
        '********************         FACT          *********************
        If myObj = "fact" Then
            idArray = queryTableForTag("fact_tags", currentDate)
            If idArray.Count <> 0 Then
                If idArray.Count > 1 Then
                    factID = compareCounts("facts", idArray)
                Else
                    factID = idArray(0)
                End If
            Else
                If factID <> Nothing Or picID <> Nothing Or highlightID <> Nothing Or quoteID <> Nothing Or wordID <> Nothing Then
                    If picID <> Nothing And myObj <> "picture" Then
                        tags.Union(getTags("pictures", picID))
                    End If
                    If highlightID <> Nothing And myObj <> "highlight" Then
                        tags.Union(getTags("highlights", highlightID))
                    End If
                    If quoteID <> Nothing And myObj <> "quote" Then
                        tags.Union(getTags("quote", quoteID))
                    End If
                    If songID <> Nothing And myObj <> "song" Then
                        tags.Union(getTags("songs", songID))
                    End If
                    If wordID <> Nothing And myObj <> "word" Then
                        tags.Union(getTags("words", wordID))
                    End If
                Else
                    'Select a Random Fact   *****ADJUST TO SELECT AMONG RECORDS WITH LOWEST COUNT*****
                    factID = randomID("facts")
                End If
            End If
            '********************       PICTURE        *********************
        ElseIf myObj = "picture" Then
            idArray = queryTableForTag("picture_tags", currentDate)
            If idArray.Count <> 0 Then
                If idArray.Count > 1 Then
                    picID = compareCounts("pictures", idArray)
                Else
                    picID = idArray(0)
                End If
            Else
                'If no currentDate in Pictures, get factID Tags and search for those
                If factID <> Nothing Or picID <> Nothing Or highlightID <> Nothing Or quoteID <> Nothing Or wordID <> Nothing Then
                    If picID <> Nothing And myObj <> "picture" Then
                        tags.Union(getTags("pictures", picID))
                    End If
                    If highlightID <> Nothing And myObj <> "highlight" Then
                        tags.Union(getTags("highlights", highlightID))
                    End If
                    If quoteID <> Nothing And myObj <> "quote" Then
                        tags.Union(getTags("quote", quoteID))
                    End If
                    If songID <> Nothing And myObj <> "song" Then
                        tags.Union(getTags("songs", songID))
                    End If
                    If wordID <> Nothing And myObj <> "word" Then
                        tags.Union(getTags("words", wordID))
                    End If
                End If
                If tags.Count <> 0 Then
                    For Each tag In tags
                        'Gets all synonyms of tag and adds to tags() without duplicates
                        tags.Union(getSynonyms(tag))
                    Next
                    For Each tag In tags
                        'Get all ID's associated with tag
                        tempTagArray = queryTableForTag("pictures", tags(i))
                        If tempTagArray.Count > 0 Then
                            If tempTagArray.Count > 1 Then
                                'For Each ID generate/adjust hitcount
                                For Each temp In tempTagArray
                                    If idArray.Contains(temp) Then
                                        myNum = idArray.ToList.IndexOf(temp)
                                        hitcountArray(myNum) = hitcountArray(myNum) + 1
                                    Else
                                        redimArray(idArray, temp)
                                        redimArray(hitcountArray, 1)
                                    End If
                                Next
                                'Create Array of only ID's with largest hitcounts
                                tempIDArray = getArrayIndexOfLargest(hitcountArray)
                                idArray = getArrayOfTableIDsWithLargestHitCount(tempIDArray, idArray)
                                picID = compareCounts("pictures", idArray)
                            Else
                                picID = tempTagArray(0)
                            End If
                        Else
                            i += 1
                        End If
                    Next
                Else
                    picID = randomID("pictures")
                End If
            End If
            '********************      HIGHLIGHT      *********************
        ElseIf myObj = "highlight" Then
            idArray = queryTableForTag("highlight_tags", currentDate)
            If idArray.Count <> 0 Then
                If idArray.Count > 1 Then
                    highlightID = compareCounts("highlights", idArray)
                Else
                    highlightID = idArray(0)
                End If
            Else
                If factID <> Nothing Or picID <> Nothing Or highlightID <> Nothing Or quoteID <> Nothing Or wordID <> Nothing Then
                    If picID <> Nothing And myObj <> "picture" Then
                        tags.Union(getTags("pictures", picID))
                    End If
                    If highlightID <> Nothing And myObj <> "highlight" Then
                        tags.Union(getTags("highlights", highlightID))
                    End If
                    If quoteID <> Nothing And myObj <> "quote" Then
                        tags.Union(getTags("quote", quoteID))
                    End If
                    If songID <> Nothing And myObj <> "song" Then
                        tags.Union(getTags("songs", songID))
                    End If
                    If wordID <> Nothing And myObj <> "word" Then
                        tags.Union(getTags("words", wordID))
                    End If
                End If
                If tags.Count <> 0 Then
                    For Each tag In tags
                        'Gets all synonyms of tag and adds to tags() without duplicates
                        tags.Union(getSynonyms(tag))
                    Next
                    For Each tag In tags
                        'Get all ID's associated with tag
                        tempTagArray = queryTableForTag("highlights", tags(i))
                        If tempTagArray.Count > 0 Then
                            If tempTagArray.Count > 1 Then
                                'For Each ID generate/adjust hitcount
                                For Each temp In tempTagArray
                                    If idArray.Contains(temp) Then
                                        myNum = idArray.ToList.IndexOf(temp)
                                        hitcountArray(myNum) = hitcountArray(myNum) + 1
                                    Else
                                        redimArray(idArray, temp)
                                        redimArray(hitcountArray, 1)
                                    End If
                                Next
                                'Create Array of only ID's with largest hitcounts
                                tempIDArray = getArrayIndexOfLargest(hitcountArray)
                                idArray = getArrayOfTableIDsWithLargestHitCount(tempIDArray, idArray)
                                highlightID = compareCounts("highlights", idArray)
                            Else
                                highlightID = tempTagArray(0)
                            End If
                        Else
                            i += 1
                        End If
                    Next
                Else
                    highlightID = randomID("highlights")
                End If
            End If
            '********************        QUOTE        *********************
        ElseIf myObj = "quote" Then
            idArray = queryTableForTag("quote_tags", currentDate)
            If idArray.Count <> 0 Then
                If idArray.Count > 1 Then
                    quoteID = compareCounts("highlights", idArray)
                Else
                    quoteID = idArray(0)
                End If
            Else
                If factID <> Nothing Or picID <> Nothing Or highlightID <> Nothing Or quoteID <> Nothing Or wordID <> Nothing Then
                    If picID <> Nothing And myObj <> "picture" Then
                        tags.Union(getTags("pictures", picID))
                    End If
                    If highlightID <> Nothing And myObj <> "highlight" Then
                        tags.Union(getTags("highlights", highlightID))
                    End If
                    If quoteID <> Nothing And myObj <> "quote" Then
                        tags.Union(getTags("quote", quoteID))
                    End If
                    If songID <> Nothing And myObj <> "song" Then
                        tags.Union(getTags("songs", songID))
                    End If
                    If wordID <> Nothing And myObj <> "word" Then
                        tags.Union(getTags("words", wordID))
                    End If
                End If
                If tags.Count <> 0 Then
                    For Each tag In tags
                        'Gets all synonyms of tag and adds to tags() without duplicates
                        tags.Union(getSynonyms(tag))
                    Next
                    For Each tag In tags
                        'Get all ID's associated with tag
                        tempTagArray = queryTableForTag("quotes", tags(i))
                        If tempTagArray.Count > 0 Then
                            If tempTagArray.Count > 1 Then
                                'For Each ID generate/adjust hitcount
                                For Each temp In tempTagArray
                                    If idArray.Contains(temp) Then
                                        myNum = idArray.ToList.IndexOf(temp)
                                        hitcountArray(myNum) = hitcountArray(myNum) + 1
                                    Else
                                        redimArray(idArray, temp)
                                        redimArray(hitcountArray, 1)
                                    End If
                                Next
                                'Create Array of only ID's with largest hitcounts
                                tempIDArray = getArrayIndexOfLargest(hitcountArray)
                                idArray = getArrayOfTableIDsWithLargestHitCount(tempIDArray, idArray)
                                quoteID = compareCounts("quotes", idArray)
                            Else
                                quoteID = tempTagArray(0)
                            End If
                        Else
                            i += 1
                        End If
                    Next
                Else
                    quoteID = randomID("quotes")
                End If
            End If
            '********************        SONG         *********************
        ElseIf myObj = "song" Then
            idArray = queryTableForTag("song_tags", currentDate)
            If idArray.Count <> 0 Then
                If idArray.Count > 1 Then
                    songID = compareCounts("songs", idArray)
                Else
                    songID = idArray(0)
                End If
            Else
                If factID <> Nothing Or picID <> Nothing Or highlightID <> Nothing Or quoteID <> Nothing Or wordID <> Nothing Then
                    If picID <> Nothing And myObj <> "picture" Then
                        tags.Union(getTags("pictures", picID))
                    End If
                    If highlightID <> Nothing And myObj <> "highlight" Then
                        tags.Union(getTags("highlights", highlightID))
                    End If
                    If quoteID <> Nothing And myObj <> "quote" Then
                        tags.Union(getTags("quote", quoteID))
                    End If
                    If songID <> Nothing And myObj <> "song" Then
                        tags.Union(getTags("songs", songID))
                    End If
                    If wordID <> Nothing And myObj <> "word" Then
                        tags.Union(getTags("words", wordID))
                    End If
                End If
                If tags.Count <> 0 Then
                    For Each tag In tags
                        'Gets all synonyms of tag and adds to tags() without duplicates
                        tags.Union(getSynonyms(tag))
                    Next
                    For Each tag In tags
                        'Get all ID's associated with tag
                        tempTagArray = queryTableForTag("songs", tags(i))
                        If tempTagArray.Count > 0 Then
                            If tempTagArray.Count > 1 Then
                                'For Each ID generate/adjust hitcount
                                For Each temp In tempTagArray
                                    If idArray.Contains(temp) Then
                                        myNum = idArray.ToList.IndexOf(temp)
                                        hitcountArray(myNum) = hitcountArray(myNum) + 1
                                    Else
                                        redimArray(idArray, temp)
                                        redimArray(hitcountArray, 1)
                                    End If
                                Next
                                'Create Array of only ID's with largest hitcounts
                                tempIDArray = getArrayIndexOfLargest(hitcountArray)
                                idArray = getArrayOfTableIDsWithLargestHitCount(tempIDArray, idArray)
                                songID = compareCounts("songs", idArray)
                            Else
                                songID = tempTagArray(0)
                            End If
                        Else
                            i += 1
                        End If
                    Next
                Else
                    songID = randomID("songs")
                End If
            End If
            '********************        WORD         *********************
        ElseIf myObj = "word" Then
            'Select a random wordID
            wordID = randomID("words")
        End If
        If myObj = "fact" Then
            Return factID
        ElseIf myObj = "picture" Then
            Return picID
        ElseIf myObj = "highlight" Then
            Return highlightID
        ElseIf myObj = "quote" Then
            Return quoteID
        ElseIf myObj = "song" Then
            Return songID
        ElseIf myObj = "word" Then
            Return wordID
        Else
            MessageBox.Show("ERROR: No Object Specified.")
            Return Nothing
        End If
    End Function

    'Function to Query Database Table for Tag
    Private Function queryTableForTag(myTable As String, myTag As String)
        Dim data2 As MySql.Data.MySqlClient.MySqlDataReader
        Dim adapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim command2 As New MySql.Data.MySqlClient.MySqlCommand
        Dim recordsWithTags() As String = Nothing
        Dim i As Integer = 0

        conn.Open()

        command2.CommandText = "SELECT @id FROM @myTable WHERE tag = @myTag;"
        command2.Connection = conn

        'Facts
        If myTable = "fact_tags" Then
            i = 0
            command2.Parameters.AddWithValue("id", "fact_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myTag", myTag)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                recordsWithTags(i) = data2.GetString("fact_id")
                i += 1
            End While
            'Pictures
        ElseIf myTable = "picture_tags" Then
            i = 0
            command2.Parameters.AddWithValue("id", "picture_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myTag", myTag)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                recordsWithTags(i) = data2.GetString("picture_id")
                i += 1
            End While
            'Highlights
        ElseIf myTable = "highlight_tags" Then
            i = 0
            command2.Parameters.AddWithValue("id", "highlight_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myTag", myTag)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                recordsWithTags(i) = data2.GetString("highlight_id")
                i += 1
            End While
            'Quotes
        ElseIf myTable = "quote_tags" Then
            i = 0
            command2.Parameters.AddWithValue("id", "quote_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myTag", myTag)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                recordsWithTags(i) = data2.GetString("quote_id")
                i += 1
            End While
            'Songs
        ElseIf myTable = "song_tags" Then
            i = 0
            command2.Parameters.AddWithValue("id", "song_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myTag", myTag)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                recordsWithTags(i) = data2.GetString("song_id")
                i += 1
            End While
        ElseIf myTable = "word_tags" Then
            i = 0
            command2.Parameters.AddWithValue("id", "word_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myTag", myTag)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                recordsWithTags(i) = data2.GetString("word_id")
                i += 1
            End While
        End If
        Return recordsWithTags
        data2.Close()
    End Function

    'Get Tags for Object ID
    Private Function getTags(myTable As String, myID As String)
        Dim data2 As MySql.Data.MySqlClient.MySqlDataReader
        Dim adapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim command2 As New MySql.Data.MySqlClient.MySqlCommand
        Dim myTags() As String = Nothing
        Dim i As Integer = 0

        conn.Open()

        command2.CommandText = "SELECT tag FROM @myTable WHERE @myTableID = @myID;"
        command2.Connection = conn

        'Facts
        If myTable = "fact_tags" Then
            i = 0
            command2.Parameters.AddWithValue("myTableID", "fact_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myID)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                myTags(i) = data2.GetString("tag")
                i += 1
            End While
            'Pictures
        ElseIf myTable = "picture_tags" Then
            i = 0
            command2.Parameters.AddWithValue("myTableID", "picture_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myID)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                myTags(i) = data2.GetString("tag")
                i += 1
            End While
            'Highlights
        ElseIf myTable = "highlight_tags" Then
            i = 0
            command2.Parameters.AddWithValue("myTableID", "highlight_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myID)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                myTags(i) = data2.GetString("tag")
                i += 1
            End While
            'Quotes
        ElseIf myTable = "quote_tags" Then
            i = 0
            command2.Parameters.AddWithValue("myTableID", "quote_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myID)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                myTags(i) = data2.GetString("tag")
                i += 1
            End While
            'Songs
        ElseIf myTable = "song_tags" Then
            i = 0
            command2.Parameters.AddWithValue("myTableID", "song_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myID)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                myTags(i) = data2.GetString("tag")
                i += 1
            End While
        ElseIf myTable = "word_tags" Then
            i = 0
            command2.Parameters.AddWithValue("myTableID", "word_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myID)
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader

            While data2.HasRows
                data2.Read()
                myTags(i) = data2.GetString("tag")
                i += 1
            End While
        End If
        Return myTags
        data2.Close()
    End Function

    'Compare two different ID Counts
    Public Function compareCounts(myTable As String, myArray() As String)
        Dim data2 As MySql.Data.MySqlClient.MySqlDataReader
        Dim adapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim command2 As New MySql.Data.MySqlClient.MySqlCommand
        Dim myCount1 As String = Nothing
        Dim myCount2 As String = Nothing
        Dim randomNum As Integer = Nothing
        Dim lowestCount As String = Nothing
        Dim i As Integer = 1

        conn.Open()

        command2.CommandText = "SELECT count FROM @myTable WHERE @myTableID = @myID;"
        command2.Connection = conn

        'Facts
        If myTable = "facts" Then
            command2.Parameters.AddWithValue("myTableID", "fact_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myArray(0))
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader
            While data2.HasRows
                data2.Read()
                myCount1 = data2.GetString("count")
                lowestCount = myArray(0)
            End While
            While i < myArray.Count
                command2.Parameters.AddWithValue("myID", myArray(i))
                adapter2.SelectCommand = command2
                data2 = command2.ExecuteReader
                While data2.HasRows
                    data2.Read()
                    myCount2 = data2.GetString("count")
                    If myCount1 > myCount2 Then
                        myCount1 = myCount2
                        lowestCount = myArray(i)
                    ElseIf myCount1 = myCount2 Then
                        'Randomly Choose One
                        randomNum = CInt(Math.Ceiling(Rnd() * 2)) + 1
                        If randomNum = 1 Then
                            myCount1 = myCount2
                            lowestCount = myArray(i)
                        End If
                    End If
                End While
            End While
            'Pictures
        ElseIf myTable = "pictures" Then
            command2.Parameters.AddWithValue("myTableID", "picture_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myArray(0))
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader
            While data2.HasRows
                data2.Read()
                myCount1 = data2.GetString("count")
            End While
            While i < myArray.Count
                command2.Parameters.AddWithValue("myID", myArray(i))
                adapter2.SelectCommand = command2
                data2 = command2.ExecuteReader
                While data2.HasRows
                    data2.Read()
                    myCount2 = data2.GetString("count")
                    If myCount1 > myCount2 Then
                        myCount1 = myCount2
                        lowestCount = myArray(i)
                    ElseIf myCount1 = myCount2 Then
                        'Randomly Choose One
                        randomNum = CInt(Math.Ceiling(Rnd() * 2)) + 1
                        If randomNum = 1 Then
                            myCount1 = myCount2
                            lowestCount = myArray(i)
                        End If
                    End If
                End While
            End While
            'Highlights
        ElseIf myTable = "highlights" Then
            command2.Parameters.AddWithValue("myTableID", "highlight_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myArray(0))
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader
            While data2.HasRows
                data2.Read()
                myCount1 = data2.GetString("count")
            End While
            While i < myArray.Count
                command2.Parameters.AddWithValue("myID", myArray(i))
                adapter2.SelectCommand = command2
                data2 = command2.ExecuteReader
                While data2.HasRows
                    data2.Read()
                    myCount2 = data2.GetString("count")
                    If myCount1 > myCount2 Then
                        myCount1 = myCount2
                        lowestCount = myArray(i)
                    ElseIf myCount1 = myCount2 Then
                        'Randomly Choose One
                        randomNum = CInt(Math.Ceiling(Rnd() * 2)) + 1
                        If randomNum = 1 Then
                            myCount1 = myCount2
                            lowestCount = myArray(i)
                        End If
                    End If
                End While
            End While
            'Quotes
        ElseIf myTable = "quotes" Then
            command2.Parameters.AddWithValue("myTableID", "quote_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myArray(0))
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader
            While data2.HasRows
                data2.Read()
                myCount1 = data2.GetString("count")
            End While
            While i < myArray.Count
                command2.Parameters.AddWithValue("myID", myArray(i))
                adapter2.SelectCommand = command2
                data2 = command2.ExecuteReader
                While data2.HasRows
                    data2.Read()
                    myCount2 = data2.GetString("count")
                    If myCount1 > myCount2 Then
                        myCount1 = myCount2
                        lowestCount = myArray(i)
                    ElseIf myCount1 = myCount2 Then
                        'Randomly Choose One
                        randomNum = CInt(Math.Ceiling(Rnd() * 2)) + 1
                        If randomNum = 1 Then
                            myCount1 = myCount2
                            lowestCount = myArray(i)
                        End If
                    End If
                End While
            End While
            'Songs
        ElseIf myTable = "songs" Then
            command2.Parameters.AddWithValue("myTableID", "song_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myArray(0))
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader
            While data2.HasRows
                data2.Read()
                myCount1 = data2.GetString("count")
            End While
            While i < myArray.Count
                command2.Parameters.AddWithValue("myID", myArray(i))
                adapter2.SelectCommand = command2
                data2 = command2.ExecuteReader
                While data2.HasRows
                    data2.Read()
                    myCount2 = data2.GetString("count")
                    If myCount1 > myCount2 Then
                        myCount1 = myCount2
                        lowestCount = myArray(i)
                    ElseIf myCount1 = myCount2 Then
                        'Randomly Choose One
                        randomNum = CInt(Math.Ceiling(Rnd() * 2)) + 1
                        If randomNum = 1 Then
                            myCount1 = myCount2
                            lowestCount = myArray(i)
                        End If
                    End If
                End While
            End While
            'Words
        ElseIf myTable = "words" Then
            command2.Parameters.AddWithValue("myTableID", "word_id")
            command2.Parameters.AddWithValue("myTable", myTable)
            command2.Parameters.AddWithValue("myID", myArray(0))
            adapter2.SelectCommand = command2
            data2 = command2.ExecuteReader
            While data2.HasRows
                data2.Read()
                myCount1 = data2.GetString("count")
            End While
            While i < myArray.Count
                command2.Parameters.AddWithValue("myID", myArray(i))
                adapter2.SelectCommand = command2
                data2 = command2.ExecuteReader
                While data2.HasRows
                    data2.Read()
                    myCount2 = data2.GetString("count")
                    If myCount1 > myCount2 Then
                        myCount1 = myCount2
                        lowestCount = myArray(i)
                    ElseIf myCount1 = myCount2 Then
                        'Randomly Choose One
                        randomNum = CInt(Math.Ceiling(Rnd() * 2)) + 1
                        If randomNum = 1 Then
                            myCount1 = myCount2
                            lowestCount = myArray(i)
                        End If
                    End If
                End While
            End While
        End If
        Return lowestCount
    End Function

    'Get Count of Records in Table
    Public Function getRecordCount(myTable As String)
        Dim data2 As MySql.Data.MySqlClient.MySqlDataReader
        Dim adapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim command2 As New MySql.Data.MySqlClient.MySqlCommand
        Dim myCount As String = Nothing

        conn.Open()

        command2.CommandText = "SELECT COUNT(*) FROM @myTable;"
        command2.Connection = conn
        command2.Parameters.AddWithValue("myTable", myTable)
        adapter2.SelectCommand = command2
        data2 = command2.ExecuteReader
        data2.Read()
        myCount = data2.ToString
        Return myCount
    End Function

    'Select Random ID from Table
    Public Function randomID(myTable As String)
        Dim data2 As MySql.Data.MySqlClient.MySqlDataReader
        Dim adapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim command2 As New MySql.Data.MySqlClient.MySqlCommand
        Dim myCount As String = Nothing
        Dim myID As String = Nothing

        conn.Open()

        command2.CommandText = "SELECT COUNT(*) FROM @myTable;"
        command2.Connection = conn
        command2.Parameters.AddWithValue("myTable", myTable)
        adapter2.SelectCommand = command2
        data2 = command2.ExecuteReader
        data2.Read()
        myCount = data2.ToString
        myID = CInt(Math.Ceiling(Rnd() * myCount)) + 1
        Return myID
    End Function


    'Select ID with smallest count from Table
    Public Function smallestCountID(myTable As String)
        Dim data2 As MySql.Data.MySqlClient.MySqlDataReader
        Dim adapter2 As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim command2 As New MySql.Data.MySqlClient.MySqlCommand
        Dim myID As String = Nothing
        Dim col As String = Nothing
        Dim i As Integer = 0
        Dim myArray() As Integer = Nothing

        conn.Open()

        command2.CommandText = "SELECT @myID FROM @myTable WHERE count=Min(count);"
        command2.Connection = conn
        command2.Parameters.AddWithValue("myTable", myTable)
        If myTable = "facts" Then
            command2.Parameters.AddWithValue("myID", "fact_ID")
            col = "fact_ID"
        ElseIf myTable = "pictures" Then
            command2.Parameters.AddWithValue("myID", "picture_ID")
            col = "picture_ID"
        ElseIf myTable = "highlights" Then
            command2.Parameters.AddWithValue("myID", "highlight_ID")
            col = "highlight_ID"
        ElseIf myTable = "songs" Then
            command2.Parameters.AddWithValue("myID", "song_ID")
            col = "song_ID"
        ElseIf myTable = "quotes" Then
            command2.Parameters.AddWithValue("myID", "quote_ID")
            col = "quote_ID"
        ElseIf myTable = "words" Then
            command2.Parameters.AddWithValue("myID", "word_ID")
            col = "word_ID"
        End If
        adapter2.SelectCommand = command2
        data2 = command2.ExecuteReader
        While data2.HasRows
            data2.Read()
            myArray(i) = data2.GetString(col)
            i += 1
        End While
        myID = CInt(Math.Ceiling(Rnd() * myArray.Count)) + 1
        Return myArray(myID)
    End Function


    Public Function importExcel(path As String)
        Dim sSheetName As String
        Dim sConnection As String
        Dim dtTablesList As DataTable
        Dim oleExcelCommand As OleDb.OleDbCommand
        Dim oleExcelConnection As OleDb.OleDbConnection

        sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path & ";Extended Properties=""Excel 12.0;HDR=No;IMEX=1"""     'HDR=Yes: first row has column names not data; IMEX=1 treats all data as text

        oleExcelConnection = New OleDb.OleDbConnection(sConnection)
        oleExcelConnection.Open()

        dtTablesList = oleExcelConnection.GetSchema("Tables")

        If dtTablesList.Rows.Count > 0 Then
            sSheetName = dtTablesList.Rows(0)("TABLE_NAME").ToString
        End If

        dtTablesList.Clear()
        dtTablesList.Dispose()

        If sSheetName <> "" Then
            oleExcelCommand = oleExcelConnection.CreateCommand()
            oleExcelCommand.CommandText = "Select * FROM [" & sSheetName & "]"
            oleExcelCommand.CommandType = CommandType.Text

            Dim dataAdapter As New OleDb.OleDbDataAdapter
            dataAdapter.SelectCommand = oleExcelCommand
            Dim oDataSet As New DataSet
            dataAdapter.Fill(oDataSet)
        End If
        oleExcelConnection.Close()
        Return dtTablesList
    End Function

    Public Function separateString(tags As String)
        Dim tagsArray() As String = Nothing
        tagsArray = tags.Split(", ")
        Return tagsArray
    End Function

    Public Function getSynonyms(tag As String)
        Dim myArray() As String = Nothing
        Dim wordApp As New Microsoft.Office.Interop.Word.Application
        Dim objLanguage As Object = Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishUS
        Dim info As Microsoft.Office.Interop.Word.SynonymInfo
        info = wordApp.SynonymInfo(tag, objLanguage)
        If info IsNot Nothing Then
            If info.MeaningCount > 0 Then
                Dim duplicate As Boolean
                For Each meaning As String In DirectCast(info.MeaningList, Array)
                    Dim objMeaning As Object = meaning
                    Dim synonyms As Array
                    synonyms = DirectCast(info.SynonymList(objMeaning), Array)
                    For Each synonym As String In synonyms
                        duplicate = False
                        Dim list As String
                        For Each list In myArray
                            If list = synonym Then
                                duplicate = True
                                Exit For
                            End If
                        Next
                        If Not duplicate Then
                            myArray.SetValue(synonym, myArray.Count)
                        End If
                    Next
                Next
            End If
        End If
        Return myArray
    End Function

    'Adjust array and add string to end
    Public Function redimArray(myArray As Array, myObj As Object)
        Dim newArray(myArray.Length) As String
        Dim i As Integer = 0
        For Each myItem In myArray
            newArray(i) = myItem
            i += 1
        Next
        newArray(i) = myObj
        Return newArray
    End Function

    'Get Largest count value
    Public Function getLargestValueInArray(myArray() As Integer)
        Dim myNum As Integer = 0
        For Each num In myArray
            If num > myNum Then
                myNum = num
            End If
        Next
        Return myNum
    End Function

    'Find largest value in array, return all indexes of that value
    Public Function getArrayIndexOfLargest(myArray() As Integer)
        Dim myNum As Integer = getLargestValueInArray(myArray)
        Dim newArray() As Integer = Nothing
        For Each value In myArray
            If value = myNum Then
                Dim myNum2 As Integer = myArray.ToList.IndexOf(value)
                redimArray(newArray, myNum2)
            End If
        Next
        Return newArray
    End Function

    'Return newArray with only the indexes from getIndexOfLargest
    Public Function getArrayOfTableIDsWithLargestHitCount(myArray1() As Integer, myArray2() As String)
        Dim newArray() As String = Nothing
        For Each index In myArray1
            redimArray(newArray, myArray2(index))
        Next
        Return newArray
    End Function

End Module
