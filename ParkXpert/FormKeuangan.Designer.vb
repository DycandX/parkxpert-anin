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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Panel2 = New Panel()
        cbFilter = New ComboBox()
        Panel3 = New Panel()
        Button2 = New Button()
        btnRefresh = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(-4, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(1009, 28)
        Label1.TabIndex = 1
        Label1.Text = "------------------------------------------ L A P O R A N   K E U A N G A N ------------------------------------------"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cbFilter)
        Panel2.Location = New Point(334, 494)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(193, 100)
        Panel2.TabIndex = 2
        ' 
        ' cbFilter
        ' 
        cbFilter.BackColor = SystemColors.Window
        cbFilter.FlatStyle = FlatStyle.Flat
        cbFilter.FormattingEnabled = True
        cbFilter.Location = New Point(15, 39)
        cbFilter.Name = "cbFilter"
        cbFilter.Size = New Size(161, 23)
        cbFilter.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(btnRefresh)
        Panel3.Location = New Point(526, 494)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(135, 100)
        Panel3.TabIndex = 3
        ' 
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
        ' btnRefresh
        ' 
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Cambria", 11.25F)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(5, 16)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(125, 31)
        btnRefresh.TabIndex = 0
        btnRefresh.Text = "Refresh Tabel"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' FormKeuangan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(1000, 617)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormKeuangan"
        Text = "FormKeuangan"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
