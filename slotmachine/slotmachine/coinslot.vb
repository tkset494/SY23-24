Public Class coinslot
    Public Event dispense(p As Image)
    Public Event coinreturnevent(D As Integer, Q As Integer, DM As Integer, N As Integer)
    Public Property quarters As Integer
    Public Property nickels As Integer

    Public Property dimes As Integer
    Public Property dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = dollars + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
            Return _total
        End Get
    End Property
    Public Sub coinreturn()
        RaiseEvent coinreturnevent(dollars, quarters, dimes, nickels)
        dollars = 0
        quarters = 0
        dimes = 0
        nickels = 0

    End Sub
    Public Sub insertquarter()
        quarters = quarters + 1

    End Sub
    Public Sub insertnickels()
        nickels = nickels + 1
    End Sub
    Public Sub insertdimes()
        dimes = dimes + 1
    End Sub
    Public Sub insertdollars()
        dollars = dollars + 1
    End Sub
    Public Sub Bigwin()
        dollars = dollars + 50
    End Sub
    Public Sub Biggestwin()
        dollars = dollars + 100
    End Sub
    Public Sub smallwin()
        dollars = dollars + 20
    End Sub
    Public Sub spin()
        If total >= 1 Then
            _total = _total - 1
            dollars = 0
            quarters = 0
            dimes = 0
            nickels = _total / 0.05
        End If
    End Sub
End Class
