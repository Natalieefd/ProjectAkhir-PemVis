Public Class formPesananCust

    Public Shared Mode As String = ""

    Private Sub formPesananCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlabelTanggal.Text = Today
        SlabelJam.Text = TimeOfDay

        Me.Location = New Point(Me.Location.X, Me.Location.Y + 200)

        pnlFormPesanan.Location = New Point(57, 88)
        ToggleData()
        lblPS.Show()

        Select Case Mode
            Case "Ubah"
                btnUbah.Visible = True
                btnClear.Visible = True
                btnBatalkan.Visible = False
            Case "Batal"
                btnUbah.Visible = False
                btnClear.Visible = False
                btnBatalkan.Visible = True
            Case Else
                lblPS.Visible = False
        End Select

    End Sub

    Private Sub dgvPesanan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesanan.CellContentClick
        HideData()
    End Sub

    Private Sub HideData()
        lblHeader.Hide()
        dgvPesanan.Hide()
        lblPS.Hide()

        pnlFormPesanan.Show()
        Me.Size = New Size(820, 530)
    End Sub

    Private Sub ToggleData()
        lblHeader.Show()
        dgvPesanan.Show()
        lblPS.Show()

        pnlFormPesanan.Hide()
        Me.Size = New Size(820, 430)
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formCustomer.Show()
        Me.Close()
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formProfilTokoC.Show()
        Me.Close()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KatalogToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        formKatalog.Show()
        Me.Close()
    End Sub

    Private Sub UbahPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPesananToolStripMenuItem.Click
        Mode = "Ubah"
        Me.Location = New Point(Me.Location.X, Me.Location.Y - 200)
        Me.formPesananCust_Load(sender, e)
    End Sub

    Private Sub LihatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem.Click
        Mode = "Lihat"
        Me.Location = New Point(Me.Location.X, Me.Location.Y - 200)
        Me.formPesananCust_Load(sender, e)
    End Sub

    Private Sub BatalkanPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatalkanPesananToolStripMenuItem.Click
        Mode = "Batal"
        Me.Location = New Point(Me.Location.X, Me.Location.Y - 200)
        Me.formPesananCust_Load(sender, e)
    End Sub

    Private Sub BuatPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatPesananToolStripMenuItem.Click
        formKatalog.Show()
        Me.Close()
    End Sub

    Private Sub LihatProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LihatPesananToolStripMenuItem1.Click
        Me.ActiveControl = MenuStrip1
        formProfil.Show()
        Me.Hide()
    End Sub

    Private Sub UbahProfilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UbahProfilToolStripMenuItem1.Click
        Me.ActiveControl = MenuStrip1
        formProfil.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ActiveControl = MenuStrip1
        Home.Show()
        Me.Close()
    End Sub

    Private Sub formPesananCust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(sender, MenuStrip1)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNama.Clear()
        txtJumlah.Clear()
        txtHargaTotal.Clear()
        txtAlamat.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ToggleData()
    End Sub

    Private Sub lblPS_Click(sender As Object, e As EventArgs) Handles lblPS.Click 'Hapus Nanti
        HideData()
    End Sub
End Class