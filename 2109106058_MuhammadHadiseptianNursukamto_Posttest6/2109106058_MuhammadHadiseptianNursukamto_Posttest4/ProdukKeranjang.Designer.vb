<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdukKeranjang
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
        Me.GambarProduk = New System.Windows.Forms.PictureBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.JumlahProduk = New System.Windows.Forms.Button()
        Me.NamaProduk = New System.Windows.Forms.Button()
        Me.HargaProduk = New System.Windows.Forms.Button()
        Me.KodeTransaksi = New System.Windows.Forms.Button()
        CType(Me.GambarProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GambarProduk
        '
        Me.GambarProduk.Location = New System.Drawing.Point(12, 12)
        Me.GambarProduk.Name = "GambarProduk"
        Me.GambarProduk.Size = New System.Drawing.Size(146, 146)
        Me.GambarProduk.TabIndex = 0
        Me.GambarProduk.TabStop = False
        '
        'btnPlus
        '
        Me.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlus.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(268, 88)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(32, 32)
        Me.btnPlus.TabIndex = 2
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinus.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(164, 88)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(32, 32)
        Me.btnMinus.TabIndex = 3
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(164, 126)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(137, 32)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'JumlahProduk
        '
        Me.JumlahProduk.FlatAppearance.BorderSize = 0
        Me.JumlahProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JumlahProduk.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahProduk.Location = New System.Drawing.Point(202, 88)
        Me.JumlahProduk.Name = "JumlahProduk"
        Me.JumlahProduk.Size = New System.Drawing.Size(59, 32)
        Me.JumlahProduk.TabIndex = 6
        Me.JumlahProduk.Text = "999"
        Me.JumlahProduk.UseVisualStyleBackColor = True
        '
        'NamaProduk
        '
        Me.NamaProduk.BackColor = System.Drawing.Color.Transparent
        Me.NamaProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NamaProduk.FlatAppearance.BorderSize = 0
        Me.NamaProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NamaProduk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaProduk.Location = New System.Drawing.Point(164, 12)
        Me.NamaProduk.Name = "NamaProduk"
        Me.NamaProduk.Size = New System.Drawing.Size(136, 32)
        Me.NamaProduk.TabIndex = 11
        Me.NamaProduk.Text = "Penghapus"
        Me.NamaProduk.UseVisualStyleBackColor = False
        '
        'HargaProduk
        '
        Me.HargaProduk.BackColor = System.Drawing.Color.Transparent
        Me.HargaProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HargaProduk.FlatAppearance.BorderSize = 0
        Me.HargaProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HargaProduk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaProduk.Location = New System.Drawing.Point(163, 50)
        Me.HargaProduk.Name = "HargaProduk"
        Me.HargaProduk.Size = New System.Drawing.Size(137, 32)
        Me.HargaProduk.TabIndex = 10
        Me.HargaProduk.Text = "Rp 20.000"
        Me.HargaProduk.UseVisualStyleBackColor = False
        '
        'KodeTransaksi
        '
        Me.KodeTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.KodeTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KodeTransaksi.FlatAppearance.BorderSize = 0
        Me.KodeTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KodeTransaksi.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeTransaksi.Location = New System.Drawing.Point(12, 12)
        Me.KodeTransaksi.Name = "KodeTransaksi"
        Me.KodeTransaksi.Size = New System.Drawing.Size(137, 32)
        Me.KodeTransaksi.TabIndex = 12
        Me.KodeTransaksi.UseVisualStyleBackColor = False
        Me.KodeTransaksi.Visible = False
        '
        'ProdukKeranjang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(313, 170)
        Me.Controls.Add(Me.KodeTransaksi)
        Me.Controls.Add(Me.NamaProduk)
        Me.Controls.Add(Me.HargaProduk)
        Me.Controls.Add(Me.JumlahProduk)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.GambarProduk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProdukKeranjang"
        Me.Text = "ProdukKeranjang"
        CType(Me.GambarProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GambarProduk As PictureBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents JumlahProduk As Button
    Friend WithEvents NamaProduk As Button
    Friend WithEvents HargaProduk As Button
    Friend WithEvents KodeTransaksi As Button
End Class
