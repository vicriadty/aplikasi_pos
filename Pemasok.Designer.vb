<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pemasok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pemasok))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodePmsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPmsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatPmsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponPmsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonPmsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailPmsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabelPemasokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangDataSet = New FormBarang.barangDataSet()
        Me.Tutup = New System.Windows.Forms.Button()
        Me.Batal = New System.Windows.Forms.Button()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Telepon = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.Kode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Person = New System.Windows.Forms.TextBox()
        Me.Tabel_PemasokTableAdapter = New FormBarang.barangDataSetTableAdapters.Tabel_PemasokTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelPemasokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(275, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 21)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Nama"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodePmsDataGridViewTextBoxColumn, Me.NamaPmsDataGridViewTextBoxColumn, Me.AlamatPmsDataGridViewTextBoxColumn, Me.TeleponPmsDataGridViewTextBoxColumn, Me.PersonPmsDataGridViewTextBoxColumn, Me.EmailPmsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TabelPemasokBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 309)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(887, 190)
        Me.DataGridView1.TabIndex = 37
        '
        'KodePmsDataGridViewTextBoxColumn
        '
        Me.KodePmsDataGridViewTextBoxColumn.DataPropertyName = "KodePms"
        Me.KodePmsDataGridViewTextBoxColumn.FillWeight = 64.17112!
        Me.KodePmsDataGridViewTextBoxColumn.HeaderText = "KodePms"
        Me.KodePmsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodePmsDataGridViewTextBoxColumn.Name = "KodePmsDataGridViewTextBoxColumn"
        '
        'NamaPmsDataGridViewTextBoxColumn
        '
        Me.NamaPmsDataGridViewTextBoxColumn.DataPropertyName = "NamaPms"
        Me.NamaPmsDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.NamaPmsDataGridViewTextBoxColumn.HeaderText = "NamaPms"
        Me.NamaPmsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamaPmsDataGridViewTextBoxColumn.Name = "NamaPmsDataGridViewTextBoxColumn"
        '
        'AlamatPmsDataGridViewTextBoxColumn
        '
        Me.AlamatPmsDataGridViewTextBoxColumn.DataPropertyName = "AlamatPms"
        Me.AlamatPmsDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.AlamatPmsDataGridViewTextBoxColumn.HeaderText = "AlamatPms"
        Me.AlamatPmsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AlamatPmsDataGridViewTextBoxColumn.Name = "AlamatPmsDataGridViewTextBoxColumn"
        '
        'TeleponPmsDataGridViewTextBoxColumn
        '
        Me.TeleponPmsDataGridViewTextBoxColumn.DataPropertyName = "TeleponPms"
        Me.TeleponPmsDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.TeleponPmsDataGridViewTextBoxColumn.HeaderText = "TeleponPms"
        Me.TeleponPmsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TeleponPmsDataGridViewTextBoxColumn.Name = "TeleponPmsDataGridViewTextBoxColumn"
        '
        'PersonPmsDataGridViewTextBoxColumn
        '
        Me.PersonPmsDataGridViewTextBoxColumn.DataPropertyName = "PersonPms"
        Me.PersonPmsDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.PersonPmsDataGridViewTextBoxColumn.HeaderText = "PersonPms"
        Me.PersonPmsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PersonPmsDataGridViewTextBoxColumn.Name = "PersonPmsDataGridViewTextBoxColumn"
        '
        'EmailPmsDataGridViewTextBoxColumn
        '
        Me.EmailPmsDataGridViewTextBoxColumn.DataPropertyName = "EmailPms"
        Me.EmailPmsDataGridViewTextBoxColumn.FillWeight = 107.1658!
        Me.EmailPmsDataGridViewTextBoxColumn.HeaderText = "EmailPms"
        Me.EmailPmsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailPmsDataGridViewTextBoxColumn.Name = "EmailPmsDataGridViewTextBoxColumn"
        '
        'TabelPemasokBindingSource
        '
        Me.TabelPemasokBindingSource.DataMember = "Tabel_Pemasok"
        Me.TabelPemasokBindingSource.DataSource = Me.BarangDataSet
        '
        'BarangDataSet
        '
        Me.BarangDataSet.DataSetName = "barangDataSet"
        Me.BarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tutup
        '
        Me.Tutup.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tutup.Location = New System.Drawing.Point(405, 249)
        Me.Tutup.Name = "Tutup"
        Me.Tutup.Size = New System.Drawing.Size(93, 31)
        Me.Tutup.TabIndex = 36
        Me.Tutup.Text = "Tutup"
        Me.Tutup.UseVisualStyleBackColor = True
        '
        'Batal
        '
        Me.Batal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batal.Location = New System.Drawing.Point(279, 249)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(93, 31)
        Me.Batal.TabIndex = 35
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.Location = New System.Drawing.Point(158, 249)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(93, 31)
        Me.Hapus.TabIndex = 34
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simpan.Location = New System.Drawing.Point(35, 249)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(93, 31)
        Me.Simpan.TabIndex = 33
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(332, 31)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(284, 28)
        Me.Nama.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(344, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 21)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Person"
        '
        'Telepon
        '
        Me.Telepon.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telepon.Location = New System.Drawing.Point(127, 129)
        Me.Telepon.Name = "Telepon"
        Me.Telepon.Size = New System.Drawing.Size(199, 28)
        Me.Telepon.TabIndex = 29
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(127, 183)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(489, 28)
        Me.Email.TabIndex = 28
        '
        'Alamat
        '
        Me.Alamat.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alamat.Location = New System.Drawing.Point(126, 82)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(490, 28)
        Me.Alamat.TabIndex = 27
        '
        'Kode
        '
        Me.Kode.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode.Location = New System.Drawing.Point(126, 31)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(140, 28)
        Me.Kode.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Kode"
        '
        'Person
        '
        Me.Person.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Person.Location = New System.Drawing.Point(418, 129)
        Me.Person.Name = "Person"
        Me.Person.Size = New System.Drawing.Size(198, 28)
        Me.Person.TabIndex = 39
        '
        'Tabel_PemasokTableAdapter
        '
        Me.Tabel_PemasokTableAdapter.ClearBeforeFill = True
        '
        'Pemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(911, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.Person)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Tutup)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Simpan)
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
        Me.Name = "Pemasok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pemasok"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelPemasokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Tutup As Button
    Friend WithEvents Batal As Button
    Friend WithEvents Hapus As Button
    Friend WithEvents Simpan As Button
    Friend WithEvents Nama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Telepon As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Alamat As TextBox
    Friend WithEvents Kode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Person As TextBox
    Friend WithEvents BarangDataSet As barangDataSet
    Friend WithEvents TabelPemasokBindingSource As BindingSource
    Friend WithEvents Tabel_PemasokTableAdapter As barangDataSetTableAdapters.Tabel_PemasokTableAdapter
    Friend WithEvents KodePmsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPmsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatPmsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeleponPmsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonPmsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailPmsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
