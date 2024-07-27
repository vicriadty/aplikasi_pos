Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Public Class Pemakai
    Sub Kosongkan()
        Kode.Text = ""
        Nama.Text = ""
        Password.Text = ""
        Status.Text = ""
        Kode.Focus()
    End Sub

    Sub DataBaru()
        Kode.Text = ""
        Nama.Text = ""
        Password.Text = ""
        Status.Text = ""
        Nama.Focus()
    End Sub

    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Tabel_Pemakai", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tabel_Pemakai")
        DataGridView1.DataSource = (ds.Tables("Tabel_Pemakai"))
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Pemakai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Tampilkan()
    End Sub

    Private Sub Tutup_Click(sender As Object, e As EventArgs) Handles Tutup.Click
        Me.Close()
    End Sub

    Private Sub Batal_Click(sender As Object, e As EventArgs) Handles Batal.Click
        Kosongkan()
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        If Kode.Text = "" Or Nama.Text = "" Or Password.Text = "" Or Status.Text = "" Then
            MsgBox("Data Belum Lengkap !")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from Tabel_Pemakai where KodePmk = '" & Kode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "Insert into Tabel_Pemakai (KodePmk, NamaPmk, PassPmk, StatusPmk) 
                Values " & "('" & Kode.Text & "','" & Nama.Text & "','" & Password.Text & "',
                '" & Status.Text & "')"
                cmd = New OleDbCommand(sqltambah, conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim sqledit = "Update Tabel_Pemakai set " & "NamaPmk='" & Nama.Text & "', " & "PassPmk='" & Password.Text & "', 
                " & "StatusPmk='" & Status.Text & "', " & "where KodePmk='" & Kode.Text & "'"
                cmd = New OleDbCommand(sqledit, conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        If Kode.Text = "" Then
            MsgBox("Isi Kode Tabel_Pemakai terlebih dahulu")
            Kode.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin ingin menghapus data ini..?", "'", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Tabel_Pemakai where KodePmk='" & Kode.Text & "'", conn)
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
                Using cmd As New OleDbCommand("SELECT * FROM Tabel_Pemakai WHERE KodePmk='" & Kode.Text & "'", conn)
                    cmd.Parameters.AddWithValue("?", Kode.Text)

                    Using rd As OleDbDataReader = cmd.ExecuteReader()
                        If rd.Read() Then
                            Nama.Text = rd.GetString(1)
                            Password.Text = rd.GetString(2)
                            Status.Text = rd.GetValue(3).ToString()
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
    End Sub
End Class