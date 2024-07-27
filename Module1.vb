Imports System.Data.OleDb

Module Module1
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader

    Public Sub Koneksi()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TUGAS SEMESTER 4 INFORMATIKA\PEMROGRAMAN VISUAL\UASFORMBARANG\FormBarang\FormBarang\bin\Debug\barang.accdb")
        conn.Open()
    End Sub
End Module
