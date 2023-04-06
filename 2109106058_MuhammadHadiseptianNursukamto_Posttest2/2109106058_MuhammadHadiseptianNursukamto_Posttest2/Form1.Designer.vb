<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.txtGaji = New System.Windows.Forms.TextBox()
        Me.txtTnpKet = New System.Windows.Forms.TextBox()
        Me.txtSakit = New System.Windows.Forms.TextBox()
        Me.txtHari = New System.Windows.Forms.TextBox()
        Me.txtIzin = New System.Windows.Forms.TextBox()
        Me.txtTunjangan = New System.Windows.Forms.TextBox()
        Me.txtGjBersih = New System.Windows.Forms.TextBox()
        Me.listData = New System.Windows.Forms.ListView()
        Me.cmbBulan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.errorInput = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtGaji
        '
        Me.txtGaji.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtGaji.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorInput.SetIconPadding(Me.txtGaji, 5)
        Me.txtGaji.Location = New System.Drawing.Point(188, 48)
        Me.txtGaji.Name = "txtGaji"
        Me.txtGaji.Size = New System.Drawing.Size(160, 29)
        Me.txtGaji.TabIndex = 0
        Me.txtGaji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTnpKet
        '
        Me.txtTnpKet.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTnpKet.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorInput.SetIconPadding(Me.txtTnpKet, 5)
        Me.txtTnpKet.Location = New System.Drawing.Point(187, 213)
        Me.txtTnpKet.Name = "txtTnpKet"
        Me.txtTnpKet.Size = New System.Drawing.Size(160, 29)
        Me.txtTnpKet.TabIndex = 1
        Me.txtTnpKet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSakit
        '
        Me.txtSakit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSakit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorInput.SetIconPadding(Me.txtSakit, 5)
        Me.txtSakit.Location = New System.Drawing.Point(188, 102)
        Me.txtSakit.Name = "txtSakit"
        Me.txtSakit.Size = New System.Drawing.Size(160, 29)
        Me.txtSakit.TabIndex = 2
        Me.txtSakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHari
        '
        Me.txtHari.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtHari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtHari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHari.Location = New System.Drawing.Point(527, 102)
        Me.txtHari.Name = "txtHari"
        Me.txtHari.ReadOnly = True
        Me.txtHari.Size = New System.Drawing.Size(160, 29)
        Me.txtHari.TabIndex = 3
        Me.txtHari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIzin
        '
        Me.txtIzin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtIzin.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorInput.SetIconPadding(Me.txtIzin, 5)
        Me.txtIzin.Location = New System.Drawing.Point(188, 157)
        Me.txtIzin.Name = "txtIzin"
        Me.txtIzin.Size = New System.Drawing.Size(160, 29)
        Me.txtIzin.TabIndex = 7
        Me.txtIzin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTunjangan
        '
        Me.txtTunjangan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTunjangan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTunjangan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTunjangan.Location = New System.Drawing.Point(527, 157)
        Me.txtTunjangan.Name = "txtTunjangan"
        Me.txtTunjangan.ReadOnly = True
        Me.txtTunjangan.Size = New System.Drawing.Size(160, 29)
        Me.txtTunjangan.TabIndex = 6
        Me.txtTunjangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGjBersih
        '
        Me.txtGjBersih.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtGjBersih.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtGjBersih.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGjBersih.Location = New System.Drawing.Point(527, 213)
        Me.txtGjBersih.Name = "txtGjBersih"
        Me.txtGjBersih.ReadOnly = True
        Me.txtGjBersih.Size = New System.Drawing.Size(160, 29)
        Me.txtGjBersih.TabIndex = 5
        Me.txtGjBersih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'listData
        '
        Me.listData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listData.HideSelection = False
        Me.listData.Location = New System.Drawing.Point(39, 314)
        Me.listData.Name = "listData"
        Me.listData.Size = New System.Drawing.Size(721, 259)
        Me.listData.TabIndex = 11
        Me.listData.UseCompatibleStateImageBehavior = False
        '
        'cmbBulan
        '
        Me.cmbBulan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cmbBulan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBulan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBulan.FormattingEnabled = True
        Me.cmbBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cmbBulan.Location = New System.Drawing.Point(527, 48)
        Me.cmbBulan.Name = "cmbBulan"
        Me.cmbBulan.Size = New System.Drawing.Size(160, 29)
        Me.cmbBulan.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Gaji Pokok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(466, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Bulan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(377, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Jumlah Hari Kerja"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Sakit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Tanpa Keterangan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(142, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Izin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Tunjangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(424, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Gaji Bersih"
        '
        'btnTambah
        '
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(243, 261)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(104, 35)
        Me.btnTambah.TabIndex = 21
        Me.btnTambah.Text = "Add"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(386, 261)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(104, 35)
        Me.btnKeluar.TabIndex = 23
        Me.btnKeluar.Text = "Exit"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(527, 261)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(104, 35)
        Me.btnHapus.TabIndex = 22
        Me.btnHapus.Text = "Clear"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'errorInput
        '
        Me.errorInput.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 611)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBulan)
        Me.Controls.Add(Me.listData)
        Me.Controls.Add(Me.txtIzin)
        Me.Controls.Add(Me.txtTunjangan)
        Me.Controls.Add(Me.txtGjBersih)
        Me.Controls.Add(Me.txtHari)
        Me.Controls.Add(Me.txtSakit)
        Me.Controls.Add(Me.txtTnpKet)
        Me.Controls.Add(Me.txtGaji)
        Me.Name = "Form1"
        Me.Text = "2109106058 Kalkulasi Gaji"
        CType(Me.errorInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGaji As TextBox
    Friend WithEvents txtTnpKet As TextBox
    Friend WithEvents txtSakit As TextBox
    Friend WithEvents txtHari As TextBox
    Friend WithEvents txtIzin As TextBox
    Friend WithEvents txtTunjangan As TextBox
    Friend WithEvents txtGjBersih As TextBox
    Friend WithEvents listData As ListView
    Friend WithEvents cmbBulan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents errorInput As ErrorProvider
End Class
