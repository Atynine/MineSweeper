<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewGame
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
        Me.spnWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.spnHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.spnMines = New System.Windows.Forms.NumericUpDown()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.spnWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnMines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spnWidth
        '
        Me.spnWidth.Location = New System.Drawing.Point(64, 12)
        Me.spnWidth.Name = "spnWidth"
        Me.spnWidth.Size = New System.Drawing.Size(120, 20)
        Me.spnWidth.TabIndex = 0
        Me.spnWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnWidth.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Height"
        '
        'spnHeight
        '
        Me.spnHeight.Location = New System.Drawing.Point(64, 38)
        Me.spnHeight.Name = "spnHeight"
        Me.spnHeight.Size = New System.Drawing.Size(120, 20)
        Me.spnHeight.TabIndex = 2
        Me.spnHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnHeight.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mines"
        '
        'spnMines
        '
        Me.spnMines.Location = New System.Drawing.Point(64, 64)
        Me.spnMines.Name = "spnMines"
        Me.spnMines.Size = New System.Drawing.Size(120, 20)
        Me.spnMines.TabIndex = 4
        Me.spnMines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnMines.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(15, 90)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(109, 90)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'NewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 124)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.spnMines)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.spnHeight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.spnWidth)
        Me.Name = "NewGame"
        Me.Text = "New"
        CType(Me.spnWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnMines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spnWidth As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents spnHeight As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents spnMines As NumericUpDown
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCancel As Button
End Class
