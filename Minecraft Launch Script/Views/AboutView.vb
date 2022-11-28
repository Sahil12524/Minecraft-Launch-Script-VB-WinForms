Public Class AboutView
    'Dim rs As New Resizer
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

    Private mediaPlayer As System.Media.SoundPlayer = New System.Media.SoundPlayer("audio/mc_klic.wav")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rs.FindAllControls(Me)
    End Sub

    Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'rs.ResizeAllControls(Me)
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'mediaPlayer.Play()
    End Sub

    Private Sub btnLatestUpdateCheck_Click(sender As Object, e As EventArgs) Handles btnLatestUpdateCheck.Click
        Dim r As Long
        r = ShellExecute(0, "open", "https://github.com/Sahil12524/Minecraft-Launch-Script/releases/latest", 0, 0, 1)
    End Sub

    Private Sub btnHowToUseLauncher_Click(sender As Object, e As EventArgs) Handles btnHowToUseLauncher.Click
        Dim r As Long
        r = ShellExecute(0, "open", "https://www.youtube.com/watch?v=go_npKhqGiA", 0, 0, 1)
    End Sub
End Class