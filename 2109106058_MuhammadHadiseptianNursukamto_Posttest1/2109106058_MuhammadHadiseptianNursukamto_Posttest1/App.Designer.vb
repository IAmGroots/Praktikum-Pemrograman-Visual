<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
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
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.txtAwal = New System.Windows.Forms.TextBox()
        Me.txtAkhir = New System.Windows.Forms.TextBox()
        Me.listSatuanAwal = New System.Windows.Forms.ListBox()
        Me.listSatuanAkhir = New System.Windows.Forms.ListBox()
        Me.txtPanah = New System.Windows.Forms.TextBox()
        Me.errorInputTarget = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtJudul = New System.Windows.Forms.TextBox()
        CType(Me.errorInputTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHasil
        '
        Me.txtHasil.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtHasil.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtHasil.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasil.Location = New System.Drawing.Point(89, 85)
        Me.txtHasil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.ReadOnly = True
        Me.txtHasil.Size = New System.Drawing.Size(416, 32)
        Me.txtHasil.TabIndex = 1
        Me.txtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAwal
        '
        Me.txtAwal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAwal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorInputTarget.SetIconPadding(Me.txtAwal, 5)
        Me.txtAwal.Location = New System.Drawing.Point(89, 121)
        Me.txtAwal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAwal.Name = "txtAwal"
        Me.txtAwal.Size = New System.Drawing.Size(175, 32)
        Me.txtAwal.TabIndex = 2
        Me.txtAwal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAkhir
        '
        Me.txtAkhir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAkhir.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtAkhir.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorInputTarget.SetIconPadding(Me.txtAkhir, 5)
        Me.txtAkhir.Location = New System.Drawing.Point(330, 121)
        Me.txtAkhir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAkhir.Name = "txtAkhir"
        Me.txtAkhir.Size = New System.Drawing.Size(175, 32)
        Me.txtAkhir.TabIndex = 3
        Me.txtAkhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'listSatuanAwal
        '
        Me.listSatuanAwal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.listSatuanAwal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listSatuanAwal.FormattingEnabled = True
        Me.listSatuanAwal.ItemHeight = 23
        Me.listSatuanAwal.Items.AddRange(New Object() {"Kilometer (km)", "Hektometer (hm)", "Dekameter (dam)", "Meter (m)", "Desimeter (dm)", "Centimeter (cm)", "Milimeter (mm)"})
        Me.listSatuanAwal.Location = New System.Drawing.Point(89, 157)
        Me.listSatuanAwal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listSatuanAwal.Name = "listSatuanAwal"
        Me.listSatuanAwal.Size = New System.Drawing.Size(175, 165)
        Me.listSatuanAwal.TabIndex = 6
        '
        'listSatuanAkhir
        '
        Me.listSatuanAkhir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.listSatuanAkhir.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listSatuanAkhir.FormattingEnabled = True
        Me.listSatuanAkhir.ItemHeight = 23
        Me.listSatuanAkhir.Items.AddRange(New Object() {"Kilometer (km)", "Hektometer (hm)", "Dekameter (dam)", "Meter (m)", "Desimeter (dm)", "Centimeter (cm)", "Milimeter (mm)"})
        Me.listSatuanAkhir.Location = New System.Drawing.Point(330, 157)
        Me.listSatuanAkhir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listSatuanAkhir.Name = "listSatuanAkhir"
        Me.listSatuanAkhir.Size = New System.Drawing.Size(175, 165)
        Me.listSatuanAkhir.TabIndex = 7
        '
        'txtPanah
        '
        Me.txtPanah.BackColor = System.Drawing.SystemColors.Control
        Me.txtPanah.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanah.Location = New System.Drawing.Point(277, 203)
        Me.txtPanah.Name = "txtPanah"
        Me.txtPanah.ReadOnly = True
        Me.txtPanah.Size = New System.Drawing.Size(41, 41)
        Me.txtPanah.TabIndex = 8
        '
        'errorInputTarget
        '
        Me.errorInputTarget.ContainerControl = Me
        '
        'txtJudul
        '
        Me.txtJudul.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtJudul.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtJudul.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJudul.ForeColor = System.Drawing.Color.Black
        Me.txtJudul.Location = New System.Drawing.Point(89, 46)
        Me.txtJudul.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.ReadOnly = True
        Me.txtJudul.Size = New System.Drawing.Size(416, 35)
        Me.txtJudul.TabIndex = 9
        Me.txtJudul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.txtPanah)
        Me.Controls.Add(Me.listSatuanAkhir)
        Me.Controls.Add(Me.listSatuanAwal)
        Me.Controls.Add(Me.txtAkhir)
        Me.Controls.Add(Me.txtAwal)
        Me.Controls.Add(Me.txtHasil)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "App"
        Me.Text = "Posttest 1 - Konversi Satuan Panjang"
        CType(Me.errorInputTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents txtAwal As TextBox
    Friend WithEvents txtAkhir As TextBox
    Friend WithEvents listSatuanAwal As ListBox
    Friend WithEvents listSatuanAkhir As ListBox
    Friend WithEvents txtPanah As TextBox
    Friend WithEvents errorInputTarget As ErrorProvider
    Friend WithEvents txtJudul As TextBox
End Class
