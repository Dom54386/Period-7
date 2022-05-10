Public Class Form1
    Dim vend As New Bank

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vend.AddNickel()
        TotalLabel.Text = vend.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vend.addDimes()
        TotalLabel.Text = vend.total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vend.addQuarters()
        TotalLabel.Text = vend.total.ToString("c2")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class
