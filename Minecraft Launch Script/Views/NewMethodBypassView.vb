Public Class NewMethodBypassView

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
    Public Async Sub updateForm()
        Dim taskRunning = True
        While taskRunning
            Await Task.Delay(100)
            updateLbl()
            HomeView.Invalidate()
            HomeView.Update()
            Me.Invalidate()
            Me.Update()
            HomeView.Invalidate()
            HomeView.lblBackupReqStatus.Update()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            HomeView.Activate()
            HomeView.Refresh()
            Me.Invalidate()
            Me.Update()
            Application.DoEvents()
            If HomeView.lblBackupReqStatus.Text = "No" Then
                taskRunning = False
                Panel13.Hide()
                Panel10.Show()
                Panel16.Show()
                Panel6.Show()
                Panel19.Show()
            End If
            If HomeView.lblBypassStatus.Text = "True" Then
                taskRunning = True
                taskRunning = False


            ElseIf HomeView.lblBypassStatus.Text = "False" Then
                taskRunning = False
            End If

            If HomeView.lblBypassStatus.Text = "True" Then
                taskRunning = True
                taskRunning = False
                Panel19.Show()
                Panel10.Hide()
                Panel16.Show()
                Panel6.Show()
                taskRunning = True
                taskRunning = False
            ElseIf HomeView.lblBypassStatus.Text = "False" Or HomeView.lblBypassStatus.Text = "N/A" Then
                taskRunning = True
                taskRunning = False
                Panel19.Hide()
                taskRunning = True
                taskRunning = False
            End If
            If HomeView.lblBypassStatus.Text = "False" And HomeView.lblBackupReqStatus.Text = "No" Then
                taskRunning = True
                taskRunning = False
                Panel10.Show()
                Panel16.Hide()
                Panel6.Hide()
                taskRunning = True
                taskRunning = False
            End If
        End While
    End Sub
    Private Sub updateLbl()
        HomeView.conditChk()
    End Sub
    Public Async Sub BypassStopStatus()
        Dim taskRunning = True
        Await Task.Delay(100)
        updateLbl()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        HomeView.Activate()
        HomeView.Refresh()
        If HomeView.lblCurrentSystem32DllVersion.Text = HomeView.lblBackupSystem32DllVersion.Text And HomeView.lblCurrentSysWOW64DllVersion.Text = HomeView.lblBackupSysWOW64DllVersion.Text Then
            MessageBox.Show("Bypass Stopped Successfully ✔️")
            taskRunning = False
        Else
            MessageBox.Show("Bypass Stop Error ✖️")
            'HomeView.lblBypassStatus.Text = "True"
            Panel19.Show()
            Panel6.Show()
            taskRunning = False
        End If
    End Sub
    Public Async Sub BypassLoadStatus()
        Dim taskRunning = True
        Await Task.Delay(100)
        updateLbl()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        HomeView.Activate()
        HomeView.Refresh()
        If HomeView.lblCurrentSystem32DllVersion.Text = HomeView.lblHackSystem32DllVersion.Text And HomeView.lblCurrentSysWOW64DllVersion.Text = HomeView.lblHackSysWOW64DllVersion.Text Then
            MessageBox.Show("Bypass Loaded Successfully ✔️")
            taskRunning = False
        Else
            MessageBox.Show("Bypass Load Error ✖️")
            Panel16.Hide()
            Panel6.Hide()
            Panel19.Hide()
            taskRunning = False
        End If
    End Sub
    Private Sub New_Method_Bypass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        'HomeView.Close()
        'Threading.Thread.Sleep(1000)
        If HomeView.lblBackupReqStatus.Text = "Yes" Or HomeView.lblBackupReqStatus.Text = "N/A" Or HomeView.lblBackupSystem32DllVersion.Text = "Backup not found" And HomeView.lblBackupSysWOW64DllVersion.Text = "Backup not found" Or HomeView.lblBackupSystem32DllVersion.Text = "Backup not found" Or HomeView.lblBackupSysWOW64DllVersion.Text = "Backup not found" Then
            Panel13.Show()
            Panel10.Hide()
            Panel16.Hide()
            Panel6.Hide()
            Panel19.Hide()
        ElseIf HomeView.lblBackupReqStatus.Text = "No" Then
            Panel13.Hide()
            Panel10.Show()
            Panel16.Show()
            Panel6.Show()
            Panel19.Show()
        End If

        If HomeView.lblBypassStatus.Text = "True" Then
            Panel19.Show()
        ElseIf HomeView.lblBypassStatus.Text = "False" Or HomeView.lblBypassStatus.Text = "N/A" Then
            Panel19.Hide()
        End If

        If HomeView.lblBypassStatus.Text = "True" Then

            Panel19.Show()
            Panel10.Hide()
            Panel16.Show()
            Panel6.Show()

        ElseIf HomeView.lblBypassStatus.Text = "False" Or HomeView.lblBypassStatus.Text = "N/A" Then

            Panel19.Hide()

        End If
        If HomeView.lblBypassStatus.Text = "False" And HomeView.lblBackupReqStatus.Text = "No" Then

            Panel10.Show()
            Panel16.Hide()
            Panel6.Hide()
        End If
        'updateForm()
    End Sub
    Private Sub New_Method_Bypass_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        OldMethodView.Close()
    End Sub
    Private Sub New_Method_Bypass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        OldMethodView.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startProc As Process
        updateForm()
        startProc = Process.Start("bin/new_Start.bat")
        startProc.WaitForExit()
        updateForm()
        BypassLoadStatus()
        'taskRunning = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App", AppWinStyle.Hide)
        Threading.Thread.Sleep(4000)
        Shell("taskkill /F /IM ""RuntimeBroker.exe""", AppWinStyle.Hide)
        Dim proc() As Process
        proc = Process.GetProcessesByName("Minecraft.Windows".ToLower) ' <- Do not use .exe in process name
        If proc.Count > 0 Then

        Else
            Dim startProc As Process
            Dim result As DialogResult = MessageBox.Show("Minecraft Bedrock Edition is not installed in this computer, please make sure that you have to install the game first and then use this launcher.", "Minecraft Not Installed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            updateForm()
            startProc = Process.Start("bin/new_Stop.bat")
            startProc.WaitForExit()
            updateForm()
            BypassStopStatus()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'taskRunning = True
        'taskRunning = False

        Dim startProc As Process
        updateForm()
        startProc = Process.Start("bin/new_Stop.bat")
        startProc.WaitForExit()
        updateForm()
        BypassStopStatus()
        'taskRunning = True
        'taskRunning = False
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim backupDLL As Process
        Dim result As DialogResult = MessageBox.Show("Are You Sure That You Never Used This Button Before, Note: Backup Should Be Done Only One Time If You Are A New User?, Press Yes to Make a Backup If Not Made Before Or Press No To Cancel The Backup Process", "Backup DLL Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            updateForm()
            backupDLL = Process.Start("bin/backup_DLL.bat")
            backupDLL.WaitForExit()
            updateForm()
            Update()
        ElseIf result = DialogResult.No Then
            Button5.Enabled = False
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As DialogResult = MessageBox.Show("Are You Sure That You Want To Quick Restart your PC?, Use This Button Only If The System32's DLL Says 'Sharing Violation' Error.", "Quick Restart Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Shell("logoff")
        End If
    End Sub
End Class