<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(commun))
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GunaButton7 = New Guna.UI.WinForms.GunaButton()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackgroundImage = CType(resources.GetObject("GunaPictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.GunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Location = New System.Drawing.Point(510, 115)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(122, 116)
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(466, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(231, 21)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Η σελλίδα είναι υπό κατασκευή"
        '
        'GunaButton7
        '
        Me.GunaButton7.AnimationHoverSpeed = 0.07!
        Me.GunaButton7.AnimationSpeed = 0.03!
        Me.GunaButton7.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.GunaButton7.BorderColor = System.Drawing.Color.Black
        Me.GunaButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton7.ForeColor = System.Drawing.Color.White
        Me.GunaButton7.Image = CType(resources.GetObject("GunaButton7.Image"), System.Drawing.Image)
        Me.GunaButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton7.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton7.Location = New System.Drawing.Point(554, 564)
        Me.GunaButton7.Name = "GunaButton7"
        Me.GunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.GunaButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton7.OnHoverImage = Nothing
        Me.GunaButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton7.Radius = 4
        Me.GunaButton7.Size = New System.Drawing.Size(42, 34)
        Me.GunaButton7.TabIndex = 70
        '
        'commun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1157, 717)
        Me.Controls.Add(Me.GunaButton7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "commun"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "commun"
        Me.TopMost = True
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GunaButton7 As Guna.UI.WinForms.GunaButton
End Class
