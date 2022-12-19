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
    End Sub

    Private Sub btnNewMethodBypass_Click(sender As Object, e As EventArgs) Handles btnNewMethodBypass.Click
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(NewMethodBypassView)
        Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt")
        Threading.Thread.Sleep(1000)

        If HomeView.lblBackupReqStatus.Text = "Yes" Or HomeView.lblBackupReqStatus.Text = "N/A" Or HomeView.lblBackupSystem32DllVersion.Text = "Backup not found" And HomeView.lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
            NewMethodBypassView.Panel13.Show()
        ElseIf HomeView.lblBackupReqStatus.Text = "No" Then
            NewMethodBypassView.Panel13.Hide()
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
End Class