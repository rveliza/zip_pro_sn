Public Class Backup_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Dim fn As String
        Dim file_name As String
        fn = Me.FolderBrowserDialog1.SelectedPath
        If fn = "" Then
            Exit Sub
        End If
        file_name = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm" + ".zpr")
        Me.file_path_TextBox1.Text = fn + "\" + file_name
    End Sub
End Class