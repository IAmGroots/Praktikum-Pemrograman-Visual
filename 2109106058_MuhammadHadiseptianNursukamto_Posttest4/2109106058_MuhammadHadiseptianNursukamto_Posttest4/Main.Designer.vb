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
        Me.btnLihat = New System.Windows.Forms.Button()
        Me.panelUtama = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLihat
        '
        Me.btnLihat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLihat.BackColor = System.Drawing.Color.LightBlue
        Me.btnLihat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLihat.FlatAppearance.BorderSize = 0
        Me.btnLihat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLihat.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLihat.Location = New System.Drawing.Point(12, 12)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.Size = New System.Drawing.Size(192, 48)
        Me.btnLihat.TabIndex = 1
        Me.btnLihat.Text = "Daftar Produk"
        Me.btnLihat.UseVisualStyleBackColor = False
        '
        'panelUtama
        '
        Me.panelUtama.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelUtama.Location = New System.Drawing.Point(12, 72)
        Me.panelUtama.Name = "panelUtama"
        Me.panelUtama.Size = New System.Drawing.Size(1495, 741)
        Me.panelUtama.TabIndex = 3
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTambah.BackColor = System.Drawing.Color.LightBlue
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTambah.Location = New System.Drawing.Point(217, 12)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(192, 48)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah Produk"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1519, 825)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.panelUtama)
        Me.Controls.Add(Me.btnLihat)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLihat As Button
    Friend WithEvents panelUtama As Panel
    Friend WithEvents btnTambah As Button
End Class
