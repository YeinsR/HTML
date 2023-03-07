Public Class Form4
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B As Integer

        A = (Int(TextBox1.Text) * Int(TextBox3.Text)) / 100

        B = A / Int(TextBox2.Text)

        Label3.Text = B






































    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class