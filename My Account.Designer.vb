<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My_Account
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
        Dim AmountLabel2 As System.Windows.Forms.Label
        Dim NarrationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(My_Account))
        Me.BankAccRegDataSet = New Bank_App.BankAccRegDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New Bank_App.BankAccRegDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New Bank_App.BankAccRegDataSetTableAdapters.TableAdapterManager()
        Me.Table1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Table1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserIDLabel1 = New System.Windows.Forms.Label()
        Me.First_NameLabel1 = New System.Windows.Forms.Label()
        Me.Last_NameLabel1 = New System.Windows.Forms.Label()
        Me.AgeLabel1 = New System.Windows.Forms.Label()
        Me.CountryLabel1 = New System.Windows.Forms.Label()
        Me.Phone_NumberLabel1 = New System.Windows.Forms.Label()
        Me.EmailLabel1 = New System.Windows.Forms.Label()
        Me.AmountLabel1 = New System.Windows.Forms.Label()
        Me.PassportPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DIDLabel1 = New System.Windows.Forms.Label()
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepositDataSet = New Bank_App.DepositDataSet()
        Me.Transaction_DateLabel1 = New System.Windows.Forms.Label()
        Me.DepositorLabel1 = New System.Windows.Forms.Label()
        Me.AmountLabel3 = New System.Windows.Forms.Label()
        Me.NarrationLabel1 = New System.Windows.Forms.Label()
        Me.Table1TableAdapter1 = New Bank_App.DepositDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager1 = New Bank_App.DepositDataSetTableAdapters.TableAdapterManager()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        AmountLabel2 = New System.Windows.Forms.Label()
        NarrationLabel = New System.Windows.Forms.Label()
        CType(Me.BankAccRegDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table1BindingNavigator.SuspendLayout()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepositDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(161, 241)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(46, 13)
        UserIDLabel.TabIndex = 1
        UserIDLabel.Text = "User ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(161, 264)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(161, 287)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(161, 310)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 7
        AgeLabel.Text = "Age:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(161, 333)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 9
        CountryLabel.Text = "Country:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(161, 356)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 11
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(161, 379)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(161, 402)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 15
        AmountLabel.Text = "Amount:"
        '
        'PassportLabel
        '
        PassportLabel.AutoSize = True
        PassportLabel.Location = New System.Drawing.Point(161, 41)
        PassportLabel.Name = "PassportLabel"
        PassportLabel.Size = New System.Drawing.Size(51, 13)
        PassportLabel.TabIndex = 17
        PassportLabel.Text = "Passport:"
        '
        'DIDLabel
        '
        DIDLabel.AutoSize = True
        DIDLabel.Location = New System.Drawing.Point(59, 54)
        DIDLabel.Name = "DIDLabel"
        DIDLabel.Size = New System.Drawing.Size(29, 13)
        DIDLabel.TabIndex = 0
        DIDLabel.Text = "DID:"
        '
        'Transaction_DateLabel
        '
        Transaction_DateLabel.AutoSize = True
        Transaction_DateLabel.Location = New System.Drawing.Point(59, 77)
        Transaction_DateLabel.Name = "Transaction_DateLabel"
        Transaction_DateLabel.Size = New System.Drawing.Size(92, 13)
        Transaction_DateLabel.TabIndex = 2
        Transaction_DateLabel.Text = "Transaction Date:"
        '
        'DepositorLabel
        '
        DepositorLabel.AutoSize = True
        DepositorLabel.Location = New System.Drawing.Point(59, 100)
        DepositorLabel.Name = "DepositorLabel"
        DepositorLabel.Size = New System.Drawing.Size(55, 13)
        DepositorLabel.TabIndex = 4
        DepositorLabel.Text = "Depositor:"
        '
        'AmountLabel2
        '
        AmountLabel2.AutoSize = True
        AmountLabel2.Location = New System.Drawing.Point(59, 123)
        AmountLabel2.Name = "AmountLabel2"
        AmountLabel2.Size = New System.Drawing.Size(46, 13)
        AmountLabel2.TabIndex = 6
        AmountLabel2.Text = "Amount:"
        '
        'NarrationLabel
        '
        NarrationLabel.AutoSize = True
        NarrationLabel.Location = New System.Drawing.Point(59, 146)
        NarrationLabel.Name = "NarrationLabel"
        NarrationLabel.Size = New System.Drawing.Size(53, 13)
        NarrationLabel.TabIndex = 8
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
        'Table1BindingNavigator
        '
        Me.Table1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Table1BindingNavigator.BindingSource = Me.Table1BindingSource
        Me.Table1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Table1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Table1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Table1BindingNavigatorSaveItem})
        Me.Table1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Table1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Table1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Table1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Table1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Table1BindingNavigator.Name = "Table1BindingNavigator"
        Me.Table1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Table1BindingNavigator.Size = New System.Drawing.Size(833, 25)
        Me.Table1BindingNavigator.TabIndex = 0
        Me.Table1BindingNavigator.Text = "BindingNavigator1"
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
        'Table1BindingNavigatorSaveItem
        '
        Me.Table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table1BindingNavigatorSaveItem.Name = "Table1BindingNavigatorSaveItem"
        Me.Table1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Table1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserIDLabel1
        '
        Me.UserIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "UserID", True))
        Me.UserIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDLabel1.Location = New System.Drawing.Point(248, 241)
        Me.UserIDLabel1.Name = "UserIDLabel1"
        Me.UserIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UserIDLabel1.TabIndex = 2
        Me.UserIDLabel1.Text = "Label1"
        '
        'First_NameLabel1
        '
        Me.First_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "First_Name", True))
        Me.First_NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameLabel1.Location = New System.Drawing.Point(248, 264)
        Me.First_NameLabel1.Name = "First_NameLabel1"
        Me.First_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.First_NameLabel1.TabIndex = 4
        Me.First_NameLabel1.Text = "Label1"
        '
        'Last_NameLabel1
        '
        Me.Last_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Last_Name", True))
        Me.Last_NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameLabel1.Location = New System.Drawing.Point(248, 287)
        Me.Last_NameLabel1.Name = "Last_NameLabel1"
        Me.Last_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Last_NameLabel1.TabIndex = 6
        Me.Last_NameLabel1.Text = "Label1"
        '
        'AgeLabel1
        '
        Me.AgeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Age", True))
        Me.AgeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLabel1.Location = New System.Drawing.Point(248, 310)
        Me.AgeLabel1.Name = "AgeLabel1"
        Me.AgeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AgeLabel1.TabIndex = 8
        Me.AgeLabel1.Text = "Label1"
        '
        'CountryLabel1
        '
        Me.CountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Country", True))
        Me.CountryLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryLabel1.Location = New System.Drawing.Point(248, 333)
        Me.CountryLabel1.Name = "CountryLabel1"
        Me.CountryLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CountryLabel1.TabIndex = 10
        Me.CountryLabel1.Text = "Label1"
        '
        'Phone_NumberLabel1
        '
        Me.Phone_NumberLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Phone_Number", True))
        Me.Phone_NumberLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberLabel1.Location = New System.Drawing.Point(248, 356)
        Me.Phone_NumberLabel1.Name = "Phone_NumberLabel1"
        Me.Phone_NumberLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Phone_NumberLabel1.TabIndex = 12
        Me.Phone_NumberLabel1.Text = "Label1"
        '
        'EmailLabel1
        '
        Me.EmailLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Email", True))
        Me.EmailLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel1.Location = New System.Drawing.Point(248, 379)
        Me.EmailLabel1.Name = "EmailLabel1"
        Me.EmailLabel1.Size = New System.Drawing.Size(100, 23)
        Me.EmailLabel1.TabIndex = 14
        Me.EmailLabel1.Text = "Label1"
        '
        'AmountLabel1
        '
        Me.AmountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Amount", True))
        Me.AmountLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLabel1.Location = New System.Drawing.Point(248, 402)
        Me.AmountLabel1.Name = "AmountLabel1"
        Me.AmountLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AmountLabel1.TabIndex = 16
        Me.AmountLabel1.Text = "Label1"
        '
        'PassportPictureBox
        '
        Me.PassportPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Table1BindingSource, "Passport", True))
        Me.PassportPictureBox.Location = New System.Drawing.Point(251, 41)
        Me.PassportPictureBox.Name = "PassportPictureBox"
        Me.PassportPictureBox.Size = New System.Drawing.Size(177, 171)
        Me.PassportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassportPictureBox.TabIndex = 18
        Me.PassportPictureBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(DIDLabel)
        Me.GroupBox1.Controls.Add(Me.DIDLabel1)
        Me.GroupBox1.Controls.Add(Transaction_DateLabel)
        Me.GroupBox1.Controls.Add(Me.Transaction_DateLabel1)
        Me.GroupBox1.Controls.Add(DepositorLabel)
        Me.GroupBox1.Controls.Add(Me.DepositorLabel1)
        Me.GroupBox1.Controls.Add(AmountLabel2)
        Me.GroupBox1.Controls.Add(Me.AmountLabel3)
        Me.GroupBox1.Controls.Add(NarrationLabel)
        Me.GroupBox1.Controls.Add(Me.NarrationLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(164, 464)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 196)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Logs(Recent Transactions)"
        '
        'DIDLabel1
        '
        Me.DIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "DID", True))
        Me.DIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIDLabel1.Location = New System.Drawing.Point(157, 54)
        Me.DIDLabel1.Name = "DIDLabel1"
        Me.DIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DIDLabel1.TabIndex = 1
        Me.DIDLabel1.Text = "Label1"
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table1"
        Me.Table1BindingSource1.DataSource = Me.DepositDataSet
        '
        'DepositDataSet
        '
        Me.DepositDataSet.DataSetName = "DepositDataSet"
        Me.DepositDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Transaction_DateLabel1
        '
        Me.Transaction_DateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Transaction_Date", True))
        Me.Transaction_DateLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transaction_DateLabel1.Location = New System.Drawing.Point(157, 77)
        Me.Transaction_DateLabel1.Name = "Transaction_DateLabel1"
        Me.Transaction_DateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Transaction_DateLabel1.TabIndex = 3
        Me.Transaction_DateLabel1.Text = "Label1"
        '
        'DepositorLabel1
        '
        Me.DepositorLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Depositor", True))
        Me.DepositorLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepositorLabel1.Location = New System.Drawing.Point(157, 100)
        Me.DepositorLabel1.Name = "DepositorLabel1"
        Me.DepositorLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DepositorLabel1.TabIndex = 5
        Me.DepositorLabel1.Text = "Label1"
        '
        'AmountLabel3
        '
        Me.AmountLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Amount", True))
        Me.AmountLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLabel3.Location = New System.Drawing.Point(157, 123)
        Me.AmountLabel3.Name = "AmountLabel3"
        Me.AmountLabel3.Size = New System.Drawing.Size(100, 23)
        Me.AmountLabel3.TabIndex = 7
        Me.AmountLabel3.Text = "Label1"
        '
        'NarrationLabel1
        '
        Me.NarrationLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource1, "Narration", True))
        Me.NarrationLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NarrationLabel1.Location = New System.Drawing.Point(157, 146)
        Me.NarrationLabel1.Name = "NarrationLabel1"
        Me.NarrationLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NarrationLabel1.TabIndex = 9
        Me.NarrationLabel1.Text = "Label1"
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
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(531, 374)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(135, 45)
        Me.Button9.TabIndex = 41
        Me.Button9.Text = "USER TRANSACTIONS"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(531, 282)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(135, 45)
        Me.Button7.TabIndex = 40
        Me.Button7.Text = "TRANSFER MONEY"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(531, 204)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(135, 45)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "WITHDRAWAL"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(531, 128)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(135, 45)
        Me.Button8.TabIndex = 38
        Me.Button8.Text = "DEPOSIT"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(531, 42)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(135, 45)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "DELETE MY ACCOUNT"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(562, 666)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 26)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(213, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'My_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 714)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDLabel1)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameLabel1)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameLabel1)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeLabel1)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryLabel1)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberLabel1)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailLabel1)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountLabel1)
        Me.Controls.Add(PassportLabel)
        Me.Controls.Add(Me.PassportPictureBox)
        Me.Controls.Add(Me.Table1BindingNavigator)
        Me.Name = "My_Account"
        Me.Text = "My_Account"
        CType(Me.BankAccRegDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table1BindingNavigator.ResumeLayout(False)
        Me.Table1BindingNavigator.PerformLayout()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepositDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankAccRegDataSet As Bank_App.BankAccRegDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As Bank_App.BankAccRegDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As Bank_App.BankAccRegDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Table1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents First_NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Last_NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents AgeLabel1 As System.Windows.Forms.Label
    Friend WithEvents CountryLabel1 As System.Windows.Forms.Label
    Friend WithEvents Phone_NumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents EmailLabel1 As System.Windows.Forms.Label
    Friend WithEvents AmountLabel1 As System.Windows.Forms.Label
    Friend WithEvents PassportPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DepositDataSet As Bank_App.DepositDataSet
    Friend WithEvents Table1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter1 As Bank_App.DepositDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager1 As Bank_App.DepositDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Transaction_DateLabel1 As System.Windows.Forms.Label
    Friend WithEvents DepositorLabel1 As System.Windows.Forms.Label
    Friend WithEvents AmountLabel3 As System.Windows.Forms.Label
    Friend WithEvents NarrationLabel1 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
