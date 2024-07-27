Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Koneksi()
        cmd = New OleDbCommand("select * from Tabel_Pemakai where NamaPmk='" &
        Username.Text & "' and PassPmk='" & Password.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Login dengan Username='" & Username.Text & "' Berhasil !")
            Me.Visible = False
            Loading.Show()
        Else
            MsgBox("Username atau Password salah !")
            Username.Focus()

        End If
    End Sub
    Private Sub Username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Username.KeyPress
        If e.KeyChar = Chr(13) Then Password.Focus()
    End Sub

    Private Sub Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password.KeyPress
        If e.KeyChar = Chr(13) Then BtnLogin.Focus()
    End Sub

    Private Sub BtnLogin_MouseEnter(sender As Object, e As EventArgs) Handles BtnLogin.MouseEnter
        BtnLogin.BackColor = Color.SkyBlue
    End Sub

    Private Sub BtnLogin_MouseLeave(sender As Object, e As EventArgs) Handles BtnLogin.MouseLeave
        BtnLogin.BackColor = Color.RoyalBlue
    End Sub

    Private Sub BtnTutup_MouseEnter(sender As Object, e As EventArgs) Handles BtnTutup.MouseEnter
        BtnTutup.BackColor = Color.Salmon
    End Sub

    Private Sub BtnTutup_MouseLeave(sender As Object, e As EventArgs) Handles BtnTutup.MouseLeave
        BtnTutup.BackColor = Color.Red
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class