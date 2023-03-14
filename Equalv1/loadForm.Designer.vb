<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loadForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loadForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(451, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All Copyrights Reserved Christos Konstantinides 2021-2022"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(12, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Σύστημα Διαχείρησης Επιχειρήσεων"
        '
        'GunaProgressBar1
        '
        Me.GunaProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.GunaProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaProgressBar1.Location = New System.Drawing.Point(15, 210)
        Me.GunaProgressBar1.Name = "GunaProgressBar1"
        Me.GunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaProgressBar1.Radius = 4
        Me.GunaProgressBar1.Size = New System.Drawing.Size(721, 10)
        Me.GunaProgressBar1.TabIndex = 33
        Me.GunaProgressBar1.Visible = False
        '
        'Timer2
        '
        '
        'loadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(748, 224)
        Me.Controls.Add(Me.GunaProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loadForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loadForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents Timer2 As Timer
End Class
