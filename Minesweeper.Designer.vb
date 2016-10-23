<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Minesweeper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlMines = New System.Windows.Forms.FlowLayoutPanel()
        Me.stsStrip = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEasy = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMedium = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHard = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCustom = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHighscores = New System.Windows.Forms.ToolStripMenuItem()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.stsStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMines
        '
        Me.pnlMines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMines.BackColor = System.Drawing.SystemColors.Control
        Me.pnlMines.Location = New System.Drawing.Point(9, 24)
        Me.pnlMines.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMines.Name = "pnlMines"
        Me.pnlMines.Size = New System.Drawing.Size(488, 359)
        Me.pnlMines.TabIndex = 0
        '
        'stsStrip
        '
        Me.stsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.stsStrip.Location = New System.Drawing.Point(0, 383)
        Me.stsStrip.Name = "stsStrip"
        Me.stsStrip.Size = New System.Drawing.Size(506, 22)
        Me.stsStrip.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFile, Me.btnHighscores})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(506, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnFile
        '
        Me.btnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnRestart, Me.btnExit})
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(37, 20)
        Me.btnFile.Text = "File"
        '
        'btnNew
        '
        Me.btnNew.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEasy, Me.btnMedium, Me.btnHard, Me.btnCustom})
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(152, 22)
        Me.btnNew.Text = "New"
        '
        'btnEasy
        '
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(119, 22)
        Me.btnEasy.Text = "Easy"
        '
        'btnMedium
        '
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(119, 22)
        Me.btnMedium.Text = "Medium"
        '
        'btnHard
        '
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(119, 22)
        Me.btnHard.Text = "Hard"
        '
        'btnCustom
        '
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(119, 22)
        Me.btnCustom.Text = "Custom"
        '
        'btnRestart
        '
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(152, 22)
        Me.btnRestart.Text = "Restart"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 22)
        Me.btnExit.Text = "Exit"
        '
        'btnHighscores
        '
        Me.btnHighscores.Name = "btnHighscores"
        Me.btnHighscores.Size = New System.Drawing.Size(78, 20)
        Me.btnHighscores.Text = "Highscores"
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(506, 405)
        Me.Controls.Add(Me.stsStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlMines)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Minesweeper"
        Me.Text = "MineSweeper"
        Me.stsStrip.ResumeLayout(False)
        Me.stsStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMines As FlowLayoutPanel
    Friend WithEvents stsStrip As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnFile As ToolStripMenuItem
    Friend WithEvents btnNew As ToolStripMenuItem
    Friend WithEvents btnRestart As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
    Friend WithEvents timer As Timer
    Friend WithEvents btnHighscores As ToolStripMenuItem
    Friend WithEvents btnEasy As ToolStripMenuItem
    Friend WithEvents btnMedium As ToolStripMenuItem
    Friend WithEvents btnHard As ToolStripMenuItem
    Friend WithEvents btnCustom As ToolStripMenuItem
End Class
