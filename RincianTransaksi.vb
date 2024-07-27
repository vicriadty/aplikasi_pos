Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class RincianTransaksi
    Sub TampilFaktur()
        cmd = New OleDbCommand("SELECT * FROM Tabel_Penjualan", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            NoFaktur.Items.Add(rd.GetString(0))
        Loop
    End Sub
    Sub TampilData()
        da = New OleDbDataAdapter("SELECT Nama_Barang,Harga_Jual,Jumlah,Subtotal FROM Tabel_DetailJual 
                                    WHERE Faktur='" & NoFaktur.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "Tabel_DetailJual")
        DataGridView1.DataSource = ds.Tables("Tabel_DetailJual")
        DataGridView1.ReadOnly = True
        cmd = New OleDbCommand("SELECT Tanggal, Item, Total, Dibayar, Kembali, NamaPmk FROM Tabel_Penjualan 
                                INNER JOIN Tabel_Pemakai ON Tabel_Penjualan.KodePmk=Tabel_Pemakai.KodePmk 
                                WHERE Faktur='" & NoFaktur.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
    End Sub
    Private Sub RincianTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilFaktur()
    End Sub

    Private Sub NoFaktur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NoFaktur.SelectedIndexChanged
        Call TampilData()
    End Sub
End Class