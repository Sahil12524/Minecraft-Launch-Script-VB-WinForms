Imports System.IO

Public Class PerformanceTweakView
    Dim root As String = "C:\"
    Dim appDefLoc = My.Application.Info.DirectoryPath
    Dim fileReader As String = Environ$("USERPROFILE") & "\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftpe\options.txt"
    Private Sub btnVsyncOn_Click(sender As Object, e As EventArgs) Handles btnVsyncOn.Click
        'Directory.SetCurrentDirectory(root)
        Try
            Dim fileWrite As String = My.Computer.FileSystem.ReadAllText(fileReader).Replace("gfx_vsync:0", "gfx_vsync:1")
            File.WriteAllText(fileReader, fileWrite)
            updateForm()
            Directory.SetCurrentDirectory(appDefLoc)
        Catch ex As System.IO.DirectoryNotFoundException
            lblVsyncStatus.Text = "Minecraft is not installed!"
            lblVsyncStatus.ForeColor = Color.Red
            Directory.SetCurrentDirectory(appDefLoc)
        End Try
    End Sub
    Private Sub btnVsyncOff_Click(sender As Object, e As EventArgs) Handles btnVsyncOff.Click
        Try
            Dim fileWrite As String = My.Computer.FileSystem.ReadAllText(fileReader).Replace("gfx_vsync:1", "gfx_vsync:0")
            File.WriteAllText(fileReader, fileWrite)
            updateForm()
            Directory.SetCurrentDirectory(appDefLoc)
        Catch ex As System.IO.DirectoryNotFoundException
            lblVsyncStatus.Text = "Minecraft is not installed!"
            lblVsyncStatus.ForeColor = Color.Red
            Directory.SetCurrentDirectory(appDefLoc)
        End Try
    End Sub
    Public Async Sub updateForm()
        Dim taskRunning = True

        While taskRunning
            Await Task.Delay(100)
            updateLbl()
            Dim fileWrite As String = My.Computer.FileSystem.ReadAllText(fileReader)
            If fileWrite.Contains("gfx_vsync:0") Then
                taskRunning = True
                taskRunning = False
                lblVsyncStatus.Text = "OFF"
                lblVsyncStatus.ForeColor = Color.Green
                taskRunning = True
                taskRunning = False
            ElseIf fileWrite.Contains("gfx_vsync:1") Then
                taskRunning = True
                taskRunning = False
                lblVsyncStatus.Text = "ON"
                lblVsyncStatus.ForeColor = Color.Red
                taskRunning = True
                taskRunning = False
            End If
        End While
    End Sub
    Public Sub updateLbl()
        Dim fileWrite As String = My.Computer.FileSystem.ReadAllText(fileReader)
        If fileWrite.Contains("gfx_vsync:0") Then
            lblVsyncStatus.Text = "OFF"
            lblVsyncStatus.ForeColor = Color.Green
        ElseIf fileWrite.Contains("gfx_vsync:1") Then
            lblVsyncStatus.Text = "ON"
            lblVsyncStatus.ForeColor = Color.Red
        End If
    End Sub
    Private Sub PerformanceTweakView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Directory.SetCurrentDirectory(root)
            Dim fileWrite As String = My.Computer.FileSystem.ReadAllText(fileReader)
            If fileWrite.Contains("gfx_vsync:0") Then
                lblVsyncStatus.Text = "OFF"
                lblVsyncStatus.ForeColor = Color.Green
            ElseIf fileWrite.Contains("gfx_vsync:1") Then
                lblVsyncStatus.Text = "ON"
                lblVsyncStatus.ForeColor = Color.Red
            End If
        Catch ex As System.IO.DirectoryNotFoundException
            lblVsyncStatus.Text = "Minecraft is not installed!"
            lblVsyncStatus.ForeColor = Color.Red
            Directory.SetCurrentDirectory(appDefLoc)
        End Try
    End Sub
End Class