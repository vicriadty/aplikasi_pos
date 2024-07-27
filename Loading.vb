Imports System.Reflection.Emit

Public Class Loading
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MenuUtama.Show()
            MenuUtama.Status1.Text = rd.GetString(0)
            MenuUtama.Status2.Text = rd.GetString(1)
            MenuUtama.Status3.Text = rd.GetString(3)
            If MenuUtama.Status3.Text <> "ADMIN" Then
                MenuUtama.StatusStrip1.Enabled = False
            Else
                MenuUtama.StatusStrip1.Enabled = True
            End If
            Me.Close()
        Else
            ProgressBar1.Value += 5
            Label1.Text = ProgressBar1.Value & "%"
        End If
    End Sub
End Class