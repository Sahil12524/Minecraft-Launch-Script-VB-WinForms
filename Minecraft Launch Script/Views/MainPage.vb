﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
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
        switchPanel(NewMethodBypassView)
    End Sub

    Private Sub btnNewMethodBypass_Click(sender As Object, e As EventArgs) Handles btnNewMethodBypass.Click
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        switchPanel(NewMethodBypassView)
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
    End Sub
End Class