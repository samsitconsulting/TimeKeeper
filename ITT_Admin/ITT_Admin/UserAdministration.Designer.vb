<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAdministration
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAdministration))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbxUsers = New System.Windows.Forms.ComboBox()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New ITT_Admin.Database1DataSet1()
        Me.LoginTableAdapter = New ITT_Admin.Database1DataSet1TableAdapters.loginTableAdapter()
        Me.chkIsAdmin = New System.Windows.Forms.CheckBox()
        Me.chkChangePassword = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'cbxUsers
        '
        Me.cbxUsers.FormattingEnabled = True
        Me.cbxUsers.Location = New System.Drawing.Point(13, 78)
        Me.cbxUsers.Name = "cbxUsers"
        Me.cbxUsers.Size = New System.Drawing.Size(209, 21)
        Me.cbxUsers.TabIndex = 7
        Me.cbxUsers.ValueMember = "user_id"
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "login"
        Me.LoginBindingSource.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'chkIsAdmin
        '
        Me.chkIsAdmin.AutoSize = True
        Me.chkIsAdmin.Location = New System.Drawing.Point(150, 207)
        Me.chkIsAdmin.Name = "chkIsAdmin"
        Me.chkIsAdmin.Size = New System.Drawing.Size(62, 17)
        Me.chkIsAdmin.TabIndex = 8
        Me.chkIsAdmin.Text = "isAdmin"
        Me.chkIsAdmin.UseVisualStyleBackColor = True
        '
        'chkChangePassword
        '
        Me.chkChangePassword.AutoSize = True
        Me.chkChangePassword.Checked = True
        Me.chkChangePassword.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChangePassword.Location = New System.Drawing.Point(150, 230)
        Me.chkChangePassword.Name = "chkChangePassword"
        Me.chkChangePassword.Size = New System.Drawing.Size(112, 17)
        Me.chkChangePassword.TabIndex = 9
        Me.chkChangePassword.Text = "Change Password"
        Me.chkChangePassword.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(233, 342)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "Submit"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(314, 342)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Location = New System.Drawing.Point(86, 136)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(43, 13)
        Me.lblUserId.TabIndex = 12
        Me.lblUserId.Text = "User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fullname"
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(139, 133)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(170, 20)
        Me.txtUserId.TabIndex = 14
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(138, 166)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(170, 20)
        Me.txtFullname.TabIndex = 15
        '
        'UserAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chkChangePassword)
        Me.Controls.Add(Me.chkIsAdmin)
        Me.Controls.Add(Me.cbxUsers)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UserAdministration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbxUsers As System.Windows.Forms.ComboBox
    Friend WithEvents Database1DataSet1 As ITT_Admin.Database1DataSet1
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As ITT_Admin.Database1DataSet1TableAdapters.loginTableAdapter
    Friend WithEvents chkIsAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents chkChangePassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblUserId As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
End Class
