<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePwd
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
        Me.txtCurrentPwd = New System.Windows.Forms.TextBox()
        Me.txtNewPwd = New System.Windows.Forms.TextBox()
        Me.txtNewPwdChk = New System.Windows.Forms.TextBox()
        Me.lblCurrentPwd = New System.Windows.Forms.Label()
        Me.lblNewPwd = New System.Windows.Forms.Label()
        Me.lblNewPwdChk = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New ITT_Admin.Database1DataSet1()
        Me.LoginTableAdapter = New ITT_Admin.Database1DataSet1TableAdapters.loginTableAdapter()
        Me.TableAdapterManager1 = New ITT_Admin.Database1DataSet1TableAdapters.TableAdapterManager()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCurrentPwd
        '
        Me.txtCurrentPwd.Location = New System.Drawing.Point(156, 26)
        Me.txtCurrentPwd.Name = "txtCurrentPwd"
        Me.txtCurrentPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPwd.Size = New System.Drawing.Size(215, 20)
        Me.txtCurrentPwd.TabIndex = 0
        '
        'txtNewPwd
        '
        Me.txtNewPwd.Location = New System.Drawing.Point(156, 64)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd.Size = New System.Drawing.Size(215, 20)
        Me.txtNewPwd.TabIndex = 1
        '
        'txtNewPwdChk
        '
        Me.txtNewPwdChk.Location = New System.Drawing.Point(156, 97)
        Me.txtNewPwdChk.Name = "txtNewPwdChk"
        Me.txtNewPwdChk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwdChk.Size = New System.Drawing.Size(215, 20)
        Me.txtNewPwdChk.TabIndex = 2
        '
        'lblCurrentPwd
        '
        Me.lblCurrentPwd.AutoSize = True
        Me.lblCurrentPwd.Location = New System.Drawing.Point(54, 32)
        Me.lblCurrentPwd.Name = "lblCurrentPwd"
        Me.lblCurrentPwd.Size = New System.Drawing.Size(93, 13)
        Me.lblCurrentPwd.TabIndex = 3
        Me.lblCurrentPwd.Text = "Current Password:"
        '
        'lblNewPwd
        '
        Me.lblNewPwd.AutoSize = True
        Me.lblNewPwd.Location = New System.Drawing.Point(66, 71)
        Me.lblNewPwd.Name = "lblNewPwd"
        Me.lblNewPwd.Size = New System.Drawing.Size(81, 13)
        Me.lblNewPwd.TabIndex = 4
        Me.lblNewPwd.Text = "New Password:"
        '
        'lblNewPwdChk
        '
        Me.lblNewPwdChk.AutoSize = True
        Me.lblNewPwdChk.Location = New System.Drawing.Point(29, 104)
        Me.lblNewPwdChk.Name = "lblNewPwdChk"
        Me.lblNewPwdChk.Size = New System.Drawing.Size(118, 13)
        Me.lblNewPwdChk.TabIndex = 5
        Me.lblNewPwdChk.Text = "Retype New Password:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(325, 127)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.loginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ITT_Admin.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ChangePwd
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblNewPwdChk)
        Me.Controls.Add(Me.lblNewPwd)
        Me.Controls.Add(Me.lblCurrentPwd)
        Me.Controls.Add(Me.txtNewPwdChk)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.txtCurrentPwd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCurrentPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPwdChk As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentPwd As System.Windows.Forms.Label
    Friend WithEvents lblNewPwd As System.Windows.Forms.Label
    Friend WithEvents lblNewPwdChk As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet1 As ITT_Admin.Database1DataSet1
    Friend WithEvents LoginTableAdapter As ITT_Admin.Database1DataSet1TableAdapters.loginTableAdapter
    Friend WithEvents TableAdapterManager1 As ITT_Admin.Database1DataSet1TableAdapters.TableAdapterManager
End Class
