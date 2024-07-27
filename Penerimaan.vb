Imports System.Data.OleDb
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Public Class Penerimaan
    Sub Kosongkan()
        KodePms.Text = ""
        NamaPms.Text = ""
        PersonPms.Text = ""
        Stok.Text = ""
        Terima.Text = ""
        Kode.Focus()

    End Sub

    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Tabel_TMPTerima", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tabel_TMPTerima")
        DataGridView1.DataSource = (ds.Tables("Tabel_TMPTerima"))
        DataGridView1.ReadOnly = True
        'Call AturKolom()
    End Sub


    Sub HapusGrid()
        da = New OleDbDataAdapter("Delete * from Tabel_TMPTerima", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tabel_TMPTerima")
        DataGridView1.DataSource = (ds.Tables("Tabel_TMPTerima"))
        'DataGridView1.ReadOnly = True

    End Sub

    Sub CariTotalTerima()

        On Error Resume Next
        cmd = New OleDbCommand("select sum (Diterima) as ketemu from Tabel_TMPTerima", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TotalTerima.Text = rd.GetValue(0)
        Else
            TotalTerima.Text = 0
        End If
    End Sub

    Private Sub Otomatis()
        cmd = New OleDbCommand("Select * from Table_Penerimaan_Barang", conn)
        Dim randomstring As String = GenerateRandomString(1)

        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        urutan = "TR" + Format(Now, "yyMMdd") + randomstring
        NoFaktur.Text = urutan
    End Sub

    Sub TampilTabel_Pemasok()
        cmd = New OleDbCommand("select * from Tabel_Pemasok", conn)
        rd = cmd.ExecuteReader
        KodePms.Items.Clear()
        Do While rd.Read
            KodePms.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub HapusMaster()
        KodePms.Text = ""
        'LBLPerson.Text = ""
        'LBLNama.Text = ""
        NoReff.Text = ""
        TotalTerima.Text = ""
        KodePms.Focus()
    End Sub

    Private Sub Penerimaan_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Koneksi()
        Call Otomatis()
        Tanggal.Text = Today
        SimpanFaktur.Text = NoFaktur.Text
    End Sub

    Private Sub Penerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call HapusGrid()
        Call Tampilkan()
        Call TampilTabel_Pemasok()

    End Sub
    Function GenerateRandomString(length As Integer) As String
        ' Karakter yang mungkin dalam random string
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"

        ' Inisialisasi objek Random
        Dim rand As New Random()

        ' StringBuilder untuk menggabungkan karakter
        Dim builder As New StringBuilder()

        ' Generate random string
        For i As Integer = 1 To length
            Dim index As Integer = rand.Next(0, chars.Length)
            builder.Append(chars(index))
        Next

        ' Kembalikan random string yang dihasilkan
        Return builder.ToString()
    End Function
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 3 Then
            DataGridView1.Rows(e.RowIndex).Cells(3).Value =
            DataGridView1.Rows(e.RowIndex).Cells(2).Value * DataGridView1.Rows(e.RowIndex).Cells(3).Value
            Call CariTotalTerima()
            Call Kosongkan()
        End If
    End Sub
    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        If e.ColumnIndex = 0 Then
            cmd = New OleDbCommand("Select * from Tabel_Barang where KodeBrg='" & e.FormattedValue.ToString & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                DataGridView1.Rows(e.RowIndex).Cells(0).Value = rd.GetValue(0)
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = rd.GetString(1)
                DataGridView1.Rows(e.RowIndex).Cells(2).Value = rd.GetValue(2)
                Exit Sub
            Else
                Beep()
            End If
        End If

        If e.ColumnIndex = 3 Then
            DataGridView1.Rows(e.RowIndex).Cells(3).Value =
            DataGridView1.Rows(e.RowIndex).Cells(2).Value * e.FormattedValue.ToString
        End If
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        If Kode.Text = "" Or Nama.Text = "" Or Terima.Text = "" Then
            MsgBox("Data belum lengkap")

            Exit Sub
        End If

        Try
            Dim Simpan As String = "INSERT INTO Table_Penerimaan_Barang (NomorTrm, TanggalTrm, KodePms, NomorBon, TotalTrm, KodePmk) VALUES (@NomorTrm, @TanggalTrm, @KodePms, @NomorBon, @TotalTrm, @KodePmk)"

            cmd = New OleDbCommand(Simpan, conn)
            cmd.Parameters.AddWithValue("@NomorTrm", NoFaktur.Text)
            cmd.Parameters.AddWithValue("@TanggalTrm", Tanggal.Text)
            cmd.Parameters.AddWithValue("@KodePms", KodePms.Text)
            cmd.Parameters.AddWithValue("@NomorBon", NoReff.Text)
            cmd.Parameters.AddWithValue("@TotalTrm", Terima.Text)
            cmd.Parameters.AddWithValue("@KodePmk", MenuUtama.Status1.Text)
            cmd.ExecuteNonQuery()
            SimpanFaktur.Text = NoFaktur.Text
            Kosongkan()


            'simpan kedalam table tmpt penerima
            Dim sql_simpan_tmp As String = "INSERT INTO Tabel_TMPTerima (Kode, Nama, StokAwal, Diterima) VALUES (@Kode, @Nama, @StokAwal, @Diterima)"

            cmd = New OleDbCommand(sql_simpan_tmp, conn)
            cmd.Parameters.AddWithValue("@Kode", Kode.Text)
            cmd.Parameters.AddWithValue("@Nama", Nama.Text)
            cmd.Parameters.AddWithValue("@StokAwal", Stok.Text)
            cmd.Parameters.AddWithValue("@Diterima", Terima.Text)
            cmd.ExecuteNonQuery()

            ' Baca tabel Tabel_TMPTerima
            da = New OleDbDataAdapter("SELECT * FROM Tabel_TMPTerima", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            Otomatis()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ShowBrg_Click(sender As Object, e As EventArgs) Handles ShowBrg.Click
        DataBarangP.ShowDialog()
    End Sub

    Private Sub ShowBrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ShowBrg.KeyPress

    End Sub

    Private Sub Kode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Kode.KeyPress
        If e.KeyChar = Chr(13) Then
            If Kode.Text = "" Then
                MsgBox("Kode barang masih kosong")
            Else
                ' Check in Tabel_TMPTerima
                cmd = New OleDbCommand("SELECT * FROM Tabel_TMPTerima WHERE Kode='" & Kode.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    'Kode.Text = rd.GetValue(0)
                    Nama.Text = rd.GetString(1)
                    Stok.Text = rd.GetValue(2)
                    MsgBox("Kode barang sudah ada dalam transaksi, edit saja jumlahnya")
                    Stok.Focus()
                    Exit Sub
                Else
                    ' Check in Tabel_Barang
                    cmd = New OleDbCommand("SELECT * FROM Tabel_Barang WHERE KodeBrg='" & Kode.Text & "'", conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows Then
                        'Kode.Text = rd.GetValue(0)
                        Nama.Text = rd.GetString(1)
                        Stok.Text = rd.GetValue(3)
                        Terima.Focus()
                    Else
                        MsgBox("Kode tidak terdaftar")
                        Kode.Text = ""
                        Kode.Focus()
                    End If
                End If
            End If
        End If

        If e.KeyChar = Chr(27) Then
            cmd = New OleDbCommand("SELECT * FROM Tabel_TMPTerima WHERE Kode='" & Kode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim sqlhapus As String = "DELETE FROM Tabel_TMPTerima WHERE Kode='" & Kode.Text & "'"
                cmd = New OleDbCommand(sqlhapus, conn)
                cmd.ExecuteNonQuery()
                Call Tampilkan()
                Call CariTotalTerima()
                If DataGridView1.Rows.Count - 1 = 0 Then
                    Call HapusMaster()
                End If
                Kode.Text = ""
            Else
                MsgBox("Kode tidak ada dalam transaksi. Focus ()")
            End If
        End If
    End Sub

    Private Sub Terima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Terima.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("SELECT * FROM Tabel_TMPTerima WHERE Kode='" & Kode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim editjumlah As String = "UPDATE Tabel_TMPTerima SET Diterima='" & Terima.Text & "' WHERE Kode='" & Kode.Text & "'"
                cmd = New OleDbCommand(editjumlah, conn)
                cmd.ExecuteNonQuery()
                Call Tampilkan()
                Call CariTotalTerima()
                'Call Kosongkan()
            Else
                Dim sglsimpan As String = "INSERT INTO Tabel_TMPTerima (Kode, Nama, StokAwal, Diterima) VALUES ('" & Kode.Text & "','" & Nama.Text & "','" & Stok.Text & "','" & Terima.Text & "')"
                cmd = New OleDbCommand(sglsimpan, conn)
                cmd.ExecuteNonQuery()
                Call Tampilkan()
                Call CariTotalTerima()
                'Call Kosongkan()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Batal_Click(sender As Object, e As EventArgs) Handles Batal.Click
        Call Kosongkan()
        Call HapusGrid()
        Call HapusMaster()
        Call Tampilkan()
    End Sub

    Private Sub Tutup_Click(sender As Object, e As EventArgs) Handles Tutup.Click
        Me.Close()
    End Sub

    Private Sub KodePms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KodePms.KeyPress
        If e.KeyChar = Chr(13) Then
            If KodePms.Text = "" Then
                MsgBox("Kode Tabel_Pemasok masih kosong")
            Else
                NoReff.Focus()
            End If
        End If
    End Sub

    Private Sub KodePms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KodePms.SelectedIndexChanged
        cmd = New OleDbCommand("select * from Tabel_Pemasok where KodePms='" & KodePms.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            'LBLPerson.Text = rd.Item(5)
            NamaPms.Text = rd.Item(1)
            PersonPms.Text = rd.Item(4)
        Else
            MsgBox("Kode Tabel_Pemasok tidak terdaftar")
        End If
    End Sub

    Private Sub NoReff_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NoReff.KeyPress
        If e.KeyChar = Chr(13) Then Kode.Focus()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        HapusGrid()
    End Sub
End Class