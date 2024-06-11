<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInput))
        Panel2 = New Panel()
        Label6 = New Label()
        txttarif = New TextBox()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        btnClear = New Button()
        btnSimpan = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cbPetugas = New ComboBox()
        txtNopol = New TextBox()
        cbKendaraan = New ComboBox()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightSteelBlue
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(txttarif)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnSimpan)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(cbPetugas)
        Panel2.Controls.Add(txtNopol)
        Panel2.Controls.Add(cbKendaraan)
        Panel2.Location = New Point(14, 113)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(404, 429)
        Panel2.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 11.25F)
        Label6.Location = New Point(17, 205)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 22)
        Label6.TabIndex = 12
        Label6.Text = "Tarif"
        ' 
        ' txttarif
        ' 
        txttarif.BorderStyle = BorderStyle.FixedSingle
        txttarif.Location = New Point(146, 203)
        txttarif.Margin = New Padding(3, 4, 3, 4)
        txttarif.Name = "txttarif"
        txttarif.Size = New Size(228, 27)
        txttarif.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(86, 23)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(11, 7, 11, 7)
        Label5.Size = New Size(253, 44)
        Label5.TabIndex = 1
        Label5.Text = "INPUT KENDARAAN"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "    dd / MM / yyyy  -  HH : mm : ss"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(146, 308)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(228, 27)
        DateTimePicker1.TabIndex = 10
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Cambria", 9.75F, FontStyle.Bold)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(289, 372)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(86, 31)
        btnClear.TabIndex = 9
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatStyle = FlatStyle.Popup
        btnSimpan.Font = New Font("Cambria", 9.75F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(146, 372)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(86, 31)
        btnSimpan.TabIndex = 8
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 11.25F)
        Label4.Location = New Point(17, 311)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 22)
        Label4.TabIndex = 7
        Label4.Text = "Waktu Masuk"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 11.25F)
        Label3.Location = New Point(17, 257)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 22)
        Label3.TabIndex = 6
        Label3.Text = "Plat Nomor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 11.25F)
        Label2.Location = New Point(17, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 22)
        Label2.TabIndex = 5
        Label2.Text = "Jenis Kendaraan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 11.25F)
        Label1.Location = New Point(17, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 22)
        Label1.TabIndex = 4
        Label1.Text = "Petugas"
        ' 
        ' cbPetugas
        ' 
        cbPetugas.FormattingEnabled = True
        cbPetugas.Items.AddRange(New Object() {"Anindita Rahma", "Sahardian Putra", "Zulvikar Kharisma"})
        cbPetugas.Location = New Point(146, 99)
        cbPetugas.Margin = New Padding(3, 4, 3, 4)
        cbPetugas.Name = "cbPetugas"
        cbPetugas.Size = New Size(228, 28)
        cbPetugas.TabIndex = 2
        ' 
        ' txtNopol
        ' 
        txtNopol.BorderStyle = BorderStyle.FixedSingle
        txtNopol.Location = New Point(146, 255)
        txtNopol.Margin = New Padding(3, 4, 3, 4)
        txtNopol.Name = "txtNopol"
        txtNopol.Size = New Size(228, 27)
        txtNopol.TabIndex = 1
        ' 
        ' cbKendaraan
        ' 
        cbKendaraan.FormattingEnabled = True
        cbKendaraan.Items.AddRange(New Object() {"Motor", "Mobil"})
        cbKendaraan.Location = New Point(146, 151)
        cbKendaraan.Margin = New Padding(3, 4, 3, 4)
        cbKendaraan.Name = "cbKendaraan"
        cbKendaraan.Size = New Size(228, 28)
        cbKendaraan.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(436, 101)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' frmInput
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(433, 559)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmInput"
        Text = "InputKendaraan"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPetugas As ComboBox
    Friend WithEvents txtNopol As TextBox
    Friend WithEvents cbKendaraan As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttarif As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
