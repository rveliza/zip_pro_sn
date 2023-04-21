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

    Private Sub Start_Button2_Click(sender As Object, e As EventArgs) Handles Start_Button2.Click
        If Me.path_TextBox1.Text = "" Then
            MessageBox.Show("Please select your file")
            Exit Sub
        End If

        Dim fn As String
        fn = Me.path_TextBox1.Text
        Using z As New Ionic.Zip.ZipFile(fn)
            Try
                z.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                z.AlternateEncoding = System.Text.Encoding.UTF8
                z.Password = "111"

                Dim df As String
                df = Application.StartupPath
                z.ExtractAll(df, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)

                MessageBox.Show("Restoration is done! Pleae check your data!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
End Class