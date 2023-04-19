Public Class Backup_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Dim fn As String
        Dim file_name As String
        fn = Me.FolderBrowserDialog1.SelectedPath
        If fn = "" Then
            Exit Sub
        End If
        file_name = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm" + ".z19")
        Me.file_path_TextBox1.Text = fn + "\" + file_name
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using z As New Ionic.Zip.ZipFile()
            Try
                z.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                z.AlternateEncoding = System.Text.Encoding.UTF8
                z.Password = "111"

                Dim fn As String
                fn = Application.StartupPath

                z.AddFile(fn + "\data\Shop_db.mbn", "data")
                z.AddFile(fn + "\data\Audio\maryfisher1992.mp3", "data\Audio")
                z.AddFile(fn + "\data\Audio\xxx1.mp3", "data\Audio")
                z.AddFile(fn + "\data\image\1.jpg", "data\image")
                z.AddFile(fn + "\data\image\2.jpg", "data\image")
                z.AddFile(fn + "\data\image\3.jpg", "data\image")
                z.AddFile(fn + "\data\image\4.png", "data\image")
                z.Save(Me.file_path_TextBox1.Text)

                Dim fi As New System.IO.FileInfo(Me.file_path_TextBox1.Text)
                Dim fs As Long
                fs = fi.Length

                If fs = 0 Then
                    MessageBox.Show("Backup failed")
                Else
                    Dim fs_kb As Long
                    fs_kb = fs \ 1024 'file size in KB
                    MessageBox.Show("Backup is done!  File size is: " + fs_kb.ToString + " KB")
                End If



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
End Class