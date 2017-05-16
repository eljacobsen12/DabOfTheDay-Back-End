Public Class QuoteForm
    Dim qText As String
    Dim authorText As String
    Dim tagText As String
    Dim tags() As String

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        connectDB()
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        disconnectDB()
    End Sub

    Private Sub btnAddQuote_Click(sender As Object, e As EventArgs) Handles btnAddQuote.Click
        qText = txtQuote.Text
        authorText = txtAuthor.Text
        tagText = txtTags.Text

        tags = separateString(tagText)

        addQuote()
    End Sub

    Private Function addQuote()
        Dim iReturn As Boolean
        Dim quoteID As Integer = Nothing
        Using SQLConnection As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
            'Add Fact and Fact_Resource to MySQL
            Using sqlCommand As New MySql.Data.MySqlClient.MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO quotes (`quote`, `author`) values (@quote,@author)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@quote", qText)
                    .Parameters.AddWithValue("@author", authorText)
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
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM quotes"
                    quoteID = sqlCommand.ExecuteScalar
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
                        sqlCommand.CommandText = "INSERT INTO quote_tags ('quote_id',`tags`) values (@quote_id,@tags)"
                        sqlCommand.Parameters.AddWithValue("@quote_id", quoteID)
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

    Private Sub QuoteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnFact_Click(sender As Object, e As EventArgs) 
        FactForm.Show()
        Hide()
    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) 
        WordsForm.Show()
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

    Private Sub QuoteForm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub
End Class