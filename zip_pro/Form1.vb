Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using z As New Ionic.Zip.ZipFile()
            Try
                z.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                z.AlternateEncoding = System.Text.Encoding.UTF8

                z.Password = "111"

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using z As New Ionic.Zip.ZipFile()
            Try

                z.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                z.AlternateEncoding = System.Text.Encoding.UTF8

                z.AddFile("C:\githubs\VB\ZipFiles\lowpass.jpg", "意象")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using z As New Ionic.Zip.ZipFile()
            Try
                z.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                z.AlternateEncoding = System.Text.Encoding.UTF8

                z.Password = "111"

                z.AddDirectory("C:\githubs\VB\ZipFiles")

                z.Save("C:\githubs\VB\ZipFiles\ZippedFiles.zip")
                'z.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
End Class
