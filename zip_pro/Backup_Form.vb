Public Class Backup_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Dim fn As String
        Dim file_name As String
        fn = Me.FolderBrowserDialog1.SelectedPath
        If fn = "" Then
            Exit Sub
        End If
        file_name = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm")
        Me.file_path_TextBox1.Text = fn + "\" + file_name
    End Sub

    Function percentage_cal(curr_item As Int32, total_items As Int32) As Int32
        Dim p_double As Double
        Dim rv As Int32
        p_double = (curr_item / total_items) * 100
        rv = CType(p_double, Int32)
        Return rv
    End Function

    Sub progress_validator(main_curr_item As Integer, main_total_items_count As Integer, sub_curr_item As Integer, sub_total_items_count As Integer)
        '---------------------------------------------------------------------
        Me.main_ProgressBar2.Value = percentage_cal(main_curr_item, main_total_items_count)
        Me.main_ProgressBar2.Refresh()

        Me.main_Label4.Text = Me.main_ProgressBar2.Value.ToString + "+"
        Me.main_Label4.Refresh()
        '-----------------------------------------------------------------------
        Me.sub_ProgressBar1.Value = percentage_cal(sub_curr_item, sub_total_items_count)
        Me.sub_Label3.Refresh()

        Me.sub_Label3.Text = Me.sub_ProgressBar1.Value.ToString + "+"
        Me.sub_Label3.Refresh()
        '--------------------------------------------------------------
        System.Threading.Thread.Sleep(200)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using z As New Ionic.Zip.ZipFile()

            If Me.file_path_TextBox1.Text = "" Then
                MessageBox.Show("Please select backup folder!")
                Exit Sub
            End If

            Me.sub_ProgressBar1.Value = 0
            Me.main_ProgressBar2.Value = 0
            Me.sub_Label3.Text = "0"
            Me.main_Label4.Text = "0"
            Me.prog_Panel1.Visible = True
            Me.prog_Panel1.Refresh()
            Try
                z.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary
                z.AlternateEncoding = System.Text.Encoding.UTF8
                z.Password = "111"

                Dim fn As String
                fn = Application.StartupPath

                z.AddFile(fn + "\data\Shop_db.mbn", "data")
                progress_validator(1, 7, 1, 1)

                z.AddFile(fn + "\data\Audio\maryfisher1992.mp3", "data\Audio")
                progress_validator(2, 7, 1, 2)

                z.AddFile(fn + "\data\Audio\xxx1.mp3", "data\Audio")
                progress_validator(3, 7, 2, 2)

                z.AddFile(fn + "\data\image\1.jpg", "data\image")
                progress_validator(4, 7, 1, 4)

                z.AddFile(fn + "\data\image\2.jpg", "data\image")
                progress_validator(5, 7, 2, 4)

                z.AddFile(fn + "\data\image\3.jpg", "data\image")
                progress_validator(6, 7, 3, 4)

                z.AddFile(fn + "\data\image\4.png", "data\image")

                Me.prog_Label2.Text = "Saving backup..."
                Me.prog_Label2.Refresh()
                z.Save(Me.file_path_TextBox1.Text + ".zip")

                progress_validator(7, 7, 4, 4)



                Dim fi As New System.IO.FileInfo(Me.file_path_TextBox1.Text + ".zip")
                Dim fs As Long
                fs = fi.Length

                Me.prog_Panel1.Visible = False
                If fs = 0 Then
                    MessageBox.Show("Backup failed")
                Else
                    Dim fs_kb As Long
                    fs_kb = fs \ 1024 'file size in KB
                    MessageBox.Show("Backup is done!  File size is: " + fs_kb.ToString + " KB")
                End If



            Catch ex As Exception
                Me.prog_Panel1.Visible = False
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Text = percentage_cal(35, 70)
    End Sub
End Class