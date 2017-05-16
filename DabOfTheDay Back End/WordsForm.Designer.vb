<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WordsForm))
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
        Me.btnPostToWeb = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddWord = New System.Windows.Forms.Button()
        Me.lblDefinition = New System.Windows.Forms.Label()
        Me.txtPronunciation = New System.Windows.Forms.TextBox()
        Me.lblPronunciation = New System.Windows.Forms.Label()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.txtSynonyms = New System.Windows.Forms.TextBox()
        Me.lblSynonyms = New System.Windows.Forms.Label()
        Me.txtDefinition = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnImportXML = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConnection, Me.btnViewTables, Me.btnAdd, Me.btnPostToWeb})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 28)
        Me.ToolStrip1.TabIndex = 21
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
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(50, 531)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 50)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddWord
        '
        Me.btnAddWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWord.Location = New System.Drawing.Point(789, 531)
        Me.btnAddWord.Name = "btnAddWord"
        Me.btnAddWord.Size = New System.Drawing.Size(150, 50)
        Me.btnAddWord.TabIndex = 19
        Me.btnAddWord.Text = "Add Word"
        Me.btnAddWord.UseVisualStyleBackColor = True
        '
        'lblDefinition
        '
        Me.lblDefinition.AutoSize = True
        Me.lblDefinition.Location = New System.Drawing.Point(44, 118)
        Me.lblDefinition.Name = "lblDefinition"
        Me.lblDefinition.Size = New System.Drawing.Size(102, 25)
        Me.lblDefinition.TabIndex = 11
        Me.lblDefinition.Text = "Definition"
        '
        'txtPronunciation
        '
        Me.txtPronunciation.Location = New System.Drawing.Point(49, 478)
        Me.txtPronunciation.Name = "txtPronunciation"
        Me.txtPronunciation.Size = New System.Drawing.Size(889, 31)
        Me.txtPronunciation.TabIndex = 18
        '
        'lblPronunciation
        '
        Me.lblPronunciation.AutoSize = True
        Me.lblPronunciation.Location = New System.Drawing.Point(44, 450)
        Me.lblPronunciation.Name = "lblPronunciation"
        Me.lblPronunciation.Size = New System.Drawing.Size(144, 25)
        Me.lblPronunciation.TabIndex = 17
        Me.lblPronunciation.Text = "Pronunciation"
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(49, 396)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(889, 31)
        Me.txtSentence.TabIndex = 16
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(44, 368)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(103, 25)
        Me.lblSentence.TabIndex = 15
        Me.lblSentence.Text = "Sentence"
        '
        'txtSynonyms
        '
        Me.txtSynonyms.Location = New System.Drawing.Point(49, 311)
        Me.txtSynonyms.Name = "txtSynonyms"
        Me.txtSynonyms.Size = New System.Drawing.Size(889, 31)
        Me.txtSynonyms.TabIndex = 14
        '
        'lblSynonyms
        '
        Me.lblSynonyms.AutoSize = True
        Me.lblSynonyms.Location = New System.Drawing.Point(44, 283)
        Me.lblSynonyms.Name = "lblSynonyms"
        Me.lblSynonyms.Size = New System.Drawing.Size(340, 25)
        Me.lblSynonyms.TabIndex = 13
        Me.lblSynonyms.Text = "Synonyms (Delimited by Commas)"
        '
        'txtDefinition
        '
        Me.txtDefinition.Location = New System.Drawing.Point(49, 146)
        Me.txtDefinition.Multiline = True
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.Size = New System.Drawing.Size(889, 123)
        Me.txtDefinition.TabIndex = 12
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(50, 73)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(889, 31)
        Me.txtWord.TabIndex = 23
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(45, 45)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(63, 25)
        Me.lblWord.TabIndex = 22
        Me.lblWord.Text = "Word"
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 603)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 26)
        Me.StatusStrip1.TabIndex = 49
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnImportXML
        '
        Me.btnImportXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportXML.Location = New System.Drawing.Point(386, 531)
        Me.btnImportXML.Name = "btnImportXML"
        Me.btnImportXML.Size = New System.Drawing.Size(194, 50)
        Me.btnImportXML.TabIndex = 51
        Me.btnImportXML.Text = "Import XML"
        Me.btnImportXML.UseVisualStyleBackColor = True
        '
        'WordsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 629)
        Me.Controls.Add(Me.btnImportXML)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddWord)
        Me.Controls.Add(Me.lblDefinition)
        Me.Controls.Add(Me.txtPronunciation)
        Me.Controls.Add(Me.lblPronunciation)
        Me.Controls.Add(Me.txtSentence)
        Me.Controls.Add(Me.lblSentence)
        Me.Controls.Add(Me.txtSynonyms)
        Me.Controls.Add(Me.lblSynonyms)
        Me.Controls.Add(Me.txtDefinition)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "WordsForm"
        Me.Text = "Words"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddWord As Button
    Friend WithEvents lblDefinition As Label
    Friend WithEvents txtPronunciation As TextBox
    Friend WithEvents lblPronunciation As Label
    Friend WithEvents txtSentence As TextBox
    Friend WithEvents lblSentence As Label
    Friend WithEvents txtSynonyms As TextBox
    Friend WithEvents lblSynonyms As Label
    Friend WithEvents txtDefinition As TextBox
    Friend WithEvents txtWord As TextBox
    Friend WithEvents lblWord As Label
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblConnectionStatus As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnConnection As ToolStripDropDownButton
    Friend WithEvents btnConnect As ToolStripMenuItem
    Friend WithEvents btnDisconnect As ToolStripMenuItem
    Friend WithEvents btnImportXML As Button
    Friend WithEvents btnViewTables As ToolStripButton
    Friend WithEvents btnAdd As ToolStripDropDownButton
    Friend WithEvents btnNewFact As ToolStripMenuItem
    Friend WithEvents btnNewQuote As ToolStripMenuItem
    Friend WithEvents btnNewSong As ToolStripMenuItem
    Friend WithEvents btnNewPicture As ToolStripMenuItem
    Friend WithEvents btnNewHighlight As ToolStripMenuItem
    Friend WithEvents btnNewWord As ToolStripMenuItem
    Friend WithEvents btnPostToWeb As ToolStripButton
End Class
