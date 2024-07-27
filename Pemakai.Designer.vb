<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pemakai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pemakai))
        Me.Kode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tutup = New System.Windows.Forms.Button()
        Me.Batal = New System.Windows.Forms.Button()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodePmkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPmkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassPmkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusPmkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabelPemakaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangDataSet = New FormBarang.barangDataSet()
        Me.Tabel_PemakaiTableAdapter = New FormBarang.barangDataSetTableAdapters.Tabel_PemakaiTableAdapter()
        Me.Status = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelPemakaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kode
        '
        Me.Kode.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kode.Location = New System.Drawing.Point(121, 32)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(140, 28)
        Me.Kode.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 21)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Nama"
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(121, 84)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(235, 28)
        Me.Nama.TabIndex = 22
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(28, 140)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 21)
        Me.label3.TabIndex = 25
        Me.label3.Text = "Password"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(121, 137)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(235, 28)
        Me.Password.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Status"
        '
        'Tutup
        '
        Me.Tutup.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tutup.Location = New System.Drawing.Point(402, 254)
        Me.Tutup.Name = "Tutup"
        Me.Tutup.Size = New System.Drawing.Size(93, 31)
        Me.Tutup.TabIndex = 31
        Me.Tutup.Text = "Tutup"
        Me.Tutup.UseVisualStyleBackColor = True
        '
        'Batal
        '
        Me.Batal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batal.Location = New System.Drawing.Point(276, 254)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(93, 31)
        Me.Batal.TabIndex = 30
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.Location = New System.Drawing.Point(155, 254)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(93, 31)
        Me.Hapus.TabIndex = 29
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Simpan.Location = New System.Drawing.Point(32, 254)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(93, 31)
        Me.Simpan.TabIndex = 28
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodePmkDataGridViewTextBoxColumn, Me.NamaPmkDataGridViewTextBoxColumn, Me.PassPmkDataGridViewTextBoxColumn, Me.StatusPmkDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TabelPemakaiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 321)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(503, 206)
        Me.DataGridView1.TabIndex = 32
        '
        'KodePmkDataGridViewTextBoxColumn
        '
        Me.KodePmkDataGridViewTextBoxColumn.DataPropertyName = "KodePmk"
        Me.KodePmkDataGridViewTextBoxColumn.HeaderText = "KodePmk"
        Me.KodePmkDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodePmkDataGridViewTextBoxColumn.Name = "KodePmkDataGridViewTextBoxColumn"
        Me.KodePmkDataGridViewTextBoxColumn.Width = 80
        '
        'NamaPmkDataGridViewTextBoxColumn
        '
        Me.NamaPmkDataGridViewTextBoxColumn.DataPropertyName = "NamaPmk"
        Me.NamaPmkDataGridViewTextBoxColumn.HeaderText = "NamaPmk"
        Me.NamaPmkDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamaPmkDataGridViewTextBoxColumn.Name = "NamaPmkDataGridViewTextBoxColumn"
        Me.NamaPmkDataGridViewTextBoxColumn.Width = 125
        '
        'PassPmkDataGridViewTextBoxColumn
        '
        Me.PassPmkDataGridViewTextBoxColumn.DataPropertyName = "PassPmk"
        Me.PassPmkDataGridViewTextBoxColumn.HeaderText = "PassPmk"
        Me.PassPmkDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PassPmkDataGridViewTextBoxColumn.Name = "PassPmkDataGridViewTextBoxColumn"
        Me.PassPmkDataGridViewTextBoxColumn.Width = 125
        '
        'StatusPmkDataGridViewTextBoxColumn
        '
        Me.StatusPmkDataGridViewTextBoxColumn.DataPropertyName = "StatusPmk"
        Me.StatusPmkDataGridViewTextBoxColumn.HeaderText = "StatusPmk"
        Me.StatusPmkDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusPmkDataGridViewTextBoxColumn.Name = "StatusPmkDataGridViewTextBoxColumn"
        Me.StatusPmkDataGridViewTextBoxColumn.Width = 125
        '
        'TabelPemakaiBindingSource
        '
        Me.TabelPemakaiBindingSource.DataMember = "Tabel_Pemakai"
        Me.TabelPemakaiBindingSource.DataSource = Me.BarangDataSet
        '
        'BarangDataSet
        '
        Me.BarangDataSet.DataSetName = "barangDataSet"
        Me.BarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabel_PemakaiTableAdapter
        '
        Me.Tabel_PemakaiTableAdapter.ClearBeforeFill = True
        '
        'Status
        '
        Me.Status.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"ADMIN", "OPERATOR", "KASIR"})
        Me.Status.Location = New System.Drawing.Point(121, 194)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(235, 29)
        Me.Status.TabIndex = 33
        '
        'Pemakai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(527, 539)
        Me.ControlBox = False
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Tutup)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Kode)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pemakai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pemakai"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelPemakaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Kode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Nama As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tutup As Button
    Friend WithEvents Batal As Button
    Friend WithEvents Hapus As Button
    Friend WithEvents Simpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BarangDataSet As barangDataSet
    Friend WithEvents TabelPemakaiBindingSource As BindingSource
    Friend WithEvents Tabel_PemakaiTableAdapter As barangDataSetTableAdapters.Tabel_PemakaiTableAdapter
    Friend WithEvents KodePmkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPmkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassPmkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusPmkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Status As ComboBox
End Class
