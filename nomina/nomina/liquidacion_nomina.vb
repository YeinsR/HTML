Public Class liquidacion_nomina
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Calculo devengado -> Basico'
        Dim basico As Integer
        basico = Val(TextBox4.Text / 30) * Val(TextBox6.Text)
        TextBox5.Text = basico

        'Calculo devengado -> Subsidio Transporte'
        If Val(TextBox4.Text) < 2320000 Then

            TextBox7.Text = (140606 * Val(TextBox6.Text)) / 30

        Else
            TextBox7.Text = 0


        End If

        'Calculo devengado -> Horas_Extras'

        Dim extras As Integer
        extras = Val(TextBox9.Text) + Val(TextBox10.Text) + Val(TextBox11.Text) + Val(TextBox12.Text)
        TextBox18.Text = extras

        'Calculo Neto_A_Pagar -> Total_Devengado'
        Dim total As Double

        total = Val(TextBox5.Text) + Val(TextBox7.Text) + (Val(TextBox4.Text * 1.25) * Val(TextBox9.Text)) / 240 + (Val(TextBox4.Text * 1.75) * Val(TextBox10.Text)) / 240 + (Val(TextBox4.Text * 2) * Val(TextBox11.Text)) / 240 + (Val(TextBox4.Text * 2.5) * Val(TextBox12.Text)) / 240

        TextBox8.Text = total


        'Calculo Deducidos -> Eps'
        Dim eps As Double
        eps = (Val(TextBox8.Text) - Val(TextBox7.Text)) * 0.04
        TextBox15.Text = eps

        'Calculo Deducidos -> Pension'
        Dim pension As Double
        pension = (Val(TextBox8.Text) - Val(TextBox7.Text)) * 0.04
        TextBox14.Text = pension


        'Calculo Deducidos -> Fondo'

        If Val(TextBox4.Text) >= 4640000 Then

            Dim fondo As Double
            fondo = Val(TextBox8.Text) * 0.01

            TextBox13.Text = fondo
        Else
            TextBox13.Text = 0

        End If

        'Calculo Neto_A_Pagar -> Total_Deducidos'
        Dim deducido As Double

        deducido = Val(TextBox15.Text) + Val(TextBox14.Text) + Val(TextBox13.Text)
        TextBox16.Text = deducido

        'Calculo Neto_A_Pagar -> Pago_neto'

        Dim pago As Double

        pago = Val(TextBox8.Text) - Val(TextBox16.Text)
        TextBox17.Text = pago


    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox15.Text = ""
            TextBox16.Text = ""
            TextBox17.Text = ""
            TextBox18.Text = ""

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class