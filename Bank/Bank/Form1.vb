Public Class Form1
    Public BA As bankaccount
    Private Sub withdraw_Click(sender As Object, e As EventArgs) Handles withdraw.Click
        Me.BA.Withdraw(CDbl(amount.Text))
    End Sub

    Private Sub Deposit_Click(sender As Object, e As EventArgs) Handles Deposit.Click
        Me.BA.Deposit(CDbl(amount.Text))
    End Sub

    Private Sub balance_Click(sender As Object, e As EventArgs) Handles balance.Click
        MsgBox("Name: " & Me.BA.getName() & vbNewLine & "Balance: " & Me.BA.getAmount())
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Me.BA = New bankaccount(CDbl(amount.Text))
        Me.BA.Deposit(CDbl(amount.Text))
        Me.BA.SetName(name1.Text)
        MsgBox("Account Created")
    End Sub



End Class
