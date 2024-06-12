<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtama))
        Panel1 = New Panel()
        Panel6 = New Panel()
        Label1 = New Label()
        profilAkses = New Label()
        profilUname = New Label()
        profilNama = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        btnPembayaran = New CheckBox()
        btnInput = New CheckBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        btnexit = New Button()
        btnmin = New Button()
        Body = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(profilAkses)
        Panel1.Controls.Add(profilUname)
        Panel1.Controls.Add(profilNama)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 139)
        Panel1.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(300, 24)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1000, 617)
        Panel6.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(227, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 4
        Label1.Text = "Logout"
        ' 
        ' profilAkses
        ' 
        profilAkses.AutoSize = True
        profilAkses.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        profilAkses.ForeColor = Color.White
        profilAkses.Location = New Point(101, 77)
        profilAkses.Name = "profilAkses"
        profilAkses.Size = New Size(41, 17)
        profilAkses.TabIndex = 3
        profilAkses.Text = "Akses"
        ' 
        ' profilUname
        ' 
        profilUname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        profilUname.AutoSize = True
        profilUname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        profilUname.ForeColor = Color.White
        profilUname.Location = New Point(101, 55)
        profilUname.Name = "profilUname"
        profilUname.Size = New Size(83, 21)
        profilUname.TabIndex = 2
        profilUname.Text = "Username"
        ' 
        ' profilNama
        ' 
        profilNama.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        profilNama.AutoSize = True
        profilNama.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        profilNama.ForeColor = Color.White
        profilNama.Location = New Point(101, 31)
        profilNama.Name = "profilNama"
        profilNama.Size = New Size(64, 25)
        profilNama.TabIndex = 1
        profilNama.Text = "Nama"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(15, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MidnightBlue
        Panel2.Controls.Add(btnPembayaran)
        Panel2.Controls.Add(btnInput)
        Panel2.Location = New Point(0, 140)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 407)
        Panel2.TabIndex = 1
        ' 
        ' btnPembayaran
        ' 
        btnPembayaran.Appearance = Appearance.Button
        btnPembayaran.AutoSize = True
        btnPembayaran.BackgroundImageLayout = ImageLayout.None
        btnPembayaran.FlatStyle = FlatStyle.Flat
        btnPembayaran.Font = New Font("Sitka Small", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPembayaran.ForeColor = Color.White
        btnPembayaran.Image = CType(resources.GetObject("btnPembayaran.Image"), Image)
        btnPembayaran.ImageAlign = ContentAlignment.MiddleLeft
        btnPembayaran.Location = New Point(-1, 56)
        btnPembayaran.Name = "btnPembayaran"
        btnPembayaran.Size = New Size(306, 46)
        btnPembayaran.TabIndex = 2
        btnPembayaran.Text = "PEMBAYARAN                "
        btnPembayaran.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPembayaran.UseVisualStyleBackColor = False
        ' 
        ' btnInput
        ' 
        btnInput.Appearance = Appearance.Button
        btnInput.AutoSize = True
        btnInput.BackgroundImageLayout = ImageLayout.None
        btnInput.FlatStyle = FlatStyle.Flat
        btnInput.Font = New Font("Sitka Small", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnInput.ForeColor = Color.White
        btnInput.Image = CType(resources.GetObject("btnInput.Image"), Image)
        btnInput.ImageAlign = ContentAlignment.MiddleLeft
        btnInput.Location = New Point(-1, 5)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(305, 46)
        btnInput.TabIndex = 1
        btnInput.Text = "INPUT KENDARAAN     "
        btnInput.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInput.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.MidnightBlue
        Panel3.Location = New Point(0, 548)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(300, 93)
        Panel3.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LimeGreen
        Panel4.Location = New Point(0, 640)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1300, 8)
        Panel4.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.LimeGreen
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(btnexit)
        Panel5.Controls.Add(btnmin)
        Panel5.Location = New Point(300, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1000, 25)
        Panel5.TabIndex = 3
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Panel8)
        Panel7.Location = New Point(0, 24)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(200, 100)
        Panel7.TabIndex = 4
        ' 
        ' Panel8
        ' 
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(200, 100)
        Panel8.TabIndex = 4
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.LimeGreen
        btnexit.FlatStyle = FlatStyle.Flat
        btnexit.Font = New Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnexit.ForeColor = Color.White
        btnexit.Location = New Point(975, 0)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(25, 25)
        btnexit.TabIndex = 5
        btnexit.Text = "X"
        btnexit.TextAlign = ContentAlignment.TopCenter
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnmin
        ' 
        btnmin.BackColor = Color.LimeGreen
        btnmin.FlatStyle = FlatStyle.Flat
        btnmin.Font = New Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnmin.ForeColor = Color.White
        btnmin.Location = New Point(951, 0)
        btnmin.Name = "btnmin"
        btnmin.Size = New Size(25, 25)
        btnmin.TabIndex = 4
        btnmin.Text = "_"
        btnmin.TextAlign = ContentAlignment.TopCenter
        btnmin.UseVisualStyleBackColor = False
        ' 
        ' Body
        ' 
        Body.BorderStyle = BorderStyle.FixedSingle
        Body.Location = New Point(300, 24)
        Body.Name = "Body"
        Body.Size = New Size(1000, 617)
        Body.TabIndex = 4
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1300, 648)
        Controls.Add(Body)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormUtama"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents profilNama As Label
    Friend WithEvents profilAkses As Label
    Friend WithEvents profilUname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmin As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnInput As CheckBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Body As Panel
    Friend WithEvents btnPembayaran As CheckBox
End Class
