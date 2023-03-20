Public Class TRANSFER

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankAccRegDataSet)

    End Sub


    Private Sub Table1BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankAccRegDataSet)

    End Sub

    Private Sub TRANSFER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankAccRegDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.BankAccRegDataSet.Table1)

        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        TextBox4.Hide()
        TextBox3.Hide()



    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Table1TableAdapter.FillBy(Me.BankAccRegDataSet.Table1, New System.Nullable(Of Integer)(CType(UserIDToolStripTextBox.Text, Integer)))
            GroupBox2.Show()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, C, j, k, l, m As Integer
        A = TextBox1.Text
        B = TextBox1.Text
        m = TextBox3.Text
        k = TextBox4.Text
        j = AmountLabel1.Text
        C = A + j
        m = m - A
        AmountLabel1.Text = C
        MsgBox("Your Transfer Of " & B & " is Successful")
        UserIDTextBox.Text = TextBox3.Text
        Me.Table1TableAdapter.FillBy2(Me.BankAccRegDataSet.Table1, New System.Nullable(Of Integer)(CType(TextBox2.Text, Integer)))
        AmountLabel1.Text = m
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankAccRegDataSet)
    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Table1TableAdapter.FillBy2(Me.BankAccRegDataSet.Table1, New System.Nullable(Of Integer)(CType(TextBox2.Text, Integer)))
            GroupBox3.Show()
            GroupBox1.Show()
            TextBox4.Text = UserIDTextBox.Text
            TextBox3.Text = AmountLabel1.Text
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class