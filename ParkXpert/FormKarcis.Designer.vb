<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKarcis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKarcis))
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
<<<<<<< HEAD
        Panel2 = New Panel()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
=======
        pbQRCode = New PictureBox()
        lblpetugas = New Label()
        lblwaktu = New Label()
        lblnopol = New Label()
        lbljenis = New Label()
        lblid = New Label()
        Label15 = New Label()
>>>>>>> checkpoint3
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
<<<<<<< HEAD
        Label7 = New Label()
        Label6 = New Label()
=======
>>>>>>> checkpoint3
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnPrint = New Button()
<<<<<<< HEAD
        btnClear = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
=======
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(pbQRCode, ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> checkpoint3
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox1)
<<<<<<< HEAD
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
=======
        Panel1.Controls.Add(lblpetugas)
        Panel1.Controls.Add(lblwaktu)
        Panel1.Controls.Add(lblnopol)
        Panel1.Controls.Add(lbljenis)
        Panel1.Controls.Add(lblid)
        Panel1.Controls.Add(Label15)
>>>>>>> checkpoint3
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
<<<<<<< HEAD
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
=======
>>>>>>> checkpoint3
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(481, 165)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
<<<<<<< HEAD
        GroupBox1.Controls.Add(Panel2)
=======
        GroupBox1.Controls.Add(pbQRCode)
>>>>>>> checkpoint3
        GroupBox1.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(317, 8)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(145, 145)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Scan Disini"
        ' 
<<<<<<< HEAD
        ' Panel2
        ' 
        Panel2.Location = New Point(12, 16)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(120, 120)
        Panel2.TabIndex = 0
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(141, 123)
        Label21.Name = "Label21"
        Label21.Size = New Size(12, 15)
        Label21.TabIndex = 19
        Label21.Text = "-"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(141, 106)
        Label20.Name = "Label20"
        Label20.Size = New Size(12, 15)
        Label20.TabIndex = 18
        Label20.Text = "-"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(141, 89)
        Label19.Name = "Label19"
        Label19.Size = New Size(12, 15)
        Label19.TabIndex = 17
        Label19.Text = "-"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(141, 55)
        Label18.Name = "Label18"
        Label18.Size = New Size(12, 15)
        Label18.TabIndex = 16
        Label18.Text = "-"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(141, 38)
        Label17.Name = "Label17"
        Label17.Size = New Size(12, 15)
        Label17.TabIndex = 15
        Label17.Text = "-"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(141, 21)
        Label16.Name = "Label16"
        Label16.Size = New Size(12, 15)
        Label16.TabIndex = 14
        Label16.Text = "-"
=======
        ' pbQRCode
        ' 
        pbQRCode.Location = New Point(13, 17)
        pbQRCode.Name = "pbQRCode"
        pbQRCode.Size = New Size(120, 120)
        pbQRCode.TabIndex = 0
        pbQRCode.TabStop = False
        ' 
        ' lblpetugas
        ' 
        lblpetugas.AutoSize = True
        lblpetugas.Font = New Font("Cambria", 11.25F)
        lblpetugas.Location = New Point(139, 116)
        lblpetugas.Name = "lblpetugas"
        lblpetugas.Size = New Size(13, 17)
        lblpetugas.TabIndex = 19
        lblpetugas.Text = "-"
        ' 
        ' lblwaktu
        ' 
        lblwaktu.AutoSize = True
        lblwaktu.Font = New Font("Cambria", 11.25F)
        lblwaktu.Location = New Point(139, 93)
        lblwaktu.Name = "lblwaktu"
        lblwaktu.Size = New Size(13, 17)
        lblwaktu.TabIndex = 18
        lblwaktu.Text = "-"
        ' 
        ' lblnopol
        ' 
        lblnopol.AutoSize = True
        lblnopol.Font = New Font("Cambria", 11.25F)
        lblnopol.Location = New Point(139, 70)
        lblnopol.Name = "lblnopol"
        lblnopol.Size = New Size(13, 17)
        lblnopol.TabIndex = 16
        lblnopol.Text = "-"
        ' 
        ' lbljenis
        ' 
        lbljenis.AutoSize = True
        lbljenis.Font = New Font("Cambria", 11.25F)
        lbljenis.Location = New Point(139, 47)
        lbljenis.Name = "lbljenis"
        lbljenis.Size = New Size(13, 17)
        lbljenis.TabIndex = 15
        lbljenis.Text = "-"
        ' 
        ' lblid
        ' 
        lblid.AutoSize = True
        lblid.Font = New Font("Cambria", 11.25F)
        lblid.Location = New Point(139, 24)
        lblid.Name = "lblid"
        lblid.Size = New Size(13, 17)
        lblid.TabIndex = 14
        lblid.Text = "-"
>>>>>>> checkpoint3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
<<<<<<< HEAD
        Label15.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(123, 126)
        Label15.Name = "Label15"
        Label15.Size = New Size(12, 12)
        Label15.TabIndex = 13
        Label15.Text = ":"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(123, 109)
        Label14.Name = "Label14"
        Label14.Size = New Size(12, 12)
        Label14.TabIndex = 12
        Label14.Text = ":"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(123, 92)
        Label13.Name = "Label13"
        Label13.Size = New Size(12, 12)
        Label13.TabIndex = 11
        Label13.Text = ":"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(123, 75)
        Label12.Name = "Label12"
        Label12.Size = New Size(12, 12)
