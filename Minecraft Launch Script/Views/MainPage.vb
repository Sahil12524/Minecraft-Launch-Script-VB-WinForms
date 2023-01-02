Imports System.IO
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Public Class MainPage
    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(HomeView)
        rbDarkTheme.Select()
    End Sub

    Private Sub btnNewMethodBypass_Click(sender As Object, e As EventArgs) Handles btnNewMethodBypass.Click
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(NewMethodBypassView)
        Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt", AppWinStyle.Hide, Wait:=100)
        'Threading.Thread.Sleep(1000)

        If HomeView.lblBackupReqStatus.Text = "Yes" Or HomeView.lblBackupReqStatus.Text = "N/A" Or HomeView.lblBackupSystem32DllVersion.Text = "Backup not found" And HomeView.lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
            NewMethodBypassView.Panel13.Show()
            NewMethodBypassView.Panel10.Hide()
            NewMethodBypassView.Panel16.Hide()
            NewMethodBypassView.Panel6.Hide()
            NewMethodBypassView.Panel19.Hide()
        ElseIf HomeView.lblBackupReqStatus.Text = "No" Then
            NewMethodBypassView.Panel13.Hide()
            NewMethodBypassView.Panel10.Show()
            NewMethodBypassView.Panel16.Show()
            NewMethodBypassView.Panel6.Show()
            NewMethodBypassView.Panel19.Show()
        End If
    End Sub

    Private Sub btnOldMethod_Click(sender As Object, e As EventArgs) Handles btnOldMethod.Click
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(OldMethodView)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(AboutView)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(HomeView)
        HomeView.conditChk()
    End Sub

    Private Sub MainPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt")
    End Sub

    Private Sub MainPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If HomeView.lblBypassStatus.Text = "True" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure that you want to close the launcher without stopping the Bypass?", "Bypass Still Running!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt")
                Me.Dispose() '<- First MainPage Should be stopped then it will stop the whole app 
                Application.Exit()
                'MsgBox(result) <- used only for debug
            ElseIf result = DialogResult.No Then
                e.Cancel = True
                'MsgBox(result) <- used only for debug
            End If
        ElseIf HomeView.lblBypassStatus.Text = "False" Then

        End If
    End Sub

    Private Sub rbDarkTheme_CheckedChanged(sender As Object, e As EventArgs) Handles rbDarkTheme.CheckedChanged
        Me.BackColor = SystemColors.Desktop
        Me.ForeColor = SystemColors.Control
        HomeView.BackColor = SystemColors.Desktop
        HomeView.ForeColor = SystemColors.Control
        NewMethodBypassView.BackColor = SystemColors.Desktop
        NewMethodBypassView.ForeColor = SystemColors.Control
        NewMethodBypassView.RichTextBox4.BackColor = SystemColors.Desktop
        NewMethodBypassView.RichTextBox4.ForeColor = SystemColors.Control
        NewMethodBypassView.RichTextBox3.BackColor = SystemColors.Desktop
        NewMethodBypassView.RichTextBox3.ForeColor = SystemColors.Control
        NewMethodBypassView.RichTextBox5.BackColor = SystemColors.Desktop
        NewMethodBypassView.RichTextBox5.ForeColor = SystemColors.Control
        NewMethodBypassView.RichTextBox2.BackColor = SystemColors.Desktop
        NewMethodBypassView.RichTextBox2.ForeColor = SystemColors.Control
        NewMethodBypassView.RichTextBox6.BackColor = SystemColors.Desktop
        NewMethodBypassView.RichTextBox6.ForeColor = SystemColors.Control
        AboutView.BackColor = SystemColors.Desktop
        AboutView.ForeColor = SystemColors.Control
        AboutView.RichTextBox3.BackColor = SystemColors.Desktop
        AboutView.RichTextBox3.ForeColor = SystemColors.Control
        AboutView.RichTextBox4.BackColor = SystemColors.Desktop
        AboutView.RichTextBox4.ForeColor = SystemColors.Control
    End Sub

    Private Sub rbLightTheme_CheckedChanged(sender As Object, e As EventArgs) Handles rbLightTheme.CheckedChanged
        Me.BackColor = SystemColors.Control
        Me.ForeColor = SystemColors.ControlText
        HomeView.BackColor = SystemColors.Control
        HomeView.ForeColor = SystemColors.ControlText
        NewMethodBypassView.BackColor = SystemColors.Control
        NewMethodBypassView.ForeColor = SystemColors.ControlText
        NewMethodBypassView.RichTextBox4.BackColor = SystemColors.Control
        NewMethodBypassView.RichTextBox4.ForeColor = SystemColors.ControlText
        NewMethodBypassView.RichTextBox3.BackColor = SystemColors.Control
        NewMethodBypassView.RichTextBox3.ForeColor = SystemColors.ControlText
        NewMethodBypassView.RichTextBox5.BackColor = SystemColors.Control
        NewMethodBypassView.RichTextBox5.ForeColor = SystemColors.ControlText
        NewMethodBypassView.RichTextBox2.BackColor = SystemColors.Control
        NewMethodBypassView.RichTextBox2.ForeColor = SystemColors.ControlText
        NewMethodBypassView.RichTextBox6.BackColor = SystemColors.Control
        NewMethodBypassView.RichTextBox6.ForeColor = SystemColors.ControlText
        AboutView.BackColor = SystemColors.Control
        AboutView.ForeColor = SystemColors.ControlText
        AboutView.RichTextBox3.BackColor = SystemColors.Control
        AboutView.RichTextBox3.ForeColor = SystemColors.ControlText
        AboutView.RichTextBox4.BackColor = SystemColors.Control
        AboutView.RichTextBox4.ForeColor = SystemColors.ControlText
    End Sub
End Class