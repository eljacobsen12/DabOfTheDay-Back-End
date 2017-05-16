Public Class SongsForm
    Dim songText As String
    Dim pathText As String
    Dim artistText As String
    Dim albumText As String
    Dim genreText As String
    Dim tagText As String
    Dim tags() As String

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        disconnectDB()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        connectDB()
    End Sub

    Private Sub btnAddSong_Click(sender As Object, e As EventArgs) Handles btnAddSong.Click
        songText = txtSongTitle.Text
        pathText = txtSongPath.Text
        artistText = txtArtist.Text
        albumText = txtAlbum.Text
        genreText = txtGenre.Text

        tags = separateString(tagText)

        addSong()
    End Sub

    Private Function addSong()
        Dim iReturn As Boolean
        Dim songID As Integer = Nothing
        Using SQLConnection As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
            'Add Fact and Fact_Resource to MySQL
            Using sqlCommand As New MySql.Data.MySqlClient.MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO songs (`title`, `artist`, 'path', 'album', 'genre') values (@title,@artist,@path,@album,@genre)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@title", songText)
                    .Parameters.AddWithValue("@artist", artistText)
                    .Parameters.AddWithValue("@path", pathText)
                    .Parameters.AddWithValue("@album", albumText)
                    .Parameters.AddWithValue("@genre", genreText)
                End With
                Try
                    SQLConnection.Open()
                    sqlCommand.ExecuteNonQuery()
                    iReturn = True
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox(ex.Message.ToString)
                    iReturn = False
                Finally
                    sqlCommand.Dispose()
                    SQLConnection.Close()
                End Try
            End Using

            'Add Fact_Tags to MySQL
            Using sqlCommand As New MySql.Data.MySqlClient.MySqlCommand
                With sqlCommand
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                End With
                'Get record count from DB
                Try
                    SQLConnection.Open()
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM songs"
                    songID = sqlCommand.ExecuteScalar
                    iReturn = True
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox(ex.Message.ToString)
                    iReturn = False
                Finally
                    sqlCommand.Dispose()
                    SQLConnection.Close()
                End Try
                'Add Fact Tags to DB
                Try
                    SQLConnection.Open()
                    For i = 0 To UBound(tags)
                        sqlCommand.CommandText = "INSERT INTO song_tags ('song_id',`tags`) values (@song_id,@tags)"
                        sqlCommand.Parameters.AddWithValue("@song_id", songID)
                        sqlCommand.Parameters.AddWithValue("@tags", Trim(tags(i)))
                        sqlCommand.ExecuteNonQuery()
                    Next
                    iReturn = True
                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MsgBox(ex.Message.ToString)
                    iReturn = False
                Finally
                    sqlCommand.Dispose()
                    SQLConnection.Close()
                End Try
            End Using
        End Using
        Return iReturn
    End Function

    Private Sub btnFact_Click(sender As Object, e As EventArgs) 
        FactForm.Show()
        Hide()
    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) 
        WordsForm.Show()
        Hide()
    End Sub

    Private Sub btnQuote_Click(sender As Object, e As EventArgs) 
        QuoteForm.Show()
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

    Private Sub SongForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub SongForm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub
End Class