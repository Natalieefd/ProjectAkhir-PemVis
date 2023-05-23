<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formProfil
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFormUbah = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
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
        Me.pnlProfil = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KatalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatalkanPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatProfilToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahProfilToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtKonfirmPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlFormUbah.SuspendLayout()
        Me.pnlProfil.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1966)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1772, 39)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SlabelTanggal
        '
        Me.SlabelTanggal.Name = "SlabelTanggal"
        Me.SlabelTanggal.Size = New System.Drawing.Size(120, 29)
        Me.SlabelTanggal.Text = "Tanggal : "
        '
        'SlabelJam
        '
        Me.SlabelJam.Name = "SlabelJam"
        Me.SlabelJam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SlabelJam.Size = New System.Drawing.Size(76, 29)
        Me.SlabelJam.Text = "Jam : "
        '
        'pnlFormUbah
        '
        Me.pnlFormUbah.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlFormUbah.Controls.Add(Me.btnCancel)
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
        Me.pnlFormUbah.Location = New System.Drawing.Point(80, 889)
        Me.pnlFormUbah.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlFormUbah.Name = "pnlFormUbah"
        Me.pnlFormUbah.Size = New System.Drawing.Size(1372, 628)
        Me.pnlFormUbah.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_close_window_50
        Me.btnCancel.Location = New System.Drawing.Point(1280, 28)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 59)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(542, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 48)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "UBAH PROFIL"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_broom_50
        Me.btnClear.Location = New System.Drawing.Point(760, 467)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 134)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUbahForm
        '
        Me.btnUbahForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbahForm.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_sync_50
        Me.btnUbahForm.Location = New System.Drawing.Point(470, 467)
        Me.btnUbahForm.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnUbahForm.Name = "btnUbahForm"
        Me.btnUbahForm.Size = New System.Drawing.Size(150, 134)
        Me.btnUbahForm.TabIndex = 16
        Me.btnUbahForm.Text = "Ubah"
        Me.btnUbahForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUbahForm.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(790, 266)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 29)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Alamat"
        '
        'txtUbahAlamat
        '
        Me.txtUbahAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahAlamat.Location = New System.Drawing.Point(970, 258)
        Me.txtUbahAlamat.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUbahAlamat.MaxLength = 50
        Me.txtUbahAlamat.Multiline = True
        Me.txtUbahAlamat.Name = "txtUbahAlamat"
        Me.txtUbahAlamat.Size = New System.Drawing.Size(300, 146)
        Me.txtUbahAlamat.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(790, 169)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 29)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "No Telp"
        '
        'txtUbahNoTelp
        '
        Me.txtUbahNoTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahNoTelp.Location = New System.Drawing.Point(970, 164)
        Me.txtUbahNoTelp.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUbahNoTelp.MaxLength = 15
        Me.txtUbahNoTelp.Name = "txtUbahNoTelp"
        Me.txtUbahNoTelp.Size = New System.Drawing.Size(300, 32)
        Me.txtUbahNoTelp.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(94, 369)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(98, 347)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 29)
        Me.Label5.TabIndex = 8
        '
        'txtUbahPass
        '
        Me.txtUbahPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahPass.Location = New System.Drawing.Point(274, 364)
        Me.txtUbahPass.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUbahPass.MaxLength = 50
        Me.txtUbahPass.Name = "txtUbahPass"
        Me.txtUbahPass.Size = New System.Drawing.Size(300, 32)
        Me.txtUbahPass.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 267)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Username"
        '
        'txtUbahUsn
        '
        Me.txtUbahUsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahUsn.Location = New System.Drawing.Point(274, 261)
        Me.txtUbahUsn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUbahUsn.MaxLength = 50
        Me.txtUbahUsn.Name = "txtUbahUsn"
        Me.txtUbahUsn.Size = New System.Drawing.Size(300, 32)
        Me.txtUbahUsn.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama"
        '
        'txtUbahNama
        '
        Me.txtUbahNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahNama.Location = New System.Drawing.Point(274, 164)
        Me.txtUbahNama.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUbahNama.MaxLength = 50
        Me.txtUbahNama.Name = "txtUbahNama"
        Me.txtUbahNama.Size = New System.Drawing.Size(300, 32)
        Me.txtUbahNama.TabIndex = 11
        '
        'pnlProfil
        '
        Me.pnlProfil.BackColor = System.Drawing.Color.CadetBlue
        Me.pnlProfil.Controls.Add(Me.PictureBox1)
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
        Me.pnlProfil.Location = New System.Drawing.Point(342, 152)
        Me.pnlProfil.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlProfil.Name = "pnlProfil"
        Me.pnlProfil.Size = New System.Drawing.Size(834, 684)
        Me.pnlProfil.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_customer_100
        Me.PictureBox1.Location = New System.Drawing.Point(356, 97)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'txtAlamat
        '
        Me.txtAlamat.Enabled = False
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(356, 541)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(358, 121)
        Me.txtAlamat.TabIndex = 2
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Enabled = False
        Me.txtNoTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTelp.Location = New System.Drawing.Point(356, 466)
        Me.txtNoTelp.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(358, 32)
        Me.txtNoTelp.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Enabled = False
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(356, 394)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(358, 32)
        Me.txtPass.TabIndex = 2
        '
        'txtUsn
        '
        Me.txtUsn.Enabled = False
        Me.txtUsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsn.Location = New System.Drawing.Point(356, 325)
        Me.txtUsn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUsn.Name = "txtUsn"
        Me.txtUsn.Size = New System.Drawing.Size(358, 32)
        Me.txtUsn.TabIndex = 2
        '
        'txtNama
        '
        Me.txtNama.Enabled = False
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(356, 258)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(358, 32)
        Me.txtNama.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(346, 25)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(178, 48)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "PROFIL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(134, 328)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 29)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Username"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(134, 261)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 29)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Nama"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(134, 398)
        Me.Label20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 29)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Password"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(134, 469)
        Me.Label22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 29)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "No Telp"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(134, 544)
        Me.Label24.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(92, 29)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Alamat"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1772, 69)
        Me.pnlTop.TabIndex = 50
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(1664, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(108, 69)
        Me.pnlControl.TabIndex = 49
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.maximize15px
        Me.btnMinimize.Location = New System.Drawing.Point(4, 19)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(28, 28)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.close15px
        Me.btnClose.Location = New System.Drawing.Point(64, 19)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 28)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfilTokoToolStripMenuItem, Me.KatalogToolStripMenuItem, Me.PesananToolStripMenuItem, Me.ProfilToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 69)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1772, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(98, 33)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ProfilTokoToolStripMenuItem
        '
        Me.ProfilTokoToolStripMenuItem.Name = "ProfilTokoToolStripMenuItem"
        Me.ProfilTokoToolStripMenuItem.Size = New System.Drawing.Size(151, 33)
        Me.ProfilTokoToolStripMenuItem.Text = "Profil Toko"
        '
        'KatalogToolStripMenuItem
        '
        Me.KatalogToolStripMenuItem.Name = "KatalogToolStripMenuItem"
        Me.KatalogToolStripMenuItem.Size = New System.Drawing.Size(115, 33)
        Me.KatalogToolStripMenuItem.Text = "Katalog"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatPesananToolStripMenuItem, Me.UbahPesananToolStripMenuItem, Me.BatalkanPesananToolStripMenuItem})
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(127, 33)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'LihatPesananToolStripMenuItem
        '
        Me.LihatPesananToolStripMenuItem.Name = "LihatPesananToolStripMenuItem"
        Me.LihatPesananToolStripMenuItem.Size = New System.Drawing.Size(337, 44)
        Me.LihatPesananToolStripMenuItem.Text = "Lihat Pesanan"
        '
        'UbahPesananToolStripMenuItem
        '
        Me.UbahPesananToolStripMenuItem.Name = "UbahPesananToolStripMenuItem"
        Me.UbahPesananToolStripMenuItem.Size = New System.Drawing.Size(337, 44)
        Me.UbahPesananToolStripMenuItem.Text = "Ubah Pesanan"
        '
        'BatalkanPesananToolStripMenuItem
        '
        Me.BatalkanPesananToolStripMenuItem.Name = "BatalkanPesananToolStripMenuItem"
        Me.BatalkanPesananToolStripMenuItem.Size = New System.Drawing.Size(337, 44)
        Me.BatalkanPesananToolStripMenuItem.Text = "Batalkan Pesanan"
        '
        'ProfilToolStripMenuItem
        '
        Me.ProfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatProfilToolStripMenuItem1, Me.UbahProfilToolStripMenuItem1})
        Me.ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        Me.ProfilToolStripMenuItem.Size = New System.Drawing.Size(89, 33)
        Me.ProfilToolStripMenuItem.Text = "Profil"
        '
        'LihatProfilToolStripMenuItem1
        '
        Me.LihatProfilToolStripMenuItem1.Name = "LihatProfilToolStripMenuItem1"
        Me.LihatProfilToolStripMenuItem1.Size = New System.Drawing.Size(264, 44)
        Me.LihatProfilToolStripMenuItem1.Text = "Lihat Profil"
        '
        'UbahProfilToolStripMenuItem1
        '
        Me.UbahProfilToolStripMenuItem1.Name = "UbahProfilToolStripMenuItem1"
        Me.UbahProfilToolStripMenuItem1.Size = New System.Drawing.Size(264, 44)
        Me.UbahProfilToolStripMenuItem1.Text = "Ubah Profil"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(72, 33)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'txtKonfirmPass
        '
        Me.txtKonfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKonfirmPass.Location = New System.Drawing.Point(248, 159)
        Me.txtKonfirmPass.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtKonfirmPass.Name = "txtKonfirmPass"
        Me.txtKonfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKonfirmPass.Size = New System.Drawing.Size(300, 32)
        Me.txtKonfirmPass.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(108, 36)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(396, 44)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Konfirmasi Password"
        '
        'pnlPass
        '
        Me.pnlPass.BackColor = System.Drawing.Color.DarkCyan
        Me.pnlPass.Controls.Add(Me.Label8)
        Me.pnlPass.Controls.Add(Me.btnSubmit)
        Me.pnlPass.Controls.Add(Me.Label4)
        Me.pnlPass.Controls.Add(Me.txtKonfirmPass)
        Me.pnlPass.Location = New System.Drawing.Point(468, 1550)
        Me.pnlPass.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(612, 416)
        Me.pnlPass.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_send_50
        Me.btnSubmit.Location = New System.Drawing.Point(248, 264)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 127)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'formProfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1806, 1016)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlPass)
        Me.Controls.Add(Me.pnlProfil)
        Me.Controls.Add(Me.pnlFormUbah)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnlProfil As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtUsn As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KatalogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BatalkanPesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatProfilToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UbahProfilToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtKonfirmPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlPass As Panel
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
