﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formProfilTokoC
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SlabelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlabelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlProfil = New System.Windows.Forms.Panel()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlProfil.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(800, 36)
        Me.pnlTop.TabIndex = 51
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnMaximize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControl.Location = New System.Drawing.Point(719, 0)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 53
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
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Cornsilk
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlabelTanggal, Me.SlabelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 52
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SlabelTanggal
        '
        Me.SlabelTanggal.Name = "SlabelTanggal"
        Me.SlabelTanggal.Size = New System.Drawing.Size(61, 17)
        Me.SlabelTanggal.Text = "Tanggal : "
        '
        'SlabelJam
        '
        Me.SlabelJam.Name = "SlabelJam"
        Me.SlabelJam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SlabelJam.Size = New System.Drawing.Size(40, 17)
        Me.SlabelJam.Text = "Jam : "
        '
        'pnlProfil
        '
        Me.pnlProfil.BackColor = System.Drawing.Color.Bisque
        Me.pnlProfil.Controls.Add(Me.txtAlamat)
        Me.pnlProfil.Controls.Add(Me.txtNoTelp)
        Me.pnlProfil.Controls.Add(Me.txtEmail)
        Me.pnlProfil.Controls.Add(Me.txtNama)
        Me.pnlProfil.Controls.Add(Me.Label14)
        Me.pnlProfil.Controls.Add(Me.Label18)
        Me.pnlProfil.Controls.Add(Me.Label20)
        Me.pnlProfil.Controls.Add(Me.Label22)
        Me.pnlProfil.Controls.Add(Me.Label24)
        Me.pnlProfil.Location = New System.Drawing.Point(192, 100)
        Me.pnlProfil.Name = "pnlProfil"
        Me.pnlProfil.Size = New System.Drawing.Size(417, 282)
        Me.pnlProfil.TabIndex = 54
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(171, 188)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(181, 65)
        Me.txtAlamat.TabIndex = 29
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTelp.Location = New System.Drawing.Point(171, 149)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(181, 23)
        Me.txtNoTelp.TabIndex = 28
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(171, 112)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(181, 23)
        Me.txtEmail.TabIndex = 27
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Vela Sans GX", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(171, 73)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(181, 23)
        Me.txtNama.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Vela Sans GX", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(144, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 28)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "PROFIL TOKO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(60, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 17)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Nama"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(60, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 17)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Email"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(60, 151)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 17)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "No Telp"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Vela Sans GX Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(60, 190)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 17)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "Alamat"
        '
        'formProfilTokoC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlProfil)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formProfilTokoC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KPOP Store"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlProfil.ResumeLayout(False)
        Me.pnlProfil.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SlabelTanggal As ToolStripStatusLabel
    Friend WithEvents SlabelJam As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
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
End Class