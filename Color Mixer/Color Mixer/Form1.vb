Public Class Form1
    Dim inputRed As Integer
    Dim inputGreen As Integer
    Dim inputBlue As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Integer.TryParse(redTextBox.Text, inputRed)
        Integer.TryParse(greenTextBox.Text, inputGreen)
        Integer.TryParse(blueTextBox.Text, inputBlue)

        TrackBar1.Value = redTextBox.Text
        TrackBar2.Value = greenTextBox.Text
        TrackBar3.Value = blueTextBox.Text
        PictureBox1.BackColor =
         Color.FromArgb(inputRed, inputGreen, inputBlue)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim iExit = MessageBox.Show("confirm if you want to exit", "color picker", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            End
        End If
    End Sub
End Class
