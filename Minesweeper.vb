Public Class Minesweeper
    'Offsets/Sizes
    Const SIZE_MINE As Integer = 16
    Const OFFSET_TOP As Integer = 56
    Const OFFSET_BOT As Integer = 16
    Const OFFSET_LEFT As Integer = 9
    Const OFFSET_RIGHT As Integer = 9
    'Variables
    Property difficulty As SaveGame.Difficulty = SaveGame.Difficulty.Easy
    Property widthMines As Integer = 15
    Property heightMines As Integer = 15
    Property numMines As Integer = 20

    Private Shared random As New Random
    Private hasEnded As Boolean = False
    Private numCleared As Integer = 0
    Private timeElapsed As Integer = 0
    Private scores As New ArrayList()

    Private Sub MineClicked(sender As Object, e As EventArgs)
        If (hasEnded) Then Return
        timer.Start()
        Try
            Dim button As MineButton = CType(sender, MineButton)
            If (button.IsShowing) Then Return
            button.Clicked()
            'Check if the player clicked a mine
            If (button.IsMine) Then
                lblStatus.Text = "You Lose!"
                hasEnded = True
                timer.Stop()
                Return
            End If
            numCleared += 1
            'Check if the player won
            If (numCleared >= widthMines * heightMines - numMines) Then
                lblStatus.Text = "You Won!"
                hasEnded = True
                timer.Stop()
                scores.Add(timeElapsed)
                scores.Sort()
                Return
            End If

            'Recursively call this method on surrounding tiles if it is empty
            If (button.AdjacentMines = 0 And Not button.IsMine) Then
                Dim numMines As Integer = 0
                Dim middlePos = pnlMines.Controls.IndexOf(button)
                Dim newButton As MineButton
                Dim pos As Integer

                'Top-Middle
                pos = middlePos - widthMines
                If (pos >= 0 And pos < pnlMines.Controls.Count) Then
                    newButton = CType(pnlMines.Controls.Item((pos)), MineButton)
                    If (Not newButton.IsShowing) Then MineClicked(newButton, Nothing)
                End If
                'Bottom-Middle
                pos = middlePos + widthMines
                If (pos >= 0 And pos < pnlMines.Controls.Count) Then
                    newButton = CType(pnlMines.Controls.Item((pos)), MineButton)
                    If (Not newButton.IsShowing) Then MineClicked(newButton, Nothing)
                End If

                'Check if we are along the left-edge of the grid
                If (middlePos Mod widthMines > 0) Then
                    'Top-left
                    pos = middlePos - widthMines - 1
                    If (pos >= 0 And pos < pnlMines.Controls.Count) Then
                        newButton = CType(pnlMines.Controls.Item((pos)), MineButton)
                        If (Not newButton.IsShowing) Then MineClicked(newButton, Nothing)
                    End If
                    'Bottom-left
                    pos = middlePos + widthMines - 1
                    If (pos >= 0 And pos < pnlMines.Controls.Count) Then
                        newButton = CType(pnlMines.Controls.Item((pos)), MineButton)
                        If (Not newButton.IsShowing) Then MineClicked(newButton, Nothing)
                    End If
                    'Left
                    newButton = CType(pnlMines.Controls.Item((middlePos - 1)), MineButton)
                    If (Not newButton.IsShowing) Then MineClicked(newButton, Nothing)
                End If
                'Check if we are along the right-edge of the grid
                If (middlePos Mod widthMines < widthMines - 1) Then
                    'Top-right
                    pos = middlePos - widthMines + 1
                    If (pos >= 0 And pos < pnlMines.Controls.Count) Then
                        newButton = CType(pnlMines.Controls.Item((pos)), MineButton)
                        If (Not newButton.IsShowing) Then MineClicked(newButton, Nothing)
                    End If
                    'Bottom-right
                    pos = middlePos + widthMines + 1
                    If (pos >= 0 And pos < pnlMines.Controls.Count) Then
                        newButton = CType(pnlMines.Controls.Item((pos)), MineButton)
                        If (Not newButton.IsShowing) Then MineClicked(newButton, Nothing)
                    End If
                    'Right
                    newButton = CType(pnlMines.Controls.Item((middlePos + 1)), MineButton)
                    If (Not newButton.IsShowing) Then MineClicked(newButton, Nothing)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Something besides a button was clicked!")
            Return
        End Try
    End Sub
    Private Sub AddButtons()
        'Add MineButtons to form
        For i As Integer = 0 To (widthMines * heightMines) - 1
            Dim button As New MineButton
            AddHandler button.Click, AddressOf Me.MineClicked
            pnlMines.Controls.Add(button)
        Next
    End Sub
    Private Sub SeedMines()
        'Choose random tiles to be mines
        For i As Integer = 0 To numMines - 1
            Dim rand As Integer = random.Next(0, pnlMines.Controls.Count)
            With CType(pnlMines.Controls.Item(rand), MineButton)
                'Make sure we haven't already made this tile a mine
                If (.IsMine) Then
                    i -= 1
                    Continue For
                End If
                .IsMine = True
            End With
        Next
    End Sub
    Private Sub SeedAdjacency()
        For i As Integer = 0 To (widthMines * heightMines) - 1
            Dim numMines As Integer = 0
            Dim button = CType(pnlMines.Controls.Item(i), MineButton)
            Dim middlePos = pnlMines.Controls.IndexOf(button)
            'Top-Middle
            If (ContainsMine(middlePos - widthMines)) Then numMines += 1
            'Bottom-Middle
            If (ContainsMine(middlePos + widthMines)) Then numMines += 1

            'Check if we are along the left-edge of the grid
            If (middlePos Mod widthMines > 0) Then
                'Top-left
                If (ContainsMine(middlePos - widthMines - 1)) Then numMines += 1
                'Bottom-left
                If (ContainsMine(middlePos + widthMines - 1)) Then numMines += 1
                'Left
                If (ContainsMine(middlePos - 1)) Then numMines += 1
            End If
            'Check if we are along the right-edge of the grid
            If (middlePos Mod widthMines < widthMines - 1) Then
                'MessageBox.Show(middlePos Mod widthMines)
                'Top-right
                If (ContainsMine(middlePos - widthMines + 1)) Then numMines += 1
                'Bottom-right
                If (ContainsMine(middlePos + widthMines + 1)) Then numMines += 1
                'Right
                If (ContainsMine(middlePos + 1)) Then numMines += 1
            End If

            'Set number of adjacent mines
            button.AdjacentMines = numMines
        Next
    End Sub
    Private Function ContainsMine(index As Integer)
        'Make sure tile exists
        If (index >= 0 And index < pnlMines.Controls.Count) Then
            Dim button2 = CType(pnlMines.Controls.Item(index), MineButton)
            If (button2.IsMine) Then
                Return True
            End If
        End If
        Return False
    End Function
    Private Sub Setup()
        'Calculate needed size for game and set form size
        Me.Size = New Size((widthMines + 1) * SIZE_MINE + OFFSET_LEFT + OFFSET_RIGHT,
                           ((heightMines + 1) * SIZE_MINE) + OFFSET_TOP + OFFSET_BOT)
        'Set all variables to defaults
        numCleared = 0
        timeElapsed = 0
        hasEnded = False
        timer.Stop()
        pnlMines.Controls.Clear()
        lblStatus.Text = ""
        'Add and setup mines
        AddButtons()
        SeedMines()
        SeedAdjacency()
        scores = SaveGame.Load(difficulty)
    End Sub



    Private Sub ClickButtonEasy(sender As Object, e As EventArgs) Handles btnEasy.Click
        'Save scores if there are any
        If scores.Count > 0 Then
            SaveGame.Save(difficulty, scores)
        End If
        'Set Variables
        Me.widthMines = 10
        Me.heightMines = 10
        Me.numMines = 15
        Me.difficulty = SaveGame.Difficulty.Easy
        Me.Setup()
    End Sub
    Private Sub ClickButtonMedium(sender As Object, e As EventArgs) Handles btnMedium.Click
        'Save scores if there are any
        If scores.Count > 0 Then
            SaveGame.Save(difficulty, scores)
        End If
        'Set Variables
        Me.widthMines = 15
        Me.heightMines = 15
        Me.numMines = 25
        Me.difficulty = SaveGame.Difficulty.Medium
        Me.Setup()
    End Sub
    Private Sub ClickButtonHard(sender As Object, e As EventArgs) Handles btnHard.Click
        'Save scores if there are any
        If scores.Count > 0 Then
            SaveGame.Save(difficulty, scores)
        End If
        'Set Variables
        Me.widthMines = 20
        Me.heightMines = 20
        Me.numMines = 50
        Me.difficulty = SaveGame.Difficulty.Hard
        Me.Setup()
    End Sub
    Private Sub ClickButtonHighscores(sender As Object, e As EventArgs) Handles btnHighscores.Click
        'Show highscores form
        Dim form As New Highscores
        'Set text in highscores form
        If (scores.Count > 0) Then form.lblScore1.Text = scores.Item(0) & " seconds"
        If (scores.Count > 1) Then form.lblScore2.Text = scores.Item(1) & " seconds"
        If (scores.Count > 2) Then form.lblScore3.Text = scores.Item(2) & " seconds"
        If (scores.Count > 3) Then form.lblScore4.Text = scores.Item(3) & " seconds"
        If (scores.Count > 4) Then form.lblScore5.Text = scores.Item(4) & " seconds"
        form.ShowDialog()
    End Sub
    Private Sub ClickButtonRestart(sender As Object, e As EventArgs) Handles btnRestart.Click
        FormLoad(sender, e)
    End Sub
    Private Sub ClickButtonNew(sender As Object, e As EventArgs) Handles btnNew.Click, btnCustom.Click
        'Show custom game dialog
        Dim form As New NewGame
        If (form.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Me.Close()
        End If
    End Sub
    Private Sub ClickButtonExit(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Setup()
    End Sub
    Private Sub FormClose(sender As Object, e As EventArgs) Handles MyBase.Closing
        'Save scores if there are any
        If scores.Count > 0 Then
            SaveGame.Save(difficulty, scores)
        End If
    End Sub
    Private Sub TimerTick(sender As Object, e As EventArgs) Handles timer.Tick
        'Add 1 second to timeElapsed
        timeElapsed += 1
        lblStatus.Text = timeElapsed & " seconds"
    End Sub
End Class
