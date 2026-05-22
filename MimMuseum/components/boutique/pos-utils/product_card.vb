Public Class product_card

    Public Event product_clicked(sender As product_card)

    Private _item_id As Integer
    Private _item_name As String
    Private _unit_price As Decimal
    Private _stock As Integer

    Public ReadOnly Property item_id As Integer
        Get
            Return _item_id
        End Get
    End Property

    Public ReadOnly Property item_name As String
        Get
            Return _item_name
        End Get
    End Property

    Public ReadOnly Property unit_price As Decimal
        Get
            Return _unit_price
        End Get
    End Property

    Public ReadOnly Property stock As Integer
        Get
            Return _stock
        End Get
    End Property


    Public Sub set_product(
                    id As Integer,
                    name As String,
                    price As Decimal,
                    stk As Integer,
                    image_filename As String
                    )
        _item_id = id
        _item_name = name
        _unit_price = price
        _stock = stk

        lblName.Text = name
        lblPrice.Text = price.ToString("C2")

        Try
            If Not String.IsNullOrWhiteSpace(image_filename) Then
                Dim full_path As String = image_helpers.get_item_image_path(image_filename)
                If Not String.IsNullOrEmpty(full_path) Then
                    picItem.Image = Image.FromFile(full_path)
                    Return
                End If
            End If
            picItem.Image = image_helpers.get_placeholder_image()
        Catch
            picItem.Image = image_helpers.get_placeholder_image()
        End Try
    End Sub


    ' route all child clicks up to the card-level event — no dead zones
    Private Sub raise_card_click(sender As Object, e As EventArgs) _
        Handles Me.Click,
                picItem.Click,
                lblName.Click,
                lblPrice.Click

        RaiseEvent product_clicked(Me)
    End Sub

End Class