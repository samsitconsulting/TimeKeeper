<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAdjustTime = New System.Windows.Forms.Button()
        Me.btnLogTime = New System.Windows.Forms.Button()
        Me.btnGenerateRpt = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(61, 87)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(265, 58)
        Me.btnCreateUser.TabIndex = 0
        Me.btnCreateUser.Text = "Create/Update User"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnAdjustTime
        '
        Me.btnAdjustTime.Location = New System.Drawing.Point(61, 152)
        Me.btnAdjustTime.Name = "btnAdjustTime"
        Me.btnAdjustTime.Size = New System.Drawing.Size(265, 58)
        Me.btnAdjustTime.TabIndex = 6
        Me.btnAdjustTime.Text = "Adjust Time"
        Me.btnAdjustTime.UseVisualStyleBackColor = True
        '
        'btnLogTime
        '
        Me.btnLogTime.Location = New System.Drawing.Point(61, 216)
        Me.btnLogTime.Name = "btnLogTime"
        Me.btnLogTime.Size = New System.Drawing.Size(265, 58)
        Me.btnLogTime.TabIndex = 7
        Me.btnLogTime.Text = "Log Time"
        Me.btnLogTime.UseVisualStyleBackColor = True
        '
        'btnGenerateRpt
        '
        Me.btnGenerateRpt.Location = New System.Drawing.Point(61, 280)
        Me.btnGenerateRpt.Name = "btnGenerateRpt"
        Me.btnGenerateRpt.Size = New System.Drawing.Size(265, 58)
        Me.btnGenerateRpt.TabIndex = 8
        Me.btnGenerateRpt.Text = "Generate Reports"
        Me.btnGenerateRpt.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGenerateRpt)
        Me.Controls.Add(Me.btnLogTime)
        Me.Controls.Add(Me.btnAdjustTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCreateUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdjustTime As System.Windows.Forms.Button
    Friend WithEvents btnLogTime As System.Windows.Forms.Button
    Friend WithEvents btnGenerateRpt As System.Windows.Forms.Button
End Class
