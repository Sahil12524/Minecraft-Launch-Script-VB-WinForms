Imports System.IO

Public Class HomeView

    Public Sub conditChk()
        Dim fileReader As String
        Shell("cmd.exe /c wmic datafile where name=""C:\\Windows\\System32\\Windows.ApplicationModel.Store.dll"" Get Version /value > ""CurSystem32Ver.txt"" && wmic datafile where name=""C:\\Windows\\SysWOW64\\Windows.ApplicationModel.Store.dll"" Get Version /value > ""CurSysWOW64Ver.txt"" ", AppWinStyle.Hide, Wait:=100)
        'Threading.Thread.Sleep(1000)
        Try
            fileReader = My.Computer.FileSystem.ReadAllText("CurSystem32Ver.txt").Replace("Version=", "")
            lblCurrentSystem32DllVersion.Text = fileReader.Trim
            fileReader = My.Computer.FileSystem.ReadAllText("CurSysWOW64Ver.txt").Replace("Version=", "")
            lblCurrentSysWOW64DllVersion.Text = fileReader.Trim
        Catch ex As FileNotFoundException
            MsgBox(ex.ToString)
            Shell("Cmd.exe /c type nul > CurSystem32Ver.txt && type nul > CurSysWOW64Ver.txt")
        End Try

        Try
            Dim backupSystem32Dll As FileVersionInfo = FileVersionInfo.GetVersionInfo("bin\dlls\Original Dlls Backup\System32\Windows.ApplicationModel.Store.dll")
            lblBackupSystem32DllVersion.Text = backupSystem32Dll.ProductVersion.ToString
            Dim backupSysWOW64Dll As FileVersionInfo = FileVersionInfo.GetVersionInfo("bin\dlls\Original Dlls Backup\SysWOW64\Windows.ApplicationModel.Store.dll")
            lblBackupSysWOW64DllVersion.Text = backupSysWOW64Dll.ProductVersion.ToString
        Catch ex As FileNotFoundException
            lblBackupSystem32DllVersion.Text = "Backup not found"
            lblBackupSysWOW64DllVersion.Text = "Backup not found"
            'If lblBackupSystem32DllVersion.Text = "Backup not found" And lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
            '    Dim result As DialogResult = MessageBox.Show("Backup DLLs in both the folder not found, please make a backup of DLLs to avoid Windows Corruptions", "Backup Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If
        End Try

        If lblCurrentSystem32DllVersion.Text = lblHackSystem32DllVersion.Text And lblCurrentSysWOW64DllVersion.Text = lblHackSysWOW64DllVersion.Text Or lblCurrentSystem32DllVersion.Text = lblHackSystem32DllVersion.Text Or lblCurrentSysWOW64DllVersion.Text = lblHackSysWOW64DllVersion.Text Then
            lblBypassStatus.ForeColor = Color.Lime
            lblBypassStatus.Text = "True"
        Else
            lblBypassStatus.ForeColor = Color.Red
            lblBypassStatus.Text = "False"
        End If

        If lblCurrentSystem32DllVersion.Text = lblBackupSystem32DllVersion.Text And lblCurrentSysWOW64DllVersion.Text = lblBackupSysWOW64DllVersion.Text Then
            lblBackupReqStatus.ForeColor = Color.Lime
            lblBackupReqStatus.Text = "No"
        ElseIf lblCurrentSystem32DllVersion.Text <> lblBackupSystem32DllVersion.Text And lblCurrentSysWOW64DllVersion.Text <> lblBackupSysWOW64DllVersion.Text And lblBypassStatus.Text = "True" Then
            lblBackupReqStatus.ForeColor = Color.Lime
            lblBackupReqStatus.Text = "No"
        ElseIf lblBypassStatus.Text = "True" Then
            lblBackupReqStatus.ForeColor = Color.Lime
            lblBackupReqStatus.Text = "No"
        Else
            lblBackupReqStatus.ForeColor = Color.Red
            lblBackupReqStatus.Text = "Yes"
        End If

        If lblBackupSystem32DllVersion.Text = "Backup not found" And lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
            lblBackupReqStatus.Text = "N/A"
            lblBypassStatus.ForeColor = Color.Red
            lblBypassStatus.Text = "False"
            lblLauncherHealthStatus.Text = "N/A"
        End If

        'If lblBackupReqStatus.Text = "Yes" Then
        '    Dim result As DialogResult = MessageBox.Show("Backup of the DLLs Needs to be Updated because the original DLLs are either updated via Windows Update or by Microsoft Store Update. Note: Update of Backup DLLs is compulsory to avoid Windows Corruptions or Microsoft Store not working issue!", "Backup Needs To Be Updated!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If

        If lblCurrentSystem32DllVersion.Text = lblBackupSystem32DllVersion.Text And lblCurrentSysWOW64DllVersion.Text = lblBackupSysWOW64DllVersion.Text And lblCurrentSystem32DllVersion.Text = lblCurrentSysWOW64DllVersion.Text And lblBackupSystem32DllVersion.Text = lblBackupSysWOW64DllVersion.Text And lblBackupSystem32DllVersion.Text <> lblHackSystem32DllVersion.Text And lblBackupSysWOW64DllVersion.Text <> lblHackSysWOW64DllVersion.Text Then
            lblLauncherHealthStatus.ForeColor = Color.Lime
            lblLauncherHealthStatus.Text = "Good"
        ElseIf lblBypassStatus.Text = "True" And lblCurrentSystem32DllVersion.Text = lblHackSystem32DllVersion.Text And lblCurrentSysWOW64DllVersion.Text = lblHackSysWOW64DllVersion.Text Then
            lblLauncherHealthStatus.ForeColor = Color.Lime
            lblLauncherHealthStatus.Text = "Good"
        ElseIf lblBackupSystem32DllVersion.Text = "Backup not found" And lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
            lblLauncherHealthStatus.Text = "N/A"
        Else
            lblLauncherHealthStatus.ForeColor = Color.Red
            lblLauncherHealthStatus.Text = "Bad"
        End If
    End Sub

    Private Sub HomeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conditChk() ' <- Function!
        If lblBackupReqStatus.Text = "Yes" Then
            Dim result As DialogResult = MessageBox.Show("Backup of the DLLs Needs to be Updated because the original DLLs are either got updated via Windows Update or by Microsoft Store Update. Note: Update of Backup DLLs is compulsory to avoid Windows Corruptions or Microsoft Store not working like issues!", "Backup of DLLs Needs To Be Updated!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If lblBackupSystem32DllVersion.Text = "Backup not found" And lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
            Dim result As DialogResult = MessageBox.Show("Backup DLLs in both the folder are not found, please make a backup of DLLs to avoid Windows Corruptions", "Backup DLLs Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If lblLauncherHealthStatus.Text = "Bad" Then
            Dim result As DialogResult = MessageBox.Show("The Launcher has a Bad Health, Make sure that you fix the health first before you use the launcher.", "Launcher Bad Health Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Application.Restart()
    End Sub

    Private Sub HomeView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt")
    End Sub

    Private Sub HomeView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt")
    End Sub
End Class