<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.EqualDBBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New Equalv1.Database1DataSet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EqualDBTableAdapter = New Equalv1.Database1DataSetTableAdapters.EqualDBTableAdapter()
        Me.EqualDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Equalv1.Database1DataSet()
        Me.SfComboBox1 = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.SfComboBox2 = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.EqualDBBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EqualDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SfComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SfComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EqualDBBindingSource1
        '
        Me.EqualDBBindingSource1.DataMember = "EqualDB"
        Me.EqualDBBindingSource1.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.Label10, Guna.UI.Animation.DecorationType.None)
        Me.Label10.Location = New System.Drawing.Point(29, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "Ποσοστό Κέρδους"
        '
        'EqualDBTableAdapter
        '
        Me.EqualDBTableAdapter.ClearBeforeFill = True
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
        'SfComboBox1
        '
        Me.GunaTransition1.SetDecoration(Me.SfComboBox1, Guna.UI.Animation.DecorationType.None)
        Me.SfComboBox1.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.SfComboBox1.Location = New System.Drawing.Point(11, 36)
        Me.SfComboBox1.Name = "SfComboBox1"
        Me.SfComboBox1.Size = New System.Drawing.Size(150, 28)
        Me.SfComboBox1.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SfComboBox1.TabIndex = 98
        '
        'GunaTransition1
        '
        Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.GunaTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.GunaTransition1.DefaultAnimation = Animation1
        '
        'SfComboBox2
        '
        Me.GunaTransition1.SetDecoration(Me.SfComboBox2, Guna.UI.Animation.DecorationType.None)
        Me.SfComboBox2.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.SfComboBox2.Location = New System.Drawing.Point(11, 125)
        Me.SfComboBox2.Name = "SfComboBox2"
        Me.SfComboBox2.Size = New System.Drawing.Size(150, 28)
        Me.SfComboBox2.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SfComboBox2.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Location = New System.Drawing.Point(29, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Φιξ Έκπτωση"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(173, 184)
        Me.Controls.Add(Me.SfComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SfComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.EqualDBBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EqualDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SfComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SfComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EqualDBBindingSource1 As BindingSource
    Friend WithEvents Database1DataSet1 As Database1DataSet
    Friend WithEvents Label10 As Label
    Friend WithEvents EqualDBTableAdapter As Database1DataSetTableAdapters.EqualDBTableAdapter
    Friend WithEvents EqualDBBindingSource As BindingSource
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents SfComboBox1 As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents SfComboBox2 As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents Label1 As Label
End Class
