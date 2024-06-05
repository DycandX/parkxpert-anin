<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnexit = New Button()
        btnmin = New Button()
        Panel3 = New Panel()
        Label1 = New Label()
        txtuname = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtPassword = New TextBox()
        cbshowpwd = New CheckBox()
        btnLogin = New Button()
        Timer1 = New Timer(components)
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LimeGreen
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(375, 5)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MidnightBlue
        Panel2.Controls.Add(btnexit)
        Panel2.Controls.Add(btnmin)
        Panel2.Location = New Point(0, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(375, 30)
        Panel2.TabIndex = 1
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.MidnightBlue
        btnexit.FlatStyle = FlatStyle.Flat
        btnexit.ForeColor = Color.White
        btnexit.Location = New Point(335, 0)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(40, 30)
        btnexit.TabIndex = 0
        btnexit.Text = "X"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnmin
        ' 
        btnmin.BackColor = Color.MidnightBlue
        btnmin.FlatStyle = FlatStyle.Flat
        btnmin.ForeColor = Color.White
        btnmin.Location = New Point(296, 0)
        btnmin.Name = "btnmin"
        btnmin.Size = New Size(40, 30)
        btnmin.TabIndex = 0
        btnmin.Text = "_"
        btnmin.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.MidnightBlue
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 440)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(375, 35)
        Panel3.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Print", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label1.Location = New Point(54, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 50)
        Label1.TabIndex = 2
        Label1.Text = "Selamat Datang!"
        ' 
        ' txtuname
        ' 
        txtuname.BackColor = Color.White
        txtuname.BorderStyle = BorderStyle.FixedSingle
        txtuname.Cursor = Cursors.IBeam
        txtuname.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtuname.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        txtuname.Location = New Point(37, 188)
        txtuname.Margin = New Padding(4)
        txtuname.Name = "txtuname"
        txtuname.Size = New Size(299, 24)
        txtuname.TabIndex = 0
        txtuname.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label2.Location = New Point(150, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 16)
        Label2.TabIndex = 5
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Label3.Location = New Point(152, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 16)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        txtPassword.Location = New Point(37, 255)
        txtPassword.Margin = New Padding(4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(299, 24)
        txtPassword.TabIndex = 1
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' cbshowpwd
        ' 
        cbshowpwd.AutoSize = True
        cbshowpwd.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbshowpwd.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        cbshowpwd.Location = New Point(37, 290)
        cbshowpwd.Name = "cbshowpwd"
        cbshowpwd.Size = New Size(114, 19)
        cbshowpwd.TabIndex = 0
        cbshowpwd.Text = "Show Password"
        cbshowpwd.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.White
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnLogin.Location = New Point(37, 353)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(299, 32)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(375, 475)
        Controls.Add(btnLogin)
        Controls.Add(cbshowpwd)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtuname)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnmin As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtuname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cbshowpwd As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Timer1 As Timer

End Class
