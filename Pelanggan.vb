Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Pelanggan
    Sub Kosongkan()
        Kode.Text = ""
        Nama.Text = ""
        Alamat.Text = ""
        Telepon.Text = ""
        JK.Text = ""
        Email.Text = ""
        Kode.Focus()
    End Sub

    Sub DataBaru()
        Kode.Text = ""
        Nama.Text = ""
        Alamat.Text = ""
        Telepon.Text = ""
        JK.Text = ""
        Email.Text = ""
        Nama.Focus()
    End Sub

    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Tabel_Pelanggan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tabel_Pelanggan")
        DataGridView1.DataSource = (ds.Tables("Tabel_Pelanggan"))
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Tampilkan()
    End Sub

    Private Sub Tutup_Click(sender As Object, e As EventArgs) Handles Tutup.Click
        Me.Close()
    End Sub

    Private Sub Batal_Click(sender As Object, e As EventArgs) Handles Batal.Click
        Kosongkan()
    End Sub

    Private Sub Kode_TextChanged(sender As Object, e As EventArgs) Handles Kode.TextChanged

    End Sub

    Private Sub Kode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Kode.KeyPress

    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        If Kode.Text = "" Or Nama.Text = "" Or Alamat.Text = "" Or Telepon.Text = "" Or JK.Text = "" Or Email.Text = "" Then
            MsgBox("Data Belum Lengkap !")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from Tabel_Pelanggan where KodePlg = '" & Kode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "Insert into Tabel_Pelanggan (KodePlg, NamaPlg, AlamatPlg, TeleponPlg,
                JK, EmailPlg) Values " & "('" & Kode.Text & "','" & Nama.Text & "','" & Alamat.Text & "',
                '" & Telepon.Text & "','" & JK.Text & "','" & Email.Text & "')"
                cmd = New OleDbCommand(sqltambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Pelanggan berhasil di simpan !")
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim sqledit = "Update Tabel_Pelanggan set " & "NamaPlg='" & Nama.Text & "', " & "AlamatPlg='" & Alamat.Text & "', 
                " & "TeleponPlg='" & Telepon.Text & "', " & "JK='" & JK.Text & "', " & "EmailPlg='" & Email.Text & "' 
                " & "where KodePlg='" & Kode.Text & "'"
                cmd = New OleDbCommand(sqledit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Pelanggan berhasil di update !")
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        If Kode.Text = "" Then
            MsgBox("Isi Kode Tabel_Pelanggan terlebih dahulu")
            Kode.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin ingin menghapus data ini..?", "'", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Tabel_Pelanggan where KodePlg='" & Kode.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub Kode_KeyDown(sender As Object, e As KeyEventArgs) Handles Kode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Using cmd As New OleDbCommand("SELECT * FROM Tabel_Pelanggan WHERE KodePlg='" & Kode.Text & "'", conn)
                    cmd.Parameters.AddWithValue("?", Kode.Text)

                    Using rd As OleDbDataReader = cmd.ExecuteReader()
                        If rd.Read() Then
                            Nama.Text = rd.GetString(1)
                            Alamat.Text = rd.GetString(2)
                            Telepon.Text = rd.GetValue(3).ToString()
                            JK.Text = rd.GetValue(4).ToString()
                            Email.Text = rd.GetValue(5).ToString()
                            Nama.Focus()
                        Else
                            DataBaru()
                            Nama.Focus()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If

        'If Not ((e.KeyCode >= "0" And e.KeyCode <= "9") Or e.KeyCode = vbBack) Then e.Handled() = True
    End Sub
End Class