Public Class WITHDRAWAL

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankAccRegDataSet)

    End Sub

    Private Sub WITHDRAWAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankAccRegDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.BankAccRegDataSet.Table1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim A, B, C As Integer
            A = AmountTextBox.Text
            B = TextBox1.Text
            C = A - B
            AmountTextBox.Text = C
            If B >= A Then
                MsgBox("Your account is too low for this transaction, Process Terminated!")
            ElseIf B > A Then
                MsgBox("Total Amount of" & B & "has been withdrawn from your account! Thanks for using Better Bank.")
            End If

        Catch ex As Exception
            MsgBox("Invalid Input detected, Please enter a valid amount")
        End Try
        
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TRANSFER.Show()
    End Sub

    Private Sub FillBy3ToolStripButton_Click(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Table1TableAdapter.FillBy3(Me.BankAccRegDataSet.Table1, New System.Nullable(Of Integer)(CType(TextBox2.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class