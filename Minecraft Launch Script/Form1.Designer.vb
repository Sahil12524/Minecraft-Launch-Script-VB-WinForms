<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTipForRun = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipForInstallNow = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipForRestart = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipForCloseGame = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipForWhatsNew = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipForDayTheme = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipForNightTheme = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipForResetForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipForResetClipService = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.ToolTipForRun.SetToolTip(Me.Button1, resources.GetString("Button1.ToolTip"))
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.ToolTipForCloseGame.SetToolTip(Me.Button2, resources.GetString("Button2.ToolTip"))
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.ToolTipForWhatsNew.SetToolTip(Me.Button4, resources.GetString("Button4.ToolTip"))
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.ToolTipForRestart.SetToolTip(Me.Button5, resources.GetString("Button5.ToolTip"))
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Name = "Label1"
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.ToolTipForResetClipService.SetToolTip(Me.Button6, resources.GetString("Button6.ToolTip"))
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.ToolTipForResetForm.SetToolTip(Me.Button7, resources.GetString("Button7.ToolTip"))
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Minecraft_Launch_Script.My.Resources.Resources.nightIco
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        Me.ToolTipForNightTheme.SetToolTip(Me.PictureBox2, resources.GetString("PictureBox2.ToolTip"))
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Minecraft_Launch_Script.My.Resources.Resources.dayIco
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        Me.ToolTipForDayTheme.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        '
        'ToolTipForRun
        '
        Me.ToolTipForRun.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForRun.ToolTipTitle = "Run"
        '
        'ToolTipForInstallNow
        '
        Me.ToolTipForInstallNow.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForInstallNow.ToolTipTitle = "Install Now"
        '
        'ToolTipForRestart
        '
        Me.ToolTipForRestart.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForRestart.ToolTipTitle = "Restart"
        '
        'ToolTipForCloseGame
        '
        Me.ToolTipForCloseGame.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForCloseGame.ToolTipTitle = "Close Game"
        '
        'ToolTipForWhatsNew
        '
        Me.ToolTipForWhatsNew.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForWhatsNew.ToolTipTitle = "What's New"
        '
        'ToolTipForDayTheme
        '
        Me.ToolTipForDayTheme.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForDayTheme.ToolTipTitle = "Day Theme"
        '
        'ToolTipForNightTheme
        '
        Me.ToolTipForNightTheme.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForNightTheme.ToolTipTitle = "Night Theme"
        '
        'ToolTipForResetForm
        '
        Me.ToolTipForResetForm.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForResetForm.ToolTipTitle = "Reset Form"
        '
        'ToolTipForResetClipService
        '
        Me.ToolTipForResetClipService.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForResetClipService.ToolTipTitle = "Reset Clip Service"
        '
        'Button8
        '
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Minecraft_Launch_Script.My.Resources.Resources.mcbackGndDay
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTipForRun As ToolTip
    Friend WithEvents ToolTipForCloseGame As ToolTip
    Friend WithEvents ToolTipForWhatsNew As ToolTip
    Friend WithEvents ToolTipForRestart As ToolTip
    Friend WithEvents ToolTipForInstallNow As ToolTip
    Friend WithEvents ToolTipForDayTheme As ToolTip
    Friend WithEvents ToolTipForNightTheme As ToolTip
    Friend WithEvents ToolTipForResetForm As ToolTip
    Friend WithEvents ToolTipForResetClipService As ToolTip
    Friend WithEvents Button8 As Button
End Class
