﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlContent1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlContent1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(0, 298)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(521, 29)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnRegist
        '
        Me.btnRegist.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRegist.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRegist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegist.Location = New System.Drawing.Point(0, 327)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(521, 29)
        Me.btnRegist.TabIndex = 2
        Me.btnRegist.Text = "Register"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(713, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Cornsilk
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 392)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(764, 22)
        Me.StatusStrip1.TabIndex = 45
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SlabelTanggal
        '
        Me.SlabelTanggal.Name = "SlabelTanggal"
        Me.SlabelTanggal.Size = New System.Drawing.Size(72, 17)
        Me.SlabelTanggal.Text = "Tanggal : "
        '
        'SlabelJam
        '
        Me.SlabelJam.Name = "SlabelJam"
        Me.SlabelJam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SlabelJam.Size = New System.Drawing.Size(46, 17)
        Me.SlabelJam.Text = "Jam : "
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.Coral
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(243, 392)
        Me.pnlLeft.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(248, 120)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "WELCOME TO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "K-POP STORE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(243, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(521, 36)
        Me.pnlTop.TabIndex = 47
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(467, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(54, 36)
        Me.pnlControl.TabIndex = 49
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.maximize15px
        Me.btnMinimize.Location = New System.Drawing.Point(2, 10)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(14, 15)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.close15px
        Me.btnClose.Location = New System.Drawing.Point(32, 10)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(14, 15)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pnlContent1
        '
        Me.pnlContent1.Controls.Add(Me.Panel1)
        Me.pnlContent1.Controls.Add(Me.btnLogin)
        Me.pnlContent1.Controls.Add(Me.btnRegist)
        Me.pnlContent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent1.Location = New System.Drawing.Point(243, 36)
        Me.pnlContent1.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlContent1.Name = "pnlContent1"
        Me.pnlContent1.Size = New System.Drawing.Size(521, 356)
        Me.pnlContent1.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.Logo_Kpop_Store
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 298)
        Me.Panel1.TabIndex = 3
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 414)
        Me.Controls.Add(Me.pnlContent1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "K-Pop Store"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlContent1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegist As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlContent1 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
End Class
