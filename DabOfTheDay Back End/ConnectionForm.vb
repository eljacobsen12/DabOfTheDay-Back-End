Public Class ConnectionForm
    Private Sub ConnectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        connectDB()
        If isConnected = True Then
            lblConnectionStatus.Text = "Connected"
            lblConnectionStatus.ForeColor = Color.Green
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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        connectDB()
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        disconnectDB()
    End Sub

    Private Sub btnViewTables_Click(sender As Object, e As EventArgs) Handles btnViewTables.Click
        ViewTable.Show()
        Hide()
    End Sub

    Private Sub ConnectionForm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub
End Class