Public Class ViewPostForm
    Dim da As Common.DbDataAdapter
    Dim command2 As New MySql.Data.MySqlClient.MySqlCommand
    Dim ds As DataSet = New DataSet
    Dim dtf As DataTable = ds.Tables.Add("Facts")
    Dim dtq As DataTable = ds.Tables.Add("Quotes")
    Dim dtw As DataTable = ds.Tables.Add("Words")
    Dim dts As DataTable = ds.Tables.Add("Songs")
    Dim dtp As DataTable = ds.Tables.Add("Pictures")
    Dim dth As DataTable = ds.Tables.Add("Highlights")
    Dim connString As String
    Dim myQuery As String
    Dim selectedTable As String = Nothing
    Dim excelPath As String
    Dim factID As Integer = Nothing
    Dim highlightID As Integer = Nothing
    Dim pictureID As Integer = Nothing
    Dim quoteID As Integer = Nothing
    Dim songID As Integer = Nothing
    Dim wordID As Integer = Nothing

    Private Sub UploadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnFacts_Click(sender As Object, e As EventArgs) Handles btnFacts.Click
        If ViewTable.selectedFact <> Nothing Then
            If btnWords.BackColor = Color.PowderBlue Then
                btnWords.BackColor = Color.Azure
            ElseIf btnQuotes.BackColor = Color.PowderBlue Then
                btnQuotes.BackColor = Color.Azure
            ElseIf btnSongs.BackColor = Color.PowderBlue Then
                btnSongs.BackColor = Color.Azure
            ElseIf btnPictures.BackColor = Color.PowderBlue Then
                btnPictures.BackColor = Color.Azure
            ElseIf btnHighlights.BackColor = Color.PowderBlue Then
                btnHighlights.BackColor = Color.Azure
            End If

            btnFacts.BackColor = Color.PowderBlue
            selectedTable = "Facts"
            myQuery = "Select * from Facts WHERE fact_id ='" & ViewTable.selectedFact & "'"

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Facts")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "facts"
                MyDataGrid.DataSource = dtf
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("No Fact Selected.")
        End If
    End Sub

    Private Sub btnQuotes_Click(sender As Object, e As EventArgs) Handles btnQuotes.Click
        If ViewTable.selectedQuote <> Nothing Then
            If btnWords.BackColor = Color.PowderBlue Then
                btnWords.BackColor = Color.Azure
            ElseIf btnFacts.BackColor = Color.PowderBlue Then
                btnFacts.BackColor = Color.Azure
            ElseIf btnSongs.BackColor = Color.PowderBlue Then
                btnSongs.BackColor = Color.Azure
            ElseIf btnPictures.BackColor = Color.PowderBlue Then
                btnPictures.BackColor = Color.Azure
            ElseIf btnHighlights.BackColor = Color.PowderBlue Then
                btnHighlights.BackColor = Color.Azure
            End If

            btnFacts.BackColor = Color.PowderBlue
            selectedTable = "Quotes"
            myQuery = "Select * from Quotes WHERE quote_id ='" & ViewTable.selectedQuote & "'"

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Quotes")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "quotes"
                MyDataGrid.DataSource = dtq
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("No Quote Selected.")
        End If
    End Sub

    Private Sub btnWords_Click(sender As Object, e As EventArgs) Handles btnWords.Click
        If ViewTable.selectedFact <> Nothing Then
            If btnFacts.BackColor = Color.PowderBlue Then
                btnFacts.BackColor = Color.Azure
            ElseIf btnQuotes.BackColor = Color.PowderBlue Then
                btnQuotes.BackColor = Color.Azure
            ElseIf btnSongs.BackColor = Color.PowderBlue Then
                btnSongs.BackColor = Color.Azure
            ElseIf btnPictures.BackColor = Color.PowderBlue Then
                btnPictures.BackColor = Color.Azure
            ElseIf btnHighlights.BackColor = Color.PowderBlue Then
                btnHighlights.BackColor = Color.Azure
            End If

            btnFacts.BackColor = Color.PowderBlue
            selectedTable = "Words"
            myQuery = "Select * from Words WHERE word_id ='" & ViewTable.selectedWord & "'"

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Words")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "words"
                MyDataGrid.DataSource = dtw
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("No Word Selected.")
        End If
    End Sub

    Private Sub btnSongs_Click(sender As Object, e As EventArgs) Handles btnSongs.Click
        If ViewTable.selectedFact <> Nothing Then
            If btnWords.BackColor = Color.PowderBlue Then
                btnWords.BackColor = Color.Azure
            ElseIf btnQuotes.BackColor = Color.PowderBlue Then
                btnQuotes.BackColor = Color.Azure
            ElseIf btnFacts.BackColor = Color.PowderBlue Then
                btnFacts.BackColor = Color.Azure
            ElseIf btnPictures.BackColor = Color.PowderBlue Then
                btnPictures.BackColor = Color.Azure
            ElseIf btnHighlights.BackColor = Color.PowderBlue Then
                btnHighlights.BackColor = Color.Azure
            End If

            btnFacts.BackColor = Color.PowderBlue
            selectedTable = "Songs"
            myQuery = "Select * from Songs WHERE song_id ='" & ViewTable.selectedSong & "'"

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Songs")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "songs"
                MyDataGrid.DataSource = dts
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("No Song Selected.")
        End If
    End Sub

    Private Sub btnPictures_Click(sender As Object, e As EventArgs) Handles btnPictures.Click
        If ViewTable.selectedFact <> Nothing Then
            If btnWords.BackColor = Color.PowderBlue Then
                btnWords.BackColor = Color.Azure
            ElseIf btnQuotes.BackColor = Color.PowderBlue Then
                btnQuotes.BackColor = Color.Azure
            ElseIf btnSongs.BackColor = Color.PowderBlue Then
                btnSongs.BackColor = Color.Azure
            ElseIf btnFacts.BackColor = Color.PowderBlue Then
                btnFacts.BackColor = Color.Azure
            ElseIf btnHighlights.BackColor = Color.PowderBlue Then
                btnHighlights.BackColor = Color.Azure
            End If

            btnFacts.BackColor = Color.PowderBlue
            selectedTable = "Pictures"
            myQuery = "Select * from Pictures WHERE pic_id ='" & ViewTable.selectedPicture & "'"

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Picture")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "picture"
                MyDataGrid.DataSource = dtp
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("No Picture Selected.")
        End If
    End Sub

    Private Sub btnHighlights_Click(sender As Object, e As EventArgs) Handles btnHighlights.Click
        If ViewTable.selectedFact <> Nothing Then
            If btnWords.BackColor = Color.PowderBlue Then
                btnWords.BackColor = Color.Azure
            ElseIf btnQuotes.BackColor = Color.PowderBlue Then
                btnQuotes.BackColor = Color.Azure
            ElseIf btnSongs.BackColor = Color.PowderBlue Then
                btnSongs.BackColor = Color.Azure
            ElseIf btnPictures.BackColor = Color.PowderBlue Then
                btnPictures.BackColor = Color.Azure
            ElseIf btnFacts.BackColor = Color.PowderBlue Then
                btnFacts.BackColor = Color.Azure
            End If

            btnFacts.BackColor = Color.PowderBlue
            selectedTable = "Highlights"
            myQuery = "Select * from Highlights WHERE highlight_id ='" & ViewTable.selectedHighlight & "'"

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Highlights")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "highlights"
                MyDataGrid.DataSource = dth
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("No Highlight Selected.")
        End If
    End Sub

    Private Sub btnFact_Click(sender As Object, e As EventArgs)
        FactForm.Show()
        Hide()
    End Sub

    Private Sub btnQuote_Click(sender As Object, e As EventArgs)
        QuoteForm.Show()
        Hide()
    End Sub

    Private Sub btnSong_Click(sender As Object, e As EventArgs)
        SongsForm.Show()
        Hide()
    End Sub

    Private Sub btnPicture_Click(sender As Object, e As EventArgs)
        PicturesForm.Show()
        Hide()
    End Sub

    Private Sub btnHighlight_Click(sender As Object, e As EventArgs)
        HighlightsForm.Show()
        Hide()
    End Sub

    Private Sub btnViewTables_Click(sender As Object, e As EventArgs) Handles btnViewTables.Click
        ViewTable.Show()
        Hide()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        connectDB()
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        End If
    End Sub

    Private Sub UploadForm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Dim ans As String
        ans = MsgBox("Post to DabOfTheDay.com?", vbYesNo)
        If ans = vbYes Then
            'If there is a selection for each object then upload.
            If ViewTable.selectedFact <> Nothing And ViewTable.selectedWord <> Nothing And ViewTable.selectedQuote <> Nothing And ViewTable.selectedSong <> Nothing And ViewTable.selectedPicture <> Nothing And ViewTable.selectedHighlight <> Nothing Then

            End If
        Else
            Show()
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If chkFact.Checked = False Then
            ViewTable.selectedFact = createNewPost("fact")
        End If
        If chkHighlight.Checked = False Then
            ViewTable.selectedHighlight = createNewPost("highlight")
        End If
        If chkPicture.Checked = False Then
            ViewTable.selectedPicture = createNewPost("picture")
        End If
        If chkQuote.Checked = False Then
            ViewTable.selectedQuote = createNewPost("quote")
        End If
        If chkSong.Checked = False Then
            ViewTable.selectedSong = createNewPost("song")
        End If
        If chkWord.Checked = False Then
            ViewTable.selectedWord = createNewPost("word")
        End If
        If selectedTable = "Facts" Then
            command2.CommandText = "Select * from @myTable WHERE @tableID=@myID"
            command2.Parameters.AddWithValue("@myTable", "facts")
            command2.Parameters.AddWithValue("@tableID", "fact_id")
            command2.Parameters.AddWithValue("@myID", ViewTable.selectedFact)

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Facts")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "facts"
                MyDataGrid.DataSource = dtf
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        ElseIf selectedTable = "Pictures" Then
            selectedTable = "Pictures"
            command2.CommandText = "Select * from @myTable WHERE @tableID=@myID"
            command2.Parameters.AddWithValue("@myTable", "pictures")
            command2.Parameters.AddWithValue("@tableID", "picture_id")
            command2.Parameters.AddWithValue("@myID", ViewTable.selectedPicture)

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Pictures")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "pictures"
                MyDataGrid.DataSource = dtp
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        ElseIf selectedTable = "Highlights" Then
            selectedTable = "Highlights"
            command2.CommandText = "Select * from @myTable WHERE @tableID=@myID"
            command2.Parameters.AddWithValue("@myTable", "highlights")
            command2.Parameters.AddWithValue("@tableID", "highlight_id")
            command2.Parameters.AddWithValue("@myID", ViewTable.selectedHighlight)

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Highlights")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "highlights"
                MyDataGrid.DataSource = dth
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        ElseIf selectedTable = "Quotes" Then
            selectedTable = "Quotes"
            command2.CommandText = "Select * from @myTable WHERE @tableID=@myID"
            command2.Parameters.AddWithValue("@myTable", "quotes")
            command2.Parameters.AddWithValue("@tableID", "quote_id")
            command2.Parameters.AddWithValue("@myID", ViewTable.selectedQuote)

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Quotes")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "quotes"
                MyDataGrid.DataSource = dtq
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        ElseIf selectedTable = "Songs" Then
            selectedTable = "Songs"
            command2.CommandText = "Select * from @myTable WHERE @tableID=@myID"
            command2.Parameters.AddWithValue("@myTable", "songs")
            command2.Parameters.AddWithValue("@tableID", "song_id")
            command2.Parameters.AddWithValue("@myID", ViewTable.selectedSong)

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Songs")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "songs"
                MyDataGrid.DataSource = dts
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        ElseIf selectedTable = "Words" Then
            selectedTable = "Words"
            command2.CommandText = "Select * from @myTable WHERE @tableID=@myID"
            command2.Parameters.AddWithValue("@myTable", "words")
            command2.Parameters.AddWithValue("@tableID", "word_id")
            command2.Parameters.AddWithValue("@myID", ViewTable.selectedWord)

            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myQuery, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, "Words")
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = "words"
                MyDataGrid.DataSource = dtw
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnNewFact_Click(sender As Object, e As EventArgs) Handles btnNewFact.Click
        FactForm.Show()
        Hide()
    End Sub

    Private Sub btnNewQuote_Click(sender As Object, e As EventArgs) Handles btnNewQuote.Click
        QuoteForm.Show()
        Hide()
    End Sub

    Private Sub btnNewSong_Click(sender As Object, e As EventArgs) Handles btnNewSong.Click
        SongsForm.Show()
        Hide()
    End Sub

    Private Sub btnNewPicture_Click(sender As Object, e As EventArgs) Handles btnNewPicture.Click
        PicturesForm.Show()
        Hide()
    End Sub

    Private Sub btnNewHighlight_Click(sender As Object, e As EventArgs) Handles btnNewHighlight.Click
        HighlightsForm.Show()
        Hide()
    End Sub

    Private Sub btnNewWord_Click(sender As Object, e As EventArgs) Handles btnNewWord.Click
        WordsForm.Show()
        Hide()
    End Sub
End Class