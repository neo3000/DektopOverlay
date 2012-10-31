Imports System.Xml

Public Class Form2

    Dim showTag As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Save()
        If (showTag = True) Then
            Form1.Close()
            showTag = False
        Else
            Form1.Show()
            showTag = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub
End Class