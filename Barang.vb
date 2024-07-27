Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Barang
    Sub Kosongkan()
        Kode.Text = ""
        Nama.Text = ""
        Jumlah.Text = ""
        Stok.Text = ""
        Harga.Text = ""
        Satuan.Text = ""
        Kode.Focus()
    End Sub

    Sub DataBaru()
        Kode.Text = ""
        Nama.Text = ""
        Jumlah.Text = ""
        Stok.Text = ""
        Harga.Text = ""
        Satuan.Text = ""
        Satuan.Focus()
    End Sub

    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Tabel_Barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tabel_Barang")
        DataGridView1.DataSource = (ds.Tables("Tabel_Barang"))
        DataGridView1.ReadOnly = True
    End Sub

    Sub TampilSatuan()
        'Satuan.Items.Clear()

        'cmd = New OleDbCommand("Select distinct satuan from Tabel_Barang", conn)

        'rd = cmd.ExecuteReader
        'While rd.Read
        '    Satuan.Items.Add(rd.GetString(0))
        'End While
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
        Call TampilSatuan()
    End Sub

    Private Sub Kode_TextChanged(sender As Object, e As EventArgs) Handles Kode.TextChanged

    End Sub

    Private Sub Kode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Kode.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("Select * from Tabel_Barang where KodeBrg='" & Kode.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    Nama.Text = rd.GetString(1)
                    Satuan.Text = rd.GetString(2)
                    Jumlah.Text = rd.GetValue(3)
                    Stok.Text = rd.GetValue(4)
                    Harga.Text = rd.GetValue(5)
                    Nama.Focus()
                Else
                    Call DataBaru()
                    Nama.Focus()
                End If
            Catch ex As Exception

            End Try
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        If Kode.Text = "" Or Nama.Text = "" Or Satuan.Text = "" Or Jumlah.Text = "" Or Stok.Text = "" Or Harga.Text = "" Then
            MsgBox("Data Belum Lengkap !")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from Tabel_Barang where KodeBrg = '" & Kode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "Insert into Tabel_Barang (KodeBrg, NamaBrg, Satuan, JumlahBrg,
                StokMinimal, Harga) Values " & "('" & Kode.Text & "','" & Nama.Text & "','" & Satuan.Text & "',
                '" & Jumlah.Text & "','" & Stok.Text & "','" & Harga.Text & "')"
                cmd = New OleDbCommand(sqltambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Barang berhasil di simpan !")
                Call Kosongkan()
                Call Tampilkan()

            Else
                Dim sqledit = "Update Tabel_Barang set " & "NamaBrg='" & Nama.Text & "', " & "Satuan='" & Satuan.Text & "', 
                " & "JumlahBrg='" & Jumlah.Text & "', " & "StokMinimal='" & Stok.Text & "', " & "Harga='" & Harga.Text & "' 
                " & "where KodeBrg='" & Kode.Text & "'"
                cmd = New OleDbCommand(sqledit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Barang berhasil di update !")
                Call Kosongkan()
                Call Tampilkan()

            End If
        End If
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        If Kode.Text = "" Then
            MsgBox("Isi Kode Tabel_Barang terlebih dahulu")
            Kode.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin ingin menghapus data ini..?", "'", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Tabel_Barang where KodeBrg='" & Kode.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub Batal_Click(sender As Object, e As EventArgs) Handles Batal.Click
        Call Kosongkan()
    End Sub

    Private Sub Tutup_Click(sender As Object, e As EventArgs) Handles Tutup.Click
        Me.Close()
    End Sub
End Class
