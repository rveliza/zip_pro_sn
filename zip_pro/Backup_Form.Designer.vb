<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.prog_Panel1 = New System.Windows.Forms.Panel()
        Me.main_Label4 = New System.Windows.Forms.Label()
        Me.main_ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.sub_Label3 = New System.Windows.Forms.Label()
        Me.sub_ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.prog_Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.file_path_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.prog_Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.prog_Panel1)
        Me.GroupBox1.Controls.Add(Me.file_path_TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 241)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'prog_Panel1
        '
        Me.prog_Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.prog_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prog_Panel1.Controls.Add(Me.main_Label4)
        Me.prog_Panel1.Controls.Add(Me.main_ProgressBar2)
        Me.prog_Panel1.Controls.Add(Me.sub_Label3)
        Me.prog_Panel1.Controls.Add(Me.sub_ProgressBar1)
        Me.prog_Panel1.Controls.Add(Me.Panel2)
        Me.prog_Panel1.Controls.Add(Me.prog_Label2)
        Me.prog_Panel1.Controls.Add(Me.Label1)
        Me.prog_Panel1.Location = New System.Drawing.Point(126, 26)
        Me.prog_Panel1.Name = "prog_Panel1"
        Me.prog_Panel1.Size = New System.Drawing.Size(303, 139)
        Me.prog_Panel1.TabIndex = 0
        Me.prog_Panel1.Visible = False
        '
        'main_Label4
        '
        Me.main_Label4.Location = New System.Drawing.Point(258, 89)
        Me.main_Label4.Name = "main_Label4"
        Me.main_Label4.Size = New System.Drawing.Size(39, 23)
        Me.main_Label4.TabIndex = 6
        Me.main_Label4.Text = "0"
        Me.main_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'main_ProgressBar2
        '
        Me.main_ProgressBar2.Location = New System.Drawing.Point(4, 89)
        Me.main_ProgressBar2.Name = "main_ProgressBar2"
        Me.main_ProgressBar2.Size = New System.Drawing.Size(244, 23)
        Me.main_ProgressBar2.TabIndex = 5
        '
        'sub_Label3
        '
        Me.sub_Label3.Location = New System.Drawing.Point(258, 63)
        Me.sub_Label3.Name = "sub_Label3"
        Me.sub_Label3.Size = New System.Drawing.Size(39, 23)
        Me.sub_Label3.TabIndex = 4
        Me.sub_Label3.Text = "0"
        Me.sub_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sub_ProgressBar1
        '
        Me.sub_ProgressBar1.Location = New System.Drawing.Point(4, 63)
        Me.sub_ProgressBar1.Name = "sub_ProgressBar1"
        Me.sub_ProgressBar1.Size = New System.Drawing.Size(244, 23)
        Me.sub_ProgressBar1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(-3, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(305, 1)
        Me.Panel2.TabIndex = 2
        '
        'prog_Label2
        '
        Me.prog_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prog_Label2.ForeColor = System.Drawing.Color.Green
        Me.prog_Label2.Location = New System.Drawing.Point(23, 26)
        Me.prog_Label2.Name = "prog_Label2"
        Me.prog_Label2.Size = New System.Drawing.Size(255, 22)
        Me.prog_Label2.TabIndex = 1
        Me.prog_Label2.Text = "Backup in Progress"
        Me.prog_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(23, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Wait"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'file_path_TextBox1
        '
        Me.file_path_TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.file_path_TextBox1.Location = New System.Drawing.Point(180, 27)
        Me.file_path_TextBox1.Name = "file_path_TextBox1"
        Me.file_path_TextBox1.ReadOnly = True
        Me.file_path_TextBox1.Size = New System.Drawing.Size(291, 22)
        Me.file_path_TextBox1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(359, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 39)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Help"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(47, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Start"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Backup Path"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Backup_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(566, 302)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Backup_Form"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.prog_Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents file_path_TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents prog_Panel1 As Panel
    Friend WithEvents sub_Label3 As Label
    Friend WithEvents sub_ProgressBar1 As ProgressBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents prog_Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents main_ProgressBar2 As ProgressBar
    Friend WithEvents main_Label4 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
