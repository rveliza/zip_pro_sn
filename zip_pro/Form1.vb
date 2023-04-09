Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using z As New Ionic.Zip.ZipFile()
            Try
                'z.AddFile("C:\githubs\VB\ZipFiles\lowpass.jpg")

                'Custom Folder Name
                'z.AddFile("C:\githubs\VB\ZipFiles\lowpass.jpg", "My_Zips")
                z.AddFile("C:\githubs\VB\ZipFiles\lowpass.jpg", "images")
                z.AddFile("C:\githubs\VB\ZipFiles\fltplan.pdf", "aviation")
                z.AddFile("C:\githubs\VB\ZipFiles\jet.xls", "aviation")
                z.AddFile("C:\githubs\VB\ZipFiles\performance.pdf", "schedule")
                z.AddFile("C:\githubs\VB\ZipFiles\tgdis.xls", "schedule")

                z.Save("C:\githubs\VB\ZipFiles\ZippedFiles.zip")
                'z.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
End Class
