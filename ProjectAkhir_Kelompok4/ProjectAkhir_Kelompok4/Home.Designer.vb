<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.pnlContent1 = New System.Windows.Forms.Panel()
        Me.pctureLogo = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlContent1.SuspendLayout()
        CType(Me.pctureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(108, 287)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 36)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnRegist
        '
        Me.btnRegist.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRegist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegist.Location = New System.Drawing.Point(393, 287)
        Me.btnRegist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(100, 36)
        Me.btnRegist.TabIndex = 2
        Me.btnRegist.Text = "Register"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(951, 478)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 429)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(932, 24)
        Me.StatusStrip1.TabIndex = 45
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SlabelTanggal
        '
        Me.SlabelTanggal.Name = "SlabelTanggal"
        Me.SlabelTanggal.Size = New System.Drawing.Size(72, 18)
        Me.SlabelTanggal.Text = "Tanggal : "
        '
        'SlabelJam
        '
        Me.SlabelJam.Name = "SlabelJam"
        Me.SlabelJam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SlabelJam.Size = New System.Drawing.Size(49, 18)
        Me.SlabelJam.Text = "Jam : "
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.DarkKhaki
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(361, 429)
        Me.pnlLeft.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(315, 138)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "K-POP STORE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(361, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(571, 44)
        Me.pnlTop.TabIndex = 47
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnMaximize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(463, 0)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(108, 44)
        Me.pnlControl.TabIndex = 48
        '
        'pnlContent1
        '
        Me.pnlContent1.Controls.Add(Me.pctureLogo)
        Me.pnlContent1.Controls.Add(Me.btnLogin)
        Me.pnlContent1.Controls.Add(Me.btnRegist)
        Me.pnlContent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent1.Location = New System.Drawing.Point(361, 44)
        Me.pnlContent1.Name = "pnlContent1"
        Me.pnlContent1.Size = New System.Drawing.Size(571, 385)
        Me.pnlContent1.TabIndex = 48
        '
        'pctureLogo
        '
        Me.pctureLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pctureLogo.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.Logo_Kpop_Store
        Me.pctureLogo.Location = New System.Drawing.Point(0, 0)
        Me.pctureLogo.Name = "pctureLogo"
        Me.pctureLogo.Size = New System.Drawing.Size(571, 235)
        Me.pctureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctureLogo.TabIndex = 3
        Me.pctureLogo.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.minimize15px
        Me.btnMinimize.Location = New System.Drawing.Point(12, 13)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(18, 18)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.maximize15px
        Me.btnMaximize.Location = New System.Drawing.Point(45, 13)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(18, 18)
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.close15px
        Me.btnClose.Location = New System.Drawing.Point(78, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 18)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 453)
        Me.Controls.Add(Me.pnlContent1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
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
        CType(Me.pctureLogo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlContent1 As Panel
    Friend WithEvents pctureLogo As PictureBox
End Class
