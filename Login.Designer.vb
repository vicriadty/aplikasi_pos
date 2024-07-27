<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(348, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOG IN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 501)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(247, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(370, 445)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(194, 32)
        Me.Username.TabIndex = 3
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(370, 498)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(194, 32)
        Me.Password.TabIndex = 4
        Me.Password.UseSystemPasswordChar = True
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Blue
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogin.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLogin.Location = New System.Drawing.Point(370, 548)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(88, 35)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Red
        Me.BtnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTutup.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTutup.Location = New System.Drawing.Point(473, 548)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(91, 35)
        Me.BtnTutup.TabIndex = 6
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(302, 599)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Copyright @ 2024 Moh Vicri Aditiya"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 629)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
