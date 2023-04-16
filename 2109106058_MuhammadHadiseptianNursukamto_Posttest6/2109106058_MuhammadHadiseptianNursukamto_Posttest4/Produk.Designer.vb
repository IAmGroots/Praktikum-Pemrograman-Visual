<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produk
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
        Me.pctProduk = New System.Windows.Forms.PictureBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.HargaProduk = New System.Windows.Forms.Button()
        Me.NamaProduk = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.KodeProduk = New System.Windows.Forms.Button()
        CType(Me.pctProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctProduk
        '
        Me.pctProduk.Location = New System.Drawing.Point(11, 12)
        Me.pctProduk.Name = "pctProduk"
        Me.pctProduk.Size = New System.Drawing.Size(152, 152)
        Me.pctProduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctProduk.TabIndex = 0
        Me.pctProduk.TabStop = False
        '
        'btnUbah
        '
        Me.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUbah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(11, 246)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(73, 32)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'HargaProduk
        '
        Me.HargaProduk.BackColor = System.Drawing.Color.Transparent
        Me.HargaProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HargaProduk.FlatAppearance.BorderSize = 0
        Me.HargaProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HargaProduk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaProduk.Location = New System.Drawing.Point(11, 208)
        Me.HargaProduk.Name = "HargaProduk"
        Me.HargaProduk.Size = New System.Drawing.Size(152, 32)
        Me.HargaProduk.TabIndex = 2
        Me.HargaProduk.Text = "Rp 3.000"
        Me.HargaProduk.UseVisualStyleBackColor = False
        '
        'NamaProduk
        '
        Me.NamaProduk.BackColor = System.Drawing.Color.Transparent
        Me.NamaProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NamaProduk.FlatAppearance.BorderSize = 0
        Me.NamaProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NamaProduk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaProduk.Location = New System.Drawing.Point(11, 170)
        Me.NamaProduk.Name = "NamaProduk"
        Me.NamaProduk.Size = New System.Drawing.Size(152, 32)
        Me.NamaProduk.TabIndex = 3
        Me.NamaProduk.Text = "Penghapus"
        Me.NamaProduk.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(90, 246)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(73, 32)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'KodeProduk
        '
        Me.KodeProduk.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KodeProduk.Cursor = System.Windows.Forms.Cursors.Default
        Me.KodeProduk.Enabled = False
        Me.KodeProduk.FlatAppearance.BorderSize = 0
        Me.KodeProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KodeProduk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeProduk.Location = New System.Drawing.Point(11, 12)
        Me.KodeProduk.Name = "KodeProduk"
        Me.KodeProduk.Size = New System.Drawing.Size(73, 32)
        Me.KodeProduk.TabIndex = 5
        Me.KodeProduk.UseVisualStyleBackColor = False
        Me.KodeProduk.Visible = False
        '
        'Produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(175, 290)
        Me.Controls.Add(Me.KodeProduk)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.NamaProduk)
        Me.Controls.Add(Me.HargaProduk)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.pctProduk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Produk"
        Me.Text = "template"
        CType(Me.pctProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctProduk As PictureBox
    Friend WithEvents btnUbah As Button
    Friend WithEvents HargaProduk As Button
    Friend WithEvents NamaProduk As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents KodeProduk As Button
End Class
