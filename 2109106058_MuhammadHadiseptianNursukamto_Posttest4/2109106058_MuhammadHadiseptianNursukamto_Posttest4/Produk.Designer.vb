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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnHargaProduk = New System.Windows.Forms.Button()
        Me.btnNamaProduk = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnKodeProduk = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnHargaProduk
        '
        Me.btnHargaProduk.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnHargaProduk.Enabled = False
        Me.btnHargaProduk.FlatAppearance.BorderSize = 0
        Me.btnHargaProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHargaProduk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHargaProduk.Location = New System.Drawing.Point(12, 208)
        Me.btnHargaProduk.Name = "btnHargaProduk"
        Me.btnHargaProduk.Size = New System.Drawing.Size(152, 32)
        Me.btnHargaProduk.TabIndex = 2
        Me.btnHargaProduk.UseVisualStyleBackColor = False
        '
        'btnNamaProduk
        '
        Me.btnNamaProduk.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnNamaProduk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNamaProduk.Enabled = False
        Me.btnNamaProduk.FlatAppearance.BorderSize = 0
        Me.btnNamaProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNamaProduk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNamaProduk.Location = New System.Drawing.Point(12, 170)
        Me.btnNamaProduk.Name = "btnNamaProduk"
        Me.btnNamaProduk.Size = New System.Drawing.Size(152, 32)
        Me.btnNamaProduk.TabIndex = 3
        Me.btnNamaProduk.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(91, 246)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 32)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnKodeProduk
        '
        Me.btnKodeProduk.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnKodeProduk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnKodeProduk.Enabled = False
        Me.btnKodeProduk.FlatAppearance.BorderSize = 0
        Me.btnKodeProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKodeProduk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKodeProduk.Location = New System.Drawing.Point(12, 12)
        Me.btnKodeProduk.Name = "btnKodeProduk"
        Me.btnKodeProduk.Size = New System.Drawing.Size(73, 32)
        Me.btnKodeProduk.TabIndex = 5
        Me.btnKodeProduk.UseVisualStyleBackColor = False
        Me.btnKodeProduk.Visible = False
        '
        'Produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(175, 290)
        Me.Controls.Add(Me.btnKodeProduk)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnNamaProduk)
        Me.Controls.Add(Me.btnHargaProduk)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Produk"
        Me.Text = "template"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnHargaProduk As Button
    Friend WithEvents btnNamaProduk As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnKodeProduk As Button
End Class
