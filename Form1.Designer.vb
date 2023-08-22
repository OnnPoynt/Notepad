<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TextBox1 = New TextBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        NewWindowToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        DeToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        SearchWithBingToolStripMenuItem = New ToolStripMenuItem()
        FindToolStripMenuItem = New ToolStripMenuItem()
        FindNextToolStripMenuItem = New ToolStripMenuItem()
        FindPreviousToolStripMenuItem = New ToolStripMenuItem()
        ReplaceToolStripMenuItem = New ToolStripMenuItem()
        GoToToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        TimeDateToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        PrintDialog1 = New PrintDialog()
        ColorDialog1 = New ColorDialog()
        SaveFileDialog1 = New SaveFileDialog()
        FontDialog1 = New FontDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(2, 27)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(797, 411)
        TextBox1.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, NewWindowToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator1, PrintToolStripMenuItem, ToolStripSeparator2, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(218, 22)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' NewWindowToolStripMenuItem
        ' 
        NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        NewWindowToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.N
        NewWindowToolStripMenuItem.Size = New Size(218, 22)
        NewWindowToolStripMenuItem.Text = "New window"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(218, 22)
        OpenToolStripMenuItem.Text = "Open..."
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(218, 22)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.S
        SaveAsToolStripMenuItem.Size = New Size(218, 22)
        SaveAsToolStripMenuItem.Text = "Save as..."
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(215, 6)
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        PrintToolStripMenuItem.Size = New Size(218, 22)
        PrintToolStripMenuItem.Text = "Print..."
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(215, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(218, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, ToolStripSeparator3, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, DeToolStripMenuItem, ToolStripSeparator4, SearchWithBingToolStripMenuItem, FindToolStripMenuItem, FindNextToolStripMenuItem, FindPreviousToolStripMenuItem, ReplaceToolStripMenuItem, GoToToolStripMenuItem, ToolStripSeparator5, SelectAllToolStripMenuItem, TimeDateToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        UndoToolStripMenuItem.Size = New Size(211, 22)
        UndoToolStripMenuItem.Text = "Undo"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(208, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CutToolStripMenuItem.Size = New Size(211, 22)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopyToolStripMenuItem.Size = New Size(211, 22)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(211, 22)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' DeToolStripMenuItem
        ' 
        DeToolStripMenuItem.Name = "DeToolStripMenuItem"
        DeToolStripMenuItem.ShortcutKeys = Keys.Delete
        DeToolStripMenuItem.Size = New Size(211, 22)
        DeToolStripMenuItem.Text = "Delete"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(208, 6)
        ' 
        ' SearchWithBingToolStripMenuItem
        ' 
        SearchWithBingToolStripMenuItem.Name = "SearchWithBingToolStripMenuItem"
        SearchWithBingToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.E
        SearchWithBingToolStripMenuItem.Size = New Size(211, 22)
        SearchWithBingToolStripMenuItem.Text = "Search with Bing..."
        ' 
        ' FindToolStripMenuItem
        ' 
        FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        FindToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F
        FindToolStripMenuItem.Size = New Size(211, 22)
        FindToolStripMenuItem.Text = "Find..."
        ' 
        ' FindNextToolStripMenuItem
        ' 
        FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem"
        FindNextToolStripMenuItem.ShortcutKeys = Keys.F3
        FindNextToolStripMenuItem.Size = New Size(211, 22)
        FindNextToolStripMenuItem.Text = "Find next"
        ' 
        ' FindPreviousToolStripMenuItem
        ' 
        FindPreviousToolStripMenuItem.Name = "FindPreviousToolStripMenuItem"
        FindPreviousToolStripMenuItem.ShortcutKeys = Keys.Shift Or Keys.F3
        FindPreviousToolStripMenuItem.Size = New Size(211, 22)
        FindPreviousToolStripMenuItem.Text = "Find previous"
        ' 
        ' ReplaceToolStripMenuItem
        ' 
        ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        ReplaceToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.H
        ReplaceToolStripMenuItem.Size = New Size(211, 22)
        ReplaceToolStripMenuItem.Text = "Replace..."
        ' 
        ' GoToToolStripMenuItem
        ' 
        GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        GoToToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.G
        GoToToolStripMenuItem.Size = New Size(211, 22)
        GoToToolStripMenuItem.Text = "Go to..."
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(208, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        SelectAllToolStripMenuItem.Size = New Size(211, 22)
        SelectAllToolStripMenuItem.Text = "Select all"
        ' 
        ' TimeDateToolStripMenuItem
        ' 
        TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem"
        TimeDateToolStripMenuItem.ShortcutKeys = Keys.F5
        TimeDateToolStripMenuItem.Size = New Size(211, 22)
        TimeDateToolStripMenuItem.Text = "Time/Date"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SearchWithBingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindPreviousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog
End Class
