<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExcelReader
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExcelReader))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaDataGridView2 = New Guna.UI.WinForms.GunaDataGridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.ed = New System.Windows.Forms.DataGridViewImageColumn()
        Me.del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GunaPanel16 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaButton41 = New Guna.UI.WinForms.GunaButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaButton40 = New Guna.UI.WinForms.GunaButton()
        Me.DataSet1 = New Equalv1.DataSet1()
        Me.TESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TESTTableAdapter = New Equalv1.DataSet1TableAdapters.TESTTableAdapter()
        Me.TESTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.sfDataGrid1 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.ContextMenuStripEx1 = New Syncfusion.Windows.Forms.Tools.ContextMenuStripEx()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        CType(Me.GunaDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel16.SuspendLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sfDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(698, 651)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'GunaDataGridView2
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView2.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView2.EnableHeadersVisualStyles = False
        Me.GunaDataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView2.Location = New System.Drawing.Point(786, 597)
        Me.GunaDataGridView2.Name = "GunaDataGridView2"
        Me.GunaDataGridView2.RowHeadersVisible = False
        Me.GunaDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView2.Size = New System.Drawing.Size(298, 102)
        Me.GunaDataGridView2.TabIndex = 9
        Me.GunaDataGridView2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView2.ThemeStyle.HeaderStyle.Height = 4
        Me.GunaDataGridView2.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaDataGridView1
        '
        Me.GunaDataGridView1.AllowUserToAddRows = False
        Me.GunaDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GunaDataGridView1.ColumnHeadersHeight = 25
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ed, Me.del})
        Me.GunaDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(18, 564)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray
        Me.GunaDataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.GunaDataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GunaDataGridView1.RowTemplate.Height = 45
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(586, 89)
        Me.GunaDataGridView1.TabIndex = 13
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 25
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 45
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ed
        '
        Me.ed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
        Me.ed.DefaultCellStyle = DataGridViewCellStyle6
        Me.ed.FillWeight = 38.2958!
        Me.ed.HeaderText = ""
        Me.ed.Image = CType(resources.GetObject("ed.Image"), System.Drawing.Image)
        Me.ed.Name = "ed"
        Me.ed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'del
        '
        Me.del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.del.FillWeight = 39.26646!
        Me.del.HeaderText = ""
        Me.del.Image = CType(resources.GetObject("del.Image"), System.Drawing.Image)
        Me.del.Name = "del"
        '
        'GunaPanel16
        '
        Me.GunaPanel16.BackColor = System.Drawing.Color.White
        Me.GunaPanel16.Controls.Add(Me.GunaButton41)
        Me.GunaPanel16.Controls.Add(Me.Label13)
        Me.GunaPanel16.Controls.Add(Me.GunaPictureBox3)
        Me.GunaPanel16.Controls.Add(Me.GunaButton40)
        Me.GunaPanel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel16.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel16.Name = "GunaPanel16"
        Me.GunaPanel16.Size = New System.Drawing.Size(1306, 60)
        Me.GunaPanel16.TabIndex = 81
        '
        'GunaButton41
        '
        Me.GunaButton41.Animated = True
        Me.GunaButton41.AnimationHoverSpeed = 0.07!
        Me.GunaButton41.AnimationSpeed = 0.03!
        Me.GunaButton41.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton41.BaseColor = System.Drawing.Color.White
        Me.GunaButton41.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton41.BorderSize = 1
        Me.GunaButton41.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton41.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton41.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton41.ForeColor = System.Drawing.Color.White
        Me.GunaButton41.Image = CType(resources.GetObject("GunaButton41.Image"), System.Drawing.Image)
        Me.GunaButton41.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaButton41.Location = New System.Drawing.Point(1196, 14)
        Me.GunaButton41.Name = "GunaButton41"
        Me.GunaButton41.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaButton41.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaButton41.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton41.OnHoverImage = CType(resources.GetObject("GunaButton41.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton41.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton41.Radius = 15
        Me.GunaButton41.Size = New System.Drawing.Size(44, 38)
        Me.GunaButton41.TabIndex = 9
        Me.GunaButton41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(84, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(420, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Προεπισκόπηση Αρχείων EXCEL (.xlsx)"
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BackgroundImage = CType(resources.GetObject("GunaPictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox3.Location = New System.Drawing.Point(18, 7)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(40, 43)
        Me.GunaPictureBox3.TabIndex = 8
        Me.GunaPictureBox3.TabStop = False
        '
        'GunaButton40
        '
        Me.GunaButton40.Animated = True
        Me.GunaButton40.AnimationHoverSpeed = 0.07!
        Me.GunaButton40.AnimationSpeed = 0.03!
        Me.GunaButton40.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton40.BaseColor = System.Drawing.Color.White
        Me.GunaButton40.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton40.BorderSize = 1
        Me.GunaButton40.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton40.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton40.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton40.ForeColor = System.Drawing.Color.White
        Me.GunaButton40.Image = CType(resources.GetObject("GunaButton40.Image"), System.Drawing.Image)
        Me.GunaButton40.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaButton40.Location = New System.Drawing.Point(1247, 14)
        Me.GunaButton40.Name = "GunaButton40"
        Me.GunaButton40.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaButton40.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaButton40.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton40.OnHoverImage = CType(resources.GetObject("GunaButton40.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton40.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton40.Radius = 15
        Me.GunaButton40.Size = New System.Drawing.Size(44, 38)
        Me.GunaButton40.TabIndex = 7
        Me.GunaButton40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TESTBindingSource
        '
        Me.TESTBindingSource.DataMember = "TEST"
        Me.TESTBindingSource.DataSource = Me.DataSet1
        '
        'TESTTableAdapter
        '
        Me.TESTTableAdapter.ClearBeforeFill = True
        '
        'TESTBindingSource1
        '
        Me.TESTBindingSource1.DataMember = "TEST"
        Me.TESTBindingSource1.DataSource = Me.DataSet1
        '
        'sfDataGrid1
        '
        Me.sfDataGrid1.AccessibleName = "Table"
        Me.sfDataGrid1.AllowDeleting = True
        Me.sfDataGrid1.AllowFiltering = True
        Me.sfDataGrid1.AllowResizingColumns = True
        Me.sfDataGrid1.AllowSorting = False
        Me.sfDataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sfDataGrid1.AutoExpandGroups = True
        Me.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
        Me.sfDataGrid1.ContextMenuStrip = Me.ContextMenuStripEx1
        Me.sfDataGrid1.Location = New System.Drawing.Point(1, 129)
        Me.sfDataGrid1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sfDataGrid1.Name = "sfDataGrid1"
        Me.sfDataGrid1.RowHeight = 21
        Me.sfDataGrid1.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended
        Me.sfDataGrid1.ShowGroupDropArea = True
        Me.sfDataGrid1.ShowPreviewRow = True
        Me.sfDataGrid1.ShowRowHeader = True
        Me.sfDataGrid1.Size = New System.Drawing.Size(1292, 580)
        Me.sfDataGrid1.SortClickAction = Syncfusion.WinForms.DataGrid.Enums.SortClickAction.DoubleClick
        Me.sfDataGrid1.TabIndex = 99
        Me.sfDataGrid1.Text = "sfDataGrid1"
        '
        'ContextMenuStripEx1
        '
        Me.ContextMenuStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.ContextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ContextMenuStripEx1.Name = "ContextMenuStripEx1"
        Me.ContextMenuStripEx1.Size = New System.Drawing.Size(181, 70)
        Me.ContextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.[Default]
        Me.ContextMenuStripEx1.ThemeName = "Default"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = CType(resources.GetObject("GunaAdvenceButton3.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(12, 73)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 3
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(174, 37)
        Me.GunaAdvenceButton3.TabIndex = 106
        Me.GunaAdvenceButton3.Text = "Επιλογή αρχείου (.xlsx)"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(1119, 84)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 3
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(174, 37)
        Me.GunaAdvenceButton1.TabIndex = 107
        Me.GunaAdvenceButton1.Text = "Εξαγωγή Αρχείου (.xlsx)"
        '
        'ExcelReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1306, 723)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.sfDataGrid1)
        Me.Controls.Add(Me.GunaPanel16)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.GunaDataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExcelReader"
        Me.Text = "ExcelReader"
        CType(Me.GunaDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel16.ResumeLayout(False)
        Me.GunaPanel16.PerformLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sfDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripEx1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaDataGridView2 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents ed As DataGridViewImageColumn
    Friend WithEvents del As DataGridViewImageColumn
    Friend WithEvents GunaPanel16 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaButton41 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label13 As Label
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaButton40 As Guna.UI.WinForms.GunaButton
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TESTBindingSource As BindingSource
    Friend WithEvents TESTTableAdapter As DataSet1TableAdapters.TESTTableAdapter
    Friend WithEvents TESTBindingSource1 As BindingSource
    Private WithEvents sfDataGrid1 As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents ContextMenuStripEx1 As Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
