<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbDarkTheme = New System.Windows.Forms.RadioButton()
        Me.rbLightTheme = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPerformanceTweak = New System.Windows.Forms.Button()
        Me.btnOldMethod = New System.Windows.Forms.Button()
        Me.btnNewMethodBypass = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(236, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel3.Size = New System.Drawing.Size(851, 720)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbDarkTheme)
        Me.Panel4.Controls.Add(Me.rbLightTheme)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(236, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(851, 30)
        Me.Panel4.TabIndex = 2
        '
        'rbDarkTheme
        '
        Me.rbDarkTheme.AutoSize = True
        Me.rbDarkTheme.Dock = System.Windows.Forms.DockStyle.Right
        Me.rbDarkTheme.Location = New System.Drawing.Point(750, 0)
        Me.rbDarkTheme.Name = "rbDarkTheme"
        Me.rbDarkTheme.Size = New System.Drawing.Size(49, 30)
        Me.rbDarkTheme.TabIndex = 1
        Me.rbDarkTheme.TabStop = True
        Me.rbDarkTheme.Text = "Dark"
        Me.rbDarkTheme.UseVisualStyleBackColor = True
        Me.rbDarkTheme.Visible = False
        '
        'rbLightTheme
        '
        Me.rbLightTheme.AutoSize = True
        Me.rbLightTheme.Dock = System.Windows.Forms.DockStyle.Right
        Me.rbLightTheme.Location = New System.Drawing.Point(799, 0)
        Me.rbLightTheme.Name = "rbLightTheme"
        Me.rbLightTheme.Size = New System.Drawing.Size(52, 30)
        Me.rbLightTheme.TabIndex = 0
        Me.rbLightTheme.TabStop = True
        Me.rbLightTheme.Text = "Light"
        Me.rbLightTheme.UseVisualStyleBackColor = True
        Me.rbLightTheme.Visible = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.btnPerformanceTweak)
        Me.Panel2.Controls.Add(Me.btnOldMethod)
        Me.Panel2.Controls.Add(Me.btnNewMethodBypass)
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnAbout)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 750)
        Me.Panel2.TabIndex = 0
        '
        'btnPerformanceTweak
        '
        Me.btnPerformanceTweak.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPerformanceTweak.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPerformanceTweak.Location = New System.Drawing.Point(0, 150)
        Me.btnPerformanceTweak.Name = "btnPerformanceTweak"
        Me.btnPerformanceTweak.Size = New System.Drawing.Size(236, 40)
        Me.btnPerformanceTweak.TabIndex = 4
        Me.btnPerformanceTweak.Text = "Performance Tweak"
        Me.btnPerformanceTweak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerformanceTweak.UseVisualStyleBackColor = True
        '
        'btnOldMethod
        '
        Me.btnOldMethod.BackColor = System.Drawing.SystemColors.Control
        Me.btnOldMethod.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOldMethod.Enabled = False
        Me.btnOldMethod.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOldMethod.ForeColor = System.Drawing.SystemColors.GrayText
        Me.btnOldMethod.Location = New System.Drawing.Point(0, 110)
        Me.btnOldMethod.Name = "btnOldMethod"
        Me.btnOldMethod.Size = New System.Drawing.Size(236, 40)
        Me.btnOldMethod.TabIndex = 1
        Me.btnOldMethod.Text = "Old Method"
        Me.btnOldMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOldMethod.UseVisualStyleBackColor = False
        Me.btnOldMethod.Visible = False
        '
        'btnNewMethodBypass
        '
        Me.btnNewMethodBypass.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewMethodBypass.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNewMethodBypass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewMethodBypass.Location = New System.Drawing.Point(0, 70)
        Me.btnNewMethodBypass.Name = "btnNewMethodBypass"
        Me.btnNewMethodBypass.Size = New System.Drawing.Size(236, 40)
        Me.btnNewMethodBypass.TabIndex = 0
        Me.btnNewMethodBypass.Text = "New Method Bypass"
        Me.btnNewMethodBypass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewMethodBypass.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHome.Location = New System.Drawing.Point(0, 30)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(236, 40)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(236, 30)
        Me.Panel5.TabIndex = 2
        '
        'btnAbout
        '
        Me.btnAbout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAbout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAbout.Location = New System.Drawing.Point(0, 700)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(236, 50)
        Me.btnAbout.TabIndex = 0
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1087, 750)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minecraft Bedrock Edition Launcher"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnOldMethod As Button
    Friend WithEvents btnNewMethodBypass As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents rbDarkTheme As RadioButton
    Friend WithEvents rbLightTheme As RadioButton
    Friend WithEvents btnPerformanceTweak As Button
End Class
