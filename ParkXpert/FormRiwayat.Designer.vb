<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        btnRefresh = New Button()
        btnFilter = New Button()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnRefresh)
        Panel2.Controls.Add(btnFilter)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(12, 331)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(776, 107)
        Panel2.TabIndex = 6
        ' 
        ' btnRefresh
        ' 
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(663, 65)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(104, 32)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh Tabel"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
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
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(238, 21)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(203, 23)
        DateTimePicker1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(16, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(-3, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(807, 28)
        Label1.TabIndex = 5
        Label1.Text = "---------------------------- R I W A Y A T   K E N D A R A A N ----------------------------"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(12, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 275)
        Panel1.TabIndex = 4
        ' 
        ' FormRiwayat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(800, 446)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormRiwayat"
        Text = "FormRiwayat"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFilter As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRefresh As Button
End Class
