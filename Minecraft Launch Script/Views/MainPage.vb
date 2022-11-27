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

    End Sub

End Class