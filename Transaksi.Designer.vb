<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.Faktur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tanggal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Jam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DaftarBarang = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Kode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Telepon = New System.Windows.Forms.TextBox()
        Me.JK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Alamat = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.RichTextBox()
        Me.Tutup = New System.Windows.Forms.Button()
        Me.Batal = New System.Windows.Forms.Button()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Item = New System.Windows.Forms.TextBox()
        Me.Dibayar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Kembali = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DaftarPelanggan = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Faktur
        '
        Me.Faktur.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Faktur.Location = New System.Drawing.Point(84, 24)
        Me.Faktur.Name = "Faktur"
        Me.Faktur.ReadOnly = True
        Me.Faktur.Size = New System.Drawing.Size(146, 28)
        Me.Faktur.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Faktur"
        '
        'Tanggal
        '
        Me.Tanggal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal.Location = New System.Drawing.Point(318, 24)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.ReadOnly = True
        Me.Tanggal.Size = New System.Drawing.Size(167, 28)
        Me.Tanggal.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tanggal"
        '
        'Jam
        '
        Me.Jam.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jam.Location = New System.Drawing.Point(555, 23)
        Me.Jam.Name = "Jam"
        Me.Jam.ReadOnly = True
        Me.Jam.Size = New System.Drawing.Size(157, 28)
        Me.Jam.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(512, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Jam"
        '
        'DaftarBarang
        '
        Me.DaftarBarang.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DaftarBarang.Location = New System.Drawing.Point(754, 21)
        Me.DaftarBarang.Name = "DaftarBarang"
        Me.DaftarBarang.Size = New System.Drawing.Size(140, 31)
        Me.DaftarBarang.TabIndex = 17
        Me.DaftarBarang.Text = "Daftar Barang"
        Me.DaftarBarang.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(718, 245)
        Me.DataGridView1.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(750, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 21)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Nama"
        '
        'Kode
        '
        Me.Kode.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode.FormattingEnabled = True
        Me.Kode.Items.AddRange(New Object() {"Laki - laki", "Perempuan"})
        Me.Kode.Location = New System.Drawing.Point(862, 73)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(137, 29)
        Me.Kode.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(753, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Telepon
        '
        Me.Telepon.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telepon.Location = New System.Drawing.Point(862, 237)
        Me.Telepon.Name = "Telepon"
        Me.Telepon.Size = New System.Drawing.Size(145, 28)
        Me.Telepon.TabIndex = 29
        '
        'JK
        '
        Me.JK.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JK.Location = New System.Drawing.Point(862, 279)
        Me.JK.Name = "JK"
        Me.JK.Size = New System.Drawing.Size(145, 28)
        Me.JK.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(753, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Telepon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(750, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 21)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Alamat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(750, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 21)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Kode"
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(862, 108)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(151, 28)
        Me.Nama.TabIndex = 34
        '
        'Alamat
        '
        Me.Alamat.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alamat.Location = New System.Drawing.Point(862, 153)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(151, 69)
        Me.Alamat.TabIndex = 35
        Me.Alamat.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(750, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 21)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Total"
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(862, 366)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(151, 69)
        Me.Total.TabIndex = 37
        Me.Total.Text = ""
        '
        'Tutup
        '
        Me.Tutup.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tutup.Location = New System.Drawing.Point(210, 324)
        Me.Tutup.Name = "Tutup"
        Me.Tutup.Size = New System.Drawing.Size(93, 31)
        Me.Tutup.TabIndex = 40
        Me.Tutup.Text = "Tutup"
        Me.Tutup.UseVisualStyleBackColor = True
        '
        'Batal
        '
        Me.Batal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batal.Location = New System.Drawing.Point(111, 324)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(93, 31)
        Me.Batal.TabIndex = 39
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simpan.Location = New System.Drawing.Point(12, 324)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(93, 31)
        Me.Simpan.TabIndex = 38
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(327, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 21)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Item"
        '
        'Item
        '
        Me.Item.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.Location = New System.Drawing.Point(375, 326)
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Size = New System.Drawing.Size(110, 28)
        Me.Item.TabIndex = 42
        '
        'Dibayar
        '
        Me.Dibayar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dibayar.Location = New System.Drawing.Point(576, 332)
        Me.Dibayar.Name = "Dibayar"
        Me.Dibayar.Size = New System.Drawing.Size(110, 28)
        Me.Dibayar.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(507, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 21)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Dibayar"
        '
        'Kembali
        '
        Me.Kembali.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kembali.Location = New System.Drawing.Point(576, 370)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.ReadOnly = True
        Me.Kembali.Size = New System.Drawing.Size(110, 28)
        Me.Kembali.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(507, 370)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 21)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Kembali"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 370)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 28)
        Me.TextBox1.TabIndex = 47
        '
        'DaftarPelanggan
        '
        Me.DaftarPelanggan.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DaftarPelanggan.Location = New System.Drawing.Point(1021, 71)
        Me.DaftarPelanggan.Name = "DaftarPelanggan"
        Me.DaftarPelanggan.Size = New System.Drawing.Size(44, 31)
        Me.DaftarPelanggan.TabIndex = 48
        Me.DaftarPelanggan.Text = "..."
        Me.DaftarPelanggan.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(753, 325)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 21)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Email"
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(862, 322)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(145, 28)
        Me.Email.TabIndex = 49
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1084, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.DaftarPelanggan)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Kembali)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Dibayar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Item)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Tutup)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Kode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Telepon)
        Me.Controls.Add(Me.JK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DaftarBarang)
        Me.Controls.Add(Me.Jam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Faktur)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Faktur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tanggal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Jam As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DaftarBarang As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Kode As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Telepon As TextBox
    Friend WithEvents JK As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Nama As TextBox
    Friend WithEvents Alamat As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Total As RichTextBox
    Friend WithEvents Tutup As Button
    Friend WithEvents Batal As Button
    Friend WithEvents Simpan As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Item As TextBox
    Friend WithEvents Dibayar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Kembali As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DaftarPelanggan As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Email As TextBox
End Class
