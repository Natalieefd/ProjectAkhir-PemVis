<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formProfil
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFormUbah = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUbahForm = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUbahAlamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUbahNoTelp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUbahPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUbahUsn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUbahNama = New System.Windows.Forms.TextBox()
        Me.pnlSpace = New System.Windows.Forms.Panel()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.pnlProfil = New System.Windows.Forms.Panel()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsn = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KatalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatPesananToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPesananToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtKonfirmPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlFormUbah.SuspendLayout()
        Me.pnlProfil.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Cornsilk
        Me.StatusStrip1.Font = New System.Drawing.Font("Vela Sans GX", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 937)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(764, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SlabelTanggal
        '
        Me.SlabelTanggal.Name = "SlabelTanggal"
        Me.SlabelTanggal.Size = New System.Drawing.Size(59, 17)
        Me.SlabelTanggal.Text = "Tanggal : "
        '
        'SlabelJam
        '
        Me.SlabelJam.Name = "SlabelJam"
        Me.SlabelJam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SlabelJam.Size = New System.Drawing.Size(39, 17)
        Me.SlabelJam.Text = "Jam : "
        '
        'pnlFormUbah
        '
        Me.pnlFormUbah.BackColor = System.Drawing.Color.Bisque
        Me.pnlFormUbah.Controls.Add(Me.Label1)
        Me.pnlFormUbah.Controls.Add(Me.btnClear)
        Me.pnlFormUbah.Controls.Add(Me.btnUbahForm)
        Me.pnlFormUbah.Controls.Add(Me.Label10)
        Me.pnlFormUbah.Controls.Add(Me.txtUbahAlamat)
        Me.pnlFormUbah.Controls.Add(Me.Label7)
        Me.pnlFormUbah.Controls.Add(Me.txtUbahNoTelp)
        Me.pnlFormUbah.Controls.Add(Me.Label6)
        Me.pnlFormUbah.Controls.Add(Me.Label5)
        Me.pnlFormUbah.Controls.Add(Me.txtUbahPass)
        Me.pnlFormUbah.Controls.Add(Me.Label3)
        Me.pnlFormUbah.Controls.Add(Me.txtUbahUsn)
        Me.pnlFormUbah.Controls.Add(Me.Label2)
        Me.pnlFormUbah.Controls.Add(Me.txtUbahNama)
        Me.pnlFormUbah.Location = New System.Drawing.Point(36, 432)
        Me.pnlFormUbah.Name = "pnlFormUbah"
        Me.pnlFormUbah.Size = New System.Drawing.Size(686, 294)
        Me.pnlFormUbah.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vela Sans GX", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "UBAH PROFIL"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(380, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 27)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUbahForm
        '
        Me.btnUbahForm.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbahForm.Location = New System.Drawing.Point(235, 243)
        Me.btnUbahForm.Name = "btnUbahForm"
        Me.btnUbahForm.Size = New System.Drawing.Size(75, 27)
        Me.btnUbahForm.TabIndex = 20
        Me.btnUbahForm.Text = "Ubah"
        Me.btnUbahForm.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(395, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Alamat"
        '
        'txtUbahAlamat
        '
        Me.txtUbahAlamat.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahAlamat.Location = New System.Drawing.Point(485, 134)
        Me.txtUbahAlamat.Multiline = True
        Me.txtUbahAlamat.Name = "txtUbahAlamat"
        Me.txtUbahAlamat.Size = New System.Drawing.Size(152, 78)
        Me.txtUbahAlamat.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(395, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "No Telp"
        '
        'txtUbahNoTelp
        '
        Me.txtUbahNoTelp.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahNoTelp.Location = New System.Drawing.Point(485, 85)
        Me.txtUbahNoTelp.Name = "txtUbahNoTelp"
        Me.txtUbahNoTelp.Size = New System.Drawing.Size(152, 23)
        Me.txtUbahNoTelp.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 8
        '
        'txtUbahPass
        '
        Me.txtUbahPass.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahPass.Location = New System.Drawing.Point(137, 189)
        Me.txtUbahPass.Name = "txtUbahPass"
        Me.txtUbahPass.Size = New System.Drawing.Size(152, 23)
        Me.txtUbahPass.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Username"
        '
        'txtUbahUsn
        '
        Me.txtUbahUsn.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahUsn.Location = New System.Drawing.Point(137, 136)
        Me.txtUbahUsn.Name = "txtUbahUsn"
        Me.txtUbahUsn.Size = New System.Drawing.Size(152, 23)
        Me.txtUbahUsn.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'txtUbahNama
        '
        Me.txtUbahNama.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahNama.Location = New System.Drawing.Point(137, 85)
        Me.txtUbahNama.Name = "txtUbahNama"
        Me.txtUbahNama.Size = New System.Drawing.Size(152, 23)
        Me.txtUbahNama.TabIndex = 0
        '
        'pnlSpace
        '
        Me.pnlSpace.Location = New System.Drawing.Point(36, 913)
        Me.pnlSpace.Name = "pnlSpace"
        Me.pnlSpace.Size = New System.Drawing.Size(686, 24)
        Me.pnlSpace.TabIndex = 13
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(342, 387)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 27)
        Me.btnUbah.TabIndex = 32
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'pnlProfil
        '
        Me.pnlProfil.BackColor = System.Drawing.Color.Bisque
        Me.pnlProfil.Controls.Add(Me.txtAlamat)
        Me.pnlProfil.Controls.Add(Me.txtNoTelp)
        Me.pnlProfil.Controls.Add(Me.txtPass)
        Me.pnlProfil.Controls.Add(Me.txtUsn)
        Me.pnlProfil.Controls.Add(Me.txtNama)
        Me.pnlProfil.Controls.Add(Me.Label14)
        Me.pnlProfil.Controls.Add(Me.Label16)
        Me.pnlProfil.Controls.Add(Me.Label18)
        Me.pnlProfil.Controls.Add(Me.Label20)
        Me.pnlProfil.Controls.Add(Me.Label22)
        Me.pnlProfil.Controls.Add(Me.Label24)
        Me.pnlProfil.Location = New System.Drawing.Point(171, 79)
        Me.pnlProfil.Name = "pnlProfil"
        Me.pnlProfil.Size = New System.Drawing.Size(417, 294)
        Me.pnlProfil.TabIndex = 33
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(171, 208)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(181, 65)
        Me.txtAlamat.TabIndex = 29
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTelp.Location = New System.Drawing.Point(171, 169)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(181, 23)
        Me.txtNoTelp.TabIndex = 28
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(171, 132)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(181, 23)
        Me.txtPass.TabIndex = 27
        '
        'txtUsn
        '
        Me.txtUsn.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsn.Location = New System.Drawing.Point(171, 96)
        Me.txtUsn.Name = "txtUsn"
        Me.txtUsn.Size = New System.Drawing.Size(181, 23)
        Me.txtUsn.TabIndex = 26
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(171, 61)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(181, 23)
        Me.txtNama.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Vela Sans GX", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(173, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 28)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "PROFIL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(60, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 17)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Username"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(60, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 17)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Nama"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(60, 134)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 17)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Password"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(60, 171)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 17)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "No Telp"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(60, 210)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 17)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "Alamat"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(764, 36)
        Me.pnlTop.TabIndex = 50
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnMaximize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(683, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(81, 36)
        Me.pnlControl.TabIndex = 48
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.minimize15px
        Me.btnMinimize.Location = New System.Drawing.Point(9, 11)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(14, 15)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.maximize15px
        Me.btnMaximize.Location = New System.Drawing.Point(34, 11)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(14, 15)
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.close15px
        Me.btnClose.Location = New System.Drawing.Point(58, 10)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(14, 15)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Cornsilk
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilTokoToolStripMenuItem, Me.KatalogToolStripMenuItem, Me.PesananToolStripMenuItem, Me.ProfilToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 36)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(764, 24)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProfilTokoToolStripMenuItem
        '
        Me.ProfilTokoToolStripMenuItem.Name = "ProfilTokoToolStripMenuItem"
        Me.ProfilTokoToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ProfilTokoToolStripMenuItem.Text = "Profil Toko"
        '
        'KatalogToolStripMenuItem
        '
        Me.KatalogToolStripMenuItem.Name = "KatalogToolStripMenuItem"
        Me.KatalogToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.KatalogToolStripMenuItem.Text = "Katalog"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatPesananToolStripMenuItem, Me.BuatPesananToolStripMenuItem, Me.UbahPesananToolStripMenuItem, Me.HapusPesananToolStripMenuItem})
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'LihatPesananToolStripMenuItem
        '
        Me.LihatPesananToolStripMenuItem.Name = "LihatPesananToolStripMenuItem"
        Me.LihatPesananToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LihatPesananToolStripMenuItem.Text = "Lihat Pesanan"
        '
        'BuatPesananToolStripMenuItem
        '
        Me.BuatPesananToolStripMenuItem.Name = "BuatPesananToolStripMenuItem"
        Me.BuatPesananToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BuatPesananToolStripMenuItem.Text = "Buat Pesanan"
        '
        'UbahPesananToolStripMenuItem
        '
        Me.UbahPesananToolStripMenuItem.Name = "UbahPesananToolStripMenuItem"
        Me.UbahPesananToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.UbahPesananToolStripMenuItem.Text = "Ubah Pesanan"
        '
        'HapusPesananToolStripMenuItem
        '
        Me.HapusPesananToolStripMenuItem.Name = "HapusPesananToolStripMenuItem"
        Me.HapusPesananToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.HapusPesananToolStripMenuItem.Text = "Hapus Pesanan"
        '
        'ProfilToolStripMenuItem
        '
        Me.ProfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatPesananToolStripMenuItem1, Me.UbahPesananToolStripMenuItem1})
        Me.ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        Me.ProfilToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ProfilToolStripMenuItem.Text = "Profil"
        '
        'LihatPesananToolStripMenuItem1
        '
        Me.LihatPesananToolStripMenuItem1.Name = "LihatPesananToolStripMenuItem1"
        Me.LihatPesananToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.LihatPesananToolStripMenuItem1.Text = "Lihat Pesanan"
        '
        'UbahPesananToolStripMenuItem1
        '
        Me.UbahPesananToolStripMenuItem1.Name = "UbahPesananToolStripMenuItem1"
        Me.UbahPesananToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.UbahPesananToolStripMenuItem1.Text = "Ubah Pesanan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'txtKonfirmPass
        '
        Me.txtKonfirmPass.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKonfirmPass.Location = New System.Drawing.Point(124, 83)
        Me.txtKonfirmPass.Name = "txtKonfirmPass"
        Me.txtKonfirmPass.Size = New System.Drawing.Size(152, 23)
        Me.txtKonfirmPass.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Password"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(55, 137)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 27)
        Me.btnSubmit.TabIndex = 27
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Vela Sans GX SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 26)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Konfirmasi Password"
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(171, 137)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 27)
        Me.btnBatal.TabIndex = 29
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'pnlPass
        '
        Me.pnlPass.BackColor = System.Drawing.Color.Bisque
        Me.pnlPass.Controls.Add(Me.btnBatal)
        Me.pnlPass.Controls.Add(Me.Label8)
        Me.pnlPass.Controls.Add(Me.btnSubmit)
        Me.pnlPass.Controls.Add(Me.Label4)
        Me.pnlPass.Controls.Add(Me.txtKonfirmPass)
        Me.pnlPass.Location = New System.Drawing.Point(229, 733)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(306, 180)
        Me.pnlPass.TabIndex = 36
        '
        'formProfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(781, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlPass)
        Me.Controls.Add(Me.pnlProfil)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.pnlFormUbah)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlSpace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formProfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KPOP Store"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlFormUbah.ResumeLayout(False)
        Me.pnlFormUbah.PerformLayout()
        Me.pnlProfil.ResumeLayout(False)
        Me.pnlProfil.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlPass.ResumeLayout(False)
        Me.pnlPass.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlFormUbah As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUbahForm As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUbahAlamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUbahNoTelp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUbahPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUbahUsn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUbahNama As TextBox
    Friend WithEvents pnlSpace As Panel
    Friend WithEvents btnUbah As Button
    Friend WithEvents pnlProfil As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUsn As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KatalogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuatPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatPesananToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UbahPesananToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtKonfirmPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents pnlPass As Panel
End Class
