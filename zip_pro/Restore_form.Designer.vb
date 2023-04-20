<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restore_form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.prog_Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.path_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Help_Button3 = New System.Windows.Forms.Button()
        Me.Start_Button2 = New System.Windows.Forms.Button()
        Me.Browse_Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.prog_Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 74)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Note: Backup file must be in hard drive, not in CD or DVD."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.prog_Panel2)
        Me.GroupBox1.Controls.Add(Me.path_TextBox1)
        Me.GroupBox1.Controls.Add(Me.Help_Button3)
        Me.GroupBox1.Controls.Add(Me.Start_Button2)
        Me.GroupBox1.Controls.Add(Me.Browse_Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(987, 202)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'prog_Panel2
        '
        Me.prog_Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.prog_Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prog_Panel2.Controls.Add(Me.Label3)
        Me.prog_Panel2.Controls.Add(Me.Label2)
        Me.prog_Panel2.Location = New System.Drawing.Point(322, 34)
        Me.prog_Panel2.Name = "prog_Panel2"
        Me.prog_Panel2.Size = New System.Drawing.Size(317, 142)
        Me.prog_Panel2.TabIndex = 4
        Me.prog_Panel2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(88, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Restoring backup..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(111, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please wait!"
        '
        'path_TextBox1
        '
        Me.path_TextBox1.Location = New System.Drawing.Point(163, 54)
        Me.path_TextBox1.Name = "path_TextBox1"
        Me.path_TextBox1.ReadOnly = True
        Me.path_TextBox1.Size = New System.Drawing.Size(767, 24)
        Me.path_TextBox1.TabIndex = 3
        '
        'Help_Button3
        '
        Me.Help_Button3.Location = New System.Drawing.Point(855, 149)
        Me.Help_Button3.Name = "Help_Button3"
        Me.Help_Button3.Size = New System.Drawing.Size(75, 47)
        Me.Help_Button3.TabIndex = 2
        Me.Help_Button3.Text = "Help"
        Me.Help_Button3.UseVisualStyleBackColor = True
        '
        'Start_Button2
        '
        Me.Start_Button2.Location = New System.Drawing.Point(35, 95)
        Me.Start_Button2.Name = "Start_Button2"
        Me.Start_Button2.Size = New System.Drawing.Size(116, 37)
        Me.Start_Button2.TabIndex = 1
        Me.Start_Button2.Text = "Start"
        Me.Start_Button2.UseVisualStyleBackColor = True
        '
        'Browse_Button1
        '
        Me.Browse_Button1.Location = New System.Drawing.Point(35, 48)
        Me.Browse_Button1.Name = "Browse_Button1"
        Me.Browse_Button1.Size = New System.Drawing.Size(116, 37)
        Me.Browse_Button1.TabIndex = 0
        Me.Browse_Button1.Text = "Select Backup"
        Me.Browse_Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Restore_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1012, 323)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Restore_form"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore Data"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.prog_Panel2.ResumeLayout(False)
        Me.prog_Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents prog_Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents path_TextBox1 As TextBox
    Friend WithEvents Help_Button3 As Button
    Friend WithEvents Start_Button2 As Button
    Friend WithEvents Browse_Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
