Public Class Form1
    Private formCount As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If TextBox1.Modified Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save current changes...?", "Save Changes", MessageBoxButtons.YesNoCancel)
            TextBox1.Text = ""

            If result = DialogResult.Yes Then
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                End If
            ElseIf result = DialogResult.No Then
                TextBox1.Clear()
            End If
        Else
            TextBox1.Clear()
        End If
    End Sub


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        UpdateCursorPosition()
    End Sub

    Private Sub TextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        UpdateCursorPosition()
    End Sub

    Private Sub UpdateCursorPosition()
        Dim cursorIndex As Integer = TextBox1.SelectionStart

        Dim row As Integer = TextBox1.GetLineFromCharIndex(cursorIndex) + 1
        Dim col As Integer = cursorIndex - TextBox1.GetFirstCharIndexFromLine(row - 1) + 1

        Label1.Text = $"Ln: {row}, Col: {col}"
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        UpdateCursorPosition()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If TextBox1.Modified Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save current changes before exiting?", "Save Changes", MessageBoxButtons.YesNoCancel)

            If result = DialogResult.Yes Then
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                End If
            ElseIf result = DialogResult.Cancel Then
                Return
            End If
        End If

        Application.Exit()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newForm As New Form1()
        formCount += 1
        newForm.Text = "Notepad " & formCount.ToString()
        newForm.Show()

    End Sub
End Class