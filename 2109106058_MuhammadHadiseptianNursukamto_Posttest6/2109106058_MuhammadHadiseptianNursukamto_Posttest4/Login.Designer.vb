<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.pctBackground = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnGoogle = New System.Windows.Forms.Button()
        Me.btnFacebook = New System.Windows.Forms.Button()
        Me.btnTwitter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDaftar = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.pctBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnMasuk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasuk.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(310, 406)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(333, 48)
        Me.btnMasuk.TabIndex = 0
        Me.btnMasuk.Text = "Login"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(310, 254)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(333, 32)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(310, 330)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(333, 32)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'pctBackground
        '
        Me.pctBackground.BackColor = System.Drawing.Color.White
        Me.pctBackground.Location = New System.Drawing.Point(719, 162)
        Me.pctBackground.Name = "pctBackground"
        Me.pctBackground.Size = New System.Drawing.Size(501, 423)
        Me.pctBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBackground.TabIndex = 3
        Me.pctBackground.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(272, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(986, 568)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.DimGray
        Me.lblUsername.Location = New System.Drawing.Point(306, 227)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(70, 19)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Username"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.White
        Me.Label.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.DimGray
        Me.Label.Location = New System.Drawing.Point(751, 588)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(434, 33)
        Me.Label.TabIndex = 8
        Me.Label.Text = "Jual Beli Mudah Hanya di Tokopaedi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(736, 633)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Gabung dan Rasakan Kemudahan Bertransaksi di Tokopaedi"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.White
        Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.DimGray
        Me.lblPassword.Location = New System.Drawing.Point(306, 303)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 19)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        '
        'btnGoogle
        '
        Me.btnGoogle.BackColor = System.Drawing.Color.Salmon
        Me.btnGoogle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoogle.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoogle.ForeColor = System.Drawing.Color.White
        Me.btnGoogle.Location = New System.Drawing.Point(310, 498)
        Me.btnGoogle.Name = "btnGoogle"
        Me.btnGoogle.Size = New System.Drawing.Size(333, 48)
        Me.btnGoogle.TabIndex = 11
        Me.btnGoogle.Text = "Continue With Google"
        Me.btnGoogle.UseVisualStyleBackColor = False
        '
        'btnFacebook
        '
        Me.btnFacebook.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFacebook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacebook.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacebook.ForeColor = System.Drawing.Color.White
        Me.btnFacebook.Location = New System.Drawing.Point(310, 552)
        Me.btnFacebook.Name = "btnFacebook"
        Me.btnFacebook.Size = New System.Drawing.Size(333, 48)
        Me.btnFacebook.TabIndex = 12
        Me.btnFacebook.Text = "Continue With Facebook"
        Me.btnFacebook.UseVisualStyleBackColor = False
        '
        'btnTwitter
        '
        Me.btnTwitter.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnTwitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTwitter.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwitter.ForeColor = System.Drawing.Color.White
        Me.btnTwitter.Location = New System.Drawing.Point(310, 606)
        Me.btnTwitter.Name = "btnTwitter"
        Me.btnTwitter.Size = New System.Drawing.Size(333, 48)
        Me.btnTwitter.TabIndex = 13
        Me.btnTwitter.Text = "Continue With Twitter"
        Me.btnTwitter.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(306, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Belum punya akun di Tokopaedi?"
        '
        'lblDaftar
        '
        Me.lblDaftar.AutoSize = True
        Me.lblDaftar.BackColor = System.Drawing.Color.White
        Me.lblDaftar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDaftar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaftar.ForeColor = System.Drawing.Color.DimGray
        Me.lblDaftar.Location = New System.Drawing.Point(562, 381)
        Me.lblDaftar.Name = "lblDaftar"
        Me.lblDaftar.Size = New System.Drawing.Size(81, 19)
        Me.lblDaftar.TabIndex = 15
        Me.lblDaftar.Text = "Daftar disini"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(412, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "atau masuk dengan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label5.Location = New System.Drawing.Point(329, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(295, 36)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Good to see you again"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1520, 845)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDaftar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTwitter)
        Me.Controls.Add(Me.btnFacebook)
        Me.Controls.Add(Me.btnGoogle)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pctBackground)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Login"
        Me.Text = "App"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pctBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMasuk As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pctBackground As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnGoogle As Button
    Friend WithEvents btnFacebook As Button
    Friend WithEvents btnTwitter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDaftar As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
