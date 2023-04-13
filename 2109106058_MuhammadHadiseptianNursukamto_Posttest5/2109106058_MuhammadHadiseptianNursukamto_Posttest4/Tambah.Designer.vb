<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tambah
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
        Me.txtNamaProduk = New System.Windows.Forms.TextBox()
        Me.txtStokProduk = New System.Windows.Forms.TextBox()
        Me.txtHargaProduk = New System.Windows.Forms.TextBox()
        Me.pctGambarProduk = New System.Windows.Forms.PictureBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.opnfileGambar = New System.Windows.Forms.OpenFileDialog()
        Me.clickMe = New System.Windows.Forms.Button()
        CType(Me.pctGambarProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNamaProduk
        '
        Me.txtNamaProduk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNamaProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaProduk.Location = New System.Drawing.Point(553, 185)
        Me.txtNamaProduk.Name = "txtNamaProduk"
        Me.txtNamaProduk.Size = New System.Drawing.Size(302, 35)
        Me.txtNamaProduk.TabIndex = 0
        '
        'txtStokProduk
        '
        Me.txtStokProduk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStokProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStokProduk.Location = New System.Drawing.Point(553, 267)
        Me.txtStokProduk.Name = "txtStokProduk"
        Me.txtStokProduk.Size = New System.Drawing.Size(302, 35)
        Me.txtStokProduk.TabIndex = 2
        '
        'txtHargaProduk
        '
        Me.txtHargaProduk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHargaProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaProduk.Location = New System.Drawing.Point(553, 349)
        Me.txtHargaProduk.Name = "txtHargaProduk"
        Me.txtHargaProduk.Size = New System.Drawing.Size(302, 35)
        Me.txtHargaProduk.TabIndex = 3
        '
        'pctGambarProduk
        '
        Me.pctGambarProduk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctGambarProduk.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pctGambarProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctGambarProduk.Location = New System.Drawing.Point(906, 185)
        Me.pctGambarProduk.Name = "pctGambarProduk"
        Me.pctGambarProduk.Size = New System.Drawing.Size(199, 199)
        Me.pctGambarProduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctGambarProduk.TabIndex = 4
        Me.pctGambarProduk.TabStop = False
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBatal.BackColor = System.Drawing.Color.Tomato
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(406, 432)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(330, 48)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Kembali"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSimpan.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSimpan.Location = New System.Drawing.Point(775, 432)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(330, 48)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Tambah"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama Produk"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Harga Produk"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(401, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 27)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Stok Produk"
        '
        'clickMe
        '
        Me.clickMe.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.clickMe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clickMe.FlatAppearance.BorderSize = 0
        Me.clickMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clickMe.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clickMe.Location = New System.Drawing.Point(925, 185)
        Me.clickMe.Name = "clickMe"
        Me.clickMe.Size = New System.Drawing.Size(199, 199)
        Me.clickMe.TabIndex = 23
        Me.clickMe.Text = "Click Me"
        Me.clickMe.UseVisualStyleBackColor = False
        '
        'Tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1456, 682)
        Me.Controls.Add(Me.clickMe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.pctGambarProduk)
        Me.Controls.Add(Me.txtHargaProduk)
        Me.Controls.Add(Me.txtStokProduk)
        Me.Controls.Add(Me.txtNamaProduk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tambah"
        Me.Text = "Form3"
        CType(Me.pctGambarProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNamaProduk As TextBox
    Friend WithEvents txtStokProduk As TextBox
    Friend WithEvents txtHargaProduk As TextBox
    Friend WithEvents pctGambarProduk As PictureBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents opnfileGambar As OpenFileDialog
    Friend WithEvents clickMe As Button
End Class
