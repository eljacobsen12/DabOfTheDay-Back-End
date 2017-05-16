Public Class ViewTable
    Dim da As Common.DbDataAdapter
    Dim ds As DataSet = New DataSet
    Dim dtf As DataTable = ds.Tables.Add("Facts")
    Dim dtq As DataTable = ds.Tables.Add("Quotes")
    Dim dtw As DataTable = ds.Tables.Add("Words")
    Dim dts As DataTable = ds.Tables.Add("Songs")
    Dim dtp As DataTable = ds.Tables.Add("Pictures")
    Dim dth As DataTable = ds.Tables.Add("Highlights")
    Dim connString As String
    Public Shared selectedFact As Integer = Nothing
    Public Shared selectedQuote As Integer = Nothing
    Public Shared selectedWord As Integer = Nothing
    Public Shared selectedSong As Integer = Nothing
    Public Shared selectedPicture As Integer = Nothing
    Public Shared selectedHighlight As Integer = Nothing
    Dim myQuery As String
    Dim selectedTable As String = Nothing
    Dim excelPath As String

    Private Sub btnFacts_Click(sender As Object, e As EventArgs) Handles btnFacts.Click
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
        myQuery = "Select * from Facts"

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
    End Sub

    Private Sub btnUpdateTable_Click(sender As Object, e As EventArgs) Handles btnUpdateTable.Click
        If selectedTable = "Facts" Then
            da.Update(ds, "Facts")
            MsgBox("Data sent.", MsgBoxStyle.OkOnly, "Success")
        ElseIf selectedTable = "Quotes" Then
            da.Update(ds, "Quotes")
            MsgBox("Data sent.", MsgBoxStyle.OkOnly, "Success")

        ElseIf selectedTable = "Words" Then
            da.Update(ds, "Words")
            MsgBox("Data sent.", MsgBoxStyle.OkOnly, "Success")

        ElseIf selectedTable = "Songs" Then
            da.Update(ds, "Songs")
            MsgBox("Data sent.", MsgBoxStyle.OkOnly, "Success")

        ElseIf selectedTable = "Pictures" Then
            da.Update(ds, "Pictures")
            MsgBox("Data sent.", MsgBoxStyle.OkOnly, "Success")

        ElseIf selectedTable = "Highlights" Then
            da.Update(ds, "Highlights")
            MsgBox("Data sent.", MsgBoxStyle.OkOnly, "Success")
        Else
            MsgBox("Select a Table to Update.", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub btnQuotes_Click(sender As Object, e As EventArgs) Handles btnQuotes.Click
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
        btnQuotes.BackColor = Color.PowderBlue

        selectedTable = "Quotes"
        myQuery = "Select * from Quotes"

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
    End Sub

    Private Sub btnWords_Click(sender As Object, e As EventArgs) Handles btnWords.Click
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
        btnWords.BackColor = Color.PowderBlue

        selectedTable = "Words"
        myQuery = "Select * from Words"

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
    End Sub

    Private Sub btnSongs_Click(sender As Object, e As EventArgs) Handles btnSongs.Click
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
        btnSongs.BackColor = Color.PowderBlue

        selectedTable = "Songs"
        myQuery = "Select * from Songs"

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
    End Sub

    Private Sub btnPictures_Click(sender As Object, e As EventArgs) Handles btnPictures.Click
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
        btnPictures.BackColor = Color.PowderBlue

        selectedTable = "Pictures"
        myQuery = "Select * from Pictures"

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
    End Sub

    Private Sub btnHighlights_Click(sender As Object, e As EventArgs) Handles btnHighlights.Click
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
        btnHighlights.BackColor = Color.PowderBlue

        selectedTable = "Highlights"
        myQuery = "Select * from Highlights"

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
    End Sub

    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
        Dim ans As String
        With OpenFileDialog1
            .InitialDirectory = "C:\"
            .Title = "Select Document"
            .FileName = ""
            .Filter = "XLXS (*.xlxs)|*.xlxs"
            'Shows selected file in textbox, or nothing
            If .ShowDialog() <> DialogResult.Cancel Then
                excelPath = .ShowDialog.ToString
                ans = MsgBox("Import Excel File to Table?", vbYesNo)
                If ans <> vbNo Then
                    Dim ds2 As DataSet
                    ds2 = importExcel(excelPath)
                    ds.Merge(ds2)
                End If
            End If
        End With
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If selectedTable = "facts" Then
            selectedFact = MyDataGrid.CurrentRow.Index
            MessageBox.Show("Fact Selected.")
            chkFacts.Enabled = True
            chkFacts.Visible = True
        ElseIf selectedTable = "words" Then
            selectedWord = MyDataGrid.CurrentRow.Index
            MessageBox.Show("Word Selected.")
            chkWords.Enabled = True
            chkWords.Visible = True
        ElseIf selectedTable = "quotes" Then
            selectedQuote = MyDataGrid.CurrentRow.Index
            MessageBox.Show("Quote Selected.")
            chkQuotes.Enabled = True
            chkQuotes.Visible = True
        ElseIf selectedTable = "pictures" Then
            selectedPicture = MyDataGrid.CurrentRow.Index
            MessageBox.Show("Picture Selected.")
            chkPictures.Enabled = True
            chkPictures.Visible = True
        ElseIf selectedTable = "highlights" Then
            selectedHighlight = MyDataGrid.CurrentRow.Index
            MessageBox.Show("Highlight Selected.")
            chkHighlights.Enabled = True
            chkHighlights.Visible = True
        ElseIf selectedTable = "songs" Then
            selectedSong = MyDataGrid.CurrentRow.Index
            MessageBox.Show("Song Selected.")
            chkSongs.Enabled = True
            chkSongs.Visible = True
        Else
            MessageBox.Show("No Table Selected.")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim myCommand As String = Nothing

        If txtQuery.Text <> "" Then
            myCommand = "SELECT " & Trim(txtQuery.Text) & " FROM" & selectedTable
            Try
                conn.Open()
                da = New MySql.Data.MySqlClient.MySqlDataAdapter(myCommand, conn)
                Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(ds, selectedTable)
                MyDataGrid.DataSource = Nothing
                MyDataGrid.Rows.Clear()
                MyDataGrid.DataMember = selectedTable
                If selectedTable = "facts" Then
                    MyDataGrid.DataSource = dtf
                ElseIf selectedTable = "words" Then
                    MyDataGrid.DataSource = dtw
                ElseIf selectedTable = "quotes" Then
                    MyDataGrid.DataSource = dtq
                ElseIf selectedTable = "pictures" Then
                    MyDataGrid.DataSource = dtp
                ElseIf selectedTable = "highlights" Then
                    MyDataGrid.DataSource = dth
                ElseIf selectedTable = "songs" Then
                    MyDataGrid.DataSource = dts
                Else
                    MessageBox.Show("No Table Selected.")
                End If
            Catch ex As Common.DbException
                MsgBox("Error: " & ex.ToString)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Enter text to Query.")
        End If
    End Sub

    Private Sub ViewTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ViewTable_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If isConnected = True Then
            lblConnectionStatus.ForeColor = Color.Green
        Else
            lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnViewTables_Click(sender As Object, e As EventArgs) 

    End Sub
End Class