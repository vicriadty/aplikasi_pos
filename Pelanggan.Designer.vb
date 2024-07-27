<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pelanggan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Kode = New System.Windows.Forms.TextBox()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Telepon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.JK = New System.Windows.Forms.ComboBox()
        Me.Tutup = New System.Windows.Forms.Button()
        Me.Batal = New System.Windows.Forms.Button()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodePlgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPlgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatPlgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponPlgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailPlgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabelPelangganBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangDataSet = New FormBarang.barangDataSet()
        Me.TabelPelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tabel_PelangganTableAdapter = New FormBarang.barangDataSetTableAdapters.Tabel_PelangganTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelPelangganBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelPelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telepon"
        '
        'Kode
        '
        Me.Kode.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode.Location = New System.Drawing.Point(119, 31)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(140, 28)
        Me.Kode.TabIndex = 4
        '
        'Alamat
        '
        Me.Alamat.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alamat.Location = New System.Drawing.Point(119, 82)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(490, 28)
        Me.Alamat.TabIndex = 5
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(120, 183)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(489, 28)
        Me.Email.TabIndex = 6
        '
        'Telepon
        '
        Me.Telepon.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telepon.Location = New System.Drawing.Point(120, 129)
        Me.Telepon.Name = "Telepon"
        Me.Telepon.Size = New System.Drawing.Size(199, 28)
        Me.Telepon.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(337, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Nama
        '
        Me.Nama.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Nama.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(341, 31)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(268, 28)
        Me.Nama.TabIndex = 10
        '
        'JK
        '
        Me.JK.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JK.FormattingEnabled = True
        Me.JK.Items.AddRange(New Object() {"Laki - laki", "Perempuan"})
        Me.JK.Location = New System.Drawing.Point(458, 128)
        Me.JK.Name = "JK"
        Me.JK.Size = New System.Drawing.Size(151, 29)
        Me.JK.TabIndex = 11
        '
        'Tutup
        '
        Me.Tutup.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tutup.Location = New System.Drawing.Point(398, 249)
        Me.Tutup.Name = "Tutup"
        Me.Tutup.Size = New System.Drawing.Size(93, 31)
        Me.Tutup.TabIndex = 19
        Me.Tutup.Text = "Tutup"
        Me.Tutup.UseVisualStyleBackColor = True
        '
        'Batal
        '
        Me.Batal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batal.Location = New System.Drawing.Point(272, 249)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(93, 31)
        Me.Batal.TabIndex = 18
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.Location = New System.Drawing.Point(151, 249)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(93, 31)
        Me.Hapus.TabIndex = 17
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simpan.Location = New System.Drawing.Point(28, 249)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(93, 31)
        Me.Simpan.TabIndex = 16
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodePlgDataGridViewTextBoxColumn, Me.NamaPlgDataGridViewTextBoxColumn, Me.AlamatPlgDataGridViewTextBoxColumn, Me.TeleponPlgDataGridViewTextBoxColumn, Me.JKDataGridViewTextBoxColumn, Me.EmailPlgDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TabelPelangganBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 307)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(820, 184)
        Me.DataGridView1.TabIndex = 20
        '
        'KodePlgDataGridViewTextBoxColumn
        '
        Me.KodePlgDataGridViewTextBoxColumn.DataPropertyName = "KodePlg"
        Me.KodePlgDataGridViewTextBoxColumn.FillWeight = 64.17112!
        Me.KodePlgDataGridViewTextBoxColumn.HeaderText = "KodePlg"
        Me.KodePlgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodePlgDataGridViewTextBoxColumn.Name = "KodePlgDataGridViewTextBoxColumn"
        '
        'NamaPlgDataGridViewTextBoxColumn
        '
        Me.NamaPlgDataGridViewTextBoxColumn.DataPropertyName = "NamaPlg"
        Me.NamaPlgDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.NamaPlgDataGridViewTextBoxColumn.HeaderText = "NamaPlg"
        Me.NamaPlgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamaPlgDataGridViewTextBoxColumn.Name = "NamaPlgDataGridViewTextBoxColumn"
        '
        'AlamatPlgDataGridViewTextBoxColumn
        '
        Me.AlamatPlgDataGridViewTextBoxColumn.DataPropertyName = "AlamatPlg"
        Me.AlamatPlgDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.AlamatPlgDataGridViewTextBoxColumn.HeaderText = "AlamatPlg"
        Me.AlamatPlgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AlamatPlgDataGridViewTextBoxColumn.Name = "AlamatPlgDataGridViewTextBoxColumn"
        '
        'TeleponPlgDataGridViewTextBoxColumn
        '
        Me.TeleponPlgDataGridViewTextBoxColumn.DataPropertyName = "TeleponPlg"
        Me.TeleponPlgDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.TeleponPlgDataGridViewTextBoxColumn.HeaderText = "TeleponPlg"
        Me.TeleponPlgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TeleponPlgDataGridViewTextBoxColumn.Name = "TeleponPlgDataGridViewTextBoxColumn"
        '
        'JKDataGridViewTextBoxColumn
        '
        Me.JKDataGridViewTextBoxColumn.DataPropertyName = "JK"
        Me.JKDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.JKDataGridViewTextBoxColumn.HeaderText = "JK"
        Me.JKDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JKDataGridViewTextBoxColumn.Name = "JKDataGridViewTextBoxColumn"
        '
        'EmailPlgDataGridViewTextBoxColumn
        '
        Me.EmailPlgDataGridViewTextBoxColumn.DataPropertyName = "EmailPlg"
        Me.EmailPlgDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.EmailPlgDataGridViewTextBoxColumn.HeaderText = "EmailPlg"
        Me.EmailPlgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailPlgDataGridViewTextBoxColumn.Name = "EmailPlgDataGridViewTextBoxColumn"
        '
        'TabelPelangganBindingSource1
        '
        Me.TabelPelangganBindingSource1.DataMember = "Tabel_Pelanggan"
        Me.TabelPelangganBindingSource1.DataSource = Me.BarangDataSet
        '
        'BarangDataSet
        '
        Me.BarangDataSet.DataSetName = "barangDataSet"
        Me.BarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabelPelangganBindingSource
        '
        Me.TabelPelangganBindingSource.DataMember = "Tabel_Pelanggan"
        Me.TabelPelangganBindingSource.DataSource = Me.BarangDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Nama"
        '
        'Tabel_PelangganTableAdapter
        '
        Me.Tabel_PelangganTableAdapter.ClearBeforeFill = True
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(844, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Tutup)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.JK)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Telepon)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.Kode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelanggan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelPelangganBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelPelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Kode As TextBox
    Friend WithEvents Alamat As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Telepon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Nama As TextBox
    Friend WithEvents JK As ComboBox
    Friend WithEvents Tutup As Button
    Friend WithEvents Batal As Button
    Friend WithEvents Hapus As Button
    Friend WithEvents Simpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents BarangDataSet As barangDataSet
    Friend WithEvents TabelPelangganBindingSource As BindingSource
    Friend WithEvents Tabel_PelangganTableAdapter As barangDataSetTableAdapters.Tabel_PelangganTableAdapter
    Friend WithEvents TabelPelangganBindingSource1 As BindingSource
    Friend WithEvents KodePlgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPlgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatPlgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeleponPlgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailPlgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
