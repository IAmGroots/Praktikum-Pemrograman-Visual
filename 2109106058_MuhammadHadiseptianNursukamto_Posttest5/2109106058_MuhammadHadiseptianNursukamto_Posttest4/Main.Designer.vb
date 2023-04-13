<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.panelUtama = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'panelUtama
        '
        Me.panelUtama.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelUtama.BackColor = System.Drawing.SystemColors.Control
        Me.panelUtama.Location = New System.Drawing.Point(13, 75)
        Me.panelUtama.Name = "panelUtama"
        Me.panelUtama.Size = New System.Drawing.Size(1495, 682)
        Me.panelUtama.TabIndex = 3
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.LightGray
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.DimGray
        Me.btnRefresh.Location = New System.Drawing.Point(1110, 20)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 32)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(507, 20)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(544, 32)
        Me.txtCari.TabIndex = 15
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(1051, 20)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(60, 32)
        Me.btnCari.TabIndex = 16
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logo.FlatAppearance.BorderSize = 0
        Me.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logo.Font = New System.Drawing.Font("Bauhaus 93", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.logo.Location = New System.Drawing.Point(12, 10)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(489, 52)
        Me.logo.TabIndex = 8
        Me.logo.Text = "tokopaedi"
        Me.logo.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTambah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.btnTambah.FlatAppearance.BorderSize = 2
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(12, 773)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(1496, 59)
        Me.btnTambah.TabIndex = 18
        Me.btnTambah.Text = "Tambah Produk"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.panelUtama)
        Me.Controls.Add(Me.logo)
        Me.Name = "Main"
        Me.Text = "Administrator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelUtama As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents logo As Button
    Friend WithEvents btnTambah As Button
End Class
