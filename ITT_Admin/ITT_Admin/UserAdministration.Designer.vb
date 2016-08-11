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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAdministration))
        Me.chkChangePassword = New System.Windows.Forms.CheckBox()
        Me.chkIsAdmin = New System.Windows.Forms.CheckBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbxUsers = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkChangePassword
        '
        Me.chkChangePassword.AutoSize = True
        Me.chkChangePassword.Location = New System.Drawing.Point(137, 204)
        Me.chkChangePassword.Name = "chkChangePassword"
        Me.chkChangePassword.Size = New System.Drawing.Size(112, 17)
        Me.chkChangePassword.TabIndex = 0
        Me.chkChangePassword.Text = "Change Password"
        Me.chkChangePassword.UseVisualStyleBackColor = True
        '
        'chkIsAdmin
        '
        Me.chkIsAdmin.AutoSize = True
        Me.chkIsAdmin.Location = New System.Drawing.Point(137, 227)
        Me.chkIsAdmin.Name = "chkIsAdmin"
        Me.chkIsAdmin.Size = New System.Drawing.Size(66, 17)
        Me.chkIsAdmin.TabIndex = 1
        Me.chkIsAdmin.Text = "Is Admin"
        Me.chkIsAdmin.UseVisualStyleBackColor = True
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(137, 165)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(160, 20)
        Me.txtFullname.TabIndex = 2
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(137, 129)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(160, 20)
        Me.txtUserId.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(231, 321)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(312, 321)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cbxUsers
        '
        Me.cbxUsers.FormattingEnabled = True
        Me.cbxUsers.Location = New System.Drawing.Point(12, 76)
        Me.cbxUsers.Name = "cbxUsers"
        Me.cbxUsers.Size = New System.Drawing.Size(202, 21)
        Me.cbxUsers.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'UserAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbxUsers)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.chkIsAdmin)
        Me.Controls.Add(Me.chkChangePassword)
        Me.Name = "UserAdministration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkChangePassword As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cbxUsers As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
