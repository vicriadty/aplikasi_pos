<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Kode = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Jumlah = New System.Windows.Forms.TextBox()
        Me.Stok = New System.Windows.Forms.TextBox()
        Me.Harga = New System.Windows.Forms.TextBox()
        Me.Satuan = New System.Windows.Forms.ComboBox()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.Batal = New System.Windows.Forms.Button()
        Me.Tutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeBrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokMinimalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabelBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangDataSet = New FormBarang.barangDataSet()
        Me.Tabel_BarangTableAdapter = New FormBarang.barangDataSetTableAdapters.Tabel_BarangTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stok Minimal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga"
        '
        'Kode
        '
        Me.Kode.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode.Location = New System.Drawing.Point(161, 22)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(214, 28)
        Me.Kode.TabIndex = 6
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(161, 56)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(214, 28)
        Me.Nama.TabIndex = 7
        '
        'Jumlah
        '
        Me.Jumlah.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jumlah.Location = New System.Drawing.Point(161, 125)
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Size = New System.Drawing.Size(214, 28)
        Me.Jumlah.TabIndex = 8
        '
        'Stok
        '
        Me.Stok.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stok.Location = New System.Drawing.Point(161, 159)
        Me.Stok.Name = "Stok"
        Me.Stok.Size = New System.Drawing.Size(214, 28)
        Me.Stok.TabIndex = 9
        '
        'Harga
        '
        Me.Harga.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harga.Location = New System.Drawing.Point(161, 193)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(214, 28)
        Me.Harga.TabIndex = 10
        '
        'Satuan
        '
        Me.Satuan.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Satuan.FormattingEnabled = True
        Me.Satuan.Items.AddRange(New Object() {"Pcs", "Pack"})
        Me.Satuan.Location = New System.Drawing.Point(161, 90)
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Size = New System.Drawing.Size(214, 29)
        Me.Satuan.TabIndex = 11
        '
        'Simpan
        '
        Me.Simpan.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simpan.Location = New System.Drawing.Point(29, 257)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(93, 31)
        Me.Simpan.TabIndex = 12
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.Location = New System.Drawing.Point(152, 257)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(93, 31)
        Me.Hapus.TabIndex = 13
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Batal
        '
        Me.Batal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batal.Location = New System.Drawing.Point(273, 257)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(93, 31)
        Me.Batal.TabIndex = 14
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'Tutup
        '
        Me.Tutup.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tutup.Location = New System.Drawing.Point(399, 257)
        Me.Tutup.Name = "Tutup"
        Me.Tutup.Size = New System.Drawing.Size(93, 31)
        Me.Tutup.TabIndex = 15
        Me.Tutup.Text = "Tutup"
        Me.Tutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBrgDataGridViewTextBoxColumn, Me.NamaBrgDataGridViewTextBoxColumn, Me.SatuanDataGridViewTextBoxColumn, Me.JumlahBrgDataGridViewTextBoxColumn, Me.StokMinimalDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TabelBarangBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 307)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(806, 214)
        Me.DataGridView1.TabIndex = 16
        '
        'KodeBrgDataGridViewTextBoxColumn
        '
        Me.KodeBrgDataGridViewTextBoxColumn.DataPropertyName = "KodeBrg"
        Me.KodeBrgDataGridViewTextBoxColumn.FillWeight = 87.98975!
        Me.KodeBrgDataGridViewTextBoxColumn.HeaderText = "KodeBrg"
        Me.KodeBrgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodeBrgDataGridViewTextBoxColumn.Name = "KodeBrgDataGridViewTextBoxColumn"
        '
        'NamaBrgDataGridViewTextBoxColumn
        '
        Me.NamaBrgDataGridViewTextBoxColumn.DataPropertyName = "NamaBrg"
        Me.NamaBrgDataGridViewTextBoxColumn.FillWeight = 146.9429!
        Me.NamaBrgDataGridViewTextBoxColumn.HeaderText = "NamaBrg"
        Me.NamaBrgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamaBrgDataGridViewTextBoxColumn.Name = "NamaBrgDataGridViewTextBoxColumn"
        '
        'SatuanDataGridViewTextBoxColumn
        '
        Me.SatuanDataGridViewTextBoxColumn.DataPropertyName = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.FillWeight = 80.9295!
        Me.SatuanDataGridViewTextBoxColumn.HeaderText = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SatuanDataGridViewTextBoxColumn.Name = "SatuanDataGridViewTextBoxColumn"
        '
        'JumlahBrgDataGridViewTextBoxColumn
        '
        Me.JumlahBrgDataGridViewTextBoxColumn.DataPropertyName = "JumlahBrg"
        Me.JumlahBrgDataGridViewTextBoxColumn.FillWeight = 64.17111!
        Me.JumlahBrgDataGridViewTextBoxColumn.HeaderText = "JumlahBrg"
        Me.JumlahBrgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JumlahBrgDataGridViewTextBoxColumn.Name = "JumlahBrgDataGridViewTextBoxColumn"
        '
        'StokMinimalDataGridViewTextBoxColumn
        '
        Me.StokMinimalDataGridViewTextBoxColumn.DataPropertyName = "StokMinimal"
        Me.StokMinimalDataGridViewTextBoxColumn.FillWeight = 73.02372!
        Me.StokMinimalDataGridViewTextBoxColumn.HeaderText = "StokMinimal"
        Me.StokMinimalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StokMinimalDataGridViewTextBoxColumn.Name = "StokMinimalDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "Harga"
        Me.HargaDataGridViewTextBoxColumn.FillWeight = 146.9429!
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'TabelBarangBindingSource
        '
        Me.TabelBarangBindingSource.DataMember = "Tabel_Barang"
        Me.TabelBarangBindingSource.DataSource = Me.BarangDataSet
        '
        'BarangDataSet
        '
        Me.BarangDataSet.DataSetName = "barangDataSet"
        Me.BarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabel_BarangTableAdapter
        '
        Me.Tabel_BarangTableAdapter.ClearBeforeFill = True
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(828, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Tutup)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.Satuan)
        Me.Controls.Add(Me.Harga)
        Me.Controls.Add(Me.Stok)
        Me.Controls.Add(Me.Jumlah)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Kode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Kode As TextBox
    Friend WithEvents Nama As TextBox
    Friend WithEvents Jumlah As TextBox
    Friend WithEvents Stok As TextBox
    Friend WithEvents Harga As TextBox
    Friend WithEvents Satuan As ComboBox
    Friend WithEvents Simpan As Button
    Friend WithEvents Hapus As Button
    Friend WithEvents Batal As Button
    Friend WithEvents Tutup As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BarangDataSet As barangDataSet
    Friend WithEvents TabelBarangBindingSource As BindingSource
    Friend WithEvents Tabel_BarangTableAdapter As barangDataSetTableAdapters.Tabel_BarangTableAdapter
    Friend WithEvents KodeBrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaBrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahBrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokMinimalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
