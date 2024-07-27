<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Penerimaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penerimaan))
        Me.Nomor = New System.Windows.Forms.Label()
        Me.NoFaktur = New System.Windows.Forms.TextBox()
        Me.KodePms = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PersonPms = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tanggal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NamaPms = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NoReff = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokAwalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiterimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabelTMPTerimaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangDataSet = New FormBarang.barangDataSet()
        Me.TablePenerimaanBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tutup = New System.Windows.Forms.Button()
        Me.Batal = New System.Windows.Forms.Button()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.Table_Penerimaan_BarangTableAdapter = New FormBarang.barangDataSetTableAdapters.Table_Penerimaan_BarangTableAdapter()
        Me.ShowBrg = New System.Windows.Forms.Button()
        Me.Terima = New System.Windows.Forms.TextBox()
        Me.Stok = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Kode = New System.Windows.Forms.TextBox()
        Me.Tabel_TMPTerimaTableAdapter = New FormBarang.barangDataSetTableAdapters.Tabel_TMPTerimaTableAdapter()
        Me.TotalTerima = New System.Windows.Forms.TextBox()
        Me.SimpanFaktur = New System.Windows.Forms.TextBox()
        Me.Hapus = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelTMPTerimaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablePenerimaanBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nomor
        '
        Me.Nomor.AutoSize = True
        Me.Nomor.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nomor.Location = New System.Drawing.Point(27, 26)
        Me.Nomor.Name = "Nomor"
        Me.Nomor.Size = New System.Drawing.Size(59, 21)
        Me.Nomor.TabIndex = 40
        Me.Nomor.Text = "Nomor"
        '
        'NoFaktur
        '
        Me.NoFaktur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoFaktur.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoFaktur.Location = New System.Drawing.Point(177, 23)
        Me.NoFaktur.Name = "NoFaktur"
        Me.NoFaktur.ReadOnly = True
        Me.NoFaktur.Size = New System.Drawing.Size(196, 28)
        Me.NoFaktur.TabIndex = 39
        '
        'KodePms
        '
        Me.KodePms.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodePms.FormattingEnabled = True
        Me.KodePms.Items.AddRange(New Object() {"Pcs", "Pack"})
        Me.KodePms.Location = New System.Drawing.Point(177, 77)
        Me.KodePms.Name = "KodePms"
        Me.KodePms.Size = New System.Drawing.Size(196, 29)
        Me.KodePms.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 21)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Kode Pemasok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Contact Person"
        '
        'PersonPms
        '
        Me.PersonPms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PersonPms.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonPms.Location = New System.Drawing.Point(177, 130)
        Me.PersonPms.Name = "PersonPms"
        Me.PersonPms.ReadOnly = True
        Me.PersonPms.Size = New System.Drawing.Size(196, 28)
        Me.PersonPms.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(425, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Tanggal"
        '
        'Tanggal
        '
        Me.Tanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tanggal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal.Location = New System.Drawing.Point(566, 23)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.ReadOnly = True
        Me.Tanggal.Size = New System.Drawing.Size(226, 28)
        Me.Tanggal.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 21)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Nama Pemasok"
        '
        'NamaPms
        '
        Me.NamaPms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NamaPms.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaPms.Location = New System.Drawing.Point(566, 77)
        Me.NamaPms.Name = "NamaPms"
        Me.NamaPms.ReadOnly = True
        Me.NamaPms.Size = New System.Drawing.Size(226, 28)
        Me.NamaPms.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(425, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Nomor Reff"
        '
        'NoReff
        '
        Me.NoReff.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoReff.Location = New System.Drawing.Point(566, 130)
        Me.NoReff.Name = "NoReff"
        Me.NoReff.Size = New System.Drawing.Size(226, 28)
        Me.NoReff.TabIndex = 49
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.StokAwalDataGridViewTextBoxColumn, Me.DiterimaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TabelTMPTerimaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(805, 237)
        Me.DataGridView1.TabIndex = 51
        '
        'KodeDataGridViewTextBoxColumn
        '
        Me.KodeDataGridViewTextBoxColumn.DataPropertyName = "Kode"
        Me.KodeDataGridViewTextBoxColumn.HeaderText = "Kode"
        Me.KodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodeDataGridViewTextBoxColumn.Name = "KodeDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "Nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'StokAwalDataGridViewTextBoxColumn
        '
        Me.StokAwalDataGridViewTextBoxColumn.DataPropertyName = "StokAwal"
        Me.StokAwalDataGridViewTextBoxColumn.HeaderText = "StokAwal"
        Me.StokAwalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StokAwalDataGridViewTextBoxColumn.Name = "StokAwalDataGridViewTextBoxColumn"
        '
        'DiterimaDataGridViewTextBoxColumn
        '
        Me.DiterimaDataGridViewTextBoxColumn.DataPropertyName = "Diterima"
        Me.DiterimaDataGridViewTextBoxColumn.HeaderText = "Diterima"
        Me.DiterimaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiterimaDataGridViewTextBoxColumn.Name = "DiterimaDataGridViewTextBoxColumn"
        '
        'TabelTMPTerimaBindingSource
        '
        Me.TabelTMPTerimaBindingSource.DataMember = "Tabel_TMPTerima"
        Me.TabelTMPTerimaBindingSource.DataSource = Me.BarangDataSet
        '
        'BarangDataSet
        '
        Me.BarangDataSet.DataSetName = "barangDataSet"
        Me.BarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablePenerimaanBarangBindingSource
        '
        Me.TablePenerimaanBarangBindingSource.DataMember = "Table_Penerimaan_Barang"
        Me.TablePenerimaanBarangBindingSource.DataSource = Me.BarangDataSet
        '
        'Tutup
        '
        Me.Tutup.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tutup.Location = New System.Drawing.Point(342, 482)
        Me.Tutup.Name = "Tutup"
        Me.Tutup.Size = New System.Drawing.Size(93, 31)
        Me.Tutup.TabIndex = 54
        Me.Tutup.Text = "Tutup"
        Me.Tutup.UseVisualStyleBackColor = True
        '
        'Batal
        '
        Me.Batal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batal.Location = New System.Drawing.Point(230, 482)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(93, 31)
        Me.Batal.TabIndex = 53
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simpan.Location = New System.Drawing.Point(12, 482)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(93, 31)
        Me.Simpan.TabIndex = 52
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'Table_Penerimaan_BarangTableAdapter
        '
        Me.Table_Penerimaan_BarangTableAdapter.ClearBeforeFill = True
        '
        'ShowBrg
        '
        Me.ShowBrg.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowBrg.Location = New System.Drawing.Point(31, 190)
        Me.ShowBrg.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowBrg.Name = "ShowBrg"
        Me.ShowBrg.Size = New System.Drawing.Size(44, 28)
        Me.ShowBrg.TabIndex = 82
        Me.ShowBrg.Text = "....."
        Me.ShowBrg.UseVisualStyleBackColor = True
        '
        'Terima
        '
        Me.Terima.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Terima.Location = New System.Drawing.Point(676, 191)
        Me.Terima.Margin = New System.Windows.Forms.Padding(4)
        Me.Terima.Name = "Terima"
        Me.Terima.Size = New System.Drawing.Size(116, 28)
        Me.Terima.TabIndex = 81
        '
        'Stok
        '
        Me.Stok.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stok.Location = New System.Drawing.Point(566, 191)
        Me.Stok.Margin = New System.Windows.Forms.Padding(4)
        Me.Stok.Name = "Stok"
        Me.Stok.Size = New System.Drawing.Size(99, 28)
        Me.Stok.TabIndex = 80
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(188, 191)
        Me.Nama.Margin = New System.Windows.Forms.Padding(4)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(355, 28)
        Me.Nama.TabIndex = 79
        '
        'Kode
        '
        Me.Kode.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode.Location = New System.Drawing.Point(92, 190)
        Me.Kode.Margin = New System.Windows.Forms.Padding(4)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(76, 28)
        Me.Kode.TabIndex = 78
        '
        'Tabel_TMPTerimaTableAdapter
        '
        Me.Tabel_TMPTerimaTableAdapter.ClearBeforeFill = True
        '
        'TotalTerima
        '
        Me.TotalTerima.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TotalTerima.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTerima.Location = New System.Drawing.Point(676, 485)
        Me.TotalTerima.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalTerima.Name = "TotalTerima"
        Me.TotalTerima.ReadOnly = True
        Me.TotalTerima.Size = New System.Drawing.Size(129, 28)
        Me.TotalTerima.TabIndex = 83
        '
        'SimpanFaktur
        '
        Me.SimpanFaktur.BackColor = System.Drawing.SystemColors.Window
        Me.SimpanFaktur.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpanFaktur.Location = New System.Drawing.Point(516, 485)
        Me.SimpanFaktur.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpanFaktur.Name = "SimpanFaktur"
        Me.SimpanFaktur.ReadOnly = True
        Me.SimpanFaktur.Size = New System.Drawing.Size(128, 28)
        Me.SimpanFaktur.TabIndex = 84
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.Location = New System.Drawing.Point(121, 482)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(93, 31)
        Me.Hapus.TabIndex = 85
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Penerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(829, 544)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.SimpanFaktur)
        Me.Controls.Add(Me.TotalTerima)
        Me.Controls.Add(Me.ShowBrg)
        Me.Controls.Add(Me.Terima)
        Me.Controls.Add(Me.Stok)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Kode)
        Me.Controls.Add(Me.Tutup)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NoReff)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NamaPms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PersonPms)
        Me.Controls.Add(Me.KodePms)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Nomor)
        Me.Controls.Add(Me.NoFaktur)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Penerimaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penerimaan Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelTMPTerimaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablePenerimaanBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nomor As Label
    Friend WithEvents NoFaktur As TextBox
    Friend WithEvents KodePms As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PersonPms As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tanggal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NamaPms As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NoReff As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Tutup As Button
    Friend WithEvents Batal As Button
    Friend WithEvents Simpan As Button
    Friend WithEvents BarangDataSet As barangDataSet
    Friend WithEvents TablePenerimaanBarangBindingSource As BindingSource
    Friend WithEvents Table_Penerimaan_BarangTableAdapter As barangDataSetTableAdapters.Table_Penerimaan_BarangTableAdapter
    Friend WithEvents ShowBrg As Button
    Friend WithEvents Terima As TextBox
    Friend WithEvents Stok As TextBox
    Friend WithEvents Nama As TextBox
    Friend WithEvents Kode As TextBox
    Friend WithEvents TabelTMPTerimaBindingSource As BindingSource
    Friend WithEvents Tabel_TMPTerimaTableAdapter As barangDataSetTableAdapters.Tabel_TMPTerimaTableAdapter
    Friend WithEvents KodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokAwalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiterimaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalTerima As TextBox
    Friend WithEvents SimpanFaktur As TextBox
    Friend WithEvents Hapus As Button
End Class
