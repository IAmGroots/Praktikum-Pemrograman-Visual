<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembeli
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
        Me.logo = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.pctProfile = New System.Windows.Forms.PictureBox()
        Me.btnKeranjang = New System.Windows.Forms.Button()
        Me.panelUtama = New System.Windows.Forms.Panel()
        CType(Me.pctProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.logo.Location = New System.Drawing.Point(12, 11)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(489, 52)
        Me.logo.TabIndex = 22
        Me.logo.Text = "tokopaedi"
        Me.logo.UseVisualStyleBackColor = False
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
        Me.btnCari.Location = New System.Drawing.Point(1051, 21)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(60, 32)
        Me.btnCari.TabIndex = 24
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(507, 21)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(544, 32)
        Me.txtCari.TabIndex = 23
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
        Me.btnRefresh.Location = New System.Drawing.Point(1110, 21)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 32)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Transparent
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.Black
        Me.btnKeluar.Location = New System.Drawing.Point(1433, 21)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 32)
        Me.btnKeluar.TabIndex = 28
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'pctProfile
        '
        Me.pctProfile.Location = New System.Drawing.Point(1395, 21)
        Me.pctProfile.Name = "pctProfile"
        Me.pctProfile.Size = New System.Drawing.Size(32, 32)
        Me.pctProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctProfile.TabIndex = 27
        Me.pctProfile.TabStop = False
        '
        'btnKeranjang
        '
        Me.btnKeranjang.BackColor = System.Drawing.Color.Transparent
        Me.btnKeranjang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeranjang.FlatAppearance.BorderSize = 0
        Me.btnKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeranjang.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeranjang.ForeColor = System.Drawing.Color.Black
        Me.btnKeranjang.Location = New System.Drawing.Point(1289, 21)
        Me.btnKeranjang.Name = "btnKeranjang"
        Me.btnKeranjang.Size = New System.Drawing.Size(100, 32)
        Me.btnKeranjang.TabIndex = 29
        Me.btnKeranjang.Text = "Keranjang"
        Me.btnKeranjang.UseVisualStyleBackColor = False
        '
        'panelUtama
        '
        Me.panelUtama.Location = New System.Drawing.Point(12, 76)
        Me.panelUtama.Name = "panelUtama"
        Me.panelUtama.Size = New System.Drawing.Size(1496, 757)
        Me.panelUtama.TabIndex = 0
        '
        'Pembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.panelUtama)
        Me.Controls.Add(Me.btnKeranjang)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.pctProfile)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.logo)
        Me.Name = "Pembeli"
        Me.Text = "Pembeli"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pctProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logo As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pctProfile As PictureBox
    Friend WithEvents btnKeranjang As Button
    Friend WithEvents panelUtama As Panel
End Class
