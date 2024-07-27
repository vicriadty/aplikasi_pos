Imports System.Data.OleDb

Public Class DataPelanggan
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Tabel_Pelanggan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tabel_Pelanggan")
        DataGridView1.DataSource = (ds.Tables("Tabel_Pelanggan"))
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub DataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)

            Transaksi.Kode.Text = .Cells(0).Value
            Transaksi.Nama.Text = .Cells(1).Value
            Transaksi.Alamat.Text = .Cells(2).Value
            Transaksi.Telepon.Text = .Cells(3).Value

            Transaksi.JK.Text = .Cells(4).Value
            Transaksi.Email.Text = .Cells(5).Value
        End With
        Transaksi.Show()
        Me.Close()
    End Sub
End Class