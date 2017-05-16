<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPostForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewPostForm))
        Me.MyDataGrid = New System.Windows.Forms.DataGridView()
        Me.btnFacts = New System.Windows.Forms.Button()
        Me.btnQuotes = New System.Windows.Forms.Button()
        Me.btnWords = New System.Windows.Forms.Button()
        Me.btnSongs = New System.Windows.Forms.Button()
        Me.btnPictures = New System.Windows.Forms.Button()
        Me.btnHighlights = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnConnection = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnConnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDisconnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnViewTables = New System.Windows.Forms.ToolStripButton()
        Me.btnAdd = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnNewFact = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewQuote = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewSong = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewPicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewHighlight = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewWord = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.chkQuote = New System.Windows.Forms.CheckBox()
        Me.chkFact = New System.Windows.Forms.CheckBox()
        Me.chkWord = New System.Windows.Forms.CheckBox()
        Me.chkSong = New System.Windows.Forms.CheckBox()
        Me.chkHighlight = New System.Windows.Forms.CheckBox()
        Me.chkPicture = New System.Windows.Forms.CheckBox()
        Me.lblCheckToKeep = New System.Windows.Forms.Label()
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
        Me.MyDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MyDataGrid.Location = New System.Drawing.Point(3, 111)
        Me.MyDataGrid.Name = "MyDataGrid"
        Me.MyDataGrid.ReadOnly = True
        Me.MyDataGrid.Size = New System.Drawing.Size(980, 209)
        Me.MyDataGrid.TabIndex = 15
        '
        'btnFacts
        '
        Me.btnFacts.BackColor = System.Drawing.Color.Azure
        Me.btnFacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacts.Location = New System.Drawing.Point(30, 64)
        Me.btnFacts.Name = "btnFacts"
        Me.btnFacts.Size = New System.Drawing.Size(150, 50)
        Me.btnFacts.TabIndex = 21
        Me.btnFacts.Text = "Fact"
        Me.btnFacts.UseVisualStyleBackColor = False
        '
        'btnQuotes
        '
        Me.btnQuotes.BackColor = System.Drawing.Color.Azure
        Me.btnQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuotes.Location = New System.Drawing.Point(186, 64)
        Me.btnQuotes.Name = "btnQuotes"
        Me.btnQuotes.Size = New System.Drawing.Size(150, 50)
        Me.btnQuotes.TabIndex = 20
        Me.btnQuotes.Text = "Quotes"
        Me.btnQuotes.UseVisualStyleBackColor = False
        '
        'btnWords
        '
        Me.btnWords.BackColor = System.Drawing.Color.Azure
        Me.btnWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWords.Location = New System.Drawing.Point(342, 64)
        Me.btnWords.Name = "btnWords"
        Me.btnWords.Size = New System.Drawing.Size(150, 50)
        Me.btnWords.TabIndex = 19
        Me.btnWords.Text = "Words"
        Me.btnWords.UseVisualStyleBackColor = False
        '
        'btnSongs
        '
        Me.btnSongs.BackColor = System.Drawing.Color.Azure
        Me.btnSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSongs.Location = New System.Drawing.Point(498, 64)
        Me.btnSongs.Name = "btnSongs"
        Me.btnSongs.Size = New System.Drawing.Size(150, 50)
        Me.btnSongs.TabIndex = 18
        Me.btnSongs.Text = "Songs"
        Me.btnSongs.UseVisualStyleBackColor = False
        '
        'btnPictures
        '
        Me.btnPictures.BackColor = System.Drawing.Color.Azure
        Me.btnPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPictures.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPictures.Location = New System.Drawing.Point(654, 64)
        Me.btnPictures.Name = "btnPictures"
        Me.btnPictures.Size = New System.Drawing.Size(150, 50)
        Me.btnPictures.TabIndex = 17
        Me.btnPictures.Text = "Pictures"
        Me.btnPictures.UseVisualStyleBackColor = False
        '
        'btnHighlights
        '
        Me.btnHighlights.BackColor = System.Drawing.Color.Azure
        Me.btnHighlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighlights.Location = New System.Drawing.Point(810, 64)
        Me.btnHighlights.Name = "btnHighlights"
        Me.btnHighlights.Size = New System.Drawing.Size(150, 50)
        Me.btnHighlights.TabIndex = 16
        Me.btnHighlights.Text = "Highlights"
        Me.btnHighlights.UseVisualStyleBackColor = False
        '
        'btnPost
        '
        Me.btnPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.Location = New System.Drawing.Point(498, 326)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(150, 50)
        Me.btnPost.TabIndex = 22
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConnection, Me.btnViewTables, Me.btnAdd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 28)
        Me.ToolStrip1.TabIndex = 23
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
        'btnViewTables
        '
        Me.btnViewTables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnViewTables.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTables.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewTables.Name = "btnViewTables"
        Me.btnViewTables.Size = New System.Drawing.Size(96, 25)
        Me.btnViewTables.Text = "View Tables"
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
        Me.btnNewFact.Size = New System.Drawing.Size(152, 26)
        Me.btnNewFact.Text = "Fact"
        '
        'btnNewQuote
        '
        Me.btnNewQuote.Name = "btnNewQuote"
        Me.btnNewQuote.Size = New System.Drawing.Size(152, 26)
        Me.btnNewQuote.Text = "Quote"
        '
        'btnNewSong
        '
        Me.btnNewSong.Name = "btnNewSong"
        Me.btnNewSong.Size = New System.Drawing.Size(152, 26)
        Me.btnNewSong.Text = "Song"
        '
        'btnNewPicture
        '
        Me.btnNewPicture.Name = "btnNewPicture"
        Me.btnNewPicture.Size = New System.Drawing.Size(152, 26)
        Me.btnNewPicture.Text = "Picture"
        '
        'btnNewHighlight
        '
        Me.btnNewHighlight.Name = "btnNewHighlight"
        Me.btnNewHighlight.Size = New System.Drawing.Size(152, 26)
        Me.btnNewHighlight.Text = "Highlight"
        '
        'btnNewWord
        '
        Me.btnNewWord.Name = "btnNewWord"
        Me.btnNewWord.Size = New System.Drawing.Size(152, 26)
        Me.btnNewWord.Text = "Word"
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 383)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 26)
        Me.StatusStrip1.TabIndex = 50
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(342, 326)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(150, 50)
        Me.btnGenerate.TabIndex = 51
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'chkQuote
        '
        Me.chkQuote.AutoSize = True
        Me.chkQuote.Location = New System.Drawing.Point(321, 64)
        Me.chkQuote.Name = "chkQuote"
        Me.chkQuote.Size = New System.Drawing.Size(15, 14)
        Me.chkQuote.TabIndex = 66
        Me.chkQuote.UseVisualStyleBackColor = True
        '
        'chkFact
        '
        Me.chkFact.AutoSize = True
        Me.chkFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkFact.Location = New System.Drawing.Point(165, 64)
        Me.chkFact.Name = "chkFact"
        Me.chkFact.Size = New System.Drawing.Size(15, 14)
        Me.chkFact.TabIndex = 65
        Me.chkFact.UseVisualStyleBackColor = True
        '
        'chkWord
        '
        Me.chkWord.AutoSize = True
        Me.chkWord.Location = New System.Drawing.Point(477, 64)
        Me.chkWord.Name = "chkWord"
        Me.chkWord.Size = New System.Drawing.Size(15, 14)
        Me.chkWord.TabIndex = 64
        Me.chkWord.UseVisualStyleBackColor = True
        '
        'chkSong
        '
        Me.chkSong.AutoSize = True
        Me.chkSong.Location = New System.Drawing.Point(633, 64)
        Me.chkSong.Name = "chkSong"
        Me.chkSong.Size = New System.Drawing.Size(15, 14)
        Me.chkSong.TabIndex = 69
        Me.chkSong.UseVisualStyleBackColor = True
        '
        'chkHighlight
        '
        Me.chkHighlight.AutoSize = True
        Me.chkHighlight.Location = New System.Drawing.Point(945, 64)
        Me.chkHighlight.Name = "chkHighlight"
        Me.chkHighlight.Size = New System.Drawing.Size(15, 14)
        Me.chkHighlight.TabIndex = 68
        Me.chkHighlight.UseVisualStyleBackColor = True
        '
        'chkPicture
        '
        Me.chkPicture.AutoSize = True
        Me.chkPicture.Location = New System.Drawing.Point(789, 64)
        Me.chkPicture.Name = "chkPicture"
        Me.chkPicture.Size = New System.Drawing.Size(15, 14)
        Me.chkPicture.TabIndex = 67
        Me.chkPicture.UseVisualStyleBackColor = True
        '
        'lblCheckToKeep
        '
        Me.lblCheckToKeep.AutoSize = True
        Me.lblCheckToKeep.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckToKeep.Location = New System.Drawing.Point(60, 342)
        Me.lblCheckToKeep.Name = "lblCheckToKeep"
        Me.lblCheckToKeep.Size = New System.Drawing.Size(276, 17)
        Me.lblCheckToKeep.TabIndex = 70
        Me.lblCheckToKeep.Text = "*New objects will be selected if left unchecked"
        '
        'ViewPostForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 409)
        Me.Controls.Add(Me.lblCheckToKeep)
        Me.Controls.Add(Me.chkSong)
        Me.Controls.Add(Me.chkHighlight)
        Me.Controls.Add(Me.chkPicture)
        Me.Controls.Add(Me.chkQuote)
        Me.Controls.Add(Me.chkFact)
        Me.Controls.Add(Me.chkWord)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.MyDataGrid)
        Me.Controls.Add(Me.btnFacts)
        Me.Controls.Add(Me.btnQuotes)
        Me.Controls.Add(Me.btnWords)
        Me.Controls.Add(Me.btnSongs)
        Me.Controls.Add(Me.btnPictures)
        Me.Controls.Add(Me.btnHighlights)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewPostForm"
        Me.Text = "Post To Web"
        CType(Me.MyDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyDataGrid As DataGridView
    Friend WithEvents btnFacts As Button
    Friend WithEvents btnQuotes As Button
    Friend WithEvents btnWords As Button
    Friend WithEvents btnSongs As Button
    Friend WithEvents btnPictures As Button
    Friend WithEvents btnHighlights As Button
    Friend WithEvents btnPost As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnConnection As ToolStripDropDownButton
    Friend WithEvents btnConnect As ToolStripMenuItem
    Friend WithEvents btnDisconnect As ToolStripMenuItem
    Friend WithEvents btnViewTables As ToolStripButton
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblConnectionStatus As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnGenerate As Button
    Friend WithEvents chkQuote As CheckBox
    Friend WithEvents chkFact As CheckBox
    Friend WithEvents chkWord As CheckBox
    Friend WithEvents chkSong As CheckBox
    Friend WithEvents chkHighlight As CheckBox
    Friend WithEvents chkPicture As CheckBox
    Friend WithEvents btnAdd As ToolStripDropDownButton
    Friend WithEvents btnNewFact As ToolStripMenuItem
    Friend WithEvents btnNewQuote As ToolStripMenuItem
    Friend WithEvents btnNewSong As ToolStripMenuItem
    Friend WithEvents btnNewPicture As ToolStripMenuItem
    Friend WithEvents btnNewHighlight As ToolStripMenuItem
    Friend WithEvents btnNewWord As ToolStripMenuItem
    Friend WithEvents lblCheckToKeep As Label
End Class
