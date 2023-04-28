<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Claims
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Claim_codeLabel As System.Windows.Forms.Label
        Dim Afflicted_clientLabel As System.Windows.Forms.Label
        Dim Client_IDLabel As System.Windows.Forms.Label
        Dim Claim_worthLabel As System.Windows.Forms.Label
        Dim Affected_policyLabel As System.Windows.Forms.Label
        Dim Filed_dateLabel As System.Windows.Forms.Label
        Dim Legal_ReportLabel As System.Windows.Forms.Label
        Dim Claim_descriptionLabel As System.Windows.Forms.Label
        Dim Claimed_amountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Claims))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.InsuranceDBDataSet = New INSURANCE_SYSTEM.InsuranceDBDataSet()
        Me.ClaimsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClaimsTableAdapter = New INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.claimsTableAdapter()
        Me.TableAdapterManager = New INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.TableAdapterManager()
        Me.ClaimsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClaimsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Claim_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Afflicted_clientTextBox = New System.Windows.Forms.TextBox()
        Me.Client_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Claim_worthTextBox = New System.Windows.Forms.TextBox()
        Me.Affected_policyTextBox = New System.Windows.Forms.TextBox()
        Me.Filed_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Legal_ReportTextBox = New System.Windows.Forms.TextBox()
        Me.Claim_descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Claimed_amountTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Claim_codeLabel = New System.Windows.Forms.Label()
        Afflicted_clientLabel = New System.Windows.Forms.Label()
        Client_IDLabel = New System.Windows.Forms.Label()
        Claim_worthLabel = New System.Windows.Forms.Label()
        Affected_policyLabel = New System.Windows.Forms.Label()
        Filed_dateLabel = New System.Windows.Forms.Label()
        Legal_ReportLabel = New System.Windows.Forms.Label()
        Claim_descriptionLabel = New System.Windows.Forms.Label()
        Claimed_amountLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClaimsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClaimsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClaimsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Claim_codeLabel
        '
        Claim_codeLabel.AutoSize = True
        Claim_codeLabel.BackColor = System.Drawing.Color.Transparent
        Claim_codeLabel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Claim_codeLabel.ForeColor = System.Drawing.Color.Teal
        Claim_codeLabel.Location = New System.Drawing.Point(371, 206)
        Claim_codeLabel.Name = "Claim_codeLabel"
        Claim_codeLabel.Size = New System.Drawing.Size(96, 18)
        Claim_codeLabel.TabIndex = 66
        Claim_codeLabel.Text = "Claim code:"
        '
        'Afflicted_clientLabel
        '
        Afflicted_clientLabel.AutoSize = True
        Afflicted_clientLabel.BackColor = System.Drawing.Color.Transparent
        Afflicted_clientLabel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Afflicted_clientLabel.ForeColor = System.Drawing.Color.Teal
        Afflicted_clientLabel.Location = New System.Drawing.Point(371, 248)
        Afflicted_clientLabel.Name = "Afflicted_clientLabel"
        Afflicted_clientLabel.Size = New System.Drawing.Size(144, 18)
        Afflicted_clientLabel.TabIndex = 68
        Afflicted_clientLabel.Text = "Afflicted client:"
        '
        'Client_IDLabel
        '
        Client_IDLabel.AutoSize = True
        Client_IDLabel.BackColor = System.Drawing.Color.Transparent
        Client_IDLabel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_IDLabel.ForeColor = System.Drawing.Color.Teal
        Client_IDLabel.Location = New System.Drawing.Point(371, 290)
        Client_IDLabel.Name = "Client_IDLabel"
        Client_IDLabel.Size = New System.Drawing.Size(88, 18)
        Client_IDLabel.TabIndex = 70
        Client_IDLabel.Text = "Client ID:"
        '
        'Claim_worthLabel
        '
        Claim_worthLabel.AutoSize = True
        Claim_worthLabel.BackColor = System.Drawing.Color.Transparent
        Claim_worthLabel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Claim_worthLabel.ForeColor = System.Drawing.Color.Teal
        Claim_worthLabel.Location = New System.Drawing.Point(371, 332)
        Claim_worthLabel.Name = "Claim_worthLabel"
        Claim_worthLabel.Size = New System.Drawing.Size(104, 18)
        Claim_worthLabel.TabIndex = 72
        Claim_worthLabel.Text = "Claim worth:"
        '
        'Affected_policyLabel
        '
        Affected_policyLabel.AutoSize = True
        Affected_policyLabel.BackColor = System.Drawing.Color.Transparent
        Affected_policyLabel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Affected_policyLabel.ForeColor = System.Drawing.Color.Teal
        Affected_policyLabel.Location = New System.Drawing.Point(371, 374)
        Affected_policyLabel.Name = "Affected_policyLabel"
        Affected_policyLabel.Size = New System.Drawing.Size(136, 18)
        Affected_policyLabel.TabIndex = 74
        Affected_policyLabel.Text = "Affected policy:"
        '
        'Filed_dateLabel
        '
        Filed_dateLabel.AutoSize = True
        Filed_dateLabel.BackColor = System.Drawing.Color.Transparent
        Filed_dateLabel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Filed_dateLabel.ForeColor = System.Drawing.Color.Teal
        Filed_dateLabel.Location = New System.Drawing.Point(371, 425)
        Filed_dateLabel.Name = "Filed_dateLabel"
        Filed_dateLabel.Size = New System.Drawing.Size(96, 18)
        Filed_dateLabel.TabIndex = 76
        Filed_dateLabel.Text = "Filed date:"
        '
        'Legal_ReportLabel
        '
        Legal_ReportLabel.AutoSize = True
        Legal_ReportLabel.BackColor = System.Drawing.Color.Transparent
        Legal_ReportLabel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legal_ReportLabel.ForeColor = System.Drawing.Color.Teal
        Legal_ReportLabel.Location = New System.Drawing.Point(903, 238)
        Legal_ReportLabel.Name = "Legal_ReportLabel"
        Legal_ReportLabel.Size = New System.Drawing.Size(112, 18)
        Legal_ReportLabel.TabIndex = 78
        Legal_ReportLabel.Text = "Legal Report:"
        '
        'Claim_descriptionLabel
        '
        Claim_descriptionLabel.AutoSize = True
        Claim_descriptionLabel.BackColor = System.Drawing.Color.Transparent
        Claim_descriptionLabel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Claim_descriptionLabel.ForeColor = System.Drawing.Color.Teal
        Claim_descriptionLabel.Location = New System.Drawing.Point(863, 387)
        Claim_descriptionLabel.Name = "Claim_descriptionLabel"
        Claim_descriptionLabel.Size = New System.Drawing.Size(152, 18)
        Claim_descriptionLabel.TabIndex = 80
        Claim_descriptionLabel.Text = "Claim description:"
        '
        'Claimed_amountLabel
        '
        Claimed_amountLabel.AutoSize = True
        Claimed_amountLabel.BackColor = System.Drawing.Color.Transparent
        Claimed_amountLabel.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Claimed_amountLabel.ForeColor = System.Drawing.Color.Teal
        Claimed_amountLabel.Location = New System.Drawing.Point(852, 463)
        Claimed_amountLabel.Name = "Claimed_amountLabel"
        Claimed_amountLabel.Size = New System.Drawing.Size(128, 18)
        Claimed_amountLabel.TabIndex = 82
        Claimed_amountLabel.Text = "Claimed amount:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Location = New System.Drawing.Point(557, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "DataGrid VIEW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Location = New System.Drawing.Point(358, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button6.FlatAppearance.BorderSize = 3
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Teal
        Me.Button6.Location = New System.Drawing.Point(105, 161)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 29)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "New Client"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button5.FlatAppearance.BorderSize = 3
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Teal
        Me.Button5.Location = New System.Drawing.Point(105, 212)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 29)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Policies"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button4.FlatAppearance.BorderSize = 3
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Teal
        Me.Button4.Location = New System.Drawing.Point(105, 263)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 29)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Claims"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.INSURANCE_SYSTEM.My.Resources.Resources.Sys_Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(54, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.INSURANCE_SYSTEM.My.Resources.Resources.logout1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(1061, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(186, 52)
        Me.Button3.TabIndex = 12
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button7.FlatAppearance.BorderSize = 3
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Teal
        Me.Button7.Location = New System.Drawing.Point(105, 309)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 34)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Agent Profile"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button8.FlatAppearance.BorderSize = 3
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Teal
        Me.Button8.Location = New System.Drawing.Point(753, 78)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(153, 40)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "Client Data"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Teal
        Me.Button9.Location = New System.Drawing.Point(521, 505)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 33)
        Me.Button9.TabIndex = 62
        Me.Button9.Text = "SAVE"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.Control
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Teal
        Me.Button12.Location = New System.Drawing.Point(585, 138)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(46, 32)
        Me.Button12.TabIndex = 65
        Me.Button12.Text = ">"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Teal
        Me.Button11.Location = New System.Drawing.Point(524, 138)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(46, 32)
        Me.Button11.TabIndex = 64
        Me.Button11.Text = "<"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Teal
        Me.Button10.Location = New System.Drawing.Point(346, 505)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(110, 33)
        Me.Button10.TabIndex = 63
        Me.Button10.Text = "DELETE"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Teal
        Me.Button13.Location = New System.Drawing.Point(331, 143)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(110, 27)
        Me.Button13.TabIndex = 61
        Me.Button13.Text = "NEW"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'InsuranceDBDataSet
        '
        Me.InsuranceDBDataSet.DataSetName = "InsuranceDBDataSet"
        Me.InsuranceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClaimsBindingSource
        '
        Me.ClaimsBindingSource.DataMember = "claims"
        Me.ClaimsBindingSource.DataSource = Me.InsuranceDBDataSet
        '
        'ClaimsTableAdapter
        '
        Me.ClaimsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agent_profilesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.claimsTableAdapter = Me.ClaimsTableAdapter
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.PoliciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClaimsBindingNavigator
        '
        Me.ClaimsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClaimsBindingNavigator.BindingSource = Me.ClaimsBindingSource
        Me.ClaimsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClaimsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClaimsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClaimsBindingNavigatorSaveItem})
        Me.ClaimsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClaimsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClaimsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClaimsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClaimsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClaimsBindingNavigator.Name = "ClaimsBindingNavigator"
        Me.ClaimsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClaimsBindingNavigator.Size = New System.Drawing.Size(1301, 25)
        Me.ClaimsBindingNavigator.TabIndex = 66
        Me.ClaimsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ClaimsBindingNavigatorSaveItem
        '
        Me.ClaimsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClaimsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClaimsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClaimsBindingNavigatorSaveItem.Name = "ClaimsBindingNavigatorSaveItem"
        Me.ClaimsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClaimsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Claim_codeTextBox
        '
        Me.Claim_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimsBindingSource, "Claim code", True))
        Me.Claim_codeTextBox.Location = New System.Drawing.Point(557, 206)
        Me.Claim_codeTextBox.Name = "Claim_codeTextBox"
        Me.Claim_codeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Claim_codeTextBox.TabIndex = 67
        '
        'Afflicted_clientTextBox
        '
        Me.Afflicted_clientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimsBindingSource, "Afflicted client", True))
        Me.Afflicted_clientTextBox.Location = New System.Drawing.Point(557, 248)
        Me.Afflicted_clientTextBox.Name = "Afflicted_clientTextBox"
        Me.Afflicted_clientTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Afflicted_clientTextBox.TabIndex = 69
        '
        'Client_IDTextBox
        '
        Me.Client_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimsBindingSource, "Client ID", True))
        Me.Client_IDTextBox.Location = New System.Drawing.Point(557, 290)
        Me.Client_IDTextBox.Name = "Client_IDTextBox"
        Me.Client_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Client_IDTextBox.TabIndex = 71
        '
        'Claim_worthTextBox
        '
        Me.Claim_worthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimsBindingSource, "Claim worth", True))
        Me.Claim_worthTextBox.Location = New System.Drawing.Point(557, 332)
        Me.Claim_worthTextBox.Name = "Claim_worthTextBox"
        Me.Claim_worthTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Claim_worthTextBox.TabIndex = 73
        '
        'Affected_policyTextBox
        '
        Me.Affected_policyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimsBindingSource, "Affected policy", True))
        Me.Affected_policyTextBox.Location = New System.Drawing.Point(557, 374)
        Me.Affected_policyTextBox.Name = "Affected_policyTextBox"
        Me.Affected_policyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Affected_policyTextBox.TabIndex = 75
        '
        'Filed_dateDateTimePicker
        '
        Me.Filed_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClaimsBindingSource, "Filed date", True))
        Me.Filed_dateDateTimePicker.Location = New System.Drawing.Point(557, 424)
        Me.Filed_dateDateTimePicker.Name = "Filed_dateDateTimePicker"
        Me.Filed_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Filed_dateDateTimePicker.TabIndex = 77
        '
        'Legal_ReportTextBox
        '
        Me.Legal_ReportTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimsBindingSource, "Legal Report", True))
        Me.Legal_ReportTextBox.Location = New System.Drawing.Point(1038, 193)
        Me.Legal_ReportTextBox.Multiline = True
        Me.Legal_ReportTextBox.Name = "Legal_ReportTextBox"
        Me.Legal_ReportTextBox.Size = New System.Drawing.Size(200, 63)
        Me.Legal_ReportTextBox.TabIndex = 79
        '
        'Claim_descriptionTextBox
        '
        Me.Claim_descriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimsBindingSource, "Claim description", True))
        Me.Claim_descriptionTextBox.Location = New System.Drawing.Point(1038, 288)
        Me.Claim_descriptionTextBox.Multiline = True
        Me.Claim_descriptionTextBox.Name = "Claim_descriptionTextBox"
        Me.Claim_descriptionTextBox.Size = New System.Drawing.Size(200, 117)
        Me.Claim_descriptionTextBox.TabIndex = 81
        '
        'Claimed_amountTextBox
        '
        Me.Claimed_amountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClaimsBindingSource, "Claimed amount", True))
        Me.Claimed_amountTextBox.Location = New System.Drawing.Point(1038, 461)
        Me.Claimed_amountTextBox.Name = "Claimed_amountTextBox"
        Me.Claimed_amountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Claimed_amountTextBox.TabIndex = 83
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClaimsBindingSource
        Me.ComboBox1.DisplayMember = "Claim code"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1028, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox1.TabIndex = 84
        Me.ComboBox1.ValueMember = "Claim code"
        '
        'Claims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.INSURANCE_SYSTEM.My.Resources.Resources.Custom_Background
        Me.ClientSize = New System.Drawing.Size(1301, 608)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Claim_codeLabel)
        Me.Controls.Add(Me.Claim_codeTextBox)
        Me.Controls.Add(Afflicted_clientLabel)
        Me.Controls.Add(Me.Afflicted_clientTextBox)
        Me.Controls.Add(Client_IDLabel)
        Me.Controls.Add(Me.Client_IDTextBox)
        Me.Controls.Add(Claim_worthLabel)
        Me.Controls.Add(Me.Claim_worthTextBox)
        Me.Controls.Add(Affected_policyLabel)
        Me.Controls.Add(Me.Affected_policyTextBox)
        Me.Controls.Add(Filed_dateLabel)
        Me.Controls.Add(Me.Filed_dateDateTimePicker)
        Me.Controls.Add(Legal_ReportLabel)
        Me.Controls.Add(Me.Legal_ReportTextBox)
        Me.Controls.Add(Claim_descriptionLabel)
        Me.Controls.Add(Me.Claim_descriptionTextBox)
        Me.Controls.Add(Claimed_amountLabel)
        Me.Controls.Add(Me.Claimed_amountTextBox)
        Me.Controls.Add(Me.ClaimsBindingNavigator)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Claims"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientProfile"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClaimsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClaimsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClaimsBindingNavigator.ResumeLayout(False)
        Me.ClaimsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents InsuranceDBDataSet As InsuranceDBDataSet
    Friend WithEvents ClaimsBindingSource As BindingSource
    Friend WithEvents ClaimsTableAdapter As InsuranceDBDataSetTableAdapters.claimsTableAdapter
    Friend WithEvents TableAdapterManager As InsuranceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClaimsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ClaimsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Claim_codeTextBox As TextBox
    Friend WithEvents Afflicted_clientTextBox As TextBox
    Friend WithEvents Client_IDTextBox As TextBox
    Friend WithEvents Claim_worthTextBox As TextBox
    Friend WithEvents Affected_policyTextBox As TextBox
    Friend WithEvents Filed_dateDateTimePicker As DateTimePicker
    Friend WithEvents Legal_ReportTextBox As TextBox
    Friend WithEvents Claim_descriptionTextBox As TextBox
    Friend WithEvents Claimed_amountTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
