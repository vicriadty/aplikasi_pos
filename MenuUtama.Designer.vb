<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemakaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerimaanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PencarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RincianTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RincianTransaksiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Status1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.PencarianToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.PemasokToolStripMenuItem, Me.PemakaiToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(76, 26)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'PemasokToolStripMenuItem
        '
        Me.PemasokToolStripMenuItem.Name = "PemasokToolStripMenuItem"
        Me.PemasokToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.PemasokToolStripMenuItem.Text = "Pemasok"
        '
        'PemakaiToolStripMenuItem
        '
        Me.PemakaiToolStripMenuItem.Name = "PemakaiToolStripMenuItem"
        Me.PemakaiToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.PemakaiToolStripMenuItem.Text = "Pemakai"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenerimaanBarangToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(91, 26)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenerimaanBarangToolStripMenuItem
        '
        Me.PenerimaanBarangToolStripMenuItem.Name = "PenerimaanBarangToolStripMenuItem"
        Me.PenerimaanBarangToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.PenerimaanBarangToolStripMenuItem.Text = "Penerimaan Barang"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.PenjualanToolStripMenuItem.Text = "Transaksi Penjualan"
        '
        'PencarianToolStripMenuItem
        '
        Me.PencarianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RincianTransaksiToolStripMenuItem, Me.RincianTransaksiToolStripMenuItem1})
        Me.PencarianToolStripMenuItem.Name = "PencarianToolStripMenuItem"
        Me.PencarianToolStripMenuItem.Size = New System.Drawing.Size(96, 26)
        Me.PencarianToolStripMenuItem.Text = "Pencarian"
        '
        'RincianTransaksiToolStripMenuItem
        '
        Me.RincianTransaksiToolStripMenuItem.Name = "RincianTransaksiToolStripMenuItem"
        Me.RincianTransaksiToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RincianTransaksiToolStripMenuItem.Text = "Rincian Stock"
        '
        'RincianTransaksiToolStripMenuItem1
        '
        Me.RincianTransaksiToolStripMenuItem1.Name = "RincianTransaksiToolStripMenuItem1"
        Me.RincianTransaksiToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.RincianTransaksiToolStripMenuItem1.Text = "Rincian Transaksi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(84, 26)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status1, Me.Status2, Me.Status3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 450)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(859, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status1
        '
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(72, 20)
        Me.Status1.Text = "KodePmk"
        '
        'Status2
        '
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(77, 20)
        Me.Status2.Text = "NamaPmk"
        '
        'Status3
        '
        Me.Status3.Name = "Status3"
        Me.Status3.Size = New System.Drawing.Size(77, 20)
        Me.Status3.Text = "StatusPmk"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(285, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(859, 476)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PencarianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemasokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemakaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenerimaanBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RincianTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RincianTransaksiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Status1 As ToolStripStatusLabel
    Friend WithEvents Status2 As ToolStripStatusLabel
    Friend WithEvents Status3 As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
