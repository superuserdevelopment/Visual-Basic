Public Class VBPractical1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, a, sum As Integer
        i = 0
        sum = 0
        Do While i <= 10
            a = InputBox("Enter 10 numbers")
            sum = sum + a
            i = i + 1

        Loop
        MsgBox("Sum of first 10 numbers " & sum)
        TextBox1.Text = sum


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
