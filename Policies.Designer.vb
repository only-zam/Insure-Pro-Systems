<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Policies
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
        Dim Policy_codeLabel As System.Windows.Forms.Label
        Dim PolicyLabel As System.Windows.Forms.Label
        Dim Policy_statusLabel As System.Windows.Forms.Label
        Dim Least_Cover_duration_months_Label As System.Windows.Forms.Label
        Dim Policy_descriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Policies))
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PoliciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InsuranceDBDataSet = New INSURANCE_SYSTEM.InsuranceDBDataSet()
        Me.PoliciesTableAdapter = New INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.PoliciesTableAdapter()
        Me.TableAdapterManager = New INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.TableAdapterManager()
        Me.PoliciesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PoliciesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Policy_codeTextBox = New System.Windows.Forms.TextBox()
        Me.PolicyTextBox = New System.Windows.Forms.TextBox()
        Me.Policy_statusTextBox = New System.Windows.Forms.TextBox()
        Me.Least_Cover_duration_months_TextBox = New System.Windows.Forms.TextBox()
        Me.Policy_descriptionTextBox = New System.Windows.Forms.TextBox()
        Policy_codeLabel = New System.Windows.Forms.Label()
        PolicyLabel = New System.Windows.Forms.Label()
        Policy_statusLabel = New System.Windows.Forms.Label()
        Least_Cover_duration_months_Label = New System.Windows.Forms.Label()
        Policy_descriptionLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoliciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoliciesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PoliciesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Policy_codeLabel
        '
        Policy_codeLabel.AutoSize = True
        Policy_codeLabel.BackColor = System.Drawing.Color.Transparent
        Policy_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Policy_codeLabel.ForeColor = System.Drawing.Color.Teal
        Policy_codeLabel.Location = New System.Drawing.Point(435, 215)
        Policy_codeLabel.Name = "Policy_codeLabel"
        Policy_codeLabel.Size = New System.Drawing.Size(92, 20)
        Policy_codeLabel.TabIndex = 72
        Policy_codeLabel.Text = "Policy code:"
        '
        'PolicyLabel
        '
        PolicyLabel.AutoSize = True
        PolicyLabel.BackColor = System.Drawing.Color.Transparent
        PolicyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PolicyLabel.ForeColor = System.Drawing.Color.Teal
        PolicyLabel.Location = New System.Drawing.Point(474, 241)
        PolicyLabel.Name = "PolicyLabel"
        PolicyLabel.Size = New System.Drawing.Size(53, 20)
        PolicyLabel.TabIndex = 74
        PolicyLabel.Text = "Policy:"
        '
        'Policy_statusLabel
        '
        Policy_statusLabel.AutoSize = True
        Policy_statusLabel.BackColor = System.Drawing.Color.Transparent
        Policy_statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Policy_statusLabel.ForeColor = System.Drawing.Color.Teal
        Policy_statusLabel.Location = New System.Drawing.Point(426, 267)
        Policy_statusLabel.Name = "Policy_statusLabel"
        Policy_statusLabel.Size = New System.Drawing.Size(101, 20)
        Policy_statusLabel.TabIndex = 76
        Policy_statusLabel.Text = "Policy status:"
        '
        'Least_Cover_duration_months_Label
        '
        Least_Cover_duration_months_Label.AutoSize = True
        Least_Cover_duration_months_Label.BackColor = System.Drawing.Color.Transparent
        Least_Cover_duration_months_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Least_Cover_duration_months_Label.ForeColor = System.Drawing.Color.Teal
        Least_Cover_duration_months_Label.Location = New System.Drawing.Point(304, 293)
        Least_Cover_duration_months_Label.Name = "Least_Cover_duration_months_Label"
        Least_Cover_duration_months_Label.Size = New System.Drawing.Size(223, 20)
        Least_Cover_duration_months_Label.TabIndex = 78
        Least_Cover_duration_months_Label.Text = "Least Cover duration(months):"
        '
        'Policy_descriptionLabel
        '
        Policy_descriptionLabel.AutoSize = True
        Policy_descriptionLabel.BackColor = System.Drawing.Color.Transparent
        Policy_descriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Policy_descriptionLabel.ForeColor = System.Drawing.Color.Teal
        Policy_descriptionLabel.Location = New System.Drawing.Point(393, 373)
        Policy_descriptionLabel.Name = "Policy_descriptionLabel"
        Policy_descriptionLabel.Size = New System.Drawing.Size(134, 20)
        Policy_descriptionLabel.TabIndex = 80
        Policy_descriptionLabel.Text = "Policy description:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Location = New System.Drawing.Point(523, 77)
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
        Me.Button1.Location = New System.Drawing.Point(324, 77)
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
        Me.Button6.Location = New System.Drawing.Point(103, 174)
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
        Me.Button5.Location = New System.Drawing.Point(103, 224)
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
        Me.Button4.Location = New System.Drawing.Point(103, 275)
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
        Me.PictureBox1.Location = New System.Drawing.Point(52, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.INSURANCE_SYSTEM.My.Resources.Resources.logout
        Me.Button3.Location = New System.Drawing.Point(1061, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(186, 52)
        Me.Button3.TabIndex = 11
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
        Me.Button7.Location = New System.Drawing.Point(103, 321)
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
        Me.Button8.Location = New System.Drawing.Point(708, 77)
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
        Me.Button9.Location = New System.Drawing.Point(629, 482)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 33)
        Me.Button9.TabIndex = 68
        Me.Button9.Text = "SAVE"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.Control
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Teal
        Me.Button12.Location = New System.Drawing.Point(605, 147)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(46, 32)
        Me.Button12.TabIndex = 71
        Me.Button12.Text = ">"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Teal
        Me.Button11.Location = New System.Drawing.Point(544, 147)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(46, 32)
        Me.Button11.TabIndex = 70
        Me.Button11.Text = "<"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Teal
        Me.Button10.Location = New System.Drawing.Point(454, 482)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(110, 33)
        Me.Button10.TabIndex = 69
        Me.Button10.Text = "DELETE"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Teal
        Me.Button13.Location = New System.Drawing.Point(351, 152)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(110, 27)
        Me.Button13.TabIndex = 67
        Me.Button13.Text = "NEW"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PoliciesBindingSource
        Me.ComboBox1.DisplayMember = "Policy"
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Teal
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(967, 171)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(256, 27)
        Me.ComboBox1.TabIndex = 66
        Me.ComboBox1.ValueMember = "Policy"
        '
        'PoliciesBindingSource
        '
        Me.PoliciesBindingSource.DataMember = "Policies"
        Me.PoliciesBindingSource.DataSource = Me.InsuranceDBDataSet
        '
        'InsuranceDBDataSet
        '
        Me.InsuranceDBDataSet.DataSetName = "InsuranceDBDataSet"
        Me.InsuranceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PoliciesTableAdapter
        '
        Me.PoliciesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agent_profilesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.claimsTableAdapter = Nothing
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.PoliciesTableAdapter = Me.PoliciesTableAdapter
        Me.TableAdapterManager.UpdateOrder = INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PoliciesBindingNavigator
        '
        Me.PoliciesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PoliciesBindingNavigator.BindingSource = Me.PoliciesBindingSource
        Me.PoliciesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PoliciesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PoliciesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PoliciesBindingNavigatorSaveItem})
        Me.PoliciesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PoliciesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PoliciesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PoliciesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PoliciesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PoliciesBindingNavigator.Name = "PoliciesBindingNavigator"
        Me.PoliciesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PoliciesBindingNavigator.Size = New System.Drawing.Size(1301, 25)
        Me.PoliciesBindingNavigator.TabIndex = 72
        Me.PoliciesBindingNavigator.Text = "BindingNavigator1"
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
        'PoliciesBindingNavigatorSaveItem
        '
        Me.PoliciesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PoliciesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PoliciesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PoliciesBindingNavigatorSaveItem.Name = "PoliciesBindingNavigatorSaveItem"
        Me.PoliciesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PoliciesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Policy_codeTextBox
        '
        Me.Policy_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PoliciesBindingSource, "Policy code", True))
        Me.Policy_codeTextBox.Location = New System.Drawing.Point(591, 215)
        Me.Policy_codeTextBox.Name = "Policy_codeTextBox"
        Me.Policy_codeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Policy_codeTextBox.TabIndex = 73
        '
        'PolicyTextBox
        '
        Me.PolicyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PoliciesBindingSource, "Policy", True))
        Me.PolicyTextBox.Location = New System.Drawing.Point(591, 241)
        Me.PolicyTextBox.Name = "PolicyTextBox"
        Me.PolicyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PolicyTextBox.TabIndex = 75
        '
        'Policy_statusTextBox
        '
        Me.Policy_statusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PoliciesBindingSource, "Policy status", True))
        Me.Policy_statusTextBox.Location = New System.Drawing.Point(591, 267)
        Me.Policy_statusTextBox.Name = "Policy_statusTextBox"
        Me.Policy_statusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Policy_statusTextBox.TabIndex = 77
        '
        'Least_Cover_duration_months_TextBox
        '
        Me.Least_Cover_duration_months_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PoliciesBindingSource, "Least Cover duration(months)", True))
        Me.Least_Cover_duration_months_TextBox.Location = New System.Drawing.Point(591, 293)
        Me.Least_Cover_duration_months_TextBox.Name = "Least_Cover_duration_months_TextBox"
        Me.Least_Cover_duration_months_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Least_Cover_duration_months_TextBox.TabIndex = 79
        '
        'Policy_descriptionTextBox
        '
        Me.Policy_descriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PoliciesBindingSource, "Policy description", True))
        Me.Policy_descriptionTextBox.Location = New System.Drawing.Point(591, 319)
        Me.Policy_descriptionTextBox.Multiline = True
        Me.Policy_descriptionTextBox.Name = "Policy_descriptionTextBox"
        Me.Policy_descriptionTextBox.Size = New System.Drawing.Size(184, 74)
        Me.Policy_descriptionTextBox.TabIndex = 81
        '
        'Policies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.INSURANCE_SYSTEM.My.Resources.Resources.Custom_Background
        Me.ClientSize = New System.Drawing.Size(1301, 608)
        Me.Controls.Add(Policy_codeLabel)
        Me.Controls.Add(Me.Policy_codeTextBox)
        Me.Controls.Add(PolicyLabel)
        Me.Controls.Add(Me.PolicyTextBox)
        Me.Controls.Add(Policy_statusLabel)
        Me.Controls.Add(Me.Policy_statusTextBox)
        Me.Controls.Add(Least_Cover_duration_months_Label)
        Me.Controls.Add(Me.Least_Cover_duration_months_TextBox)
        Me.Controls.Add(Policy_descriptionLabel)
        Me.Controls.Add(Me.Policy_descriptionTextBox)
        Me.Controls.Add(Me.PoliciesBindingNavigator)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Policies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Policies"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoliciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoliciesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PoliciesBindingNavigator.ResumeLayout(False)
        Me.PoliciesBindingNavigator.PerformLayout()
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents InsuranceDBDataSet As InsuranceDBDataSet
    Friend WithEvents PoliciesBindingSource As BindingSource
    Friend WithEvents PoliciesTableAdapter As InsuranceDBDataSetTableAdapters.PoliciesTableAdapter
    Friend WithEvents TableAdapterManager As InsuranceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PoliciesBindingNavigator As BindingNavigator
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
    Friend WithEvents PoliciesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Policy_codeTextBox As TextBox
    Friend WithEvents PolicyTextBox As TextBox
    Friend WithEvents Policy_statusTextBox As TextBox
    Friend WithEvents Least_Cover_duration_months_TextBox As TextBox
    Friend WithEvents Policy_descriptionTextBox As TextBox
End Class
