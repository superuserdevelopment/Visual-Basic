Public Class Form1
    Private Sub Button1_DragDrop(Source As Control, X As Single, Y As Single)
        PictureBox1.BackColor = Color.Red



    End Sub
    Private Sub Button1_Dragover(Source As Control, X As Single, Y As Single)
        PictureBox1.BackColor = Color.Blue



    End Sub

    Private Sub PictureBox1_DragDrop(Source As Control, X As Single, Y As Single)
        PictureBox1.BackColor = Color.Yellow



    End Sub

    Private Sub PictureBox1_Dragover(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        PictureBox1.BackColor = Color.Green
    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragOver
        PictureBox1.BackColor = Color.Yellow
    End Sub
End Class
