<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.withdraw = New System.Windows.Forms.Button()
        Me.balance = New System.Windows.Forms.Button()
        Me.Deposit = New System.Windows.Forms.Button()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'withdraw
        '
        Me.withdraw.Location = New System.Drawing.Point(43, 145)
        Me.withdraw.Name = "withdraw"
        Me.withdraw.Size = New System.Drawing.Size(75, 23)
        Me.withdraw.TabIndex = 0
        Me.withdraw.Text = "Withdraw"
        Me.withdraw.UseVisualStyleBackColor = True
        '
        'balance
        '
        Me.balance.Location = New System.Drawing.Point(89, 174)
        Me.balance.Name = "balance"
        Me.balance.Size = New System.Drawing.Size(75, 23)
        Me.balance.TabIndex = 1
        Me.balance.Text = "Show Info"
        Me.balance.UseVisualStyleBackColor = True
        '
        'Deposit
        '
        Me.Deposit.Location = New System.Drawing.Point(132, 145)
        Me.Deposit.Name = "Deposit"
        Me.Deposit.Size = New System.Drawing.Size(75, 23)
        Me.Deposit.TabIndex = 2
        Me.Deposit.Text = "Deposit"
        Me.Deposit.UseVisualStyleBackColor = True
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(101, 82)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(106, 20)
        Me.amount.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(40, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(51, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name:"
        '
        'name1
        '
        Me.name1.Location = New System.Drawing.Point(101, 42)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(106, 20)
        Me.name1.TabIndex = 6
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(117, 108)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 7
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 234)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Deposit)
        Me.Controls.Add(Me.balance)
        Me.Controls.Add(Me.withdraw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents withdraw As Button
    Friend WithEvents balance As Button
    Friend WithEvents Deposit As Button
    Friend WithEvents amount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents name1 As TextBox
    Friend WithEvents submit As Button
End Class
