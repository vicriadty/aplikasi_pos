Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Transaksi
    Sub BersihkanText()
        Total.Text = ""
        Dibayar.Text = ""
        Kembali.Text = ""
        Item.Text = ""
    End Sub

    Sub BuatKolomBaru()

        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama_Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Total", "SubTotal")
        Call AturLebarKolom()
    End Sub

    Sub AturLebarKolom()
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 175
        DataGridView1.Columns(2).Width = 75
        DataGridView1.Columns(3).Width = 75
        DataGridView1.Columns(4).Width = 100
    End Sub

    Sub FakturOtomatis()
        cmd = New OleDbCommand("Select * from Tabel_Penjualan where faktur in (select max (Faktur) from Tabel_Penjualan) order by Faktur desc", conn)
        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <>
            Format(Now, "yyMMdd") Then
                urutan = Format(Now, "yyMMdd") + "0001"
            Else
                hitung = rd.GetString(0) + 1
                urutan = Format(Now, "yyMMdd") +
                Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
        End If
        Faktur.Text = urutan
    End Sub
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call BuatKolomBaru()
        Call TampilPelanggan()
    End Sub
    Sub TampilPelanggan()
        cmd = New OleDbCommand("select * from Tabel_Pelanggan", conn)
        rd = cmd.ExecuteReader
        Kode.Items.Clear()
        Do While rd.Read
            Kode.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub Transaksi_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Call FakturOtomatis()
        Tanggal.Text = Today
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Jam.Text = TimeOfDay
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 0 Then
            cmd = New OleDbCommand("select * from Tabel_Barang where KodeBrg='" &
            DataGridView1.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = rd.Item(1)
                DataGridView1.Rows(e.RowIndex).Cells(2).Value = rd.Item(5)
                DataGridView1.Rows(e.RowIndex).Cells(3).Value = 1
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = DataGridView1.Rows(e.RowIndex).Cells(2).Value * DataGridView1.Rows(e.RowIndex).Cells(3).Value

                Call TotalItem()
                Call TotalHarga()

            Else
                MsgBox("Kode Tabel_Barang tidak terdaftar")
            End If
        End If

        If e.ColumnIndex = 3 Then

            cmd = New OleDbCommand("select * from Tabel_Barang where KodeBrg='" &
            DataGridView1.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If DataGridView1.Rows(e.RowIndex).Cells(3).Value > rd.Item(4) Then
                    MsgBox("Stok barang hanya ada " & rd.Item(4) & "")
                    DataGridView1.Rows(e.RowIndex).Cells(3).Value = 1
                    DataGridView1.Rows(e.RowIndex).Cells(4).Value =
                    DataGridView1.Rows(e.RowIndex).Cells(2).Value * DataGridView1.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                Else
                    DataGridView1.Rows(e.RowIndex).Cells(4).Value =
                    DataGridView1.Rows(e.RowIndex).Cells(2).Value * DataGridView1.Rows(e.RowIndex).Cells(3).Value
                    Call TotalItem()
                    Call TotalHarga()
                End If
            End If
            DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        End If
    End Sub
    Sub kena(ByVal myGrid As DataGrid)
        myGrid.CurrentCell = New DataGridCell(1, 1)
    End Sub

    Sub TotalItem()
        Dim HitungItem As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + Val(DataGridView1.Rows(I).Cells(3).Value)
            Item.Text = HitungItem
        Next

    End Sub

    Sub TotalHarga()
        Dim HitungHarga As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungHarga = HitungHarga + Val(DataGridView1.Rows(I).Cells(4).Value)
            Total.Text = HitungHarga
        Next

    End Sub

    Sub HapusBaris()
        On Error Resume Next
        Dim baris As Integer = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows(baris).Cells(0).Value = ""
        Chr(30)
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Up Then
            DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(3)
        End If
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        On Error Resume Next

        If e.KeyChar = Chr(27) Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            Call TotalItem()
            Call TotalHarga()
            Dibayar.Clear()
            Kembali.Text = ""

        End If
    End Sub

    Private Sub Dibayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Dibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(Dibayar.Text) < Val(Total.Text) Then
                MsgBox("Pembayaran kurang")
                Kembali.Text = ""
                Dibayar.Focus()
                Exit Sub
            ElseIf Val(Dibayar.Text) = Val(Total.Text) Then
                Kembali.Text = 0
                Simpan.Focus()
            Else
                Kembali.Text = Val(Dibayar.Text) - Val(Total.Text)
                Simpan.Focus()
            End If
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        If Total.Text = "" Or Dibayar.Text = "" Or Kembali.Text = "" Or
            Item.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau pembayaran
            masih kosong")
            Exit Sub
        End If
        'simpan ke tabel Table_Penjualan
        Dim simpanmaster As String = "Insert into Tabel_Penjualan (Faktur, Tanggal, Item, Total, Dibayar, Kembali, KodePmk, KodePlg) values " &
        "('" & Faktur.Text & "','" & Tanggal.Text & "','" & Item.Text &
        "','" & Total.Text & "','" & Dibayar.Text & "','" & Kembali.Text & "','" &
        MenuUtama.Status1.Text & "','" & Kode.Text & "')"

        cmd = New OleDbCommand(simpanmaster, conn)
        cmd.ExecuteNonQuery()

        For baris As Integer = 0 To DataGridView1.Rows.Count - 2

            'simpan ke tabel detail

            Dim sglsimpan As String = "Insert into Tabel_DetailJual (Faktur, KodeBrg, Nama_Barang, Harga_Jual, Jumlah, Subtotal) values " &
                "('" & Faktur.Text & "','" & DataGridView1.Rows(baris).Cells(0).Value &
                "','" & DataGridView1.Rows(baris).Cells(1).Value & "','" & DataGridView1.Rows(baris).Cells(2).Value &
                "','" & DataGridView1.Rows(baris).Cells(3).Value & "', '" & DataGridView1.Rows(baris).Cells(4).Value & "')"

            cmd = New OleDbCommand(sglsimpan, conn)

            cmd.ExecuteNonQuery()

            MsgBox("Transaksi berhasil disimpan !")

            'kurangi stok Tabel_Barang

            cmd = New OleDbCommand("select * from Tabel_Barang where KodeBrg='" &
            DataGridView1.Rows(baris).Cells(0).Value & "'", conn)

            rd = cmd.ExecuteReader

            rd.Read()

            If rd.HasRows Then
                Dim kurangistok As String = "update Tabel_Barang set JumlahBrg= '" &
                    rd.Item(3) - DataGridView1.Rows(baris).Cells(3).Value & "' where KodeBrg='" &
                    DataGridView1.Rows(baris).Cells(0).Value & "'"
                cmd = New OleDbCommand(kurangistok, conn)
                cmd.ExecuteNonQuery()
            End If

        Next baris
        DataGridView1.Columns.Clear()
        Call BuatKolomBaru()
        Call FakturOtomatis()
        Call BersihkanText()
    End Sub

    Private Sub Batal_Click(sender As Object, e As EventArgs) Handles Batal.Click
        Call BersihkanText()
        DataGridView1.Columns.Clear()
        Call BuatKolomBaru()
        DataGridView1.Focus()
    End Sub

    Private Sub Tutup_Click(sender As Object, e As EventArgs) Handles Tutup.Click
        Me.Close()
    End Sub

    Private Sub DaftarBarang_Click(sender As Object, e As EventArgs) Handles DaftarBarang.Click
        DataBarangT.ShowDialog()
    End Sub

    Private Sub Kode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Kode.SelectedIndexChanged
        cmd = New OleDbCommand("select * from Tabel_Pelanggan where KodePlg='" &
                               Kode.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Nama.Text = rd.Item(1)
            Alamat.Text = rd.Item(2)
            Telepon.Text = rd.Item(3)
            JK.Text = rd.Item(4)
            Email.Text = rd.Item(5)
        Else
            MsgBox("Kode Pelanggan tidak terdaftar")
        End If
    End Sub

    Private Sub DaftarPelanggan_Click(sender As Object, e As EventArgs) Handles DaftarPelanggan.Click
        DataPelanggan.ShowDialog()
    End Sub
End Class