Imports System.IO
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
        Threading.Thread.Sleep(800)
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
        End Try
    End Sub

    Private Sub MainPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt")
    End Sub

    Private Sub MainPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt")
    End Sub
End Class