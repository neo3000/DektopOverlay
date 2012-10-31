Imports System.Xml

Public Class Form1

    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form2.Button1.Text = "Hide"
        Me.Size = My.Settings.LastSize
    End Sub

    Private Sub ResizeMe_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ResizeMe.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.SetBounds(Me.Location.X, Me.Location.Y, (MousePosition.X - (Me.Left)) + 10, (MousePosition.Y - Me.Top) + 10)
            Me.Refresh()
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control And e.Alt And e.KeyCode = Keys.Q) Then 'STRG + ALT + Q
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        mouseX = Windows.Forms.Cursor.Position.X - Me.Left
        mouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drag = True And My.Settings.Move = True Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mouseY
            Me.Left = Windows.Forms.Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.LastPoint = Me.Location
        Form2.Button1.Text = "Show"
    End Sub

End Class
