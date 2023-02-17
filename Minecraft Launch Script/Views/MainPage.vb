Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class MainPage
    <DllImport("DwmApi")>
    Private Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByVal attrValue As Integer(), ByVal attrSize As Integer) As Integer
    End Function
    Dim isLightTheme
    Dim taskRunning = True
    Sub colorTheme()
        Dim lightmode = CInt(Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1"))
        Try
            If lightmode <> 1 Then 'its a dark mode
                If DwmSetWindowAttribute(Handle, 19, {1}, 4) <> 0 Then DwmSetWindowAttribute(Handle, 20, {1}, 4)
                ThemeHelper.DarkThemeButtons()
                isLightTheme = False
                'rbDarkTheme.Select()
                ThemeHelper.DarkTheme()
            ElseIf lightmode <> 0 Then 'its a light mode
                DwmSetWindowAttribute(Handle, 20, {0}, 4)
                ThemeHelper.LightThemeButtons()
                isLightTheme = True
                'rbLightTheme.Select()
                ThemeHelper.LightTheme()
            End If

        Catch ex As System.ObjectDisposedException
            Application.Exit()
        End Try
    End Sub
    Public Async Sub updateTheme()
        While taskRunning
            Await Task.Delay(500)
            colorTheme()
        End While
    End Sub
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
        colorTheme()
        If isLightTheme = True Then
            'rbLightTheme.Select()
            ThemeHelper.LightTheme()
            taskRunning = False
        ElseIf isLightTheme <> True Then
            'rbDarkTheme.Select()
            ThemeHelper.DarkTheme()
            taskRunning = False
        End If
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub
    Dim fileReader As String = Environ$("USERPROFILE") & "\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftpe\options.txt"
    Dim root As String = "C:\"
    Dim appDefLoc = My.Application.Info.DirectoryPath
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

        If HomeView.lblBypassStatus.Text = "True" Then
            taskRunning = True
            taskRunning = False
            NewMethodBypassView.Panel19.Show()
            NewMethodBypassView.Panel10.Hide()
            NewMethodBypassView.Panel16.Show()
            NewMethodBypassView.Panel6.Show()
            taskRunning = True
            taskRunning = False
        ElseIf HomeView.lblBypassStatus.Text = "False" Or HomeView.lblBypassStatus.Text = "N/A" Then
            taskRunning = True
            taskRunning = False
            NewMethodBypassView.Panel19.Hide()
            taskRunning = True
            taskRunning = False
        End If
        If HomeView.lblBypassStatus.Text = "False" And HomeView.lblBackupReqStatus.Text = "No" Then
            taskRunning = True
            taskRunning = False
            NewMethodBypassView.Panel10.Show()
            NewMethodBypassView.Panel16.Hide()
            NewMethodBypassView.Panel6.Hide()
            taskRunning = True
            taskRunning = False
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
        Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt", AppWinStyle.Hide, Wait:=100)
    End Sub
    Private Sub MainPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If HomeView.lblBypassStatus.Text = "True" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure that you want to close the launcher without stopping the Bypass?, Press No to stop the Bypass and Then close the launcher.", "Bypass Still Running!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Shell("cmd.exe /c del /f CurSystem32Ver.txt CurSysWOW64Ver.txt", AppWinStyle.Hide, Wait:=100)
                Me.Dispose() '<- First MainPage Should be stopped then it will stop the whole app 
                Application.Exit()
                'MsgBox(result) <- used only for debug
            ElseIf result = DialogResult.Cancel Then
                e.Cancel = True
                'MsgBox(result) <- used only for debug
            ElseIf result = DialogResult.No Then
                'e.Cancel = True
                Dim startProc As Process
                NewMethodBypassView.updateForm()
                startProc = Process.Start("bin/new_Stop.bat")
                startProc.WaitForExit()
                NewMethodBypassView.updateForm()
                'NewMethodBypassView.BypassStopStatus()
                'MsgBox(result) <- used only for debug
            End If
        ElseIf HomeView.lblBypassStatus.Text = "False" Then

        End If
    End Sub
    Private Sub rbDarkTheme_CheckedChanged(sender As Object, e As EventArgs) Handles rbDarkTheme.CheckedChanged
        ThemeHelper.DarkTheme()
    End Sub
    Private Sub rbLightTheme_CheckedChanged(sender As Object, e As EventArgs) Handles rbLightTheme.CheckedChanged
        ThemeHelper.LightTheme()
    End Sub
    Private Sub MainPage_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        taskRunning = True
        updateTheme()
    End Sub
    Private Sub MainPage_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        taskRunning = False
    End Sub
    Private Sub btnPerformanceTweak_Click(sender As Object, e As EventArgs) Handles btnPerformanceTweak.Click
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(PerformanceTweakView)
        Try
            Dim fileWrite As String = My.Computer.FileSystem.ReadAllText(fileReader)
            If fileWrite.Contains("gfx_vsync:0") Then
                PerformanceTweakView.lblVsyncStatus.Text = "OFF"
                PerformanceTweakView.lblVsyncStatus.ForeColor = Color.Green
                Directory.SetCurrentDirectory(appDefLoc)
            ElseIf fileWrite.Contains("gfx_vsync:1") Then
                PerformanceTweakView.lblVsyncStatus.Text = "ON"
                PerformanceTweakView.lblVsyncStatus.ForeColor = Color.Red
                Directory.SetCurrentDirectory(appDefLoc)
            End If
        Catch ex As System.IO.DirectoryNotFoundException
            PerformanceTweakView.lblVsyncStatus.Text = "Minecraft is not installed!"
            PerformanceTweakView.lblVsyncStatus.ForeColor = Color.Red
            Directory.SetCurrentDirectory(appDefLoc)
        End Try

    End Sub
End Class