Public Class Backup_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Dim fn As String
        fn = Me.FolderBrowserDialog1.SelectedPath
        Me.file_path_TextBox1.Text = fn
    End Sub
End Class