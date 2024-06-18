<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKeuangan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKeuangan))
        Panel1 = New Panel()
<<<<<<< HEAD
=======
        DataGridView1 = New DataGridView()
>>>>>>> checkpoint3
        Label1 = New Label()
        Panel2 = New Panel()
        cbFilter = New ComboBox()
        Panel3 = New Panel()
<<<<<<< HEAD
        Button2 = New Button()
        btnRefresh = New Button()
=======
        btnRefresh = New Button()
        btnImport = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> checkpoint3
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
<<<<<<< HEAD
        Panel1.Location = New Point(12, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 275)
        Panel1.TabIndex = 0
        ' 
=======
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(12, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(976, 418)
        Panel1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.LightSteelBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(968, 410)
        DataGridView1.TabIndex = 0
        ' 
>>>>>>> checkpoint3
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
<<<<<<< HEAD
        Label1.Location = New Point(-8, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(817, 28)
        Label1.TabIndex = 1
        Label1.Text = "------------------------------ L A P O R A N   K E U A N G A N ------------------------------"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cbFilter)
        Panel2.Location = New Point(243, 347)
=======
        Label1.Location = New Point(-4, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(1009, 28)
        Label1.TabIndex = 1
        Label1.Text = "------------------------------------------ L A P O R A N   K E U A N G A N ------------------------------------------"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(cbFilter)
        Panel2.Location = New Point(333, 494)
>>>>>>> checkpoint3
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(193, 100)
        Panel2.TabIndex = 2
        ' 
        ' cbFilter
        ' 
        cbFilter.BackColor = SystemColors.Window
        cbFilter.FlatStyle = FlatStyle.Flat
<<<<<<< HEAD
=======
        cbFilter.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
>>>>>>> checkpoint3
        cbFilter.FormattingEnabled = True
        cbFilter.Location = New Point(15, 39)
        cbFilter.Name = "cbFilter"
        cbFilter.Size = New Size(161, 23)
        cbFilter.TabIndex = 0
        ' 
        ' Panel3
        ' 
<<<<<<< HEAD
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(btnRefresh)
        Panel3.Location = New Point(435, 347)
=======
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnRefresh)
        Panel3.Controls.Add(btnImport)
        Panel3.Location = New Point(525, 494)
>>>>>>> checkpoint3
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(135, 100)
        Panel3.TabIndex = 3
        ' 
<<<<<<< HEAD
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Cambria", 11.25F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(5, 53)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 31)
        Button2.TabIndex = 1
        Button2.Text = "Import to Excel"
        Button2.UseVisualStyleBackColor = True
        ' 
=======
>>>>>>> checkpoint3
        ' btnRefresh
        ' 
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Cambria", 11.25F)
        btnRefresh.ForeColor = Color.White
<<<<<<< HEAD
        btnRefresh.Location = New Point(5, 16)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(125, 31)
        btnRefresh.TabIndex = 0
        btnRefresh.Text = "Refresh Tabel"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
=======
        btnRefresh.Location = New Point(4, 15)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(125, 31)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh Table"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnImport
        ' 
        btnImport.FlatStyle = FlatStyle.Flat
        btnImport.Font = New Font("Cambria", 11.25F)
        btnImport.ForeColor = Color.White
        btnImport.Location = New Point(4, 52)
        btnImport.Name = "btnImport"
        btnImport.Size = New Size(125, 31)
        btnImport.TabIndex = 1
        btnImport.Text = "Import to Excel"
        btnImport.UseVisualStyleBackColor = True
        ' 
>>>>>>> checkpoint3
        ' FormKeuangan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
<<<<<<< HEAD
        ClientSize = New Size(800, 461)
=======
        ClientSize = New Size(1000, 617)
>>>>>>> checkpoint3
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormKeuangan"
        Text = "FormKeuangan"
<<<<<<< HEAD
=======
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
>>>>>>> checkpoint3
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbFilter As ComboBox
    Friend WithEvents Panel3 As Panel
<<<<<<< HEAD
    Friend WithEvents Button2 As Button
=======
    Friend WithEvents btnImport As Button
    Friend WithEvents DataGridView1 As DataGridView
>>>>>>> checkpoint3
    Friend WithEvents btnRefresh As Button
End Class
