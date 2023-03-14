Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usStates As New List(Of String)()
        usStates.Add("10%")
        usStates.Add("20%")
        usStates.Add("30%")
        usStates.Add("40%")
        usStates.Add("50%")
        usStates.Add("60%")
        usStates.Add("70%")
        usStates.Add("80%")
        usStates.Add("90%")
        usStates.Add("100%")
        usStates.Add("150%")
        usStates.Add("200%")
        SfComboBox1.DataSource = usStates
        Dim fixEkpt As New List(Of String)()
        fixEkpt.Add("5%")
        fixEkpt.Add("10%")
        fixEkpt.Add("15%")
        fixEkpt.Add("20%")
        fixEkpt.Add("25%")
        fixEkpt.Add("30%")
        fixEkpt.Add("35%")
        fixEkpt.Add("40%")
        fixEkpt.Add("45%")
        fixEkpt.Add("50%")
        fixEkpt.Add("55%")
        fixEkpt.Add("100%")
        SfComboBox2.DataSource = fixEkpt
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub SfComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SfComboBox1.SelectedIndexChanged
        If SfComboBox1.SelectedValue = "10%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 0.1
        End If
        If SfComboBox1.SelectedValue = "20%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 0.2
        End If
        If SfComboBox1.SelectedValue = "30%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 0.3
        End If
        If SfComboBox1.SelectedValue = "40%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 0.4
        End If
        If SfComboBox1.SelectedValue = "50%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 0.5
        End If
        If SfComboBox1.SelectedValue = "60%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 0.6
        End If
        If SfComboBox1.SelectedValue = "70%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 0.7
        End If
        If SfComboBox1.SelectedValue = "80%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 0.8
        End If
        If SfComboBox1.SelectedValue = "90%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 0.9
        End If
        If SfComboBox1.SelectedValue = "100%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 1
        End If
        If SfComboBox1.SelectedValue = "150%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 1.5
        End If
        If SfComboBox1.SelectedValue = "200%" Then
            Form2.DoubleTextBox3.Text = Form2.GunaTextBox1.Text + Form2.GunaTextBox1.Text * 2
        End If


    End Sub

    Private Sub SfComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SfComboBox2.SelectedIndexChanged
        If SfComboBox2.SelectedValue = "5%" Then
            Form2.GunaLineTextBox12.Text = "5"
        End If
        If SfComboBox2.SelectedValue = "10%" Then
            Form2.GunaLineTextBox12.Text = "10"
        End If
        If SfComboBox2.SelectedValue = "15%" Then
            Form2.GunaLineTextBox12.Text = "15"
        End If
        If SfComboBox2.SelectedValue = "20%" Then
            Form2.GunaLineTextBox12.Text = "20"
        End If
        If SfComboBox2.SelectedValue = "25%" Then
            Form2.GunaLineTextBox12.Text = "25"
        End If
        If SfComboBox2.SelectedValue = "30%" Then
            Form2.GunaLineTextBox12.Text = "30"
        End If
        If SfComboBox2.SelectedValue = "35%" Then
            Form2.GunaLineTextBox12.Text = "35"
        End If
        If SfComboBox2.SelectedValue = "40%" Then
            Form2.GunaLineTextBox12.Text = "40"
        End If
        If SfComboBox2.SelectedValue = "45%" Then
            Form2.GunaLineTextBox12.Text = "45"
        End If
        If SfComboBox2.SelectedValue = "50%" Then
            Form2.GunaLineTextBox12.Text = "50"
        End If
        If SfComboBox2.SelectedValue = "55%" Then
            Form2.GunaLineTextBox12.Text = "55"
        End If
        If SfComboBox2.SelectedValue = "100%" Then
            Form2.GunaLineTextBox12.Text = "100"
        End If
    End Sub
End Class