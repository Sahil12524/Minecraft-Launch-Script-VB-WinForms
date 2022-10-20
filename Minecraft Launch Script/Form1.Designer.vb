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
        Me.ToolTipForResetClipService = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(82, 259)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 80)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Run"
        Me.ToolTipForRun.SetToolTip(Me.Button1, "Start the game")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(502, 259)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 80)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close Game"
        Me.ToolTipForCloseGame.SetToolTip(Me.Button2, "Close the game after playing (Very Important)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It will cause problems with the w" &
        "indows store if you close the game directly.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(240, 169)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(300, 80)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Install Now"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(240, 349)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(300, 80)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "What's New"
        Me.ToolTipForWhatsNew.SetToolTip(Me.Button4, "See what is new in this build")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(292, 259)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(200, 80)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Restart"
        Me.ToolTipForRestart.SetToolTip(Me.Button5, "Restart the game")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Version 1.7"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.Location = New System.Drawing.Point(597, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(175, 32)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Reset Clip Service"
        Me.ToolTipForResetClipService.SetToolTip(Me.Button6, "If you accidently closed the game directly without using close game button," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "use " &
        "this button to fix the windows store not working related issues.")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 515)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 37)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Not Running"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(12, 478)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 37)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Installed"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 28)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Stable"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Location = New System.Drawing.Point(16, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 76)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Theme"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Minecraft_Launch_Script.My.Resources.Resources.nightIco
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(63, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.ToolTipForNightTheme.SetToolTip(Me.PictureBox2, "Changes the background image to night theme")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Minecraft_Launch_Script.My.Resources.Resources.dayIco
        Me.PictureBox1.Location = New System.Drawing.Point(6, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.ToolTipForDayTheme.SetToolTip(Me.PictureBox1, "Changes the background image to day theme")
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
        'ToolTipForResetClipService
        '
        Me.ToolTipForResetClipService.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipForResetClipService.ToolTipTitle = "Reset Clip Service"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Control
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button8.Location = New System.Drawing.Point(597, 50)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(175, 32)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = "Restart Launcher"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Minecraft BedRock Edition Launcher"
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
    Friend WithEvents ToolTipForResetClipService As ToolTip
    Friend WithEvents Button8 As Button
End Class