=======
        Label15.Font = New Font("Lucida Console", 9.75F)
        Label15.Location = New Point(122, 120)
        Label15.Name = "Label15"
        Label15.Size = New Size(15, 13)
        Label15.TabIndex = 13
        Label15.Text = ":"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Console", 9.75F)
        Label12.Location = New Point(122, 97)
        Label12.Name = "Label12"
        Label12.Size = New Size(15, 13)
>>>>>>> checkpoint3
        Label12.TabIndex = 10
        Label12.Text = ":"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
<<<<<<< HEAD
        Label11.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(123, 58)
        Label11.Name = "Label11"
        Label11.Size = New Size(12, 12)
=======
        Label11.Font = New Font("Lucida Console", 9.75F)
        Label11.Location = New Point(122, 74)
        Label11.Name = "Label11"
        Label11.Size = New Size(15, 13)
>>>>>>> checkpoint3
        Label11.TabIndex = 9
        Label11.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
<<<<<<< HEAD
        Label10.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(123, 41)
        Label10.Name = "Label10"
        Label10.Size = New Size(12, 12)
=======
        Label10.Font = New Font("Lucida Console", 9.75F)
        Label10.Location = New Point(122, 51)
        Label10.Name = "Label10"
        Label10.Size = New Size(15, 13)
>>>>>>> checkpoint3
        Label10.TabIndex = 8
        Label10.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
<<<<<<< HEAD
        Label9.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(123, 25)
        Label9.Name = "Label9"
        Label9.Size = New Size(12, 12)
=======
        Label9.Font = New Font("Lucida Console", 9.75F)
        Label9.Location = New Point(122, 28)
        Label9.Name = "Label9"
        Label9.Size = New Size(15, 13)
>>>>>>> checkpoint3
        Label9.TabIndex = 7
        Label9.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
<<<<<<< HEAD
        Label8.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 126)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 12)
        Label8.TabIndex = 6
        Label8.Text = "Petugas"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(28, 109)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 12)
        Label7.TabIndex = 5
        Label7.Text = "Waktu Masuk"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(28, 92)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 12)
        Label6.TabIndex = 4
        Label6.Text = "Hari/Tanggal"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 12)
=======
        Label8.Font = New Font("Lucida Console", 9.75F)
        Label8.Location = New Point(12, 120)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 13)
        Label8.TabIndex = 6
        Label8.Text = "Petugas"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Console", 9.75F)
        Label5.Location = New Point(12, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 13)
>>>>>>> checkpoint3
        Label5.TabIndex = 3
        Label5.Text = "Waktu Masuk"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
<<<<<<< HEAD
        Label4.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 12)
=======
        Label4.Font = New Font("Lucida Console", 9.75F)
        Label4.Location = New Point(12, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 13)
>>>>>>> checkpoint3
        Label4.TabIndex = 2
        Label4.Text = "No. Kendaraan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
<<<<<<< HEAD
        Label3.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 12)
=======
        Label3.Font = New Font("Lucida Console", 9.75F)
        Label3.Location = New Point(12, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 13)
>>>>>>> checkpoint3
        Label3.TabIndex = 1
        Label3.Text = "Jenis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
<<<<<<< HEAD
        Label2.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 12)
=======
        Label2.Font = New Font("Lucida Console", 9.75F)
        Label2.Location = New Point(12, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 13)
>>>>>>> checkpoint3
        Label2.TabIndex = 0
        Label2.Text = "ID Parkir"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(112, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 32)
        Label1.TabIndex = 1
        Label1.Text = "K A R C I S   P A R K I R"
        ' 
        ' btnPrint
        ' 
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.White
<<<<<<< HEAD
        btnPrint.Location = New Point(315, 225)
=======
        btnPrint.Location = New Point(411, 225)
>>>>>>> checkpoint3
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(81, 29)
        btnPrint.TabIndex = 2
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
<<<<<<< HEAD
        ' btnClear
        ' 
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(411, 225)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(81, 29)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
=======
>>>>>>> checkpoint3
        ' FormKarcis
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(505, 264)
<<<<<<< HEAD
        Controls.Add(btnClear)
=======
>>>>>>> checkpoint3
        Controls.Add(btnPrint)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormKarcis"
        Text = "FormKarcis"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
<<<<<<< HEAD
=======
        CType(pbQRCode, ComponentModel.ISupportInitialize).EndInit()
>>>>>>> checkpoint3
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
<<<<<<< HEAD
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
=======
>>>>>>> checkpoint3
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
<<<<<<< HEAD
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
=======
>>>>>>> checkpoint3
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
<<<<<<< HEAD
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
=======
    Friend WithEvents lblpetugas As Label
    Friend WithEvents lblwaktu As Label
    Friend WithEvents lblnopol As Label
    Friend WithEvents lbljenis As Label
    Friend WithEvents lblid As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents pbQRCode As PictureBox
>>>>>>> checkpoint3
End Class
