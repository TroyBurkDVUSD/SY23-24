Public Class CoinSlot
    Public Event Dispense(P As Image)
    Public Event CoinReturnEvent(D As Integer, Q As Integer, DM As Integer, N As Integer)
    Public Property Quarters As Integer
    Public Property Nickles As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Dim _Total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _Total = Dollars * 1 + Quarters * 0.25 + Dimes * 0.1 + Nickles * 0.05
            Return _Total
        End Get
    End Property
    Public Sub CoinReturn()
        RaiseEvent CoinReturnEvent(Dollars, Quarters, Nickles, Dimes)
        Quarters = 0
        Dimes = 0
        Nickles = 0
        Dollars = 0
    End Sub
    Public Sub InsertQuarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub InsertNickle()
        Nickles = Nickles + 1
    End Sub
    Public Sub InsertDime()
        Dimes = Dimes + 1
    End Sub
    Public Sub InsertDollar()
        Dollars = Dollars + 1
    End Sub
    Public Sub InsertNickles()
        Nickles = Nickles + 1
    End Sub
    Public Sub Buy(p As ProductControl)
        If p.ProductCount > 0 And Total >= p.Price Then
            p.Buy()
            _Total = _Total - p.Price
            Dollars = 0
            Quarters = 0
            Dimes = 0
            Nickles = _Total / 0.05
            RaiseEvent Dispense(p.Picture)
        End If
    End Sub
End Class
