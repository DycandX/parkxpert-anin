        Imports System.ComponentModel

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
        components = New Container()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button2 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboBox2 = New ComboBox()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        BindingSource1 = New BindingSource(components)
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(BindingSource1, ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox1, ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(374, 373)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(27, 202)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(0, 0)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightSteelBlue
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Location = New Point(11, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(349, 276)
        Panel2.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(81, 16)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(10, 5, 10, 5)
        Label5.Size = New Size(185, 33)
        Label5.TabIndex = 1
        Label5.Text = "INPUT KENDARAAN"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "    dd / MM / yyyy  -  HH : mm : ss"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(113, 197)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(238, 239)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(113, 239)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 15)
        Label4.TabIndex = 7
        Label4.Text = "Waktu Masuk"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 6
        Label3.Text = "Plat Nomor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 5
        Label2.Text = "Jenis Kendaraan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 4
        Label1.Text = "Petugas"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Anindita Rahma", "Sahardian Putra"})
        ComboBox2.Location = New Point(113, 74)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(200, 23)
        ComboBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(113, 157)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 23)
        TextBox1.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil"})
        ComboBox1.Location = New Point(113, 117)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel4.BackgroundImageLayout = ImageLayout.Center
        Panel4.Controls.Add(PictureBox1)
        Panel4.Location = New Point(12, 10)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(374, 74)
        Panel4.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(374, 101)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(398, 397)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(BindingSource1, ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox1, ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents BindingSource1 As BindingSource

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
