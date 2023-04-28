<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_Client
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
        Dim Client_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim Date_enroledLabel As System.Windows.Forms.Label
        Dim PolicyLabel As System.Windows.Forms.Label
        Dim Policy_valueLabel As System.Windows.Forms.Label
        Dim Policy_duration_months_Label As System.Windows.Forms.Label
        Dim Monthly_premiumLabel As System.Windows.Forms.Label
        Dim Premium_NoLabel As System.Windows.Forms.Label
        Dim Amount_dueLabel As System.Windows.Forms.Label
        Dim Client_photoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Client))
        Dim Label1 As System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InsuranceDBDataSet = New INSURANCE_SYSTEM.InsuranceDBDataSet()
        Me.ClientsTableAdapter = New INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.ClientsTableAdapter()
        Me.TableAdapterManager = New INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.TableAdapterManager()
        Me.ClientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Client_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MobileTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Date_enroledDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Policy_valueTextBox = New System.Windows.Forms.TextBox()
        Me.Policy_duration_months_TextBox = New System.Windows.Forms.TextBox()
        Me.Monthly_premiumTextBox = New System.Windows.Forms.TextBox()
        Me.Premium_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_dueTextBox = New System.Windows.Forms.TextBox()
        Me.Client_photoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.PolicyComboBox = New System.Windows.Forms.ComboBox()
        Client_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        MobileLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        Date_enroledLabel = New System.Windows.Forms.Label()
        PolicyLabel = New System.Windows.Forms.Label()
        Policy_valueLabel = New System.Windows.Forms.Label()
        Policy_duration_months_Label = New System.Windows.Forms.Label()
        Monthly_premiumLabel = New System.Windows.Forms.Label()
        Premium_NoLabel = New System.Windows.Forms.Label()
        Amount_dueLabel = New System.Windows.Forms.Label()
        Client_photoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientsBindingNavigator.SuspendLayout()
        CType(Me.Client_photoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Client_IDLabel
        '
        Client_IDLabel.AutoSize = True
        Client_IDLabel.BackColor = System.Drawing.Color.Transparent
        Client_IDLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_IDLabel.ForeColor = System.Drawing.Color.Teal
        Client_IDLabel.Location = New System.Drawing.Point(316, 199)
        Client_IDLabel.Name = "Client_IDLabel"
        Client_IDLabel.Size = New System.Drawing.Size(77, 15)
        Client_IDLabel.TabIndex = 90
        Client_IDLabel.Text = "Client ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.Transparent
        First_NameLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.Color.Teal
        First_NameLabel.Location = New System.Drawing.Point(316, 241)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(84, 15)
        First_NameLabel.TabIndex = 92
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.Transparent
        Last_NameLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.ForeColor = System.Drawing.Color.Teal
        Last_NameLabel.Location = New System.Drawing.Point(316, 283)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(77, 15)
        Last_NameLabel.TabIndex = 94
        Last_NameLabel.Text = "Last Name:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.BackColor = System.Drawing.Color.Transparent
        DOBLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.ForeColor = System.Drawing.Color.Teal
        DOBLabel.Location = New System.Drawing.Point(316, 326)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(35, 15)
        DOBLabel.TabIndex = 96
        DOBLabel.Text = "DOB:"
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.BackColor = System.Drawing.Color.Transparent
        MobileLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MobileLabel.ForeColor = System.Drawing.Color.Teal
        MobileLabel.Location = New System.Drawing.Point(316, 409)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(56, 15)
        MobileLabel.TabIndex = 100
        MobileLabel.Text = "Mobile:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Transparent
        AddressLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.ForeColor = System.Drawing.Color.Teal
        AddressLabel.Location = New System.Drawing.Point(316, 451)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(63, 15)
        AddressLabel.TabIndex = 102
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.BackColor = System.Drawing.Color.Transparent
        CityLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.ForeColor = System.Drawing.Color.Teal
        CityLabel.Location = New System.Drawing.Point(316, 493)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(42, 15)
        CityLabel.TabIndex = 104
        CityLabel.Text = "City:"
        '
        'Date_enroledLabel
        '
        Date_enroledLabel.AutoSize = True
        Date_enroledLabel.BackColor = System.Drawing.Color.Transparent
        Date_enroledLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_enroledLabel.ForeColor = System.Drawing.Color.Teal
        Date_enroledLabel.Location = New System.Drawing.Point(866, 366)
        Date_enroledLabel.Name = "Date_enroledLabel"
        Date_enroledLabel.Size = New System.Drawing.Size(98, 15)
        Date_enroledLabel.TabIndex = 106
        Date_enroledLabel.Text = "Date enroled:"
        '
        'PolicyLabel
        '
        PolicyLabel.AutoSize = True
        PolicyLabel.BackColor = System.Drawing.Color.Transparent
        PolicyLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PolicyLabel.ForeColor = System.Drawing.Color.Teal
        PolicyLabel.Location = New System.Drawing.Point(908, 391)
        PolicyLabel.Name = "PolicyLabel"
        PolicyLabel.Size = New System.Drawing.Size(56, 15)
        PolicyLabel.TabIndex = 108
        PolicyLabel.Text = "Policy:"
        '
        'Policy_valueLabel
        '
        Policy_valueLabel.AutoSize = True
        Policy_valueLabel.BackColor = System.Drawing.Color.Transparent
        Policy_valueLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Policy_valueLabel.ForeColor = System.Drawing.Color.Teal
        Policy_valueLabel.Location = New System.Drawing.Point(866, 417)
        Policy_valueLabel.Name = "Policy_valueLabel"
        Policy_valueLabel.Size = New System.Drawing.Size(98, 15)
        Policy_valueLabel.TabIndex = 110
        Policy_valueLabel.Text = "Policy value:"
        '
        'Policy_duration_months_Label
        '
        Policy_duration_months_Label.AutoSize = True
        Policy_duration_months_Label.BackColor = System.Drawing.Color.Transparent
        Policy_duration_months_Label.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Policy_duration_months_Label.ForeColor = System.Drawing.Color.Teal
        Policy_duration_months_Label.Location = New System.Drawing.Point(789, 443)
        Policy_duration_months_Label.Name = "Policy_duration_months_Label"
        Policy_duration_months_Label.Size = New System.Drawing.Size(175, 15)
        Policy_duration_months_Label.TabIndex = 112
        Policy_duration_months_Label.Text = "Policy duration(months):"
        '
        'Monthly_premiumLabel
        '
        Monthly_premiumLabel.AutoSize = True
        Monthly_premiumLabel.BackColor = System.Drawing.Color.Transparent
        Monthly_premiumLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Monthly_premiumLabel.ForeColor = System.Drawing.Color.Teal
        Monthly_premiumLabel.Location = New System.Drawing.Point(845, 469)
        Monthly_premiumLabel.Name = "Monthly_premiumLabel"
        Monthly_premiumLabel.Size = New System.Drawing.Size(119, 15)
        Monthly_premiumLabel.TabIndex = 114
        Monthly_premiumLabel.Text = "Monthly premium:"
        '
        'Premium_NoLabel
        '
        Premium_NoLabel.AutoSize = True
        Premium_NoLabel.BackColor = System.Drawing.Color.Transparent
        Premium_NoLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Premium_NoLabel.ForeColor = System.Drawing.Color.Teal
        Premium_NoLabel.Location = New System.Drawing.Point(880, 495)
        Premium_NoLabel.Name = "Premium_NoLabel"
        Premium_NoLabel.Size = New System.Drawing.Size(84, 15)
        Premium_NoLabel.TabIndex = 116
        Premium_NoLabel.Text = "Premium No:"
        '
        'Amount_dueLabel
        '
        Amount_dueLabel.AutoSize = True
        Amount_dueLabel.BackColor = System.Drawing.Color.Transparent
        Amount_dueLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_dueLabel.ForeColor = System.Drawing.Color.Teal
        Amount_dueLabel.Location = New System.Drawing.Point(880, 521)
        Amount_dueLabel.Name = "Amount_dueLabel"
        Amount_dueLabel.Size = New System.Drawing.Size(84, 15)
        Amount_dueLabel.TabIndex = 118
        Amount_dueLabel.Text = "Amount due:"
        '
        'Client_photoLabel
        '
        Client_photoLabel.AutoSize = True
        Client_photoLabel.BackColor = System.Drawing.Color.Transparent
        Client_photoLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Client_photoLabel.ForeColor = System.Drawing.Color.Teal
        Client_photoLabel.Location = New System.Drawing.Point(941, 158)
        Client_photoLabel.Name = "Client_photoLabel"
        Client_photoLabel.Size = New System.Drawing.Size(98, 15)
        Client_photoLabel.TabIndex = 120
        Client_photoLabel.Text = "Client photo:"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button7.FlatAppearance.BorderSize = 3
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Teal
        Me.Button7.Location = New System.Drawing.Point(107, 313)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 34)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Agent Profile"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button6.FlatAppearance.BorderSize = 3
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Teal
        Me.Button6.Location = New System.Drawing.Point(108, 158)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 29)
        Me.Button6.TabIndex = 18
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
        Me.Button5.Location = New System.Drawing.Point(108, 208)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 29)
        Me.Button5.TabIndex = 17
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
        Me.Button4.Location = New System.Drawing.Point(108, 262)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 29)
        Me.Button4.TabIndex = 16
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
        Me.Button2.Location = New System.Drawing.Point(531, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 40)
        Me.Button2.TabIndex = 15
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
        Me.Button1.Location = New System.Drawing.Point(332, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 40)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.INSURANCE_SYSTEM.My.Resources.Resources.logout1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(1063, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(186, 52)
        Me.Button3.TabIndex = 20
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.INSURANCE_SYSTEM.My.Resources.Resources.Sys_Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(57, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Teal
        Me.Button8.Location = New System.Drawing.Point(332, 124)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 33)
        Me.Button8.TabIndex = 50
        Me.Button8.Text = "NEW"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Teal
        Me.Button9.Location = New System.Drawing.Point(531, 548)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 33)
        Me.Button9.TabIndex = 51
        Me.Button9.Text = "SAVE"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Teal
        Me.Button10.Location = New System.Drawing.Point(332, 548)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(110, 33)
        Me.Button10.TabIndex = 53
        Me.Button10.Text = "DELETE"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Teal
        Me.Button11.Location = New System.Drawing.Point(772, 133)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(46, 33)
        Me.Button11.TabIndex = 54
        Me.Button11.Text = "<"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.Control
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Teal
        Me.Button12.Location = New System.Drawing.Point(833, 133)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(46, 33)
        Me.Button12.TabIndex = 55
        Me.Button12.Text = ">"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.Button13.FlatAppearance.BorderSize = 3
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Teal
        Me.Button13.Location = New System.Drawing.Point(724, 78)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(153, 40)
        Me.Button13.TabIndex = 56
        Me.Button13.Text = "Client Data"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientsBindingSource
        Me.ComboBox1.DisplayMember = "First Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(490, 128)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 21)
        Me.ComboBox1.TabIndex = 89
        Me.ComboBox1.ValueMember = "First Name"
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.InsuranceDBDataSet
        '
        'InsuranceDBDataSet
        '
        Me.InsuranceDBDataSet.DataSetName = "InsuranceDBDataSet"
        Me.InsuranceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agent_profilesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.claimsTableAdapter = Nothing
        Me.TableAdapterManager.ClientsTableAdapter = Me.ClientsTableAdapter
        Me.TableAdapterManager.PoliciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = INSURANCE_SYSTEM.InsuranceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientsBindingNavigator
        '
        Me.ClientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientsBindingNavigator.BindingSource = Me.ClientsBindingSource
        Me.ClientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientsBindingNavigatorSaveItem})
        Me.ClientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientsBindingNavigator.Name = "ClientsBindingNavigator"
        Me.ClientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientsBindingNavigator.Size = New System.Drawing.Size(1331, 25)
        Me.ClientsBindingNavigator.TabIndex = 90
        Me.ClientsBindingNavigator.Text = "BindingNavigator1"
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
        'ClientsBindingNavigatorSaveItem
        '
        Me.ClientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientsBindingNavigatorSaveItem.Name = "ClientsBindingNavigatorSaveItem"
        Me.ClientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Client_IDTextBox
        '
        Me.Client_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Client ID", True))
        Me.Client_IDTextBox.Location = New System.Drawing.Point(441, 188)
        Me.Client_IDTextBox.Name = "Client_IDTextBox"
        Me.Client_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Client_IDTextBox.TabIndex = 91
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(441, 230)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.First_NameTextBox.TabIndex = 93
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(441, 272)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox.TabIndex = 95
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientsBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(441, 314)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 97
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Mobile", True))
        Me.MobileTextBox.Location = New System.Drawing.Point(441, 398)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MobileTextBox.TabIndex = 101
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(441, 440)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 103
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(441, 482)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CityTextBox.TabIndex = 105
        '
        'Date_enroledDateTimePicker
        '
        Me.Date_enroledDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientsBindingSource, "Date enroled", True))
        Me.Date_enroledDateTimePicker.Location = New System.Drawing.Point(991, 362)
        Me.Date_enroledDateTimePicker.Name = "Date_enroledDateTimePicker"
        Me.Date_enroledDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_enroledDateTimePicker.TabIndex = 107
        '
        'Policy_valueTextBox
        '
        Me.Policy_valueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Policy value", True))
        Me.Policy_valueTextBox.Location = New System.Drawing.Point(991, 414)
        Me.Policy_valueTextBox.Name = "Policy_valueTextBox"
        Me.Policy_valueTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Policy_valueTextBox.TabIndex = 111
        '
        'Policy_duration_months_TextBox
        '
        Me.Policy_duration_months_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Policy duration(months)", True))
        Me.Policy_duration_months_TextBox.Location = New System.Drawing.Point(991, 440)
        Me.Policy_duration_months_TextBox.Name = "Policy_duration_months_TextBox"
        Me.Policy_duration_months_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Policy_duration_months_TextBox.TabIndex = 113
        '
        'Monthly_premiumTextBox
        '
        Me.Monthly_premiumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Monthly premium", True))
        Me.Monthly_premiumTextBox.Location = New System.Drawing.Point(991, 466)
        Me.Monthly_premiumTextBox.Name = "Monthly_premiumTextBox"
        Me.Monthly_premiumTextBox.Size = New System.Drawing.Size(128, 20)
        Me.Monthly_premiumTextBox.TabIndex = 115
        '
        'Premium_NoTextBox
        '
        Me.Premium_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Premium No", True))
        Me.Premium_NoTextBox.Location = New System.Drawing.Point(991, 492)
        Me.Premium_NoTextBox.Name = "Premium_NoTextBox"
        Me.Premium_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Premium_NoTextBox.TabIndex = 117
        '
        'Amount_dueTextBox
        '
        Me.Amount_dueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Amount due", True))
        Me.Amount_dueTextBox.Location = New System.Drawing.Point(991, 518)
        Me.Amount_dueTextBox.Name = "Amount_dueTextBox"
        Me.Amount_dueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Amount_dueTextBox.TabIndex = 119
        '
        'Client_photoPictureBox
        '
        Me.Client_photoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ClientsBindingSource, "Client photo", True))
        Me.Client_photoPictureBox.Location = New System.Drawing.Point(1066, 158)
        Me.Client_photoPictureBox.Name = "Client_photoPictureBox"
        Me.Client_photoPictureBox.Size = New System.Drawing.Size(159, 153)
        Me.Client_photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Client_photoPictureBox.TabIndex = 121
        Me.Client_photoPictureBox.TabStop = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Teal
        Me.Button14.Location = New System.Drawing.Point(950, 284)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(110, 27)
        Me.Button14.TabIndex = 122
        Me.Button14.Text = "Upload photo"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Teal
        Me.Button15.Location = New System.Drawing.Point(1125, 462)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(107, 28)
        Me.Button15.TabIndex = 123
        Me.Button15.Text = "Retrieve"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.Teal
        Me.Button16.Location = New System.Drawing.Point(1107, 514)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(107, 28)
        Me.Button16.TabIndex = 124
        Me.Button16.Text = "Retrieve"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Teal
        Label1.Location = New System.Drawing.Point(316, 372)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 15)
        Label1.TabIndex = 125
        Label1.Text = "Gender:"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"M", "F"})
        Me.GenderComboBox.Location = New System.Drawing.Point(441, 365)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(192, 21)
        Me.GenderComboBox.TabIndex = 126
        '
        'PolicyComboBox
        '
        Me.PolicyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsBindingSource, "Policy", True))
        Me.PolicyComboBox.FormattingEnabled = True
        Me.PolicyComboBox.Items.AddRange(New Object() {"Health Insurance", "Life Assurance", "Vehicle Insurance", "Medical Insurance", "Property Insurance"})
        Me.PolicyComboBox.Location = New System.Drawing.Point(991, 387)
        Me.PolicyComboBox.Name = "PolicyComboBox"
        Me.PolicyComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PolicyComboBox.TabIndex = 127
        '
        'New_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.INSURANCE_SYSTEM.My.Resources.Resources.Custom_Background
        Me.ClientSize = New System.Drawing.Size(1331, 669)
        Me.Controls.Add(Me.PolicyComboBox)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Client_IDLabel)
        Me.Controls.Add(Me.Client_IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Date_enroledLabel)
        Me.Controls.Add(Me.Date_enroledDateTimePicker)
        Me.Controls.Add(PolicyLabel)
        Me.Controls.Add(Policy_valueLabel)
        Me.Controls.Add(Me.Policy_valueTextBox)
        Me.Controls.Add(Policy_duration_months_Label)
        Me.Controls.Add(Me.Policy_duration_months_TextBox)
        Me.Controls.Add(Monthly_premiumLabel)
        Me.Controls.Add(Me.Monthly_premiumTextBox)
        Me.Controls.Add(Premium_NoLabel)
        Me.Controls.Add(Me.Premium_NoTextBox)
        Me.Controls.Add(Amount_dueLabel)
        Me.Controls.Add(Me.Amount_dueTextBox)
        Me.Controls.Add(Client_photoLabel)
        Me.Controls.Add(Me.Client_photoPictureBox)
        Me.Controls.Add(Me.ClientsBindingNavigator)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
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
        Me.Name = "New_Client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New_client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientsBindingNavigator.ResumeLayout(False)
        Me.ClientsBindingNavigator.PerformLayout()
        CType(Me.Client_photoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents InsuranceDBDataSet As InsuranceDBDataSet
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As InsuranceDBDataSetTableAdapters.ClientsTableAdapter
    Friend WithEvents TableAdapterManager As InsuranceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientsBindingNavigator As BindingNavigator
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
    Friend WithEvents ClientsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Client_IDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents MobileTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Date_enroledDateTimePicker As DateTimePicker
    Friend WithEvents Policy_valueTextBox As TextBox
    Friend WithEvents Policy_duration_months_TextBox As TextBox
    Friend WithEvents Monthly_premiumTextBox As TextBox
    Friend WithEvents Premium_NoTextBox As TextBox
    Friend WithEvents Amount_dueTextBox As TextBox
    Friend WithEvents Client_photoPictureBox As PictureBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents PolicyComboBox As ComboBox
End Class
