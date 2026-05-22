Public Class cart_item
    Public Property item_id As Integer
    Public Property item_name As String
    Public Property quantity As Integer
    Public Property unit_price As Decimal

    Public ReadOnly Property line_total As Decimal
        Get
            Return quantity * unit_price
        End Get
    End Property

    Public Sub New(id As Integer, name As String, qty As Integer, price As Decimal)
        item_id = id
        item_name = name
        quantity = qty
        unit_price = price
    End Sub

End Class
