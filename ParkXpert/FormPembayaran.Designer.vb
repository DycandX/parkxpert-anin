﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPembayaran))
        Panel1 = New Panel()
        btnClear = New Button()
        btnCetak = New Button()
        Panel2 = New Panel()
        Label58 = New Label()
        Label57 = New Label()
        lblkembali = New Label()
        lbluang = New Label()
        lbltagihan1 = New Label()
        lblpetugas1 = New Label()
        lbldurasi1 = New Label()
        lblmasuk1 = New Label()
        Label47 = New Label()
        Label46 = New Label()
        Label45 = New Label()
        Label44 = New Label()
        Label43 = New Label()
        Label40 = New Label()
        Label37 = New Label()
        Label36 = New Label()
        Label35 = New Label()
        Label34 = New Label()
        Label29 = New Label()
        Label28 = New Label()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Panel3 = New Panel()
        Label19 = New Label()
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        lbltagihan = New Label()
        lbldurasi = New Label()
        lblmasuk = New Label()
        lblpetugas = New Label()
        lbljenis = New Label()
        lblnopol = New Label()
        lblid = New Label()
        btnBayar = New Button()
        txtuang = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblkeluar = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnCetak)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(12, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(661, 388)
        Panel1.TabIndex = 0
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(485, 347)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(566, 347)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(75, 23)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(lblkeluar)
        Panel2.Controls.Add(Label58)
        Panel2.Controls.Add(Label57)
        Panel2.Controls.Add(lblkembali)
        Panel2.Controls.Add(lbluang)
        Panel2.Controls.Add(lbltagihan1)
        Panel2.Controls.Add(lblpetugas1)
        Panel2.Controls.Add(lbldurasi1)
        Panel2.Controls.Add(lblmasuk1)
        Panel2.Controls.Add(Label47)
        Panel2.Controls.Add(Label46)
        Panel2.Controls.Add(Label45)
        Panel2.Controls.Add(Label44)
        Panel2.Controls.Add(Label43)
        Panel2.Controls.Add(Label40)
        Panel2.Controls.Add(Label37)
        Panel2.Controls.Add(Label36)
        Panel2.Controls.Add(Label35)
        Panel2.Controls.Add(Label34)
        Panel2.Controls.Add(Label29)
        Panel2.Controls.Add(Label28)
        Panel2.Controls.Add(Label27)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(Label25)
        Panel2.Controls.Add(Label24)
        Panel2.Controls.Add(Label23)
        Panel2.Controls.Add(Label22)
        Panel2.Controls.Add(Label21)
        Panel2.Controls.Add(Label20)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(375, 24)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(266, 309)
        Panel2.TabIndex = 1
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label58.Location = New Point(101, 42)
        Label58.Name = "Label58"
        Label58.Size = New Size(18, 19)
        Label58.TabIndex = 47
        Label58.Text = ":"
        ' 
        ' Label57
        ' 
        Label57.AutoSize = True
        Label57.Font = New Font("Consolas", 8.25F)
        Label57.Location = New Point(93, 286)
        Label57.Name = "Label57"
        Label57.Size = New Size(79, 13)
        Label57.TabIndex = 46
        Label57.Text = "Terima Kasih"
        ' 
        ' lblkembali
        ' 
        lblkembali.AutoSize = True
        lblkembali.Font = New Font("Consolas", 8.25F)
        lblkembali.Location = New Point(122, 248)
        lblkembali.Name = "lblkembali"
        lblkembali.Size = New Size(13, 13)
        lblkembali.TabIndex = 45
        lblkembali.Text = "-"
        ' 
        ' lbluang
        ' 
        lbluang.AutoSize = True
        lbluang.Font = New Font("Consolas", 8.25F)
        lbluang.Location = New Point(122, 225)
        lbluang.Name = "lbluang"
        lbluang.Size = New Size(13, 13)
        lbluang.TabIndex = 44
        lbluang.Text = "-"
        ' 
        ' lbltagihan1
        ' 
        lbltagihan1.AutoSize = True
        lbltagihan1.Font = New Font("Consolas", 8.25F)
        lbltagihan1.Location = New Point(122, 202)
        lbltagihan1.Name = "lbltagihan1"
        lbltagihan1.Size = New Size(13, 13)
        lbltagihan1.TabIndex = 43
        lbltagihan1.Text = "-"
        ' 
        ' lblpetugas1
        ' 
        lblpetugas1.AutoSize = True
        lblpetugas1.Font = New Font("Consolas", 8.25F)
        lblpetugas1.Location = New Point(123, 155)
        lblpetugas1.Name = "lblpetugas1"
        lblpetugas1.Size = New Size(13, 13)
        lblpetugas1.TabIndex = 42
        lblpetugas1.Text = "-"
        ' 
        ' lbldurasi1
        ' 
        lbldurasi1.AutoSize = True
        lbldurasi1.Font = New Font("Consolas", 8.25F)
        lbldurasi1.Location = New Point(123, 132)
        lbldurasi1.Name = "lbldurasi1"
        lbldurasi1.Size = New Size(13, 13)
        lbldurasi1.TabIndex = 39
        lbldurasi1.Text = "-"
        ' 
        ' lblmasuk1
        ' 
        lblmasuk1.AutoSize = True
        lblmasuk1.Font = New Font("Consolas", 8.25F)
        lblmasuk1.Location = New Point(123, 86)
        lblmasuk1.Name = "lblmasuk1"
        lblmasuk1.Size = New Size(13, 13)
        lblmasuk1.TabIndex = 37
        lblmasuk1.Text = "-"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Font = New Font("Consolas", 8.25F)
        Label47.Location = New Point(103, 248)
        Label47.Name = "Label47"
        Label47.Size = New Size(13, 13)
        Label47.TabIndex = 36
        Label47.Text = ":"
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Font = New Font("Consolas", 8.25F)
        Label46.Location = New Point(103, 225)
        Label46.Name = "Label46"
        Label46.Size = New Size(13, 13)
        Label46.TabIndex = 35
        Label46.Text = ":"
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Font = New Font("Consolas", 8.25F)
        Label45.Location = New Point(103, 202)
        Label45.Name = "Label45"
        Label45.Size = New Size(13, 13)
        Label45.TabIndex = 34
        Label45.Text = ":"
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Font = New Font("Consolas", 8.25F)
        Label44.Location = New Point(104, 155)
        Label44.Name = "Label44"
        Label44.Size = New Size(13, 13)
        Label44.TabIndex = 33
        Label44.Text = ":"
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Font = New Font("Consolas", 8.25F)
        Label43.Location = New Point(104, 132)
        Label43.Name = "Label43"
        Label43.Size = New Size(13, 13)
        Label43.TabIndex = 32
        Label43.Text = ":"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Consolas", 8.25F)
        Label40.Location = New Point(104, 109)
        Label40.Name = "Label40"
        Label40.Size = New Size(13, 13)
        Label40.TabIndex = 29
        Label40.Text = ":"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Consolas", 8.25F)
        Label37.Location = New Point(104, 86)
        Label37.Name = "Label37"
        Label37.Size = New Size(13, 13)
        Label37.TabIndex = 26
        Label37.Text = ":"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label36.Location = New Point(15, 248)
        Label36.Name = "Label36"
        Label36.Size = New Size(61, 13)
        Label36.TabIndex = 25
        Label36.Text = "Kembalian"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label35.Location = New Point(15, 225)
        Label35.Name = "Label35"
        Label35.Size = New Size(73, 13)
        Label35.TabIndex = 24
        Label35.Text = "Jumlah Uang"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label34.Location = New Point(15, 202)
        Label34.Name = "Label34"
        Label34.Size = New Size(49, 13)
        Label34.TabIndex = 19
        Label34.Text = "Tagihan"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Consolas", 8.25F)
        Label29.Location = New Point(15, 155)
        Label29.Name = "Label29"
        Label29.Size = New Size(49, 13)
        Label29.TabIndex = 19
        Label29.Text = "Petugas"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Consolas", 8.25F)
        Label28.Location = New Point(15, 132)
        Label28.Name = "Label28"
        Label28.Size = New Size(73, 13)
        Label28.TabIndex = 19
        Label28.Text = "Lama Parkir"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Consolas", 8.25F)
        Label27.Location = New Point(15, 109)
        Label27.Name = "Label27"
        Label27.Size = New Size(79, 13)
        Label27.TabIndex = 19
        Label27.Text = "Waktu Keluar"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Consolas", 8.25F)
        Label26.Location = New Point(16, 86)
        Label26.Name = "Label26"
        Label26.Size = New Size(73, 13)
        Label26.TabIndex = 19
        Label26.Text = "Waktu Masuk"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Consolas", 12F)
        Label25.Location = New Point(125, 43)
        Label25.Name = "Label25"
        Label25.Size = New Size(117, 19)
        Label25.TabIndex = 6
        Label25.Text = "No Kendaraan"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Consolas", 12F)
        Label24.Location = New Point(15, 43)
        Label24.Name = "Label24"
        Label24.Size = New Size(54, 19)
        Label24.TabIndex = 5
        Label24.Text = "Jenis"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(-4, 268)
        Label23.Name = "Label23"
        Label23.Size = New Size(272, 15)
        Label23.TabIndex = 4
        Label23.Text = "-----------------------------------------------------"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(-4, 177)
        Label22.Name = "Label22"
        Label22.Size = New Size(272, 15)
        Label22.TabIndex = 3
        Label22.Text = "-----------------------------------------------------"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(-4, 62)
        Label21.Name = "Label21"
        Label21.Size = New Size(272, 15)
        Label21.TabIndex = 2
        Label21.Text = "-----------------------------------------------------"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(-4, 27)
        Label20.Name = "Label20"
        Label20.Size = New Size(272, 15)
        Label20.TabIndex = 1
        Label20.Text = "-----------------------------------------------------"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DimGray
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label19)
        Panel3.Location = New Point(-1, -1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(266, 26)
        Panel3.TabIndex = 0
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.LightGray
        Label19.Location = New Point(6, 3)
        Label19.Name = "Label19"
        Label19.Size = New Size(163, 18)
        Label19.TabIndex = 1
        Label19.Text = "STRUK  PEMBAYARAN"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(lbltagihan)
        GroupBox1.Controls.Add(lbldurasi)
        GroupBox1.Controls.Add(lblmasuk)
        GroupBox1.Controls.Add(lblpetugas)
        GroupBox1.Controls.Add(lbljenis)
        GroupBox1.Controls.Add(lblnopol)
        GroupBox1.Controls.Add(lblid)
        GroupBox1.Controls.Add(btnBayar)
        GroupBox1.Controls.Add(txtuang)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(15, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(330, 355)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tagihan"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(128, 179)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(196, 22)
        DateTimePicker1.TabIndex = 19
        ' 
        ' lbltagihan
        ' 
        lbltagihan.AutoSize = True
        lbltagihan.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbltagihan.Location = New Point(128, 242)
        lbltagihan.Name = "lbltagihan"
        lbltagihan.Size = New Size(11, 15)
        lbltagihan.TabIndex = 18
        lbltagihan.Text = "-"
        ' 
        ' lbldurasi
        ' 
        lbldurasi.AutoSize = True
        lbldurasi.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbldurasi.Location = New Point(128, 212)
        lbldurasi.Name = "lbldurasi"
        lbldurasi.Size = New Size(11, 15)
        lbldurasi.TabIndex = 17
        lbldurasi.Text = "-"
        ' 
        ' lblmasuk
        ' 
        lblmasuk.AutoSize = True
        lblmasuk.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblmasuk.Location = New Point(128, 152)
        lblmasuk.Name = "lblmasuk"
        lblmasuk.Size = New Size(11, 15)
        lblmasuk.TabIndex = 15
        lblmasuk.Text = "-"
        ' 
        ' lblpetugas
        ' 
        lblpetugas.AutoSize = True
        lblpetugas.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblpetugas.Location = New Point(128, 123)
        lblpetugas.Name = "lblpetugas"
        lblpetugas.Size = New Size(11, 15)
        lblpetugas.TabIndex = 14
        lblpetugas.Text = "-"
        ' 
        ' lbljenis
        ' 
        lbljenis.AutoSize = True
        lbljenis.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbljenis.Location = New Point(128, 93)
        lbljenis.Name = "lbljenis"
        lbljenis.Size = New Size(11, 15)
        lbljenis.TabIndex = 13
        lbljenis.Text = "-"
        ' 
        ' lblnopol
        ' 
        lblnopol.AutoSize = True
        lblnopol.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblnopol.Location = New Point(128, 63)
        lblnopol.Name = "lblnopol"
        lblnopol.Size = New Size(11, 15)
        lblnopol.TabIndex = 12
        lblnopol.Text = "-"
        ' 
        ' lblid
        ' 
        lblid.AutoSize = True
        lblid.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblid.Location = New Point(128, 33)
        lblid.Name = "lblid"
        lblid.Size = New Size(11, 15)
        lblid.TabIndex = 11
        lblid.Text = "-"
        ' 
        ' btnBayar
        ' 
        btnBayar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnBayar.FlatStyle = FlatStyle.Flat
        btnBayar.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBayar.Location = New Point(201, 314)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(99, 30)
        btnBayar.TabIndex = 10
        btnBayar.Text = "B A Y A R"
        btnBayar.UseVisualStyleBackColor = False
        ' 
        ' txtuang
        ' 
        txtuang.Location = New Point(116, 277)
        txtuang.Name = "txtuang"
        txtuang.Size = New Size(194, 26)
        txtuang.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(18, 282)
        Label10.Name = "Label10"
        Label10.Size = New Size(76, 15)
        Label10.TabIndex = 8
        Label10.Text = "Jumlah Uang"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(18, 242)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 15)
        Label9.TabIndex = 7
        Label9.Text = "Tagihan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(18, 212)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 15)
        Label8.TabIndex = 6
        Label8.Text = "Lama Parkir"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(18, 182)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 15)
        Label7.TabIndex = 5
        Label7.Text = "Waktu Keluar"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(18, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 15)
        Label6.TabIndex = 4
        Label6.Text = "Waktu Masuk"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(18, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 15)
        Label5.TabIndex = 3
        Label5.Text = "Petugas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(18, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 2
        Label4.Text = "Jenis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 1
        Label3.Text = "No. Kendaraan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 0
        Label2.Text = "ID Parkir"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(-3, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(691, 28)
        Label1.TabIndex = 6
        Label1.Text = "----------------------------- P E M B A Y A R A N -----------------------------"
        ' 
        ' lblkeluar
        ' 
        lblkeluar.AutoSize = True
        lblkeluar.Font = New Font("Consolas", 8.25F)
        lblkeluar.Location = New Point(123, 109)
        lblkeluar.Name = "lblkeluar"
        lblkeluar.Size = New Size(13, 13)
        lblkeluar.TabIndex = 48
        lblkeluar.Text = "-"
        ' 
        ' FormPembayaran
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(685, 450)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormPembayaran"
        Text = "FormPembayaran"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblid As Label
    Friend WithEvents btnBayar As Button
    Friend WithEvents txtuang As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lbltagihan As Label
    Friend WithEvents lbldurasi As Label
    Friend WithEvents lblmasuk As Label
    Friend WithEvents lblpetugas As Label
    Friend WithEvents lbljenis As Label
    Friend WithEvents lblnopol As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents Label57 As Label
    Friend WithEvents lblkembali As Label
    Friend WithEvents lbluang As Label
    Friend WithEvents lbltagihan1 As Label
    Friend WithEvents lblpetugas1 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents lbldurasi1 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label58 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblmasuk1 As Label
    Friend WithEvents lblkeluar As Label
End Class
