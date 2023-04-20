Public Class Restore_form
    Private Sub Browse_Button1_Click(sender As Object, e As EventArgs) Handles Browse_Button1.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String
        fn = Me.OpenFileDialog1.FileName

        If fn = "OpenFileDialog1" Then
            Me.path_TextBox1.Text = ""
            Exit Sub
        End If
        Me.path_TextBox1.Text = fn
    End Sub

End Class