<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighlightsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HighlightsForm))
        Me.lblHighlightPath = New System.Windows.Forms.Label()
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
        Me.btnAddHighlight = New System.Windows.Forms.Button()
        Me.lblImageDescription = New System.Windows.Forms.Label()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.lblTags = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lblSport = New System.Windows.Forms.Label()
        Me.txtSport = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnImportXML = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHighlightPath
        '
        Me.lblHighlightPath.AutoSize = True
        Me.lblHighlightPath.Location = New System.Drawing.Point(45, 119)
        Me.lblHighlightPath.Name = "lblHighlightPath"
        Me.lblHighlightPath.Size = New System.Drawing.Size(146, 25)
        Me.lblHighlightPath.TabIndex = 44
        Me.lblHighlightPath.Text = "Highlight Path"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConnection, Me.btnViewTables, Me.btnAdd, Me.btnPostToWeb})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 28)
        Me.ToolStrip1.TabIndex = 43
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
        Me.btnClear.Location = New System.Drawing.Point(49, 437)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(194, 50)
        Me.btnClear.TabIndex = 42
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddHighlight
        '
        Me.btnAddHighlight.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHighlight.Location = New System.Drawing.Point(745, 437)
        Me.btnAddHighlight.Name = "btnAddHighlight"
        Me.btnAddHighlight.Size = New System.Drawing.Size(194, 50)
        Me.btnAddHighlight.TabIndex = 41
        Me.btnAddHighlight.Text = "Add Highlight"
        Me.btnAddHighlight.UseVisualStyleBackColor = True
        '
        'lblImageDescription
        '
        Me.lblImageDescription.AutoSize = True
        Me.lblImageDescription.Location = New System.Drawing.Point(44, 192)
        Me.lblImageDescription.Name = "lblImageDescription"
        Me.lblImageDescription.Size = New System.Drawing.Size(120, 25)
        Me.lblImageDescription.TabIndex = 37
        Me.lblImageDescription.Text = "Description"
        '
        'txtTags
        '
        Me.txtTags.Location = New System.Drawing.Point(49, 385)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(889, 31)
        Me.txtTags.TabIndex = 40
        '
        'lblTags
        '
        Me.lblTags.AutoSize = True
        Me.lblTags.Location = New System.Drawing.Point(44, 357)
        Me.lblTags.Name = "lblTags"
        Me.lblTags.Size = New System.Drawing.Size(288, 25)
        Me.lblTags.TabIndex = 39
        Me.lblTags.Text = "Tags (Delimited by Commas)"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(49, 220)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(889, 123)
        Me.txtDescription.TabIndex = 38
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(50, 147)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(889, 31)
        Me.txtPath.TabIndex = 45
        '
        'lblSport
        '
        Me.lblSport.AutoSize = True
        Me.lblSport.Location = New System.Drawing.Point(45, 45)
        Me.lblSport.Name = "lblSport"
        Me.lblSport.Size = New System.Drawing.Size(63, 25)
        Me.lblSport.TabIndex = 46
        Me.lblSport.Text = "Sport"
        '
        'txtSport
        '
        Me.txtSport.Location = New System.Drawing.Point(49, 73)
        Me.txtSport.Name = "txtSport"
        Me.txtSport.Size = New System.Drawing.Size(889, 31)
        Me.txtSport.TabIndex = 47
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 503)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 26)
        Me.StatusStrip1.TabIndex = 49
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnImportXML
        '
        Me.btnImportXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportXML.Location = New System.Drawing.Point(400, 437)
        Me.btnImportXML.Name = "btnImportXML"
        Me.btnImportXML.Size = New System.Drawing.Size(194, 50)
        Me.btnImportXML.TabIndex = 50
        Me.btnImportXML.Text = "Import XML"
        Me.btnImportXML.UseVisualStyleBackColor = True
        '
        'HighlightsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 529)
        Me.Controls.Add(Me.btnImportXML)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblSport)
        Me.Controls.Add(Me.txtSport)
        Me.Controls.Add(Me.lblHighlightPath)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddHighlight)
        Me.Controls.Add(Me.lblImageDescription)
        Me.Controls.Add(Me.txtTags)
        Me.Controls.Add(Me.lblTags)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtPath)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "HighlightsForm"
        Me.Text = "Highlights"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHighlightPath As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddHighlight As Button
    Friend WithEvents lblImageDescription As Label
    Friend WithEvents txtTags As TextBox
    Friend WithEvents lblTags As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblSport As Label
    Friend WithEvents txtSport As TextBox
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
