﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRiwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRiwayat))
        Panel2 = New Panel()
<<<<<<< HEAD
        btnRefresh = New Button()
        btnFilter = New Button()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
=======
        btnSearch = New Button()
        btnFilterKeluar = New Button()
        btnRefresh = New Button()
        btnFilterMasuk = New Button()
        DateTimePicker1 = New DateTimePicker()
        txtsearch = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> checkpoint3
        SuspendLayout()
        ' 
        ' Panel2
        ' 
<<<<<<< HEAD
        Panel2.Controls.Add(btnRefresh)
        Panel2.Controls.Add(btnFilter)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(12, 331)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(776, 107)
        Panel2.TabIndex = 6
        ' 
=======
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(btnFilterKeluar)
        Panel2.Controls.Add(btnRefresh)
        Panel2.Controls.Add(btnFilterMasuk)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(txtsearch)
        Panel2.Location = New Point(12, 498)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(976, 107)
        Panel2.TabIndex = 6
        ' 
        ' btnSearch
        ' 
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(16, 50)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(177, 33)
        btnSearch.TabIndex = 5
        btnSearch.Text = "S E A R C H   N O P O L"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnFilterKeluar
        ' 
        btnFilterKeluar.FlatStyle = FlatStyle.Flat
        btnFilterKeluar.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFilterKeluar.ForeColor = Color.White
        btnFilterKeluar.Location = New Point(530, 50)
        btnFilterKeluar.Name = "btnFilterKeluar"
        btnFilterKeluar.Size = New Size(127, 23)
        btnFilterKeluar.TabIndex = 4
        btnFilterKeluar.Text = "Filter Waktu Keluar"
        btnFilterKeluar.UseVisualStyleBackColor = True
        ' 
>>>>>>> checkpoint3
        ' btnRefresh
        ' 
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
<<<<<<< HEAD
        btnRefresh.Location = New Point(663, 65)
=======
        btnRefresh.Location = New Point(859, 61)
>>>>>>> checkpoint3
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(104, 32)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh Tabel"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
<<<<<<< HEAD
        ' btnFilter
        ' 
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFilter.ForeColor = Color.White
        btnFilter.Location = New Point(447, 21)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(127, 23)
        btnFilter.TabIndex = 2
        btnFilter.Text = "Filter Waktu Masuk"
        btnFilter.UseVisualStyleBackColor = True
=======
        ' btnFilterMasuk
        ' 
        btnFilterMasuk.FlatStyle = FlatStyle.Flat
        btnFilterMasuk.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFilterMasuk.ForeColor = Color.White
        btnFilterMasuk.Location = New Point(530, 21)
        btnFilterMasuk.Name = "btnFilterMasuk"
        btnFilterMasuk.Size = New Size(127, 23)
        btnFilterMasuk.TabIndex = 2
        btnFilterMasuk.Text = "Filter Waktu Masuk"
        btnFilterMasuk.UseVisualStyleBackColor = True
>>>>>>> checkpoint3
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
<<<<<<< HEAD
        DateTimePicker1.Location = New Point(238, 21)
=======
        DateTimePicker1.Location = New Point(321, 21)
>>>>>>> checkpoint3
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(203, 23)
        DateTimePicker1.TabIndex = 1
        ' 
<<<<<<< HEAD
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(16, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 23)
        TextBox1.TabIndex = 0
=======
        ' txtsearch
        ' 
        txtsearch.BorderStyle = BorderStyle.FixedSingle
        txtsearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtsearch.Location = New Point(16, 21)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(177, 25)
        txtsearch.TabIndex = 0
        txtsearch.TextAlign = HorizontalAlignment.Center
>>>>>>> checkpoint3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
<<<<<<< HEAD
        Label1.Location = New Point(-3, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(807, 28)
        Label1.TabIndex = 5
        Label1.Text = "---------------------------- R I W A Y A T   K E N D A R A A N ----------------------------"
=======
        Label1.Location = New Point(-7, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(1015, 28)
        Label1.TabIndex = 5
        Label1.Text = "----------------------------------------- R I W A Y A T   K E N D A R A A N -----------------------------------------"
>>>>>>> checkpoint3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
<<<<<<< HEAD
        Panel1.Location = New Point(12, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 275)
        Panel1.TabIndex = 4
        ' 
=======
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(12, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(976, 427)
        Panel1.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.LightSteelBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(968, 419)
        DataGridView1.TabIndex = 0
        ' 
>>>>>>> checkpoint3
        ' FormRiwayat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
<<<<<<< HEAD
        ClientSize = New Size(800, 446)
=======
        ClientSize = New Size(1000, 617)
>>>>>>> checkpoint3
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormRiwayat"
        Text = "FormRiwayat"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
<<<<<<< HEAD
=======
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
>>>>>>> checkpoint3
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
<<<<<<< HEAD
    Friend WithEvents btnFilter As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRefresh As Button
=======
    Friend WithEvents btnFilterMasuk As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnFilterKeluar As Button
    Friend WithEvents btnSearch As Button
>>>>>>> checkpoint3
End Class
