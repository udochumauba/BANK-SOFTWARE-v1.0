<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRANSFER
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
        Dim UserIDLabel1 As System.Windows.Forms.Label
        Dim First_NameLabel1 As System.Windows.Forms.Label
        Dim Last_NameLabel1 As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PassportLabel As System.Windows.Forms.Label
        Dim UserIDLabel4 As System.Windows.Forms.Label
        Me.BankAccRegDataSet = New Bank_App.BankAccRegDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New Bank_App.BankAccRegDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New Bank_App.BankAccRegDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UserIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.UserIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AmountLabel1 = New System.Windows.Forms.Label()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDLabel3 = New System.Windows.Forms.Label()
        Me.First_NameLabel3 = New System.Windows.Forms.Label()
        Me.Last_NameLabel3 = New System.Windows.Forms.Label()
        Me.CountryLabel1 = New System.Windows.Forms.Label()
        Me.Phone_NumberLabel1 = New System.Windows.Forms.Label()
        Me.EmailLabel1 = New System.Windows.Forms.Label()
        Me.PassportPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        UserIDLabel1 = New System.Windows.Forms.Label()
        First_NameLabel1 = New System.Windows.Forms.Label()
        Last_NameLabel1 = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PassportLabel = New System.Windows.Forms.Label()
        UserIDLabel4 = New System.Windows.Forms.Label()
        CType(Me.BankAccRegDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDLabel1
        '
        UserIDLabel1.AutoSize = True
        UserIDLabel1.Location = New System.Drawing.Point(56, 41)
        UserIDLabel1.Name = "UserIDLabel1"
        UserIDLabel1.Size = New System.Drawing.Size(46, 13)
        UserIDLabel1.TabIndex = 0
        UserIDLabel1.Text = "User ID:"
        '
        'First_NameLabel1
        '
        First_NameLabel1.AutoSize = True
        First_NameLabel1.Location = New System.Drawing.Point(56, 64)
        First_NameLabel1.Name = "First_NameLabel1"
        First_NameLabel1.Size = New System.Drawing.Size(60, 13)
        First_NameLabel1.TabIndex = 2
        First_NameLabel1.Text = "First Name:"
        '
        'Last_NameLabel1
        '
        Last_NameLabel1.AutoSize = True
        Last_NameLabel1.Location = New System.Drawing.Point(56, 87)
        Last_NameLabel1.Name = "Last_NameLabel1"
        Last_NameLabel1.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel1.TabIndex = 4
        Last_NameLabel1.Text = "Last Name:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(290, 41)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 8
        CountryLabel.Text = "Country:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(290, 64)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 10
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(290, 87)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email:"
        '
        'PassportLabel
        '
        PassportLabel.AutoSize = True
        PassportLabel.Location = New System.Drawing.Point(563, 11)
        PassportLabel.Name = "PassportLabel"
        PassportLabel.Size = New System.Drawing.Size(51, 13)
        PassportLabel.TabIndex = 16
        PassportLabel.Text = "Passport:"
        '
        'UserIDLabel4
        '
        UserIDLabel4.AutoSize = True
        UserIDLabel4.Location = New System.Drawing.Point(56, 16)
        UserIDLabel4.Name = "UserIDLabel4"
        UserIDLabel4.Size = New System.Drawing.Size(46, 13)
        UserIDLabel4.TabIndex = 18
        UserIDLabel4.Text = "User ID:"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.FillByToolStrip)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 93)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTER ACCOUNT NUMBER OF RECIPIENT"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FillByToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserIDToolStripLabel, Me.UserIDToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(123, 38)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(260, 25)
        Me.FillByToolStrip.TabIndex = 20
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'UserIDToolStripLabel
        '
        Me.UserIDToolStripLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserIDToolStripLabel.Name = "UserIDToolStripLabel"
        Me.UserIDToolStripLabel.Size = New System.Drawing.Size(118, 22)
        Me.UserIDToolStripLabel.Text = "ACCOUNT NUMBER:"
        '
        'UserIDToolStripTextBox
        '
        Me.UserIDToolStripTextBox.Name = "UserIDToolStripTextBox"
        Me.UserIDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(28, 22)
        Me.FillByToolStripButton.Text = "GO"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(40, 473)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 121)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ENTER AMOUNT TO TRANSFER"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(234, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "TRANSFER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(211, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 29)
        Me.TextBox1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(274, 676)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(30, 71)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(670, 77)
        Me.GroupBox4.TabIndex = 39
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.AmountLabel1)
        Me.GroupBox3.Controls.Add(UserIDLabel4)
        Me.GroupBox3.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox3.Controls.Add(UserIDLabel1)
        Me.GroupBox3.Controls.Add(Me.UserIDLabel3)
        Me.GroupBox3.Controls.Add(First_NameLabel1)
        Me.GroupBox3.Controls.Add(Me.First_NameLabel3)
        Me.GroupBox3.Controls.Add(Last_NameLabel1)
        Me.GroupBox3.Controls.Add(Me.Last_NameLabel3)
        Me.GroupBox3.Controls.Add(CountryLabel)
        Me.GroupBox3.Controls.Add(Me.CountryLabel1)
        Me.GroupBox3.Controls.Add(Phone_NumberLabel)
        Me.GroupBox3.Controls.Add(Me.Phone_NumberLabel1)
        Me.GroupBox3.Controls.Add(EmailLabel)
        Me.GroupBox3.Controls.Add(Me.EmailLabel1)
        Me.GroupBox3.Controls.Add(PassportLabel)
        Me.GroupBox3.Controls.Add(Me.PassportPictureBox)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(669, 168)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "User Details:"
        '
        'AmountLabel1
        '
        Me.AmountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Amount", True))
        Me.AmountLabel1.Location = New System.Drawing.Point(389, 120)
        Me.AmountLabel1.Name = "AmountLabel1"
        Me.AmountLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AmountLabel1.TabIndex = 20
        Me.AmountLabel1.Text = "Label2"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(108, 13)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserIDTextBox.TabIndex = 19
        '
        'UserIDLabel3
        '
        Me.UserIDLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "UserID", True))
        Me.UserIDLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDLabel3.Location = New System.Drawing.Point(143, 41)
        Me.UserIDLabel3.Name = "UserIDLabel3"
        Me.UserIDLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UserIDLabel3.TabIndex = 1
        Me.UserIDLabel3.Text = "Label1"
        '
        'First_NameLabel3
        '
        Me.First_NameLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "First_Name", True))
        Me.First_NameLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameLabel3.Location = New System.Drawing.Point(143, 64)
        Me.First_NameLabel3.Name = "First_NameLabel3"
        Me.First_NameLabel3.Size = New System.Drawing.Size(100, 23)
        Me.First_NameLabel3.TabIndex = 3
        Me.First_NameLabel3.Text = "Label1"
        '
        'Last_NameLabel3
        '
        Me.Last_NameLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Last_Name", True))
        Me.Last_NameLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameLabel3.Location = New System.Drawing.Point(143, 87)
        Me.Last_NameLabel3.Name = "Last_NameLabel3"
        Me.Last_NameLabel3.Size = New System.Drawing.Size(100, 23)
        Me.Last_NameLabel3.TabIndex = 5
        Me.Last_NameLabel3.Text = "Label1"
        '
        'CountryLabel1
        '
        Me.CountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Country", True))
        Me.CountryLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryLabel1.Location = New System.Drawing.Point(377, 41)
        Me.CountryLabel1.Name = "CountryLabel1"
        Me.CountryLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CountryLabel1.TabIndex = 9
        Me.CountryLabel1.Text = "Label1"
        '
        'Phone_NumberLabel1
        '
        Me.Phone_NumberLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Phone_Number", True))
        Me.Phone_NumberLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberLabel1.Location = New System.Drawing.Point(377, 64)
        Me.Phone_NumberLabel1.Name = "Phone_NumberLabel1"
        Me.Phone_NumberLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Phone_NumberLabel1.TabIndex = 11
        Me.Phone_NumberLabel1.Text = "Label1"
        '
        'EmailLabel1
        '
        Me.EmailLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Email", True))
        Me.EmailLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel1.Location = New System.Drawing.Point(377, 87)
        Me.EmailLabel1.Name = "EmailLabel1"
        Me.EmailLabel1.Size = New System.Drawing.Size(100, 23)
        Me.EmailLabel1.TabIndex = 13
        Me.EmailLabel1.Text = "Label1"
        '
        'PassportPictureBox
        '
        Me.PassportPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Table1BindingSource, "Passport", True))
        Me.PassportPictureBox.Location = New System.Drawing.Point(527, 27)
        Me.PassportPictureBox.Name = "PassportPictureBox"
        Me.PassportPictureBox.Size = New System.Drawing.Size(118, 106)
        Me.PassportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassportPictureBox.TabIndex = 17
        Me.PassportPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(244, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 31)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "BETTER BANK"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(591, 687)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 20
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(485, 687)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Current Bal:"
        '
        'TRANSFER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 609)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TRANSFER"
        Me.Text = "TRANSFER"
        CType(Me.BankAccRegDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankAccRegDataSet As Bank_App.BankAccRegDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As Bank_App.BankAccRegDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As Bank_App.BankAccRegDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents UserIDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UserIDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents UserIDLabel3 As System.Windows.Forms.Label
    Friend WithEvents First_NameLabel3 As System.Windows.Forms.Label
    Friend WithEvents Last_NameLabel3 As System.Windows.Forms.Label
    Friend WithEvents CountryLabel1 As System.Windows.Forms.Label
    Friend WithEvents Phone_NumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents EmailLabel1 As System.Windows.Forms.Label
    Friend WithEvents PassportPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents AmountLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
