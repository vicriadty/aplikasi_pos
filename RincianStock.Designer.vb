<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RincianStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RincianStock))
        Me.CekStok = New System.Windows.Forms.Button()
        Me.Tanggal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Tutup = New System.Windows.Forms.Button()
        Me.Batal = New System.Windows.Forms.Button()
        Me.Cetak = New System.Windows.Forms.Button()
        Me.TotalBarang = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CekStok
        '
        Me.CekStok.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekStok.Location = New System.Drawing.Point(12, 12)
        Me.CekStok.Name = "CekStok"
        Me.CekStok.Size = New System.Drawing.Size(196, 31)
        Me.CekStok.TabIndex = 39
        Me.CekStok.Text = "Cek Stok Minimum"
        Me.CekStok.UseVisualStyleBackColor = True
        '
        'Tanggal
        '
        Me.Tanggal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal.Location = New System.Drawing.Point(335, 15)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(167, 28)
        Me.Tanggal.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Tanggal"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(490, 231)
        Me.DataGridView1.TabIndex = 42
        '
        'Tutup
        '
        Me.Tutup.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tutup.Location = New System.Drawing.Point(209, 286)
        Me.Tutup.Name = "Tutup"
        Me.Tutup.Size = New System.Drawing.Size(93, 31)
        Me.Tutup.TabIndex = 47
        Me.Tutup.Text = "Tutup"
        Me.Tutup.UseVisualStyleBackColor = True
        '
        'Batal
        '
        Me.Batal.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batal.Location = New System.Drawing.Point(110, 286)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(93, 31)
        Me.Batal.TabIndex = 46
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'Cetak
        '
        Me.Cetak.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cetak.Location = New System.Drawing.Point(11, 286)
        Me.Cetak.Name = "Cetak"
        Me.Cetak.Size = New System.Drawing.Size(93, 31)
        Me.Cetak.TabIndex = 45
        Me.Cetak.Text = "Cetak"
        Me.Cetak.UseVisualStyleBackColor = True
        '
        'TotalBarang
        '
        Me.TotalBarang.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBarang.Location = New System.Drawing.Point(357, 286)
        Me.TotalBarang.Name = "TotalBarang"
        Me.TotalBarang.Size = New System.Drawing.Size(145, 28)
        Me.TotalBarang.TabIndex = 48
        '
        'RincianStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(514, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.TotalBarang)
        Me.Controls.Add(Me.Tutup)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.Cetak)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CekStok)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RincianStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RincianStock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CekStok As Button
    Friend WithEvents Tanggal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Tutup As Button
    Friend WithEvents Batal As Button
    Friend WithEvents Cetak As Button
    Friend WithEvents TotalBarang As TextBox
End Class
