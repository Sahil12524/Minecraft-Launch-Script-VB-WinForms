﻿Public Class NewMethodBypassView

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
    Private Sub New_Method_Bypass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub

    Private Sub New_Method_Bypass_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        OldMethodView.Close()
    End Sub

    Private Sub New_Method_Bypass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        OldMethodView.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("bin/new_Start.bat")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("bin/new_Stop.bat")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As DialogResult = MessageBox.Show("Are You Sure That You Never Used This Button Before, Note: Backup Should Be Done Only One Time If You Are A New User?, Press Yes to Make a Backup If Not Made Before Or Press No To Cancel The Backup Process", "Backup DLL Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Process.Start("bin/backup_DLL.bat")
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