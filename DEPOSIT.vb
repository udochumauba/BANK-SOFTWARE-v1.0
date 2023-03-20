Public Class DEPOSIT

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankAccRegDataSet)

    End Sub

    Private Sub DEPOSIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DepositDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.DepositDataSet.Table1)
        'TODO: This line of code loads data into the 'BankAccRegDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.BankAccRegDataSet.Table1)
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        Table1BindingSource1.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, C As Integer
        A = AmountTextBox.Text
        B = TextBox1.Text
        C = A + B
        AmountTextBox.Text = C
        MsgBox("Your Deposit Of " & B & " is Successful")
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankAccRegDataSet)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WITHDRAWAL.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TRANSFER.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        usertransactions.Show()
        Me.Close()
    End Sub

    Private Sub AgeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
       

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Table1TableAdapter.FillBy1(Me.BankAccRegDataSet.Table1, New System.Nullable(Of Integer)(CType(TextBox2.Text, Integer)))
            If UserIDTextBox.Text = "" Then
                MsgBox("The user does not exist! Please register the user and try again")
            Else
                MsgBox("Record Found, Click ok to continue")
            End If
            GroupBox2.Show()
            GroupBox3.Show()
            GroupBox1.Show()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("An error Occured! Please try Again")
        End Try
        If UserIDTextBox.Text = "" Then
            MsgBox("The Account ID cannot be found")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try

            Dim msg, style, title, response, mystring
            msg = "Do you want to delete this account?"
            style = vbYesNo
            title = "MsgBox Demonstration"
            response = MsgBox(msg, style, title)
            If response = vbYes Then
                mystring = "yes"
                Table1BindingSource.RemoveCurrent()
                Me.Validate()
                Me.Table1BindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BankAccRegDataSet)
            Else
                mystring = "no"
            End If

        Catch ex As Exception
            MsgBox("An error occured")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class