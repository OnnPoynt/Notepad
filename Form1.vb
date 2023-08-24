Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If TextBox1.Modified Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save current changes...?", "Save Changes", MessageBoxButtons.YesNoCancel)

            If result = DialogResult.Yes Then
                TextBox1.Clear()
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

        ' If TextBox1.SelectionLength > 0 Then
        'Label1.Text = "Ln:  , Col:"
        ' Return
        ' End If

        Dim row As Integer = TextBox1.GetLineFromCharIndex(cursorIndex) + 1
        Dim col As Integer = cursorIndex - TextBox1.GetFirstCharIndexFromLine(row - 1) + 1

        Label1.Text = $"Ln: {row}, Col: {col}"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class