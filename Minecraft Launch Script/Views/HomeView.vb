Imports System.IO

Public Class HomeView
    Private Sub HomeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fileReader As String
        Shell("cmd.exe /c wmic datafile where name=""C:\\Windows\\System32\\Windows.ApplicationModel.Store.dll"" Get Version /value > ""CurSystem32Ver.txt"" && wmic datafile where name=""C:\\Windows\\SysWOW64\\Windows.ApplicationModel.Store.dll"" Get Version /value > ""CurSysWOW64Ver.txt"" ")
        Threading.Thread.Sleep(800)
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
            lblBackupSysWOW64DllVersion.Text = backupSystem32Dll.ProductVersion.ToString
        Catch ex As FileNotFoundException
            lblBackupSystem32DllVersion.Text = "Backup not found"
            lblBackupSysWOW64DllVersion.Text = "Backup not found"
            If lblBackupSystem32DllVersion.Text = "Backup not found" And lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
                Dim result As DialogResult = MessageBox.Show("Backup DLLs in both the folder not found, please make a backup of DLLs to avoid Windows Corruptions", "Backup Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try

        If lblCurrentSystem32DllVersion.Text = lblHackSystem32DllVersion.Text And lblCurrentSysWOW64DllVersion.Text = lblHackSysWOW64DllVersion.Text Then
            lblBypassStatus.ForeColor = Color.Lime
            lblBypassStatus.Text = "True"
        Else
            lblBypassStatus.ForeColor = Color.Red
            lblBypassStatus.Text = "False"
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