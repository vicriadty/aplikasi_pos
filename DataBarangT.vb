Imports System.Data.OleDb

Public Class DataBarangT
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select KodeBrg,NamaBrg, Harga from Tabel_Barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tabel_Barang")
        DataGridView1.DataSource = (ds.Tables("Tabel_Barang"))
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub DataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index

        ' Mendapatkan nilai dari sel-sel di baris saat ini
        Dim newRow As New List(Of Object)()

        With Me.DataGridView1.Rows.Item(i)
            ' Menyalin nilai dari sel-sel di baris saat ini ke newRow
            For Each cell As DataGridViewCell In .Cells
                newRow.Add(cell.Value)
                Transaksi.Item.Text = .Cells(1).Value
            Next

        End With

        ' Mengakses form Transaksi
        Dim transaksiForm As New Transaksi()

        ' Menambahkan kolom ke DataGridView di form Transaksi jika belum ada
        If Transaksi.DataGridView1.Columns.Count = 0 Then
            For Each col As DataGridViewColumn In Me.DataGridView1.Columns
                Transaksi.DataGridView1.Columns.Add(col.Clone())
            Next
        End If

        ' Menambahkan baris baru ke DataGridView di form Transaksi
        Transaksi.DataGridView1.Rows.Add(newRow.ToArray())


        'Transaksi.Close()
        Transaksi.Show()
        Me.Close()
        Penerimaan.Terima.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class