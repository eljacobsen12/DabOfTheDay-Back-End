<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnectionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConnectionForm))
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.lblConnectToDB = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnConnection = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(483, 75)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(150, 50)
        Me.btnConnect.TabIndex = 42
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'lblConnectToDB
        '
        Me.lblConnectToDB.AutoSize = True
        Me.lblConnectToDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectToDB.Location = New System.Drawing.Point(125, 79)
        Me.lblConnectToDB.Name = "lblConnectToDB"
        Me.lblConnectToDB.Size = New System.Drawing.Size(352, 39)
        Me.lblConnectToDB.TabIndex = 47
        Me.lblConnectToDB.Text = "Connect To Database"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblConnectionStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 183)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 26)
        Me.StatusStrip1.TabIndex = 48
        Me.StatusStrip1.Text = "StatusStrip1"
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConnection, Me.btnViewTables, Me.btnAdd, Me.btnPostToWeb})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 28)
        Me.ToolStrip1.TabIndex = 49
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnConnection
        '
        Me.btnConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnConnection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnDisconnect})
        Me.btnConnection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnection.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Size = New System.Drawing.Size(102, 25)
        Me.btnConnection.Text = "Connection"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Green
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 26)
        Me.ToolStripMenuItem1.Text = "Connect"
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
        'ConnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 209)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblConnectToDB)
        Me.Controls.Add(Me.btnConnect)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ConnectionForm"
        Me.Text = "DabOfTheDay"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents lblConnectToDB As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblConnectionStatus As ToolStripStatusLabel
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnConnection As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnDisconnect As ToolStripMenuItem
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
