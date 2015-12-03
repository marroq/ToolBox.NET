Option Explicit On
Option Strict On

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO

Namespace CheckedLB
    Public Class frmCheckedListBox
        Inherits System.Windows.Forms.Form
        Private WithEvents checkedListBox1 As System.Windows.Forms.CheckedListBox
        Private WithEvents textBox1 As System.Windows.Forms.TextBox
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents button2 As System.Windows.Forms.Button
        Private WithEvents listBox1 As System.Windows.Forms.ListBox
        Private WithEvents button3 As System.Windows.Forms.Button
        Private components As System.ComponentModel.Container

        Public Sub New()
            InitializeComponent()

            ' Sets up the initial objects in the CheckedListBox. 
            Dim myFruit As String() = {"Apples", "Oranges", "Tomato"}
            CheckedListBox1.Items.AddRange(myFruit)

            ' Changes the selection mode from double-click to single click.
            CheckedListBox1.CheckOnClick = True
        End Sub 'New 

        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If (components IsNot Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
            Me.listBox1 = New System.Windows.Forms.ListBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(144, 64)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(128, 20)
            Me.textBox1.TabIndex = 1
            '
            'checkedListBox1
            '
            Me.checkedListBox1.Location = New System.Drawing.Point(16, 64)
            Me.checkedListBox1.Name = "checkedListBox1"
            Me.checkedListBox1.Size = New System.Drawing.Size(120, 184)
            Me.checkedListBox1.TabIndex = 0
            '
            'listBox1
            '
            Me.listBox1.Location = New System.Drawing.Point(408, 64)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(128, 186)
            Me.listBox1.TabIndex = 3
            '
            'button1
            '
            Me.button1.Enabled = False
            Me.button1.Location = New System.Drawing.Point(144, 104)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(104, 32)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Add Fruit"
            '
            'button2
            '
            Me.button2.Enabled = False
            Me.button2.Location = New System.Drawing.Point(288, 64)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(104, 32)
            Me.button2.TabIndex = 2
            Me.button2.Text = "Show Order"
            '
            'button3
            '
            Me.button3.Enabled = False
            Me.button3.Location = New System.Drawing.Point(288, 104)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(104, 32)
            Me.button3.TabIndex = 2
            Me.button3.Text = "Save Order"
            '
            'frmCheckedListBox
            '
            Me.ClientSize = New System.Drawing.Size(563, 273)
            Me.Controls.Add(Me.listBox1)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.checkedListBox1)
            Me.Name = "frmCheckedListBox"
            Me.Text = "CheckedListBox"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub 'InitializeComponent

        <STAThread()> _
        Public Shared Sub Main()
            Application.Run(New frmCheckedListBox())
        End Sub 'Main

        ' Adds the string if the text box has data in it. 
        Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles button1.Click
            If textBox1.Text <> "" Then
                If CheckedListBox1.CheckedItems.Contains(textBox1.Text) = False Then
                    CheckedListBox1.Items.Add(textBox1.Text, CheckState.Checked)
                End If
                textBox1.Clear()
            End If
        End Sub 'button1_Click

        ' Activates or deactivates the Add button. 
        Private Sub textBox1_TextChanged(sender As Object, e As System.EventArgs) Handles textBox1.TextChanged
            If textBox1.Text = "" Then
                button1.Enabled = False
            Else
                button1.Enabled = True
            End If
        End Sub 'textBox1_TextChanged

        ' Moves the checked items from the CheckedListBox to the listBox. 
        Private Sub button2_Click(sender As Object, e As System.EventArgs) Handles button2.Click
            listBox1.Items.Clear()
            button3.Enabled = False
            Dim i As Integer
            For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                listBox1.Items.Add(CheckedListBox1.CheckedItems(i))
            Next i
            If listBox1.Items.Count > 0 Then
                button3.Enabled = True
            End If
        End Sub 'button2_Click

        ' Activates the move button if there are checked items. 
        Private Sub checkedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
            If e.NewValue = CheckState.Unchecked Then
                If CheckedListBox1.CheckedItems.Count = 1 Then
                    button2.Enabled = False
                End If
            Else
                button2.Enabled = True
            End If
        End Sub 'checkedListBox1_ItemCheck

        ' Saves the items to a file. 
        Private Sub button3_Click(sender As Object, e As System.EventArgs) Handles button3.Click
            ' Insert code to save a file.
            listBox1.Items.Clear()
            Dim myEnumerator As IEnumerator = CheckedListBox1.CheckedIndices.GetEnumerator()
            Dim y As Integer
            While myEnumerator.MoveNext() <> False
                y = CInt(myEnumerator.Current)
                CheckedListBox1.SetItemChecked(y, False)
            End While
            button3.Enabled = False
        End Sub 'button3_Click
    End Class
End Namespace

