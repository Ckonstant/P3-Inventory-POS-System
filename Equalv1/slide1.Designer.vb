<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class slide1
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
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaAnimateWindow2 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 6)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(257, 21)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Η καταχώρηση εγινε με επιτυχία!!!"
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_VER_POSITIVE
        Me.GunaAnimateWindow1.Interval = 700
        Me.GunaAnimateWindow1.TargetControl = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'GunaAnimateWindow2
        '
        Me.GunaAnimateWindow2.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_VER_NEGATIVE
        Me.GunaAnimateWindow2.Interval = 700
        Me.GunaAnimateWindow2.TargetControl = Me
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(12, 3)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 8
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(288, 36)
        Me.GunaElipsePanel1.TabIndex = 1
        '
        'slide1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(306, 45)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "slide1"
        Me.Text = "slide1"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaAnimateWindow2 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
End Class
