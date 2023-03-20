Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        User.Show()
    End Sub

    Private Sub DEPOSITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEPOSITToolStripMenuItem.Click
        DEPOSIT.Show()
    End Sub

    Private Sub TRANSFERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSFERToolStripMenuItem.Click
        TRANSFER.Show()
    End Sub

    Private Sub WITHDRAWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WITHDRAWToolStripMenuItem.Click
        WITHDRAWAL.Show()
    End Sub

    Private Sub CREATEACCOUNTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CREATEACCOUNTToolStripMenuItem.Click
        User.Show()
    End Sub

    Private Sub USERPROFILESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERPROFILESToolStripMenuItem.Click
        View_Users.Show()
    End Sub

    Private Sub TRANSACTIONSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSACTIONSToolStripMenuItem.Click
        usertransactions.Show()
    End Sub
End Class
