Public Class Form1

    Dim rs As New Resizer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        mediaPlayer.Play()
        Button5.Enabled = False
        Button2.Enabled = False
        Shell("explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App")
        Threading.Thread.Sleep(3000) 'This basically slows down our program, and the main windows gets time to load after 3 sec after the minecraft gets loaded, if this lines is removed the program does'nt works correctly.
        Dim myProcess() As Process = Process.GetProcessesByName("Minecraft.Windows")
        If myProcess.Length > 0 Then
            'Process is running
            Button3.Enabled = False
            Shell("taskkill /F /IM Minecraft.Windows.exe")
            Label3.Font = New Font("Segoe UI", 20)
            Label3.Visible = True
            Label3.Text = "Installed"
            Label3.ForeColor = Color.Lime
        Else
            'Process is not running
            Button5.Enabled = False
            Button2.Enabled = False
            Button1.Enabled = False
            Label3.Font = New Font("Segoe UI", 20)
            Label3.Visible = True
            Label3.Text = "Not Installed"
            Label3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs)
        rs.ResizeAllControls(Me)
        Label3.Font = New Font("Segoe UI", 20)
        Label2.Font = New Font("Segoe UI", 20)
    End Sub

    Private Declare Function ShellExecute _
                            Lib "shell32.dll" _
                            Alias "ShellExecuteA" (
                            ByVal hwnd As Long,
                            ByVal lpOperation As String,
                            ByVal lpFile As String,
                            ByVal lpParameters As String,
                            ByVal lpDirectory As String,
                            ByVal nShowCmd As Long) _
                            As Long

    Private mediaPlayer As System.Media.SoundPlayer = New System.Media.SoundPlayer("audio/mc_klic.wav")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mediaPlayer.Play()
        Process.Start("bin/start.bat")
        Button5.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = False
        Button1.Enabled = False
        Label2.Font = New Font("Segoe UI", 20)
        Label2.Visible = True
        Label2.Text = "Running"
        Label2.ForeColor = Color.Lime
        Button6.Enabled = False
        Button8.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mediaPlayer.Play()
        Dim result As DialogResult = MessageBox.Show("Are You Sure That You Want To Exit The Game Without Saving?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            mediaPlayer.Play()
            Process.Start("bin/stop.bat")
            Button5.Enabled = False
            Button2.Enabled = False
            Button1.Enabled = True
            Label2.Font = New Font("Segoe UI", 20)
            Label2.Visible = True
            Label2.Text = "Not Running"
            Label2.ForeColor = Color.Red
            Button6.Enabled = True
            Button8.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mediaPlayer.Play()
        MessageBox.Show("Download only Minecraft Pocket Edition (Trial)", "Install Instruction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Dim r As Long
        r = ShellExecute(0, "open", "https://www.microsoft.com/store/productId/9NBLGGH2JHXJ", 0, 0, 1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mediaPlayer.Play()
        Form2.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mediaPlayer.Play()
        Process.Start("bin/restart.bat")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        mediaPlayer.Play()
        Dim r As Long
        r = ShellExecute(0, "open", "https://www.youtube.com/channel/UCJaYH5KX_21lWfX2Ag3-ocg?sub_confirmation=1", 0, 0, 1)
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Me.Button3.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Me.Button3.BackColor = Control.DefaultBackColor
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Me.Button1.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackColor = Control.DefaultBackColor
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Me.Button5.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Me.Button5.BackColor = Control.DefaultBackColor
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Me.Button2.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackColor = Control.DefaultBackColor
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Me.Button4.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Me.Button4.BackColor = Control.DefaultBackColor
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("bin/resetsvcstatus.bat")
        Button6.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.BackColor = DefaultBackColor
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.BackColor = Color.Black
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Button8.Enabled = False
        Dim result As DialogResult = MessageBox.Show("Are You Sure That You Want To Restart The Launcher?
Note: If You Restart The Launcher The Game Will Also Close Along With The Launcher.", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        Me.Button6.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Me.Button6.BackColor = Control.DefaultBackColor
    End Sub

    Private Sub Button8_MouseHover(sender As Object, e As EventArgs) Handles Button8.MouseHover
        Me.Button8.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Me.Button8.BackColor = Control.DefaultBackColor
    End Sub
End Class
