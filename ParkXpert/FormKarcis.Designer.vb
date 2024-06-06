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
        QRCode = New Panel()
        lblpetugas = New Label()
        lblwaktu = New Label()
        lblnopol = New Label()
        lbljenis = New Label()
        lblid = New Label()
        Label15 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnPrint = New Button()
        btnClear = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(lblpetugas)
        Panel1.Controls.Add(lblwaktu)
        Panel1.Controls.Add(lblnopol)
        Panel1.Controls.Add(lbljenis)
        Panel1.Controls.Add(lblid)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
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
        GroupBox1.Controls.Add(QRCode)
        GroupBox1.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(317, 8)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(145, 145)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Scan Disini"
        ' 
        ' QRCode
        ' 
        QRCode.Location = New Point(12, 16)
        QRCode.Name = "QRCode"
        QRCode.Size = New Size(120, 120)
        QRCode.TabIndex = 0
        ' 
        ' lblpetugas
        ' 
        lblpetugas.AutoSize = True
        lblpetugas.Font = New Font("Cambria", 9.75F)
        lblpetugas.Location = New Point(141, 118)
        lblpetugas.Name = "lblpetugas"
        lblpetugas.Size = New Size(11, 15)
        lblpetugas.TabIndex = 19
        lblpetugas.Text = "-"
        ' 
        ' lblwaktu
        ' 
        lblwaktu.AutoSize = True
        lblwaktu.Font = New Font("Cambria", 9.75F)
        lblwaktu.Location = New Point(141, 95)
        lblwaktu.Name = "lblwaktu"
        lblwaktu.Size = New Size(11, 15)
        lblwaktu.TabIndex = 18
        lblwaktu.Text = "-"
        ' 
        ' lblnopol
        ' 
        lblnopol.AutoSize = True
        lblnopol.Font = New Font("Cambria", 9.75F)
        lblnopol.Location = New Point(141, 72)
        lblnopol.Name = "lblnopol"
        lblnopol.Size = New Size(11, 15)
        lblnopol.TabIndex = 16
        lblnopol.Text = "-"
        ' 
        ' lbljenis
        ' 
        lbljenis.AutoSize = True
        lbljenis.Font = New Font("Cambria", 9.75F)
        lbljenis.Location = New Point(141, 49)
        lbljenis.Name = "lbljenis"
        lbljenis.Size = New Size(11, 15)
        lbljenis.TabIndex = 15
        lbljenis.Text = "-"
        ' 
        ' lblid
        ' 
        lblid.AutoSize = True
        lblid.Font = New Font("Cambria", 9.75F)
        lblid.Location = New Point(141, 26)
        lblid.Name = "lblid"
        lblid.Size = New Size(11, 15)
        lblid.TabIndex = 14
        lblid.Text = "-"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
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
        Label12.TabIndex = 10
        Label12.Text = ":"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Console", 9.75F)
        Label11.Location = New Point(122, 74)
        Label11.Name = "Label11"
        Label11.Size = New Size(15, 13)
        Label11.TabIndex = 9
        Label11.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Console", 9.75F)
        Label10.Location = New Point(122, 51)
        Label10.Name = "Label10"
        Label10.Size = New Size(15, 13)
        Label10.TabIndex = 8
        Label10.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Console", 9.75F)
        Label9.Location = New Point(122, 28)
        Label9.Name = "Label9"
        Label9.Size = New Size(15, 13)
        Label9.TabIndex = 7
        Label9.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
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
        Label5.TabIndex = 3
        Label5.Text = "Waktu Masuk"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Console", 9.75F)
        Label4.Location = New Point(12, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 13)
        Label4.TabIndex = 2
        Label4.Text = "No. Kendaraan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Console", 9.75F)
        Label3.Location = New Point(12, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 13)
        Label3.TabIndex = 1
        Label3.Text = "Jenis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Console", 9.75F)
        Label2.Location = New Point(12, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 13)
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
        btnPrint.Location = New Point(315, 225)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(81, 29)
        btnPrint.TabIndex = 2
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
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
        ' FormKarcis
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(505, 264)
        Controls.Add(btnClear)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QRCode As Panel
    Friend WithEvents lblpetugas As Label
    Friend WithEvents lblwaktu As Label
    Friend WithEvents lblnopol As Label
    Friend WithEvents lbljenis As Label
    Friend WithEvents lblid As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
End Class
