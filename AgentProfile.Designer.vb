<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgentProfile
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
        Dim Agent_CodeLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Agent_MobileLabel As System.Windows.Forms.Label
        Dim Agent_addressLabel As System.Windows.Forms.Label
        Dim Agent_statusLabel As System.Windows.Forms.Label
        Dim About_agentLabel As System.Windows.Forms.Label
        Dim Agent_photoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgentProfile))
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Agent_profilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InsuranceDBDataSet = New INSURANCE_SYSTEM.InsuranceDBDataSet()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Agent_profilesTableAdapter = New INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.Agent_profilesTableAdapter()
        Me.TableAdapterManager = New INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.TableAdapterManager()
        Me.Agent_profilesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Agent_profilesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Agent_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Agent_MobileTextBox = New System.Windows.Forms.TextBox()
        Me.Agent_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Agent_statusTextBox = New System.Windows.Forms.TextBox()
        Me.About_agentTextBox = New System.Windows.Forms.TextBox()
        Me.Agent_photoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Agent_CodeLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Agent_MobileLabel = New System.Windows.Forms.Label()
        Agent_addressLabel = New System.Windows.Forms.Label()
        Agent_statusLabel = New System.Windows.Forms.Label()
        About_agentLabel = New System.Windows.Forms.Label()
        Agent_photoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agent_profilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agent_profilesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agent_profilesBindingNavigator.SuspendLayout()
        CType(Me.Agent_photoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agent_CodeLabel
        '
        Agent_CodeLabel.AutoSize = True
        Agent_CodeLabel.BackColor = System.Drawing.Color.Transparent
        Agent_CodeLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_CodeLabel.ForeColor = System.Drawing.Color.Teal
        Agent_CodeLabel.Location = New System.Drawing.Point(362, 239)
        Agent_CodeLabel.Name = "Agent_CodeLabel"
        Agent_CodeLabel.Size = New System.Drawing.Size(84, 15)
        Agent_CodeLabel.TabIndex = 61
        Agent_CodeLabel.Text = "Agent Code:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.Transparent
        First_NameLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.Color.Teal
        First_NameLabel.Location = New System.Drawing.Point(362, 281)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(84, 15)
        First_NameLabel.TabIndex = 63
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.Transparent
        Last_NameLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.ForeColor = System.Drawing.Color.Teal
        Last_NameLabel.Location = New System.Drawing.Point(362, 323)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(77, 15)
        Last_NameLabel.TabIndex = 65
        Last_NameLabel.Text = "Last Name:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.BackColor = System.Drawing.Color.Transparent
        LocationLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.ForeColor = System.Drawing.Color.Teal
        LocationLabel.Location = New System.Drawing.Point(362, 365)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(70, 15)
        LocationLabel.TabIndex = 67
        LocationLabel.Text = "Location:"
        '
        'Agent_MobileLabel
        '
        Agent_MobileLabel.AutoSize = True
        Agent_MobileLabel.BackColor = System.Drawing.Color.Transparent
        Agent_MobileLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_MobileLabel.ForeColor = System.Drawing.Color.Teal
        Agent_MobileLabel.Location = New System.Drawing.Point(362, 407)
        Agent_MobileLabel.Name = "Agent_MobileLabel"
        Agent_MobileLabel.Size = New System.Drawing.Size(98, 15)
        Agent_MobileLabel.TabIndex = 69
        Agent_MobileLabel.Text = "Agent Mobile:"
        '
        'Agent_addressLabel
        '
        Agent_addressLabel.AutoSize = True
        Agent_addressLabel.BackColor = System.Drawing.Color.Transparent
        Agent_addressLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_addressLabel.ForeColor = System.Drawing.Color.Teal
        Agent_addressLabel.Location = New System.Drawing.Point(963, 364)
        Agent_addressLabel.Name = "Agent_addressLabel"
        Agent_addressLabel.Size = New System.Drawing.Size(105, 15)
        Agent_addressLabel.TabIndex = 71
        Agent_addressLabel.Text = "Agent address:"
        '
        'Agent_statusLabel
        '
        Agent_statusLabel.AutoSize = True
        Agent_statusLabel.BackColor = System.Drawing.Color.Transparent
        Agent_statusLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_statusLabel.ForeColor = System.Drawing.Color.Teal
        Agent_statusLabel.Location = New System.Drawing.Point(963, 406)
        Agent_statusLabel.Name = "Agent_statusLabel"
        Agent_statusLabel.Size = New System.Drawing.Size(98, 15)
        Agent_statusLabel.TabIndex = 73
        Agent_statusLabel.Text = "Agent status:"
        '
        'About_agentLabel
        '
        About_agentLabel.AutoSize = True
        About_agentLabel.BackColor = System.Drawing.Color.Transparent
        About_agentLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        About_agentLabel.ForeColor = System.Drawing.Color.Teal
        About_agentLabel.Location = New System.Drawing.Point(963, 448)
        About_agentLabel.Name = "About_agentLabel"
        About_agentLabel.Size = New System.Drawing.Size(91, 15)
        About_agentLabel.TabIndex = 75
        About_agentLabel.Text = "About agent:"
        '
        'Agent_photoLabel
        '
        Agent_photoLabel.AutoSize = True
        Agent_photoLabel.BackColor = System.Drawing.Color.Transparent
        Agent_photoLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Agent_photoLabel.ForeColor = System.Drawing.Color.Teal
        Agent_photoLabel.Location = New System.Drawing.Point(970, 219)
        Agent_photoLabel.Name = "Agent_photoLabel"
        Agent_photoLabel.Size = New System.Drawing.Size(91, 15)
        Agent_photoLabel.TabIndex = 77
        Agent_photoLabel.Text = "Agent photo:"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button7.FlatAppearance.BorderSize = 3
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Teal
        Me.Button7.Location = New System.Drawing.Point(101, 308)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 34)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "Agent Profile"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.INSURANCE_SYSTEM.My.Resources.Resources.logout1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(1057, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(186, 52)
        Me.Button3.TabIndex = 21
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.INSURANCE_SYSTEM.My.Resources.Resources.Sys_Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(50, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button6.FlatAppearance.BorderSize = 3
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Teal
        Me.Button6.Location = New System.Drawing.Point(101, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 29)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Client Profile"
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
        Me.Button5.Location = New System.Drawing.Point(101, 211)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 29)
        Me.Button5.TabIndex = 18
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
        Me.Button4.Location = New System.Drawing.Point(101, 262)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 29)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Claims"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Location = New System.Drawing.Point(553, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 40)
        Me.Button2.TabIndex = 16
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
        Me.Button1.Location = New System.Drawing.Point(354, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 40)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Agent_profilesBindingSource
        Me.ComboBox1.DisplayMember = "First Name"
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Teal
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(365, 156)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(223, 27)
        Me.ComboBox1.TabIndex = 41
        Me.ComboBox1.ValueMember = "First Name"
        '
        'Agent_profilesBindingSource
        '
        Me.Agent_profilesBindingSource.DataMember = "Agent profiles"
        Me.Agent_profilesBindingSource.DataSource = Me.InsuranceDBDataSet
        '
        'InsuranceDBDataSet
        '
        Me.InsuranceDBDataSet.DataSetName = "InsuranceDBDataSet"
        Me.InsuranceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Teal
        Me.Button9.Location = New System.Drawing.Point(868, 495)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 33)
        Me.Button9.TabIndex = 57
        Me.Button9.Text = "SAVE"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.Control
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Teal
        Me.Button12.Location = New System.Drawing.Point(882, 151)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(46, 32)
        Me.Button12.TabIndex = 60
        Me.Button12.Text = ">"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Teal
        Me.Button11.Location = New System.Drawing.Point(821, 151)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(46, 32)
        Me.Button11.TabIndex = 59
        Me.Button11.Text = "<"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Teal
        Me.Button10.Location = New System.Drawing.Point(569, 495)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(110, 33)
        Me.Button10.TabIndex = 58
        Me.Button10.Text = "DELETE"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Teal
        Me.Button8.Location = New System.Drawing.Point(628, 156)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 27)
        Me.Button8.TabIndex = 56
        Me.Button8.Text = "NEW"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Agent_profilesTableAdapter
        '
        Me.Agent_profilesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agent_profilesTableAdapter = Me.Agent_profilesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.claimsTableAdapter = Nothing
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.PoliciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Agent_profilesBindingNavigator
        '
        Me.Agent_profilesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Agent_profilesBindingNavigator.BindingSource = Me.Agent_profilesBindingSource
        Me.Agent_profilesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Agent_profilesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Agent_profilesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Agent_profilesBindingNavigatorSaveItem})
        Me.Agent_profilesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Agent_profilesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Agent_profilesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Agent_profilesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Agent_profilesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Agent_profilesBindingNavigator.Name = "Agent_profilesBindingNavigator"
        Me.Agent_profilesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Agent_profilesBindingNavigator.Size = New System.Drawing.Size(1302, 25)
        Me.Agent_profilesBindingNavigator.TabIndex = 61
        Me.Agent_profilesBindingNavigator.Text = "BindingNavigator1"
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
        'Agent_profilesBindingNavigatorSaveItem
        '
        Me.Agent_profilesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Agent_profilesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Agent_profilesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Agent_profilesBindingNavigatorSaveItem.Name = "Agent_profilesBindingNavigatorSaveItem"
        Me.Agent_profilesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Agent_profilesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Agent_CodeTextBox
        '
        Me.Agent_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agent_profilesBindingSource, "Agent Code", True))
        Me.Agent_CodeTextBox.Location = New System.Drawing.Point(488, 237)
        Me.Agent_CodeTextBox.Name = "Agent_CodeTextBox"
        Me.Agent_CodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Agent_CodeTextBox.TabIndex = 62
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agent_profilesBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(488, 279)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 64
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agent_profilesBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(488, 321)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 66
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agent_profilesBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(488, 363)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocationTextBox.TabIndex = 68
        '
        'Agent_MobileTextBox
        '
        Me.Agent_MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agent_profilesBindingSource, "Agent Mobile", True))
        Me.Agent_MobileTextBox.Location = New System.Drawing.Point(488, 405)
        Me.Agent_MobileTextBox.Name = "Agent_MobileTextBox"
        Me.Agent_MobileTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Agent_MobileTextBox.TabIndex = 70
        '
        'Agent_addressTextBox
        '
        Me.Agent_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agent_profilesBindingSource, "Agent address", True))
        Me.Agent_addressTextBox.Location = New System.Drawing.Point(1088, 372)
        Me.Agent_addressTextBox.Name = "Agent_addressTextBox"
        Me.Agent_addressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Agent_addressTextBox.TabIndex = 72
        '
        'Agent_statusTextBox
        '
        Me.Agent_statusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agent_profilesBindingSource, "Agent status", True))
        Me.Agent_statusTextBox.Location = New System.Drawing.Point(1088, 414)
        Me.Agent_statusTextBox.Name = "Agent_statusTextBox"
        Me.Agent_statusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Agent_statusTextBox.TabIndex = 74
        '
        'About_agentTextBox
        '
        Me.About_agentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agent_profilesBindingSource, "About agent", True))
        Me.About_agentTextBox.Location = New System.Drawing.Point(1088, 456)
        Me.About_agentTextBox.Name = "About_agentTextBox"
        Me.About_agentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.About_agentTextBox.TabIndex = 76
        '
        'Agent_photoPictureBox
        '
        Me.Agent_photoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Agent_profilesBindingSource, "Agent photo", True))
        Me.Agent_photoPictureBox.Location = New System.Drawing.Point(1088, 211)
        Me.Agent_photoPictureBox.Name = "Agent_photoPictureBox"
        Me.Agent_photoPictureBox.Size = New System.Drawing.Size(115, 147)
        Me.Agent_photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Agent_photoPictureBox.TabIndex = 78
        Me.Agent_photoPictureBox.TabStop = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Teal
        Me.Button13.Location = New System.Drawing.Point(951, 321)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(110, 27)
        Me.Button13.TabIndex = 79
        Me.Button13.Text = "Upload photo"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'AgentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.INSURANCE_SYSTEM.My.Resources.Resources.BG_IMG
        Me.ClientSize = New System.Drawing.Size(1302, 607)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Agent_CodeLabel)
        Me.Controls.Add(Me.Agent_CodeTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Agent_MobileLabel)
        Me.Controls.Add(Me.Agent_MobileTextBox)
        Me.Controls.Add(Agent_addressLabel)
        Me.Controls.Add(Me.Agent_addressTextBox)
        Me.Controls.Add(Agent_statusLabel)
        Me.Controls.Add(Me.Agent_statusTextBox)
        Me.Controls.Add(About_agentLabel)
        Me.Controls.Add(Me.About_agentTextBox)
        Me.Controls.Add(Agent_photoLabel)
        Me.Controls.Add(Me.Agent_photoPictureBox)
        Me.Controls.Add(Me.Agent_profilesBindingNavigator)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgentProfile"
        Me.Text = "AgentProfile"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agent_profilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agent_profilesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agent_profilesBindingNavigator.ResumeLayout(False)
        Me.Agent_profilesBindingNavigator.PerformLayout()
        CType(Me.Agent_photoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents InsuranceDBDataSet As InsuranceDBDataSet
    Friend WithEvents Agent_profilesBindingSource As BindingSource
    Friend WithEvents Agent_profilesTableAdapter As InsuranceDBDataSetTableAdapters.Agent_profilesTableAdapter
    Friend WithEvents TableAdapterManager As InsuranceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Agent_profilesBindingNavigator As BindingNavigator
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
    Friend WithEvents Agent_profilesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Agent_CodeTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents Agent_MobileTextBox As TextBox
    Friend WithEvents Agent_addressTextBox As TextBox
    Friend WithEvents Agent_statusTextBox As TextBox
    Friend WithEvents About_agentTextBox As TextBox
    Friend WithEvents Agent_photoPictureBox As PictureBox
    Friend WithEvents Button13 As Button
End Class
