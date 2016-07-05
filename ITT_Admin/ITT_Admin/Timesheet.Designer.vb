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
        Me.components = New System.ComponentModel.Container()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.time_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.work_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updated_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updated_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimesheetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New ITT_Admin.Database1DataSet1()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TimesheetTableAdapter = New ITT_Admin.Database1DataSet1TableAdapters.timesheetTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimesheetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(207, 82)
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.time_id, Me.user_id, Me.work_date, Me.time_in, Me.time_out, Me.created_date, Me.created_by, Me.updated_date, Me.updated_by})
        Me.DataGridView1.DataSource = Me.TimesheetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 11
        Me.DataGridView1.Visible = False
        '
        'time_id
        '
        Me.time_id.DataPropertyName = "time_id"
        Me.time_id.HeaderText = "time_id"
        Me.time_id.Name = "time_id"
        '
        'user_id
        '
        Me.user_id.DataPropertyName = "user_id"
        Me.user_id.HeaderText = "user_id"
        Me.user_id.Name = "user_id"
        '
        'work_date
        '
        Me.work_date.DataPropertyName = "work_date"
        Me.work_date.HeaderText = "work_date"
        Me.work_date.Name = "work_date"
        '
        'time_in
        '
        Me.time_in.DataPropertyName = "time_in"
        Me.time_in.HeaderText = "time_in"
        Me.time_in.Name = "time_in"
        '
        'time_out
        '
        Me.time_out.DataPropertyName = "time_out"
        Me.time_out.HeaderText = "time_out"
        Me.time_out.Name = "time_out"
        '
        'created_date
        '
        Me.created_date.DataPropertyName = "created_date"
        Me.created_date.HeaderText = "created_date"
        Me.created_date.Name = "created_date"
        '
        'created_by
        '
        Me.created_by.DataPropertyName = "created_by"
        Me.created_by.HeaderText = "created_by"
        Me.created_by.Name = "created_by"
        '
        'updated_date
        '
        Me.updated_date.DataPropertyName = "updated_date"
        Me.updated_date.HeaderText = "updated_date"
        Me.updated_date.Name = "updated_date"
        '
        'updated_by
        '
        Me.updated_by.DataPropertyName = "updated_by"
        Me.updated_by.HeaderText = "updated_by"
        Me.updated_by.Name = "updated_by"
        '
        'TimesheetBindingSource
        '
        Me.TimesheetBindingSource.DataMember = "timesheet"
        Me.TimesheetBindingSource.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(411, 25)
        Me.FillByToolStrip.TabIndex = 12
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(35, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'TimesheetTableAdapter
        '
        Me.TimesheetTableAdapter.ClearBeforeFill = True
        '
        'Timesheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DataGridView1)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimesheetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet1 As ITT_Admin.Database1DataSet1
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTimeIn As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTimeInData As System.Windows.Forms.Label
    Friend WithEvents btnSignIn_Out As System.Windows.Forms.Button
    Friend WithEvents lblTimeOutData As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents TimesheetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TimesheetTableAdapter As ITT_Admin.Database1DataSet1TableAdapters.timesheetTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents time_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents work_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents time_in As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents time_out As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents created_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents created_by As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents updated_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents updated_by As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
