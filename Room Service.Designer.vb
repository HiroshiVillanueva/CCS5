<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room_Service
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSrvType = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_PopulateGrid = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtSrvID = New System.Windows.Forms.TextBox()
        Me.dgtvSrv = New System.Windows.Forms.DataGridView()
        Me.srvid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.srvName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOpenRequest = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgtvSrv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSrvType
        '
        Me.txtSrvType.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtSrvType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSrvType.ForeColor = System.Drawing.Color.White
        Me.txtSrvType.FormattingEnabled = True
        Me.txtSrvType.Items.AddRange(New Object() {"Laundry", "Resupply", "Cleaning", "Massage"})
        Me.txtSrvType.Location = New System.Drawing.Point(33, 300)
        Me.txtSrvType.Name = "txtSrvType"
        Me.txtSrvType.Size = New System.Drawing.Size(271, 23)
        Me.txtSrvType.TabIndex = 27
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(380, 108)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(270, 25)
        Me.txtSearch.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(376, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 21)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Type - Search:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_PopulateGrid
        '
        Me.btn_PopulateGrid.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_PopulateGrid.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btn_PopulateGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_PopulateGrid.ForeColor = System.Drawing.Color.White
        Me.btn_PopulateGrid.Location = New System.Drawing.Point(945, 473)
        Me.btn_PopulateGrid.Name = "btn_PopulateGrid"
        Me.btn_PopulateGrid.Size = New System.Drawing.Size(177, 24)
        Me.btn_PopulateGrid.TabIndex = 23
        Me.btn_PopulateGrid.Text = "CLEAR SELECTION"
        Me.btn_PopulateGrid.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(333, 493)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 33)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(177, 493)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(150, 33)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Service Type"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(21, 493)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(150, 33)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "INSERT"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCost.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.ForeColor = System.Drawing.Color.White
        Me.txtCost.Location = New System.Drawing.Point(33, 213)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(270, 25)
        Me.txtCost.TabIndex = 13
        '
        'txtSrvID
        '
        Me.txtSrvID.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtSrvID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSrvID.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrvID.ForeColor = System.Drawing.Color.White
        Me.txtSrvID.Location = New System.Drawing.Point(34, 139)
        Me.txtSrvID.Name = "txtSrvID"
        Me.txtSrvID.Size = New System.Drawing.Size(270, 25)
        Me.txtSrvID.TabIndex = 12
        '
        'dgtvSrv
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.dgtvSrv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgtvSrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtvSrv.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dgtvSrv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgtvSrv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgtvSrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtvSrv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srvid, Me.cost, Me.type, Me.srvName})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtvSrv.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgtvSrv.GridColor = System.Drawing.Color.DarkSlateGray
        Me.dgtvSrv.Location = New System.Drawing.Point(365, 139)
        Me.dgtvSrv.Name = "dgtvSrv"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgtvSrv.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgtvSrv.RowHeadersVisible = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.dgtvSrv.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgtvSrv.Size = New System.Drawing.Size(757, 328)
        Me.dgtvSrv.TabIndex = 11
        '
        'srvid
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.NullValue = "0000"
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.srvid.DefaultCellStyle = DataGridViewCellStyle11
        Me.srvid.FillWeight = 50.0!
        Me.srvid.HeaderText = "Service ID"
        Me.srvid.Name = "srvid"
        '
        'cost
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.cost.DefaultCellStyle = DataGridViewCellStyle12
        Me.cost.HeaderText = "Service Cost"
        Me.cost.Name = "cost"
        '
        'type
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.SlateGray
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.type.DefaultCellStyle = DataGridViewCellStyle13
        Me.type.HeaderText = "Service Type"
        Me.type.Name = "type"
        '
        'srvName
        '
        Me.srvName.HeaderText = "Service Name"
        Me.srvName.Name = "srvName"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.btnOpenRequest)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSrvType)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btn_PopulateGrid)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtCost)
        Me.Panel1.Controls.Add(Me.txtSrvID)
        Me.Panel1.Controls.Add(Me.dgtvSrv)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Title)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1165, 547)
        Me.Panel1.TabIndex = 2
        '
        'btnOpenRequest
        '
        Me.btnOpenRequest.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnOpenRequest.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnOpenRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpenRequest.ForeColor = System.Drawing.Color.White
        Me.btnOpenRequest.Location = New System.Drawing.Point(596, 473)
        Me.btnOpenRequest.Name = "btnOpenRequest"
        Me.btnOpenRequest.Size = New System.Drawing.Size(177, 24)
        Me.btnOpenRequest.TabIndex = 30
        Me.btnOpenRequest.Text = "OPEN SERVICE REQUEST"
        Me.btnOpenRequest.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(33, 375)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(270, 25)
        Me.txtName.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 21)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Service Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cost"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Service ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1050, 17)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(51, 28)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(45, 13)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(416, 36)
        Me.Title.TabIndex = 1
        Me.Title.Text = "ROOM SERVICE DASHBOARD"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(20, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1123, 10)
        Me.Panel2.TabIndex = 0
        '
        'Room_Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1189, 553)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Room_Service"
        Me.Text = "Room_Service"
        CType(Me.dgtvSrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSrvType As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_PopulateGrid As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtSrvID As System.Windows.Forms.TextBox
    Friend WithEvents dgtvSrv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents srvid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOpenRequest As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents srvName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
