﻿Public Class PicturesForm
    Dim pathText As String
    Dim descText As String
    Dim tagText As String
    Dim tags() As String

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        disconnectDB()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        connectDB()
    End Sub

    Private Sub btnAddPicture_Click(sender As Object, e As EventArgs) Handles btnAddPicture.Click
        pathText = txtImagePath.Text
        descText = txtImageDescription.Text
        tagText = txtTags.Text

        'Separate comma delimited values in Tags and get Count
        tags = separateString(tagText)

        'Add Fact to the DB
        addPic()
    End Sub

    Private Function addPic()
        Dim iReturn As Boolean
        Dim picID As Integer = Nothing
        Using SQLConnection As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
            'Add Fact and Fact_Resource to MySQL
            Using sqlCommand As New MySql.Data.MySqlClient.MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO pictures (`desc`, 'path') values (@desc,@path)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@desc", descText)
                    .Parameters.AddWithValue("@path", pathText)
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
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM pictures"
                    picID = sqlCommand.ExecuteScalar
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
                        sqlCommand.CommandText = "INSERT INTO pic_tags ('pic_id',`tag`) values (@pic_id,@tag)"
                        sqlCommand.Parameters.AddWithValue("@pic_id", picID)
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

    Private Sub btnHighlight_Click(sender As Object, e As EventArgs) 
        HighlightsForm.Show()
        Hide()
    End Sub

    Private Sub btnViewTables_Click(sender As Object, e As EventArgs) Handles btnViewTables.Click
        ViewTable.Show()
        Hide()
    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) 
        WordsForm.Show()
        Hide()
    End Sub

    Private Sub PictureForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub PictureForm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub
End Class