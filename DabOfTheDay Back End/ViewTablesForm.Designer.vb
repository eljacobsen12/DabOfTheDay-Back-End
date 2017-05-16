<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTable))
        Me.MyDataGrid = New System.Windows.Forms.DataGridView()
        Me.btnHighlights = New System.Windows.Forms.Button()
        Me.btnPictures = New System.Windows.Forms.Button()
        Me.btnSongs = New System.Windows.Forms.Button()
        Me.btnWords = New System.Windows.Forms.Button()
        Me.btnQuotes = New System.Windows.Forms.Button()
        Me.btnFacts = New System.Windows.Forms.Button()
        Me.btnUpdateTable = New System.Windows.Forms.Button()
        Me.btnImportExcel = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnConnection = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnConnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDisconnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.txtQuery = New System.Windows.Forms.ToolStripTextBox()
        Me.btnAdd = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnNewFact = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewQuote = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewSong = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewPicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewHighlight = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewWord = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPostToWeb = New System.Windows.Forms.ToolStripButton()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.chkFacts = New System.Windows.Forms.Label()
        Me.chkQuotes = New System.Windows.Forms.Label()
        Me.chkWords = New System.Windows.Forms.Label()
        Me.chkSongs = New System.Windows.Forms.Label()
        Me.chkPictures = New System.Windows.Forms.Label()
        Me.chkHighlights = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        CType(Me.MyDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGrid
        '
        Me.MyDataGrid.AllowUserToOrderColumns = True
        Me.MyDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.MyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyDataGrid.Location = New System.Drawing.Point(3, 78)
        Me.MyDataGrid.Name = "MyDataGrid"
        Me.MyDataGrid.Size = New System.Drawing.Size(980, 446)
        Me.MyDataGrid.TabIndex = 0
        '
        'btnHighlights
        '
        Me.btnHighlights.BackColor = System.Drawing.Color.Azure
        Me.btnHighlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighlights.Location = New System.Drawing.Point(810, 31)
        Me.btnHighlights.Name = "btnHighlights"
        Me.btnHighlights.Size = New System.Drawing.Size(150, 50)
        Me.btnHighlights.TabIndex = 9
        Me.btnHighlights.Text = "Highlights"
        Me.btnHighlights.UseVisualStyleBackColor = False
        '
        'btnPictures
        '
        Me.btnPictures.BackColor = System.Drawing.Color.Azure
        Me.btnPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPictures.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPictures.Location = New System.Drawing.Point(654, 31)
        Me.btnPictures.Name = "btnPictures"
        Me.btnPictures.Size = New System.Drawing.Size(150, 50)
        Me.btnPictures.TabIndex = 10
        Me.btnPictures.Text = "Pictures"
        Me.btnPictures.UseVisualStyleBackColor = False
        '
        'btnSongs
        '
        Me.btnSongs.BackColor = System.Drawing.Color.Azure
        Me.btnSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSongs.Location = New System.Drawing.Point(498, 31)
        Me.btnSongs.Name = "btnSongs"
        Me.btnSongs.Size = New System.Drawing.Size(150, 50)
        Me.btnSongs.TabIndex = 11
        Me.btnSongs.Text = "Songs"
        Me.btnSongs.UseVisualStyleBackColor = False
        '
        'btnWords
        '
        Me.btnWords.BackColor = System.Drawing.Color.Azure
        Me.btnWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWords.Location = New System.Drawing.Point(342, 31)
        Me.btnWords.Name = "btnWords"
        Me.btnWords.Size = New System.Drawing.Size(150, 50)
        Me.btnWords.TabIndex = 12
        Me.btnWords.Text = "Words"
        Me.btnWords.UseVisualStyleBackColor = False
        '
        'btnQuotes
        '
        Me.btnQuotes.BackColor = System.Drawing.Color.Azure
        Me.btnQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuotes.Location = New System.Drawing.Point(186, 31)
        Me.btnQuotes.Name = "btnQuotes"
        Me.btnQuotes.Size = New System.Drawing.Size(150, 50)
        Me.btnQuotes.TabIndex = 13
        Me.btnQuotes.Text = "Quotes"
        Me.btnQuotes.UseVisualStyleBackColor = False
        '
        'btnFacts
        '
        Me.btnFacts.BackColor = System.Drawing.Color.Azure
        Me.btnFacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacts.Location = New System.Drawing.Point(30, 31)
        Me.btnFacts.Name = "btnFacts"
        Me.btnFacts.Size = New System.Drawing.Size(150, 50)
        Me.btnFacts.TabIndex = 14
        Me.btnFacts.Text = "Facts"
        Me.btnFacts.UseVisualStyleBackColor = False
        '
        'btnUpdateTable
        '
        Me.btnUpdateTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTable.Location = New System.Drawing.Point(392, 530)
        Me.btnUpdateTable.Name = "btnUpdateTable"
        Me.btnUpdateTable.Size = New System.Drawing.Size(198, 50)
        Me.btnUpdateTable.TabIndex = 15
        Me.btnUpdateTable.Text = "Update Table"
        Me.btnUpdateTable.UseVisualStyleBackColor = True
        '
        'btnImportExcel
        '
        Me.btnImportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportExcel.Location = New System.Drawing.Point(774, 530)
        Me.btnImportExcel.Name = "btnImportExcel"
        Me.btnImportExcel.Size = New System.Drawing.Size(198, 50)
        Me.btnImportExcel.TabIndex = 16
        Me.btnImportExcel.Text = "Import Excel"
        Me.btnImportExcel.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConnection, Me.btnSearch, Me.txtQuery, Me.btnAdd, Me.btnPostToWeb})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 28)
        Me.ToolStrip1.TabIndex = 44
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnConnection
        '
        Me.btnConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnConnection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConnect, Me.btnDisconnect})
        Me.btnConnection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnection.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Size = New System.Drawing.Size(102, 25)
        Me.btnConnection.Text = "Connection"
        '
        'btnConnect
        '
        Me.btnConnect.ForeColor = System.Drawing.Color.Green
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(156, 26)
        Me.btnConnect.Text = "Connect"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.ForeColor = System.Drawing.Color.Red
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(156, 26)
        Me.btnDisconnect.Text = "Disconnect"
        '
        'btnSearch
        '
        Me.btnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSearch.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(51, 25)
        Me.btnSearch.Text = "Search"
        '
        'txtQuery
        '
        Me.txtQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(200, 28)
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNewFact, Me.btnNewQuote, Me.btnNewSong, Me.btnNewPicture, Me.btnNewHighlight, Me.btnNewWord})
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(51, 25)
        Me.btnAdd.Text = "Add"
        '
        'btnNewFact
        '
        Me.btnNewFact.Name = "btnNewFact"
        Me.btnNewFact.Size = New System.Drawing.Size(144, 26)
        Me.btnNewFact.Text = "Fact"
        '
        'btnNewQuote
        '
        Me.btnNewQuote.Name = "btnNewQuote"
        Me.btnNewQuote.Size = New System.Drawing.Size(144, 26)
        Me.btnNewQuote.Text = "Quote"
        '
        'btnNewSong
        '
        Me.btnNewSong.Name = "btnNewSong"
        Me.btnNewSong.Size = New System.Drawing.Size(144, 26)
        Me.btnNewSong.Text = "Song"
        '
        'btnNewPicture
        '
        Me.btnNewPicture.Name = "btnNewPicture"
        Me.btnNewPicture.Size = New System.Drawing.Size(144, 26)
        Me.btnNewPicture.Text = "Picture"
        '
        'btnNewHighlight
        '
        Me.btnNewHighlight.Name = "btnNewHighlight"
        Me.btnNewHighlight.Size = New System.Drawing.Size(144, 26)
        Me.btnNewHighlight.Text = "Highlight"
        '
        'btnNewWord
        '
        Me.btnNewWord.Name = "btnNewWord"
        Me.btnNewWord.Size = New System.Drawing.Size(144, 26)
        Me.btnNewWord.Text = "Word"
        '
        'btnPostToWeb
        '
        Me.btnPostToWeb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPostToWeb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostToWeb.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPostToWeb.Name = "btnPostToWeb"
        Me.btnPostToWeb.Size = New System.Drawing.Size(101, 25)
        Me.btnPostToWeb.Text = "Post To Web"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(12, 530)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(198, 50)
        Me.btnSelect.TabIndex = 45
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'chkFacts
        '
        Me.chkFacts.AutoSize = True
        Me.chkFacts.BackColor = System.Drawing.Color.PowderBlue
        Me.chkFacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkFacts.Enabled = False
        Me.chkFacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkFacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFacts.Location = New System.Drawing.Point(155, 31)
        Me.chkFacts.Name = "chkFacts"
        Me.chkFacts.Size = New System.Drawing.Size(25, 18)
        Me.chkFacts.TabIndex = 47
        Me.chkFacts.Text = "✓"
        Me.chkFacts.Visible = False
        '
        'chkQuotes
        '
        Me.chkQuotes.AutoSize = True
        Me.chkQuotes.BackColor = System.Drawing.Color.PowderBlue
        Me.chkQuotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkQuotes.Enabled = False
        Me.chkQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkQuotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuotes.Location = New System.Drawing.Point(311, 31)
        Me.chkQuotes.Name = "chkQuotes"
        Me.chkQuotes.Size = New System.Drawing.Size(25, 18)
        Me.chkQuotes.TabIndex = 48
        Me.chkQuotes.Text = "✓"
        Me.chkQuotes.Visible = False
        '
        'chkWords
        '
        Me.chkWords.AutoSize = True
        Me.chkWords.BackColor = System.Drawing.Color.PowderBlue
        Me.chkWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkWords.Enabled = False
        Me.chkWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWords.Location = New System.Drawing.Point(467, 31)
        Me.chkWords.Name = "chkWords"
        Me.chkWords.Size = New System.Drawing.Size(25, 18)
        Me.chkWords.TabIndex = 49
        Me.chkWords.Text = "✓"
        Me.chkWords.Visible = False
        '
        'chkSongs
        '
        Me.chkSongs.AutoSize = True
        Me.chkSongs.BackColor = System.Drawing.Color.PowderBlue
        Me.chkSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkSongs.Enabled = False
        Me.chkSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSongs.Location = New System.Drawing.Point(623, 31)
        Me.chkSongs.Name = "chkSongs"
        Me.chkSongs.Size = New System.Drawing.Size(25, 18)
        Me.chkSongs.TabIndex = 50
        Me.chkSongs.Text = "✓"
        Me.chkSongs.Visible = False
        '
        'chkPictures
        '
        Me.chkPictures.AutoSize = True
        Me.chkPictures.BackColor = System.Drawing.Color.PowderBlue
        Me.chkPictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkPictures.Enabled = False
        Me.chkPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPictures.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPictures.Location = New System.Drawing.Point(779, 31)
        Me.chkPictures.Name = "chkPictures"
        Me.chkPictures.Size = New System.Drawing.Size(25, 18)
        Me.chkPictures.TabIndex = 51
        Me.chkPictures.Text = "✓"
        Me.chkPictures.Visible = False
        '
        'chkHighlights
        '
        Me.chkHighlights.AutoSize = True
        Me.chkHighlights.BackColor = System.Drawing.Color.PowderBlue
        Me.chkHighlights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkHighlights.Enabled = False
        Me.chkHighlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHighlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHighlights.Location = New System.Drawing.Point(935, 31)
        Me.chkHighlights.Name = "chkHighlights"
        Me.chkHighlights.Size = New System.Drawing.Size(25, 18)
        Me.chkHighlights.TabIndex = 52
        Me.chkHighlights.Text = "✓"
        Me.chkHighlights.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 21)
        Me.lblStatus.Text = "Status:"
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectionStatus.ForeColor = System.Drawing.Color.Red
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(114, 21)
        Me.lblConnectionStatus.Text = "Not Connected"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblConnectionStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 583)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 26)
        Me.StatusStrip1.TabIndex = 54
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ViewTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 609)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chkHighlights)
        Me.Controls.Add(Me.chkPictures)
        Me.Controls.Add(Me.chkSongs)
        Me.Controls.Add(Me.chkWords)
        Me.Controls.Add(Me.chkQuotes)
        Me.Controls.Add(Me.chkFacts)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnImportExcel)
        Me.Controls.Add(Me.btnUpdateTable)
        Me.Controls.Add(Me.MyDataGrid)
        Me.Controls.Add(Me.btnFacts)
        Me.Controls.Add(Me.btnQuotes)
        Me.Controls.Add(Me.btnWords)
        Me.Controls.Add(Me.btnSongs)
        Me.Controls.Add(Me.btnPictures)
        Me.Controls.Add(Me.btnHighlights)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ViewTable"
        Me.Text = "View Tables"
        CType(Me.MyDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyDataGrid As DataGridView
    Friend WithEvents btnHighlights As Button
    Friend WithEvents btnPictures As Button
    Friend WithEvents btnSongs As Button
    Friend WithEvents btnWords As Button
    Friend WithEvents btnQuotes As Button
    Friend WithEvents btnFacts As Button
    Friend WithEvents btnUpdateTable As Button
    Friend WithEvents btnImportExcel As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnConnection As ToolStripDropDownButton
    Friend WithEvents btnConnect As ToolStripMenuItem
    Friend WithEvents btnDisconnect As ToolStripMenuItem
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnSearch As ToolStripButton
    Friend WithEvents txtQuery As ToolStripTextBox
    Friend WithEvents chkFacts As Label
    Friend WithEvents chkQuotes As Label
    Friend WithEvents chkWords As Label
    Friend WithEvents chkSongs As Label
    Friend WithEvents chkPictures As Label
    Friend WithEvents chkHighlights As Label
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblConnectionStatus As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnAdd As ToolStripDropDownButton
    Friend WithEvents btnNewFact As ToolStripMenuItem
    Friend WithEvents btnNewQuote As ToolStripMenuItem
    Friend WithEvents btnNewSong As ToolStripMenuItem
    Friend WithEvents btnNewPicture As ToolStripMenuItem
    Friend WithEvents btnNewHighlight As ToolStripMenuItem
    Friend WithEvents btnNewWord As ToolStripMenuItem
    Friend WithEvents btnPostToWeb As ToolStripButton
End Class
