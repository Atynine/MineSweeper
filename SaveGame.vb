Public Class SaveGame
    Public Enum Difficulty
        Easy
        Medium
        Hard
        Custom
    End Enum
    Public Shared Sub Save(difficulty As Difficulty, scores As ArrayList)
        Dim file As System.IO.StreamWriter
        'Open file corresponding to difficulty level
        Select Case difficulty
            Case Difficulty.Easy
                file = New IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\MineSweeper\Easy.txt", False)
            Case Difficulty.Medium
                file = New IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\MineSweeper\Medium.txt", False)
            Case Difficulty.Hard
                file = New IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\MineSweeper\Hard.txt", False)
            Case Else
                file = New IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\MineSweeper\Custom.txt", False)
        End Select
        'Write all scores on a seperate line in the file
        For Each i In scores
            file.WriteLine(i)
        Next
        file.Close()
    End Sub
    Public Shared Function Load(difficulty As Difficulty) As ArrayList
        Try
            Dim list As New ArrayList
            Dim file As System.IO.StreamReader
            'Open file corresponding to difficulty level
            Select Case difficulty
                Case Difficulty.Easy
                    file = New IO.StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\MineSweeper\Easy.txt")
                Case Difficulty.Medium
                    file = New IO.StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\MineSweeper\Medium.txt")
                Case Difficulty.Hard
                    file = New IO.StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\MineSweeper\Hard.txt")
                Case Else
                    file = New IO.StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\MineSweeper\Custom.txt")
            End Select
            'Load all scores into arraylist
            Do
                Dim score As Integer
                If (Integer.TryParse(file.ReadLine, score)) Then
                    list.Add(score)
                End If
            Loop Until file.Peek = -1
            'Close file and sort arraylist
            file.Close()
            list.Sort()
            Return list
        Catch ex As IO.DirectoryNotFoundException
            'Create directory for saves
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\MineSweeper")
            Return Load(difficulty)
        Catch ex As Exception
            Return New ArrayList
        End Try
    End Function
End Class
