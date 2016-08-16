<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.dtpReport = New System.Windows.Forms.DateTimePicker()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtFolder = New System.Windows.Forms.TextBox()
        Me.diaFolder = New System.Windows.Forms.SaveFileDialog()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpReport
        '
        Me.dtpReport.Location = New System.Drawing.Point(42, 12)
        Me.dtpReport.Name = "dtpReport"
        Me.dtpReport.Size = New System.Drawing.Size(200, 20)
        Me.dtpReport.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(53, 102)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "Run"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(235, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtFolder
        '
        Me.txtFolder.Location = New System.Drawing.Point(30, 57)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.Size = New System.Drawing.Size(199, 20)
        Me.txtFolder.TabIndex = 3
        '
        'diaFolder
        '
        Me.diaFolder.Filter = """Excel files (*.xls)|*.xls|All files (*.*)|*.*"""
        Me.diaFolder.InitialDirectory = """C:\Users\%username%\Desktop"""
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(134, 102)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtFolder)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.dtpReport)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpReport As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtFolder As System.Windows.Forms.TextBox
    Friend WithEvents diaFolder As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
