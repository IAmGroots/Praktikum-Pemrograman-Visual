<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keranjang
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblKosong = New System.Windows.Forms.Label()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalBarang = New System.Windows.Forms.Button()
        Me.TotalHarga = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.FlowLayoutPanel1.Controls.Add(Me.lblKosong)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1276, 733)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'lblKosong
        '
        Me.lblKosong.AutoSize = True
        Me.lblKosong.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKosong.Location = New System.Drawing.Point(3, 0)
        Me.lblKosong.Name = "lblKosong"
        Me.lblKosong.Size = New System.Drawing.Size(247, 27)
        Me.lblKosong.TabIndex = 4
        Me.lblKosong.Text = "Keranjang masih kosong"
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnBayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBayar.FlatAppearance.BorderSize = 0
        Me.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBayar.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.Color.White
        Me.btnBayar.Location = New System.Drawing.Point(1315, 214)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(160, 48)
        Me.btnBayar.TabIndex = 3
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'btnKembali
        '
        Me.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKembali.FlatAppearance.BorderSize = 0
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Location = New System.Drawing.Point(1315, 268)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(160, 48)
        Me.btnKembali.TabIndex = 4
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1305, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ringkasan Belanja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1338, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1338, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Harga"
        '
        'TotalBarang
        '
        Me.TotalBarang.FlatAppearance.BorderSize = 0
        Me.TotalBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TotalBarang.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBarang.Location = New System.Drawing.Point(1315, 81)
        Me.TotalBarang.Name = "TotalBarang"
        Me.TotalBarang.Size = New System.Drawing.Size(160, 48)
        Me.TotalBarang.TabIndex = 8
        Me.TotalBarang.Text = "5"
        Me.TotalBarang.UseVisualStyleBackColor = True
        '
        'TotalHarga
        '
        Me.TotalHarga.FlatAppearance.BorderSize = 0
        Me.TotalHarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TotalHarga.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalHarga.Location = New System.Drawing.Point(1315, 160)
        Me.TotalHarga.Name = "TotalHarga"
        Me.TotalHarga.Size = New System.Drawing.Size(160, 48)
        Me.TotalHarga.TabIndex = 9
        Me.TotalHarga.Text = "Rp 100.000"
        Me.TotalHarga.UseVisualStyleBackColor = True
        '
        'Keranjang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1496, 757)
        Me.Controls.Add(Me.TotalHarga)
        Me.Controls.Add(Me.TotalBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Keranjang"
        Me.Text = "Keranjang"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnBayar As Button
    Friend WithEvents lblKosong As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalBarang As Button
    Friend WithEvents TotalHarga As Button
End Class
