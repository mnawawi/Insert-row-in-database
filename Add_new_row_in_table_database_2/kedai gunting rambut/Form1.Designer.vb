<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.GuntingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.GuntingDataSet = New kedai_gunting_rambut.GuntingDataSet()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Button4 = New System.Windows.Forms.Button()
    Me.Button5 = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ServicesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Button7 = New System.Windows.Forms.Button()
    Me.GuntingTableAdapter = New kedai_gunting_rambut.GuntingDataSetTableAdapters.guntingTableAdapter()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.RadioButton3 = New System.Windows.Forms.RadioButton()
    Me.RadioButton4 = New System.Windows.Forms.RadioButton()
    Me.RadioButton5 = New System.Windows.Forms.RadioButton()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.RadioButton1 = New System.Windows.Forms.RadioButton()
    Me.RadioButton6 = New System.Windows.Forms.RadioButton()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    CType(Me.GuntingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GuntingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.SuspendLayout()
    '
    'TextBox1
    '
    resources.ApplyResources(Me.TextBox1, "TextBox1")
    Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuntingBindingSource, "Customer Name", True))
    Me.TextBox1.Name = "TextBox1"
    '
    'GuntingBindingSource
    '
    Me.GuntingBindingSource.DataMember = "gunting"
    Me.GuntingBindingSource.DataSource = Me.GuntingDataSet
    '
    'GuntingDataSet
    '
    Me.GuntingDataSet.DataSetName = "GuntingDataSet"
    Me.GuntingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'Button4
    '
    resources.ApplyResources(Me.Button4, "Button4")
    Me.Button4.Name = "Button4"
    Me.Button4.UseVisualStyleBackColor = True
    '
    'Button5
    '
    resources.ApplyResources(Me.Button5, "Button5")
    Me.Button5.Name = "Button5"
    Me.Button5.UseVisualStyleBackColor = True
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuntingBindingSource, "Date & Time", True))
    Me.Label3.Name = "Label3"
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToOrderColumns = True
    resources.ApplyResources(Me.DataGridView1, "DataGridView1")
    Me.DataGridView1.AutoGenerateColumns = False
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerNameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.ServicesDataGridViewTextBoxColumn, Me.DateTimeDataGridViewTextBoxColumn})
    Me.DataGridView1.DataSource = Me.GuntingBindingSource
    Me.DataGridView1.Name = "DataGridView1"
    '
    'CustomerNameDataGridViewTextBoxColumn
    '
    Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name"
    resources.ApplyResources(Me.CustomerNameDataGridViewTextBoxColumn, "CustomerNameDataGridViewTextBoxColumn")
    Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
    '
    'AgeDataGridViewTextBoxColumn
    '
    Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
    resources.ApplyResources(Me.AgeDataGridViewTextBoxColumn, "AgeDataGridViewTextBoxColumn")
    Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
    '
    'ServicesDataGridViewTextBoxColumn
    '
    Me.ServicesDataGridViewTextBoxColumn.DataPropertyName = "Services"
    resources.ApplyResources(Me.ServicesDataGridViewTextBoxColumn, "ServicesDataGridViewTextBoxColumn")
    Me.ServicesDataGridViewTextBoxColumn.Name = "ServicesDataGridViewTextBoxColumn"
    '
    'DateTimeDataGridViewTextBoxColumn
    '
    Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date & Time"
    resources.ApplyResources(Me.DateTimeDataGridViewTextBoxColumn, "DateTimeDataGridViewTextBoxColumn")
    Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
    '
    'Button7
    '
    resources.ApplyResources(Me.Button7, "Button7")
    Me.Button7.Name = "Button7"
    Me.Button7.UseVisualStyleBackColor = True
    '
    'GuntingTableAdapter
    '
    Me.GuntingTableAdapter.ClearBeforeFill = True
    '
    'Label6
    '
    resources.ApplyResources(Me.Label6, "Label6")
    Me.Label6.Name = "Label6"
    '
    'RadioButton3
    '
    resources.ApplyResources(Me.RadioButton3, "RadioButton3")
    Me.RadioButton3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuntingBindingSource, "Services", True))
    Me.RadioButton3.ForeColor = System.Drawing.Color.Transparent
    Me.RadioButton3.Name = "RadioButton3"
    Me.RadioButton3.UseVisualStyleBackColor = True
    '
    'RadioButton4
    '
    resources.ApplyResources(Me.RadioButton4, "RadioButton4")
    Me.RadioButton4.BackColor = System.Drawing.SystemColors.Control
    Me.RadioButton4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuntingBindingSource, "Services", True))
    Me.RadioButton4.ForeColor = System.Drawing.Color.Transparent
    Me.RadioButton4.Name = "RadioButton4"
    Me.RadioButton4.UseVisualStyleBackColor = False
    '
    'RadioButton5
    '
    resources.ApplyResources(Me.RadioButton5, "RadioButton5")
    Me.RadioButton5.BackColor = System.Drawing.Color.Transparent
    Me.RadioButton5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuntingBindingSource, "Services", True))
    Me.RadioButton5.ForeColor = System.Drawing.Color.Transparent
    Me.RadioButton5.Name = "RadioButton5"
    Me.RadioButton5.UseVisualStyleBackColor = False
    '
    'Label8
    '
    resources.ApplyResources(Me.Label8, "Label8")
    Me.Label8.Name = "Label8"
    '
    'Label9
    '
    resources.ApplyResources(Me.Label9, "Label9")
    Me.Label9.Name = "Label9"
    '
    'Label10
    '
    resources.ApplyResources(Me.Label10, "Label10")
    Me.Label10.Name = "Label10"
    '
    'GroupBox1
    '
    resources.ApplyResources(Me.GroupBox1, "GroupBox1")
    Me.GroupBox1.Controls.Add(Me.Label8)
    Me.GroupBox1.Controls.Add(Me.Label9)
    Me.GroupBox1.Controls.Add(Me.Label10)
    Me.GroupBox1.Controls.Add(Me.RadioButton3)
    Me.GroupBox1.Controls.Add(Me.RadioButton5)
    Me.GroupBox1.Controls.Add(Me.RadioButton4)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.TabStop = False
    '
    'GroupBox2
    '
    resources.ApplyResources(Me.GroupBox2, "GroupBox2")
    Me.GroupBox2.Controls.Add(Me.RadioButton1)
    Me.GroupBox2.Controls.Add(Me.RadioButton6)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.TabStop = False
    '
    'RadioButton1
    '
    resources.ApplyResources(Me.RadioButton1, "RadioButton1")
    Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
    Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuntingBindingSource, "Age", True))
    Me.RadioButton1.ForeColor = System.Drawing.Color.Transparent
    Me.RadioButton1.Name = "RadioButton1"
    Me.RadioButton1.UseVisualStyleBackColor = False
    '
    'RadioButton6
    '
    resources.ApplyResources(Me.RadioButton6, "RadioButton6")
    Me.RadioButton6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuntingBindingSource, "Age", True))
    Me.RadioButton6.ForeColor = System.Drawing.Color.Transparent
    Me.RadioButton6.Name = "RadioButton6"
    Me.RadioButton6.UseVisualStyleBackColor = True
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'GroupBox3
    '
    resources.ApplyResources(Me.GroupBox3, "GroupBox3")
    Me.GroupBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuntingBindingSource, "Customer Name", True))
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.TabStop = False
    '
    'GroupBox4
    '
    resources.ApplyResources(Me.GroupBox4, "GroupBox4")
    Me.GroupBox4.Controls.Add(Me.DataGridView1)
    Me.GroupBox4.Controls.Add(Me.Button7)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.TabStop = False
    '
    'Timer1
    '
    '
    'Form1
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Button5)
    Me.Controls.Add(Me.Button4)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox4)
    Me.Controls.Add(Me.GroupBox3)
    Me.Name = "Form1"
    CType(Me.GuntingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GuntingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox4.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GuntingDataSet As kedai_gunting_rambut.GuntingDataSet
    Friend WithEvents GuntingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuntingTableAdapter As kedai_gunting_rambut.GuntingDataSetTableAdapters.guntingTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
