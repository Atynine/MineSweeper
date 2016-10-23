Public Class MineButton
    Public Property AdjacentMines As Integer = 0
    Public Property IsMine As Boolean = False
    Public Property IsShowing As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = 16
        Me.Height = 16
        Me.Margin = New Padding(0)
        Me.Image = My.Resources.__
    End Sub

    Public Sub Clicked()
        'Shows the value beneath the tile
        Me.Image = GetHiddenImage()
        Me.IsShowing = True
    End Sub

    Private Function GetHiddenImage() As Image
        If IsMine Then
            Return My.Resources.mine
        End If
        Select Case AdjacentMines
            Case 0
                Return My.Resources._0
            Case 1
                Return My.Resources._1
            Case 2
                Return My.Resources._2
            Case 3
                Return My.Resources._3
            Case 4
                Return My.Resources._4
            Case 5
                Return My.Resources._5
            Case 6
                Return My.Resources._6
            Case 7
                Return My.Resources._7
            Case 8
                Return My.Resources._8
            Case Else
                Return My.Resources._0
        End Select
    End Function

End Class
