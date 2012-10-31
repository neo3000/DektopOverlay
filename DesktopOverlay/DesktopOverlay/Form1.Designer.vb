<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ResizeMe = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Global.WindowsApplication1.My.MySettings.Default, "ImagePath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ImageLocation = Global.WindowsApplication1.My.MySettings.Default.ImagePath
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ResizeMe
        '
        Me.ResizeMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResizeMe.BackColor = System.Drawing.Color.Transparent
        Me.ResizeMe.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.ResizeMe.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.WindowsApplication1.My.MySettings.Default, "Move", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ResizeMe.Location = New System.Drawing.Point(342, 252)
        Me.ResizeMe.Name = "ResizeMe"
        Me.ResizeMe.Size = New System.Drawing.Size(10, 10)
        Me.ResizeMe.TabIndex = 1
        Me.ResizeMe.Visible = Global.WindowsApplication1.My.MySettings.Default.Move
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 262)
        Me.Controls.Add(Me.ResizeMe)
        Me.Controls.Add(Me.PictureBox1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.WindowsApplication1.My.MySettings.Default, "LastPoint", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = Global.WindowsApplication1.My.MySettings.Default.LastPoint
        Me.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ResizeMe As System.Windows.Forms.Label

End Class
