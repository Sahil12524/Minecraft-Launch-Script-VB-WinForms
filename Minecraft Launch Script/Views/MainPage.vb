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
        Else
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
        Dim fileReader As String
        Shell("cmd.exe /c wmic datafile where name=""C:\\Windows\\System32\\Windows.ApplicationModel.Store.dll"" Get Version /value > ""CurSystem32Ver.txt"" && wmic datafile where name=""C:\\Windows\\SysWOW64\\Windows.ApplicationModel.Store.dll"" Get Version /value > ""CurSysWOW64Ver.txt"" ")
        Threading.Thread.Sleep(1000)

        Try
            fileReader = My.Computer.FileSystem.ReadAllText("CurSystem32Ver.txt").Replace("Version=", "")
            HomeView.lblCurrentSystem32DllVersion.Text = fileReader.Trim
            fileReader = My.Computer.FileSystem.ReadAllText("CurSysWOW64Ver.txt").Replace("Version=", "")
            HomeView.lblCurrentSysWOW64DllVersion.Text = fileReader.Trim
        Catch ex As FileNotFoundException
            MsgBox(ex.ToString)
            Shell("Cmd.exe /c type nul > CurSystem32Ver.txt && type nul > CurSysWOW64Ver.txt")
        End Try

        Try
            Dim backupSystem32Dll As FileVersionInfo = FileVersionInfo.GetVersionInfo("bin\dlls\Original Dlls Backup\System32\Windows.ApplicationModel.Store.dll")
            HomeView.lblBackupSystem32DllVersion.Text = backupSystem32Dll.ProductVersion.ToString
            Dim backupSysWOW64Dll As FileVersionInfo = FileVersionInfo.GetVersionInfo("bin\dlls\Original Dlls Backup\SysWOW64\Windows.ApplicationModel.Store.dll")
            HomeView.lblBackupSysWOW64DllVersion.Text = backupSystem32Dll.ProductVersion.ToString
        Catch ex As FileNotFoundException
            HomeView.lblBackupSystem32DllVersion.Text = "Backup not found"
            HomeView.lblBackupSysWOW64DllVersion.Text = "Backup not found"
            If HomeView.lblBackupSystem32DllVersion.Text = "Backup not found" And HomeView.lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
                Dim result As DialogResult = MessageBox.Show("Backup DLLs in both the folder not found, please make a backup of DLLs to avoid Windows Corruptions", "Backup Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try

        If HomeView.lblCurrentSystem32DllVersion.Text = HomeView.lblHackSystem32DllVersion.Text And HomeView.lblCurrentSysWOW64DllVersion.Text = HomeView.lblHackSysWOW64DllVersion.Text Then
            HomeView.lblBypassStatus.ForeColor = Color.Lime
            HomeView.lblBypassStatus.Text = "True"
        Else
            HomeView.lblBypassStatus.ForeColor = Color.Red
            HomeView.lblBypassStatus.Text = "False"
        End If

        If HomeView.lblCurrentSystem32DllVersion.Text = HomeView.lblHackSystem32DllVersion.Text And HomeView.lblCurrentSysWOW64DllVersion.Text = HomeView.lblHackSysWOW64DllVersion.Text Then
            HomeView.lblBypassStatus.ForeColor = Color.Lime
            HomeView.lblBypassStatus.Text = "True"
        Else
            HomeView.lblBypassStatus.ForeColor = Color.Red
            HomeView.lblBypassStatus.Text = "False"
        End If

        If HomeView.lblCurrentSystem32DllVersion.Text = HomeView.lblBackupSystem32DllVersion.Text And HomeView.lblCurrentSysWOW64DllVersion.Text = HomeView.lblBackupSysWOW64DllVersion.Text Then
            HomeView.lblBackupReqStatus.ForeColor = Color.Lime
            HomeView.lblBackupReqStatus.Text = "No"
        ElseIf HomeView.lblCurrentSystem32DllVersion.Text <> HomeView.lblBackupSystem32DllVersion.Text And HomeView.lblCurrentSysWOW64DllVersion.Text <> HomeView.lblBackupSysWOW64DllVersion.Text And HomeView.lblBypassStatus.Text = "True" Then
            HomeView.lblBackupReqStatus.ForeColor = Color.Lime
            HomeView.lblBackupReqStatus.Text = "No"
        Else
            HomeView.lblBackupReqStatus.ForeColor = Color.Red
            HomeView.lblBackupReqStatus.Text = "Yes"
        End If

        If HomeView.lblBackupSystem32DllVersion.Text = "Backup not found" And HomeView.lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
            HomeView.lblBackupReqStatus.Text = "N/A"
        End If

        If HomeView.lblBackupReqStatus.Text = "Yes" Then
            Dim result As DialogResult = MessageBox.Show("Backup of the DLLs Needs to be Updated because the original DLLs are either updated via Windows Update or by Microsoft Store Update. Note: Update of Backup DLLs is compulsory to avoid Windows Corruptions or Microsoft Store not working issue!", "Backup Needs To Be Updated!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

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