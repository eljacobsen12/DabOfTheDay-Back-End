Public Class FactForm
    Dim factText As String
    Dim factTags As String
    Dim factResource As String
    Dim tags() As String = Nothing

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        connectDB()
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        disconnectDB()
    End Sub

    Private Sub btnAddFact_Click(sender As Object, e As EventArgs) Handles btnAddFact.Click
        factText = txtFact.Text
        factTags = txtTags.Text
        factResource = txtResourceLink.Text

        'Separate comma delimited values in Tags and get Count
        tags = separateString(factTags)

        'Add Fact to the DB
        addFact()
    End Sub

    Private Function addFact()
        Dim iReturn As Boolean
        Dim factID As Integer = Nothing
        Using SQLConnection As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
            'Add Fact and Fact_Resource to MySQL
            Using sqlCommand As New MySql.Data.MySqlClient.MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO facts (`fact`, `fact_resource`) values (@fact,@fact_resource)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@fact", factText)
                    .Parameters.AddWithValue("@fact_resource", factResource)
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
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM facts"
                    factID = sqlCommand.ExecuteScalar
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
                        sqlCommand.CommandText = "INSERT INTO fact_tags ('fact_id',`tag`) values (@fact_id,@tag)"
                        sqlCommand.Parameters.AddWithValue("@fact_id", factID)
                        sqlCommand.Parameters.AddWithValue("@tag", Trim(tags(i)))
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

    Private Sub FactForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs)
        WordsForm.Show()
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

    Private Sub btnImportFile_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnViewTables_Click(sender As Object, e As EventArgs) Handles btnViewTables.Click
        ViewTable.Show()
        Hide()
    End Sub

    Private Sub FactForm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub
End Class
