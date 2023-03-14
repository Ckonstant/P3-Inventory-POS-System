<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gridViewer
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
        Me.EqualDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Equalv1.Database1DataSet()
        Me.EqualDBTableAdapter = New Equalv1.Database1DataSetTableAdapters.EqualDBTableAdapter()
        Me.GunaPanel7 = New Guna.UI.WinForms.GunaPanel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CartesianChart2 = New LiveCharts.WinForms.CartesianChart()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaShadowPanel3 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaShadowPanel4 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.EqualDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel7.SuspendLayout()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaShadowPanel3.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaShadowPanel4.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'EqualDBBindingSource
        '
        Me.EqualDBBindingSource.DataMember = "EqualDB"
        Me.EqualDBBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EqualDBTableAdapter
        '
        Me.EqualDBTableAdapter.ClearBeforeFill = True
        '
        'GunaPanel7
        '
        Me.GunaPanel7.BackColor = System.Drawing.Color.White
        Me.GunaPanel7.Controls.Add(Me.Label32)
        Me.GunaPanel7.Controls.Add(Me.Label31)
        Me.GunaPanel7.Controls.Add(Me.Label30)
        Me.GunaPanel7.Controls.Add(Me.CartesianChart2)
        Me.GunaPanel7.Location = New System.Drawing.Point(12, 12)
        Me.GunaPanel7.Name = "GunaPanel7"
        Me.GunaPanel7.Size = New System.Drawing.Size(1302, 352)
        Me.GunaPanel7.TabIndex = 20
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(347, 308)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(38, 13)
        Me.Label32.TabIndex = 34
        Me.Label32.Text = "Άρτος"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(185, 308)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(33, 13)
        Me.Label31.TabIndex = 34
        Me.Label31.Text = "Ποτά"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(511, 307)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 13)
        Me.Label30.TabIndex = 33
        Me.Label30.Text = "Σύνολο"
        '
        'CartesianChart2
        '
        Me.CartesianChart2.Location = New System.Drawing.Point(9, 18)
        Me.CartesianChart2.Name = "CartesianChart2"
        Me.CartesianChart2.Size = New System.Drawing.Size(1269, 315)
        Me.CartesianChart2.TabIndex = 16
        Me.CartesianChart2.Text = "CartesianChart2"
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.Controls.Add(Me.GunaPanel1)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(55, 385)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.ShadowShift = 1
        Me.GunaShadowPanel2.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(269, 210)
        Me.GunaShadowPanel2.TabIndex = 43
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Location = New System.Drawing.Point(3, 3)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(263, 204)
        Me.GunaPanel1.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Λογαριασμός ΔΕΗ(Ρεύμα)"
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.Controls.Add(Me.GunaPanel2)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(362, 385)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowShift = 1
        Me.GunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(269, 210)
        Me.GunaShadowPanel1.TabIndex = 44
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.White
        Me.GunaPanel2.Controls.Add(Me.Label2)
        Me.GunaPanel2.Location = New System.Drawing.Point(3, 3)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(263, 204)
        Me.GunaPanel2.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Λογαριασμός ΕΦΚΑ/ΙΚΑ/ΤΕΒΕ"
        '
        'GunaShadowPanel3
        '
        Me.GunaShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.Controls.Add(Me.GunaPanel3)
        Me.GunaShadowPanel3.Location = New System.Drawing.Point(661, 385)
        Me.GunaShadowPanel3.Name = "GunaShadowPanel3"
        Me.GunaShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel3.ShadowShift = 1
        Me.GunaShadowPanel3.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel3.Size = New System.Drawing.Size(269, 210)
        Me.GunaShadowPanel3.TabIndex = 45
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.White
        Me.GunaPanel3.Controls.Add(Me.Label3)
        Me.GunaPanel3.Location = New System.Drawing.Point(3, 3)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(263, 204)
        Me.GunaPanel3.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Λογαριασμός Τηλέφωνο/Ιντερνετ"
        '
        'GunaShadowPanel4
        '
        Me.GunaShadowPanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel4.BaseColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel4.Controls.Add(Me.GunaPanel4)
        Me.GunaShadowPanel4.Location = New System.Drawing.Point(957, 385)
        Me.GunaShadowPanel4.Name = "GunaShadowPanel4"
        Me.GunaShadowPanel4.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel4.ShadowShift = 1
        Me.GunaShadowPanel4.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel4.Size = New System.Drawing.Size(269, 210)
        Me.GunaShadowPanel4.TabIndex = 46
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.White
        Me.GunaPanel4.Controls.Add(Me.Label4)
        Me.GunaPanel4.Location = New System.Drawing.Point(3, 3)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(263, 204)
        Me.GunaPanel4.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Λογαριασμός ΔΕΗ(Ρεύμα)"
        '
        'gridViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1326, 707)
        Me.Controls.Add(Me.GunaShadowPanel4)
        Me.Controls.Add(Me.GunaShadowPanel3)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.GunaShadowPanel2)
        Me.Controls.Add(Me.GunaPanel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gridViewer"
        Me.Text = "gridViewer"
        CType(Me.EqualDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel7.ResumeLayout(False)
        Me.GunaPanel7.PerformLayout()
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.GunaShadowPanel3.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        Me.GunaShadowPanel4.ResumeLayout(False)
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents EqualDBBindingSource As BindingSource
    Friend WithEvents EqualDBTableAdapter As Database1DataSetTableAdapters.EqualDBTableAdapter
    Friend WithEvents GunaPanel7 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents CartesianChart2 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaShadowPanel3 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaShadowPanel4 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label4 As Label
End Class
