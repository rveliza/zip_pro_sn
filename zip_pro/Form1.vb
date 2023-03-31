Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim z As New Ionic.Zip.ZipFile()

        Try
            z.AddFile("C:\githubs\test_folder\lowpass.jpg")
            z.Save("C:\githubs\test_folder\lowpass.zip")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
