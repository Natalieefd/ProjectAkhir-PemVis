<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManajemenTokoAdmin
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
        Me.pnlProfil = New System.Windows.Forms.Panel()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUbahForm = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUbahAlamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUbahNoTelp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKonfirmPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFormUbah = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUbahPass = New System.Windows.Forms.TextBox()
        Me.txtUbahUsn = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtUbahEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUbahNama = New System.Windows.Forms.TextBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAkunStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatDataProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahDataProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahDataProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusDataProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlProfil.SuspendLayout()
        Me.pnlPass.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlFormUbah.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlProfil
        '
        Me.pnlProfil.BackColor = System.Drawing.Color.MediumTurquoise
        Me.pnlProfil.Controls.Add(Me.txtAlamat)
        Me.pnlProfil.Controls.Add(Me.txtNoTelp)
        Me.pnlProfil.Controls.Add(Me.txtEmail)
        Me.pnlProfil.Controls.Add(Me.txtNama)
        Me.pnlProfil.Controls.Add(Me.btnUbah)
        Me.pnlProfil.Controls.Add(Me.Label14)
        Me.pnlProfil.Controls.Add(Me.Label18)
        Me.pnlProfil.Controls.Add(Me.Label20)
        Me.pnlProfil.Controls.Add(Me.Label22)
        Me.pnlProfil.Controls.Add(Me.Label24)
        Me.pnlProfil.Location = New System.Drawing.Point(418, 140)
        Me.pnlProfil.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlProfil.Name = "pnlProfil"
        Me.pnlProfil.Size = New System.Drawing.Size(834, 671)
        Me.pnlProfil.TabIndex = 4
        '
        'txtAlamat
        '
        Me.txtAlamat.Enabled = False
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(282, 363)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(458, 121)
        Me.txtAlamat.TabIndex = 9
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Enabled = False
        Me.txtNoTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTelp.Location = New System.Drawing.Point(282, 281)
        Me.txtNoTelp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(458, 32)
        Me.txtNoTelp.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(282, 217)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(458, 32)
        Me.txtEmail.TabIndex = 7
        '
        'txtNama
        '
        Me.txtNama.Enabled = False
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(282, 142)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(458, 32)
        Me.txtNama.TabIndex = 6
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_sync_50
        Me.btnUbah.Location = New System.Drawing.Point(352, 525)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(150, 123)
        Me.btnUbah.TabIndex = 10
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(272, 35)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(314, 48)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "PROFIL TOKO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(116, 144)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 29)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Nama"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(116, 219)
        Me.Label20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 29)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Email"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(116, 290)
        Me.Label22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 29)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "No Telp"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(116, 365)
        Me.Label24.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(92, 29)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 48)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "UBAH PROFIL TOKO"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_trash_50
        Me.btnClear.Location = New System.Drawing.Point(734, 519)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 140)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUbahForm
        '
        Me.btnUbahForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbahForm.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_sync_50
        Me.btnUbahForm.Location = New System.Drawing.Point(540, 519)
        Me.btnUbahForm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUbahForm.Name = "btnUbahForm"
        Me.btnUbahForm.Size = New System.Drawing.Size(150, 140)
        Me.btnUbahForm.TabIndex = 22
        Me.btnUbahForm.Text = "Ubah"
        Me.btnUbahForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUbahForm.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(748, 335)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 29)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Alamat"
        '
        'txtUbahAlamat
        '
        Me.txtUbahAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahAlamat.Location = New System.Drawing.Point(896, 331)
        Me.txtUbahAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbahAlamat.Multiline = True
        Me.txtUbahAlamat.Name = "txtUbahAlamat"
        Me.txtUbahAlamat.Size = New System.Drawing.Size(300, 146)
        Me.txtUbahAlamat.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(90, 385)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 29)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "No Telp"
        '
        'txtUbahNoTelp
        '
        Me.txtUbahNoTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahNoTelp.Location = New System.Drawing.Point(230, 381)
        Me.txtUbahNoTelp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbahNoTelp.Name = "txtUbahNoTelp"
        Me.txtUbahNoTelp.Size = New System.Drawing.Size(300, 32)
        Me.txtUbahNoTelp.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(90, 285)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 29)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Email"
        '
        'pnlPass
        '
        Me.pnlPass.BackColor = System.Drawing.Color.DarkCyan
        Me.pnlPass.Controls.Add(Me.Label8)
        Me.pnlPass.Controls.Add(Me.btnSubmit)
        Me.pnlPass.Controls.Add(Me.Label4)
        Me.pnlPass.Controls.Add(Me.txtKonfirmPass)
        Me.pnlPass.Location = New System.Drawing.Point(540, 1588)
        Me.pnlPass.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(612, 385)
        Me.pnlPass.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(86, 40)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(396, 44)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Konfirmasi Password"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_send_50
        Me.btnSubmit.Location = New System.Drawing.Point(232, 227)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 140)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Password"
        '
        'txtKonfirmPass
        '
        Me.txtKonfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKonfirmPass.Location = New System.Drawing.Point(226, 131)
        Me.txtKonfirmPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKonfirmPass.Name = "txtKonfirmPass"
        Me.txtKonfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKonfirmPass.Size = New System.Drawing.Size(300, 32)
        Me.txtKonfirmPass.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(90, 388)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 29)
        Me.Label5.TabIndex = 8
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.SandyBrown
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1973)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1672, 39)
        Me.StatusStrip1.TabIndex = 25
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
        Me.pnlFormUbah.Controls.Add(Me.Label3)
        Me.pnlFormUbah.Controls.Add(Me.Label11)
        Me.pnlFormUbah.Controls.Add(Me.txtUbahPass)
        Me.pnlFormUbah.Controls.Add(Me.txtUbahUsn)
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
        Me.pnlFormUbah.Controls.Add(Me.txtUbahEmail)
        Me.pnlFormUbah.Controls.Add(Me.Label2)
        Me.pnlFormUbah.Controls.Add(Me.txtUbahNama)
        Me.pnlFormUbah.Location = New System.Drawing.Point(130, 840)
        Me.pnlFormUbah.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFormUbah.Name = "pnlFormUbah"
        Me.pnlFormUbah.Size = New System.Drawing.Size(1372, 719)
        Me.pnlFormUbah.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(700, 244)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 29)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(700, 154)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 29)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Username"
        '
        'txtUbahPass
        '
        Me.txtUbahPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahPass.Location = New System.Drawing.Point(896, 235)
        Me.txtUbahPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbahPass.Name = "txtUbahPass"
        Me.txtUbahPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUbahPass.Size = New System.Drawing.Size(300, 32)
        Me.txtUbahPass.TabIndex = 61
        '
        'txtUbahUsn
        '
        Me.txtUbahUsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahUsn.Location = New System.Drawing.Point(896, 150)
        Me.txtUbahUsn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbahUsn.Name = "txtUbahUsn"
        Me.txtUbahUsn.Size = New System.Drawing.Size(300, 32)
        Me.txtUbahUsn.TabIndex = 60
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.icons8_close_window_50
        Me.btnCancel.Location = New System.Drawing.Point(1274, 33)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 65)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtUbahEmail
        '
        Me.txtUbahEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahEmail.Location = New System.Drawing.Point(230, 281)
        Me.txtUbahEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbahEmail.Name = "txtUbahEmail"
        Me.txtUbahEmail.Size = New System.Drawing.Size(300, 32)
        Me.txtUbahEmail.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 29)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nama"
        '
        'txtUbahNama
        '
        Me.txtUbahNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbahNama.Location = New System.Drawing.Point(230, 187)
        Me.txtUbahNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbahNama.Name = "txtUbahNama"
        Me.txtUbahNama.Size = New System.Drawing.Size(300, 32)
        Me.txtUbahNama.TabIndex = 18
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1672, 69)
        Me.pnlTop.TabIndex = 58
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(1564, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(28, 29)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.ProjectAkhir_Kelompok4.My.Resources.Resources.close15px
        Me.btnClose.Location = New System.Drawing.Point(64, 19)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 29)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SandyBrown
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ProfilTokoToolStripMenuItem, Me.ManajemenStaffToolStripMenuItem, Me.ManajemenBarangToolStripMenuItem, Me.PesananToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 69)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1672, 41)
        Me.MenuStrip1.TabIndex = 3
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
        'ManajemenStaffToolStripMenuItem
        '
        Me.ManajemenStaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatAkunStaffToolStripMenuItem, Me.TambahAkunStaffToolStripMenuItem, Me.UbahAkunStaffToolStripMenuItem, Me.DeleteAkunStaffToolStripMenuItem})
        Me.ManajemenStaffToolStripMenuItem.Name = "ManajemenStaffToolStripMenuItem"
        Me.ManajemenStaffToolStripMenuItem.Size = New System.Drawing.Size(212, 33)
        Me.ManajemenStaffToolStripMenuItem.Text = "Manajemen Staff"
        '
        'LihatAkunStaffToolStripMenuItem
        '
        Me.LihatAkunStaffToolStripMenuItem.Name = "LihatAkunStaffToolStripMenuItem"
        Me.LihatAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(346, 44)
        Me.LihatAkunStaffToolStripMenuItem.Text = "Lihat Akun Staff"
        '
        'TambahAkunStaffToolStripMenuItem
        '
        Me.TambahAkunStaffToolStripMenuItem.Name = "TambahAkunStaffToolStripMenuItem"
        Me.TambahAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(346, 44)
        Me.TambahAkunStaffToolStripMenuItem.Text = "Tambah Akun Staff"
        '
        'UbahAkunStaffToolStripMenuItem
        '
        Me.UbahAkunStaffToolStripMenuItem.Name = "UbahAkunStaffToolStripMenuItem"
        Me.UbahAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(346, 44)
        Me.UbahAkunStaffToolStripMenuItem.Text = "Ubah Akun Staff"
        '
        'DeleteAkunStaffToolStripMenuItem
        '
        Me.DeleteAkunStaffToolStripMenuItem.Name = "DeleteAkunStaffToolStripMenuItem"
        Me.DeleteAkunStaffToolStripMenuItem.Size = New System.Drawing.Size(346, 44)
        Me.DeleteAkunStaffToolStripMenuItem.Text = "Hapus Akun Staff"
        '
        'ManajemenBarangToolStripMenuItem
        '
        Me.ManajemenBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatDataProdukToolStripMenuItem, Me.TambahDataProdukToolStripMenuItem, Me.UbahDataProdukToolStripMenuItem, Me.HapusDataProdukToolStripMenuItem})
        Me.ManajemenBarangToolStripMenuItem.Name = "ManajemenBarangToolStripMenuItem"
        Me.ManajemenBarangToolStripMenuItem.Size = New System.Drawing.Size(242, 33)
        Me.ManajemenBarangToolStripMenuItem.Text = "Manajemen Produk"
        '
        'LihatDataProdukToolStripMenuItem
        '
        Me.LihatDataProdukToolStripMenuItem.Name = "LihatDataProdukToolStripMenuItem"
        Me.LihatDataProdukToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.LihatDataProdukToolStripMenuItem.Text = "Lihat Data Produk"
        '
        'TambahDataProdukToolStripMenuItem
        '
        Me.TambahDataProdukToolStripMenuItem.Name = "TambahDataProdukToolStripMenuItem"
        Me.TambahDataProdukToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.TambahDataProdukToolStripMenuItem.Text = "Tambah Data Produk"
        '
        'UbahDataProdukToolStripMenuItem
        '
        Me.UbahDataProdukToolStripMenuItem.Name = "UbahDataProdukToolStripMenuItem"
        Me.UbahDataProdukToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.UbahDataProdukToolStripMenuItem.Text = "Ubah Data Produk"
        '
        'HapusDataProdukToolStripMenuItem
        '
        Me.HapusDataProdukToolStripMenuItem.Name = "HapusDataProdukToolStripMenuItem"
        Me.HapusDataProdukToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.HapusDataProdukToolStripMenuItem.Text = "Hapus Data Produk"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(127, 33)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(72, 33)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManajemenTokoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(1706, 865)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlProfil)
        Me.Controls.Add(Me.pnlPass)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlFormUbah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManajemenTokoAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KPOP Store"
        Me.pnlProfil.ResumeLayout(False)
        Me.pnlProfil.PerformLayout()
        Me.pnlPass.ResumeLayout(False)
        Me.pnlPass.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlFormUbah.ResumeLayout(False)
        Me.pnlFormUbah.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlProfil As Panel
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUbahForm As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUbahAlamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUbahNoTelp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlPass As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKonfirmPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlFormUbah As Panel
    Friend WithEvents txtUbahEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUbahNama As TextBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAkunStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManajemenBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatDataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahDataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahDataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusDataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUbahPass As TextBox
    Friend WithEvents txtUbahUsn As TextBox
End Class
