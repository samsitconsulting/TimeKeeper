<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timesheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Timesheet))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTimeIn = New System.Windows.Forms.Label()
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblTimeInData = New System.Windows.Forms.Label()
        Me.btnSignIn_Out = New System.Windows.Forms.Button()
        Me.lblTimeOutData = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(320, 348)
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(199, 82)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'lblTimeInData
        '
        Me.lblTimeInData.AutoSize = True
        Me.lblTimeInData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeInData.Location = New System.Drawing.Point(272, 160)
        Me.lblTimeInData.Name = "lblTimeInData"
        Me.lblTimeInData.Size = New System.Drawing.Size(0, 25)
        Me.lblTimeInData.TabIndex = 7
        '
        'btnSignIn_Out
        '
        Me.btnSignIn_Out.Location = New System.Drawing.Point(147, 294)
        Me.btnSignIn_Out.Name = "btnSignIn_Out"
        Me.btnSignIn_Out.Size = New System.Drawing.Size(125, 52)
        Me.btnSignIn_Out.TabIndex = 8
        Me.btnSignIn_Out.Text = "Sign In/Out"
        Me.btnSignIn_Out.UseVisualStyleBackColor = True
        '
        'lblTimeOutData
        '
        Me.lblTimeOutData.AutoSize = True
        Me.lblTimeOutData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOutData.Location = New System.Drawing.Point(272, 220)
        Me.lblTimeOutData.Name = "lblTimeOutData"
        Me.lblTimeOutData.Size = New System.Drawing.Size(0, 25)
        Me.lblTimeOutData.TabIndex = 9
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblUsername.Location = New System.Drawing.Point(13, 83)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(0, 20)
        Me.lblUsername.TabIndex = 10
        '
        'Timesheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTimeOutData)
        Me.Controls.Add(Me.btnSignIn_Out)
        Me.Controls.Add(Me.lblTimeInData)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTimeOut)
        Me.Controls.Add(Me.lblTimeIn)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Timesheet"
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
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTimeInData As System.Windows.Forms.Label
    Friend WithEvents btnSignIn_Out As System.Windows.Forms.Button
    Friend WithEvents lblTimeOutData As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
End Class
