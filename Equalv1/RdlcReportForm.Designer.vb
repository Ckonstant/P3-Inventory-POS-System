<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RdlcReportForm
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
        Me.EqualDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Equalv1.Database1DataSet()
        Me.EqualDBTableAdapter = New Equalv1.Database1DataSetTableAdapters.EqualDBTableAdapter()
        CType(Me.EqualDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RdlcReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 261)
        Me.Name = "RdlcReportForm"
        Me.Text = "RdlcReportForm"
        CType(Me.EqualDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EqualDBBindingSource As BindingSource
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents EqualDBTableAdapter As Database1DataSetTableAdapters.EqualDBTableAdapter
End Class
