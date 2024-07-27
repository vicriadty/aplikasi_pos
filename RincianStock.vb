Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class RincianStock
    Sub AturKolom()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 60
        DataGridView1.Columns(3).Width = 60
        DataGridView1.Columns(4).Width = 60
    End Sub

    Sub HitungTotal()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            subtot += Val(DataGridView1.Rows(I).Cells(3).Value)
            TotalBarang.Text = subtot
        Next
    End Sub
    Private Sub RincianStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
    End Sub

    Private Sub RincianStock_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Tanggal.Text = Today
    End Sub

    Private Sub CekStok_Click(sender As Object, e As EventArgs) Handles CekStok.Click
        da = New OleDbDataAdapter("SELECT * FROM Tabel_Barang WHERE JumlahBrg <= Stokminimal", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tabel_Barang")
        DataGridView1.DataSource = ds.Tables("Tabel_Barang")
        Call AturKolom()
        Call HitungTotal()
    End Sub

    Private Sub Batal_Click(sender As Object, e As EventArgs) Handles Batal.Click
        If TotalBarang.Text = "" Then
            MsgBox("Klik dulu tombol Cek stok Minimum")

        Else
            DataGridView1.DataSource = ds.Tables("Tabel_Barang")
            TotalBarang.Text = ""

        End If
    End Sub

    Private Sub Tutup_Click(sender As Object, e As EventArgs) Handles Tutup.Click
        Me.Close()
    End Sub
End Class