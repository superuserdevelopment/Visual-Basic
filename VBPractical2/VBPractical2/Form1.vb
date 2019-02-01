Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox1.Visible = True
        TextBox2.Visible = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim r As Integer
        Dim a As Double
        r = Val(TextBox1.Text)
        a = 3.142 * r * r
        TextBox2.Text = a

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox5.Text = Val(TextBox3.Text) * Val(TextBox4.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = False
        Button4.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        TextBox3.Visible = 1
        TextBox4.Visible = 1
        TextBox5.Visible = 1
        TextBox1.Visible = 0
        TextBox2.Visible = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim s As String
        s = MsgBox("Do you really want to exit?", vbYesNo)
        If s = vbYes Then
            End
        End If
    End Sub
End Class
