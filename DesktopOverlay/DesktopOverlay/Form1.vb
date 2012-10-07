Imports System.Xml

Public Class Form1

    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Dim ConfigPath As String = Application.StartupPath & "\config.xml"
    Dim ConfigData As New XmlDocument
    Dim ConfigNode As XmlNode

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConfigData.Load(ConfigPath)
        ConfigNode = ConfigData.SelectSingleNode("/DesktopOverlay")
        PictureBox1.ImageLocation = ConfigNode.SelectSingleNode("Imagepath").InnerText
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control And e.Alt And e.KeyCode = Keys.F) Then 'STRG + ALT + F
            Me.WindowState = FormWindowState.Maximized
        ElseIf (e.Control And e.Alt And e.KeyCode = Keys.N) Then 'STRG + ALT + N
            Me.WindowState = FormWindowState.Normal
        ElseIf (e.Control And e.Alt And e.KeyCode = Keys.Q) Then 'STRG + ALT + Q
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        mouseX = Windows.Forms.Cursor.Position.X - Me.Left
        mouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mouseY
            Me.Left = Windows.Forms.Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub

End Class
