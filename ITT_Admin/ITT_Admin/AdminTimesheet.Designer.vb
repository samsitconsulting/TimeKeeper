<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminTimesheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminTimesheet))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTimeIn = New System.Windows.Forms.Label()
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpTimesheet = New System.Windows.Forms.DateTimePicker()
        Me.btnSignIn_Out = New System.Windows.Forms.Button()
        Me.txtSignIn = New System.Windows.Forms.DateTimePicker()
        Me.txtSignOut = New System.Windows.Forms.DateTimePicker()
        Me.cbxUsers = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(304, 332)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTimeIn
        '
        Me.lblTimeIn.AutoSize = True
        Me.lblTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIn.Location = New System.Drawing.Point(59, 149)
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.Size = New System.Drawing.Size(137, 25)
        Me.lblTimeIn.TabIndex = 1
        Me.lblTimeIn.Text = "Sign In Time:"
        '
        'lblTimeOut
        '
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.Location = New System.Drawing.Point(59, 220)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(154, 25)
        Me.lblTimeOut.TabIndex = 2
        Me.lblTimeOut.Text = "Sign Out Time:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'dtpTimesheet
        '
        Me.dtpTimesheet.Location = New System.Drawing.Point(193, 82)
        Me.dtpTimesheet.Name = "dtpTimesheet"
        Me.dtpTimesheet.Size = New System.Drawing.Size(194, 20)
        Me.dtpTimesheet.TabIndex = 6
        '
        'btnSignIn_Out
        '
        Me.btnSignIn_Out.Location = New System.Drawing.Point(137, 279)
        Me.btnSignIn_Out.Name = "btnSignIn_Out"
        Me.btnSignIn_Out.Size = New System.Drawing.Size(125, 52)
        Me.btnSignIn_Out.TabIndex = 8
        Me.btnSignIn_Out.Text = "Sign In/Out"
        Me.btnSignIn_Out.UseVisualStyleBackColor = True
        '
        'txtSignIn
        '
        Me.txtSignIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtSignIn.Location = New System.Drawing.Point(226, 152)
        Me.txtSignIn.Name = "txtSignIn"
        Me.txtSignIn.ShowUpDown = True
        Me.txtSignIn.Size = New System.Drawing.Size(143, 20)
        Me.txtSignIn.TabIndex = 11
        '
        'txtSignOut
        '
        Me.txtSignOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtSignOut.Location = New System.Drawing.Point(226, 223)
        Me.txtSignOut.Name = "txtSignOut"
        Me.txtSignOut.ShowUpDown = True
        Me.txtSignOut.Size = New System.Drawing.Size(143, 20)
        Me.txtSignOut.TabIndex = 12
        '
        'cbxUsers
        '
        Me.cbxUsers.DisplayMember = "user_id"
        Me.cbxUsers.FormattingEnabled = True
        Me.cbxUsers.Location = New System.Drawing.Point(8, 81)
        Me.cbxUsers.Name = "cbxUsers"
        Me.cbxUsers.Size = New System.Drawing.Size(176, 21)
        Me.cbxUsers.TabIndex = 13
        Me.cbxUsers.ValueMember = "user_id"
        '
        'AdminTimesheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbxUsers)
        Me.Controls.Add(Me.txtSignOut)
        Me.Controls.Add(Me.txtSignIn)
        Me.Controls.Add(Me.btnSignIn_Out)
        Me.Controls.Add(Me.dtpTimesheet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTimeOut)
        Me.Controls.Add(Me.lblTimeIn)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminTimesheet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTimeIn As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtpTimesheet As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSignIn_Out As System.Windows.Forms.Button
    Friend WithEvents txtSignIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSignOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxUsers As System.Windows.Forms.ComboBox
End Class
