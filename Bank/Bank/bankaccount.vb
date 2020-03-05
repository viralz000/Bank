Public Class bankaccount
    Private name1 As String = ""
    Private amount As Double = 0.0

    Public Sub Deposit(ByVal amount As Double)
        Me.amount = Me.amount + amount
    End Sub

    Public Sub Withdraw(ByVal amount As Double)
        Me.amount = Me.amount - amount
    End Sub

    Public Function getName()
        Return Me.name1
    End Function

    Public Function getAmount() As Double
        Return Me.amount
    End Function
#Region "Constructor"
    Public Sub New(ByVal initialAmount As Double)
        Me.amount = 0.0
    End Sub

    Public Sub New()
        Me.amount = 0.0
    End Sub
#End Region

    Public Sub SetName(ByVal name1 As String)
        Me.name1 = name1
    End Sub
End Class
