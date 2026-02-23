Public Class cart_item
    Public Property item_id As Integer
    Public Property item_name As String
        Public Property quantity As Integer
        Public Property unit_price As Decimal

        ''' <summary>Line total (quantity × unit_price)</summary>
        Public ReadOnly Property LineTotal As Decimal
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


    ' =============================================================================
    ' CustomerItem.vb  –  Wrapper used to populate the customer ComboBox
    '
    ' Schema note: customers.customer_id is IDENTITY(701,1), IDs start at 701.
    ' Nothing = walk-in (maps to NULL in transactions.customer_id).
    ' =============================================================================
    Public Class CustomerItem

        ''' <summary>Nothing = Walk-in (maps to NULL in transactions.customer_id)</summary>
        Public Property customer_id As Integer?

        Public Property display As String

        Public Sub New(id As Integer?, displayText As String)
            customer_id = id
            display = displayText
        End Sub

        ''' <summary>ComboBox renders this automatically — no DisplayMember needed.</summary>
        Public Overrides Function ToString() As String
            Return display
        End Function

    End Class
