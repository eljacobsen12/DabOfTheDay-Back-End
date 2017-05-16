<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SongsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SongsForm))
        Me.btnAddSong = New System.Windows.Forms.Button()
        Me.txtSongPath = New System.Windows.Forms.TextBox()
        Me.lblSongPath = New System.Windows.Forms.Label()
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
        Me.lblSongTitle = New System.Windows.Forms.Label()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.lblTags = New System.Windows.Forms.Label()
        Me.txtSongTitle = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnImportXML = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddSong
        '
        Me.btnAddSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSong.Location = New System.Drawing.Point(788, 516)
        Me.btnAddSong.Name = "btnAddSong"
        Me.btnAddSong.Size = New System.Drawing.Size(150, 50)
        Me.btnAddSong.TabIndex = 41
        Me.btnAddSong.Text = "Add Song"
        Me.btnAddSong.UseVisualStyleBackColor = True
        '
        'txtSongPath
        '
        Me.txtSongPath.Location = New System.Drawing.Point(50, 73)
        Me.txtSongPath.Name = "txtSongPath"
        Me.txtSongPath.Size = New System.Drawing.Size(889, 31)
        Me.txtSongPath.TabIndex = 45
        '
        'lblSongPath
        '
        Me.lblSongPath.AutoSize = True
        Me.lblSongPath.Location = New System.Drawing.Point(45, 45)
        Me.lblSongPath.Name = "lblSongPath"
        Me.lblSongPath.Size = New System.Drawing.Size(112, 25)
        Me.lblSongPath.TabIndex = 44
        Me.lblSongPath.Text = "Song Path"
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
        Me.btnClear.Location = New System.Drawing.Point(50, 516)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 50)
        Me.btnClear.TabIndex = 42
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblSongTitle
        '
        Me.lblSongTitle.AutoSize = True
        Me.lblSongTitle.Location = New System.Drawing.Point(44, 118)
        Me.lblSongTitle.Name = "lblSongTitle"
        Me.lblSongTitle.Size = New System.Drawing.Size(109, 25)
        Me.lblSongTitle.TabIndex = 37
        Me.lblSongTitle.Text = "Song Title"
        '
        'txtTags
        '
        Me.txtTags.Location = New System.Drawing.Point(49, 468)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(889, 31)
        Me.txtTags.TabIndex = 40
        '
        'lblTags
        '
        Me.lblTags.AutoSize = True
        Me.lblTags.Location = New System.Drawing.Point(44, 440)
        Me.lblTags.Name = "lblTags"
        Me.lblTags.Size = New System.Drawing.Size(288, 25)
        Me.lblTags.TabIndex = 39
        Me.lblTags.Text = "Tags (Delimited by Commas)"
        '
        'txtSongTitle
        '
        Me.txtSongTitle.Location = New System.Drawing.Point(49, 146)
        Me.txtSongTitle.Name = "txtSongTitle"
        Me.txtSongTitle.Size = New System.Drawing.Size(889, 31)
        Me.txtSongTitle.TabIndex = 46
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(50, 226)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(889, 31)
        Me.txtArtist.TabIndex = 48
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(45, 198)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(61, 25)
        Me.lblArtist.TabIndex = 47
        Me.lblArtist.Text = "Artist"
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(50, 304)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(889, 31)
        Me.txtAlbum.TabIndex = 50
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(45, 276)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(72, 25)
        Me.lblAlbum.TabIndex = 49
        Me.lblAlbum.Text = "Album"
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(49, 386)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(889, 31)
        Me.txtGenre.TabIndex = 52
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(44, 358)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(71, 25)
        Me.lblGenre.TabIndex = 51
        Me.lblGenre.Text = "Genre"
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
        Me.StatusStrip1.TabIndex = 53
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnImportXML
        '
        Me.btnImportXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportXML.Location = New System.Drawing.Point(395, 516)
        Me.btnImportXML.Name = "btnImportXML"
        Me.btnImportXML.Size = New System.Drawing.Size(194, 50)
        Me.btnImportXML.TabIndex = 54
        Me.btnImportXML.Text = "Import XML"
        Me.btnImportXML.UseVisualStyleBackColor = True
        '
        'SongForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 609)
        Me.Controls.Add(Me.btnImportXML)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.txtAlbum)
        Me.Controls.Add(Me.lblAlbum)
        Me.Controls.Add(Me.txtArtist)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.txtSongTitle)
        Me.Controls.Add(Me.btnAddSong)
        Me.Controls.Add(Me.txtSongPath)
        Me.Controls.Add(Me.lblSongPath)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblSongTitle)
        Me.Controls.Add(Me.txtTags)
        Me.Controls.Add(Me.lblTags)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "SongForm"
        Me.Text = "Songs"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddSong As Button
    Friend WithEvents txtSongPath As TextBox
    Friend WithEvents lblSongPath As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnClear As Button
    Friend WithEvents lblSongTitle As Label
    Friend WithEvents txtTags As TextBox
    Friend WithEvents lblTags As Label
    Friend WithEvents txtSongTitle As TextBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents lblArtist As Label
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents lblAlbum As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblGenre As Label
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
