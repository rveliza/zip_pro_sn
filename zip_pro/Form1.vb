Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using z As New Ionic.Zip.ZipFile()
            Try
                'z.AddFile("C:\githubs\VB\lowpass.jpg")

                'Custom Folder Name
                'z.AddFile("C:\githubs\VB\lowpass.jpg", "My_Zips")
                z.AddFile("C:\githubs\VB\lowpass.jpg", "")

                z.Save("C:\githubs\VB\lowpass.zip")
                'z.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
End Class
