Public Class Form2
    Dim rs As New Resizer

    Private mediaPlayer As System.Media.SoundPlayer = New System.Media.SoundPlayer("audio/mc_klic.wav")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub

    Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mediaPlayer.Play()
    End Sub
End Class