<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class veriFY
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
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.CalculatorControl1 = New Syncfusion.Windows.Forms.Tools.CalculatorControl()
        Me.SuspendLayout()
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_VER_POSITIVE
        Me.GunaAnimateWindow1.Interval = 650
        Me.GunaAnimateWindow1.TargetControl = Me
        '
        'CalculatorControl1
        '
        Me.CalculatorControl1.AccessibleDescription = "Calculator control"
        Me.CalculatorControl1.AccessibleName = "Calculator Control"
        Me.CalculatorControl1.BeforeTouchSize = New System.Drawing.Size(359, 310)
        Me.CalculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.CalculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White
        Me.CalculatorControl1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.CalculatorControl1.DoubleValue = 0R
        Me.CalculatorControl1.EnableTouchMode = True
        Me.CalculatorControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CalculatorControl1.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.Financial
        Me.CalculatorControl1.Location = New System.Drawing.Point(3, 12)
        Me.CalculatorControl1.MetroColor = System.Drawing.SystemColors.Control
        Me.CalculatorControl1.Name = "CalculatorControl1"
        Me.CalculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalculatorControl1.Size = New System.Drawing.Size(242, 331)
        Me.CalculatorControl1.TabIndex = 0
        Me.CalculatorControl1.Text = "CalculatorControl1"
        Me.CalculatorControl1.ThemeName = "Office2016White"
        Me.CalculatorControl1.UseVerticalAndHorizontalSpacing = True
        Me.CalculatorControl1.UseVisualStyle = True
        '
        'veriFY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(253, 355)
        Me.Controls.Add(Me.CalculatorControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "veriFY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "veriFY"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents CalculatorControl1 As Syncfusion.Windows.Forms.Tools.CalculatorControl
End Class
