Public Class MenuUtama
    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Pelanggan.Show()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Barang.Show()
    End Sub

    Private Sub PemasokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemasokToolStripMenuItem.Click
        Pemasok.Show()
    End Sub

    Private Sub PemakaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemakaiToolStripMenuItem.Click
        Pemakai.Show()
    End Sub

    Private Sub PenerimaanBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanBarangToolStripMenuItem.Click
        Penerimaan.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Transaksi.Show()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles Status1.Click

    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RincianTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RincianTransaksiToolStripMenuItem.Click
        RincianStock.Show()
    End Sub

    Private Sub RincianTransaksiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RincianTransaksiToolStripMenuItem1.Click
        RincianTransaksi.Show()
    End Sub
End Class