<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Highscores
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.lblScore4 = New System.Windows.Forms.Label()
        Me.lblScore5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(99, 159)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Top Times"
        '
        'lblScore1
        '
        Me.lblScore1.Location = New System.Drawing.Point(12, 29)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(260, 23)
        Me.lblScore1.TabIndex = 2
        Me.lblScore1.Text = "None"
        Me.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore2
        '
        Me.lblScore2.Location = New System.Drawing.Point(12, 55)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(260, 23)
        Me.lblScore2.TabIndex = 3
        Me.lblScore2.Text = "None"
        Me.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore3
        '
        Me.lblScore3.Location = New System.Drawing.Point(12, 81)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(260, 23)
        Me.lblScore3.TabIndex = 4
        Me.lblScore3.Text = "None"
        Me.lblScore3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore4
        '
        Me.lblScore4.Location = New System.Drawing.Point(12, 107)
        Me.lblScore4.Name = "lblScore4"
        Me.lblScore4.Size = New System.Drawing.Size(260, 23)
        Me.lblScore4.TabIndex = 5
        Me.lblScore4.Text = "None"
        Me.lblScore4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore5
        '
        Me.lblScore5.Location = New System.Drawing.Point(12, 133)
        Me.lblScore5.Name = "lblScore5"
        Me.lblScore5.Size = New System.Drawing.Size(260, 23)
        Me.lblScore5.TabIndex = 6
        Me.lblScore5.Text = "None"
        Me.lblScore5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Highscores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 193)
        Me.Controls.Add(Me.lblScore5)
        Me.Controls.Add(Me.lblScore4)
        Me.Controls.Add(Me.lblScore3)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Highscores"
        Me.Text = "Highscores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore1 As Label
    Friend WithEvents lblScore2 As Label
    Friend WithEvents lblScore3 As Label
    Friend WithEvents lblScore4 As Label
    Friend WithEvents lblScore5 As Label
End Class
