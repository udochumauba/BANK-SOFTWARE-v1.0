﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DEPOSIT
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim PassportLabel As System.Windows.Forms.Label
        Dim DIDLabel As System.Windows.Forms.Label
        Dim Transaction_DateLabel As System.Windows.Forms.Label
        Dim DepositorLabel As System.Windows.Forms.Label
        Dim AmountLabel1 As System.Windows.Forms.Label
        Dim NarrationLabel As System.Windows.Forms.Label
        Me.BankAccRegDataSet = New Bank_App.BankAccRegDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New Bank_App.BankAccRegDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New Bank_App.BankAccRegDataSetTableAdapters.TableAdapterManager()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.PassportPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DepositDataSet = New Bank_App.DepositDataSet()
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter1 = New Bank_App.DepositDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager1 = New Bank_App.DepositDataSetTableAdapters.TableAdapterManager()
        Me.DIDTextBox = New System.Windows.Forms.TextBox()
        Me.Transaction_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DepositorTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox1 = New System.Windows.Forms.TextBox()
        Me.NarrationTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        UserIDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        PassportLabel = New System.Windows.Forms.Label()
        DIDLabel = New System.Windows.Forms.Label()
        Transaction_DateLabel = New System.Windows.Forms.Label()
        DepositorLabel = New System.Windows.Forms.Label()
        AmountLabel1 = New System.Windows.Forms.Label()
        NarrationLabel = New System.Windows.Forms.Label()
        CType(Me.BankAccRegDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DepositDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(57, 214)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(46, 13)
        UserIDLabel.TabIndex = 1
        UserIDLabel.Text = "User ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(57, 240)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(57, 266)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(57, 292)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 7
        AgeLabel.Text = "Age:"
        AddHandler AgeLabel.Click, AddressOf Me.AgeLabel_Click
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(57, 318)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 9
        CountryLabel.Text = "Country:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(57, 344)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 11
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(57, 370)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(57, 396)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 15
        AmountLabel.Text = "Amount:"
        '
        'PassportLabel
        '
        PassportLabel.AutoSize = True
        PassportLabel.Location = New System.Drawing.Point(57, 35)
        PassportLabel.Name = "PassportLabel"
        PassportLabel.Size = New System.Drawing.Size(51, 13)
        PassportLabel.TabIndex = 17
        PassportLabel.Text = "Passport:"
        '
        'DIDLabel
        '
        DIDLabel.AutoSize = True
        DIDLabel.Location = New System.Drawing.Point(24, 26)
        DIDLabel.Name = "DIDLabel"
        DIDLabel.Size = New System.Drawing.Size(29, 13)
        DIDLabel.TabIndex = 37
        DIDLabel.Text = "DID:"
        '
        'Transaction_DateLabel
        '
        Transaction_DateLabel.AutoSize = True
        Transaction_DateLabel.Location = New System.Drawing.Point(24, 53)
        Transaction_DateLabel.Name = "Transaction_DateLabel"
        Transaction_DateLabel.Size = New System.Drawing.Size(92, 13)
        Transaction_DateLabel.TabIndex = 39
        Transaction_DateLabel.Text = "Transaction Date:"
        '
        'DepositorLabel
        '
        DepositorLabel.AutoSize = True
        DepositorLabel.Location = New System.Drawing.Point(24, 78)
        DepositorLabel.Name = "DepositorLabel"
        DepositorLabel.Size = New System.Drawing.Size(55, 13)
        DepositorLabel.TabIndex = 41
        DepositorLabel.Text = "Depositor:"
        '
        'AmountLabel1
        '
        AmountLabel1.AutoSize = True
        AmountLabel1.Location = New System.Drawing.Point(24, 104)
        AmountLabel1.Name = "AmountLabel1"
        AmountLabel1.Size = New System.Drawing.Size(46, 13)
        AmountLabel1.TabIndex = 43
        AmountLabel1.Text = "Amount:"
        '
        'NarrationLabel
        '
        NarrationLabel.AutoSize = True
        NarrationLabel.Location = New System.Drawing.Point(24, 130)
        NarrationLabel.Name = "NarrationLabel"
        NarrationLabel.Size = New System.Drawing.Size(53, 13)
        NarrationLabel.TabIndex = 45
        NarrationLabel.Text = "Narration:"
        '
        'BankAccRegDataSet
        '
        Me.BankAccRegDataSet.DataSetName = "BankAccRegDataSet"
        Me.BankAccRegDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.BankAccRegDataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Bank_App.BankAccRegDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(144, 211)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(209, 20)
        Me.UserIDTextBox.TabIndex = 2
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(144, 237)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(209, 20)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(144, 263)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(209, 20)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(144, 289)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(209, 20)
        Me.AgeTextBox.TabIndex = 8
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(144, 315)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(209, 20)
        Me.CountryTextBox.TabIndex = 10
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Phone_Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(144, 341)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(209, 20)
        Me.Phone_NumberTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(144, 367)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(209, 20)
        Me.EmailTextBox.TabIndex = 14
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(144, 393)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(209, 20)
        Me.AmountTextBox.TabIndex = 16
        '
        'PassportPictureBox
        '
        Me.PassportPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Table1BindingSource, "Passport", True))
        Me.PassportPictureBox.Location = New System.Drawing.Point(144, 35)
        Me.PassportPictureBox.Name = "PassportPictureBox"
        Me.PassportPictureBox.Size = New System.Drawing.Size(209, 170)
        Me.PassportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassportPictureBox.TabIndex = 18
        Me.PassportPictureBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(411, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 124)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PLEASE ENTER DEPOSIT VALUE:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 21)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 45)
        Me.TextBox1.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(463, 368)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(135, 45)
        Me.Button9.TabIndex = 36
        Me.Button9.Text = "USER TRANSACTIONS"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(463, 276)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(135, 45)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "TRANSFER MONEY"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(463, 198)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(135, 45)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "WITHDRAWAL"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(463, 122)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(135, 45)
        Me.Button8.TabIndex = 33
        Me.Button8.Text = "DEPOSIT"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(463, 36)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(135, 45)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "DELETE MY ACCOUNT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(UserIDLabel)
        Me.GroupBox2.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox2.Controls.Add(First_NameLabel)
        Me.GroupBox2.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox2.Controls.Add(Last_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox2.Controls.Add(AgeLabel)
        Me.GroupBox2.Controls.Add(Me.AgeTextBox)
        Me.GroupBox2.Controls.Add(CountryLabel)
        Me.GroupBox2.Controls.Add(Me.CountryTextBox)
        Me.GroupBox2.Controls.Add(Phone_NumberLabel)
        Me.GroupBox2.Controls.Add(Me.Phone_NumberTextBox)
        Me.GroupBox2.Controls.Add(EmailLabel)
        Me.GroupBox2.Controls.Add(Me.EmailTextBox)
        Me.GroupBox2.Controls.Add(AmountLabel)
        Me.GroupBox2.Controls.Add(Me.AmountTextBox)
        Me.GroupBox2.Controls.Add(PassportLabel)
        Me.GroupBox2.Controls.Add(Me.PassportPictureBox)
        Me.GroupBox2.Location = New System.Drawing.Point(155, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 431)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCOUNT DETAILS:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(155, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(670, 77)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ENTER USER'S ACCOUNT NUMBER"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(427, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 37)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "SEARCH"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(262, 28)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 20)
        Me.TextBox2.TabIndex = 37
        '
        'DepositDataSet
        '
        Me.DepositDataSet.DataSetName = "DepositDataSet"
        Me.DepositDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table1"
        Me.Table1BindingSource1.DataSource = Me.DepositDataSet
        '
        'Table1TableAdapter1
        '
        Me.Table1TableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Table1TableAdapter = Me.Table1TableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Bank_App.DepositDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DIDTextBox
        '
        Me.DIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "DID", True))
        Me.DIDTextBox.Location = New System.Drawing.Point(204, 20)
        Me.DIDTextBox.Name = "DIDTextBox"
        Me.DIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DIDTextBox.TabIndex = 38
        '
        'Transaction_DateDateTimePicker
        '
        Me.Transaction_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table1BindingSource1, "Transaction_Date", True))
        Me.Transaction_DateDateTimePicker.Location = New System.Drawing.Point(204, 46)
        Me.Transaction_DateDateTimePicker.Name = "Transaction_DateDateTimePicker"
        Me.Transaction_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Transaction_DateDateTimePicker.TabIndex = 40
        '
        'DepositorTextBox
        '
        Me.DepositorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Depositor", True))
        Me.DepositorTextBox.Location = New System.Drawing.Point(204, 72)
        Me.DepositorTextBox.Name = "DepositorTextBox"
        Me.DepositorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DepositorTextBox.TabIndex = 42
        '
        'AmountTextBox1
        '
        Me.AmountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Amount", True))
        Me.AmountTextBox1.Location = New System.Drawing.Point(204, 98)
        Me.AmountTextBox1.Name = "AmountTextBox1"
        Me.AmountTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.AmountTextBox1.TabIndex = 44
        '
        'NarrationTextBox
        '
        Me.NarrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Narration", True))
        Me.NarrationTextBox.Location = New System.Drawing.Point(204, 124)
        Me.NarrationTextBox.Name = "NarrationTextBox"
        Me.NarrationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NarrationTextBox.TabIndex = 46
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(AmountLabel1)
        Me.GroupBox3.Controls.Add(Me.DIDTextBox)
        Me.GroupBox3.Controls.Add(NarrationLabel)
        Me.GroupBox3.Controls.Add(Me.Transaction_DateDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.DepositorTextBox)
        Me.GroupBox3.Controls.Add(Me.AmountTextBox1)
        Me.GroupBox3.Controls.Add(DIDLabel)
        Me.GroupBox3.Controls.Add(Me.NarrationTextBox)
        Me.GroupBox3.Controls.Add(Transaction_DateLabel)
        Me.GroupBox3.Controls.Add(DepositorLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(155, 588)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(670, 170)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EnterTransaction Details below"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(387, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 31)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "BETTER BANK"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(825, 735)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DEPOSIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 791)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "DEPOSIT"
        Me.Text = "DEPOSIT"
        CType(Me.BankAccRegDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DepositDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankAccRegDataSet As Bank_App.BankAccRegDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As Bank_App.BankAccRegDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As Bank_App.BankAccRegDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassportPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DepositDataSet As Bank_App.DepositDataSet
    Friend WithEvents Table1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter1 As Bank_App.DepositDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager1 As Bank_App.DepositDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Transaction_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DepositorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NarrationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
