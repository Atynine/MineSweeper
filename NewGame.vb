Public Class NewGame
    Private Sub ClickButtonCancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ClickButtonStart(sender As Object, e As EventArgs) Handles btnStart.Click
        'Create new minesweeper form
        Dim form = New Minesweeper()
        'Set minesweeper form variables
        form.widthMines = spnWidth.Value
        form.heightMines = spnHeight.Value
        form.numMines = spnMines.Value
        form.difficulty = SaveGame.Difficulty.Custom
        form.Show()
        'Tell original minesweeper form it is OK to close
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class