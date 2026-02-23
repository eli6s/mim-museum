'' =============================================================================
'' product_card.vb  –  UserControl: one product tile in the POS grid
''
'' Designer requirements (product_card.Designer.vb):
''   picItem   PictureBox  – SizeMode = Zoom, fills upper portion of card
''   lblName   Label       – item name, centred, AutoSize = False, wraps
''   lblPrice  Label       – formatted price, centred
'' =============================================================================
'Public Class product_card

'    ' ------------------------------------------------------------------
'    ' Event raised when the user clicks anywhere on the card
'    ' ------------------------------------------------------------------
'    Public Event ProductClicked(sender As product_card)

'    ' ------------------------------------------------------------------
'    ' Backing fields (read-only after SetProduct)
'    ' ------------------------------------------------------------------
'    Private _itemId As Integer
'    Private _itemName As String
'    Private _unitPrice As Decimal
'    Private _stock As Integer

'    Public ReadOnly Property ItemId As Integer
'        Get
'            Return _itemId
'        End Get
'    End Property

'    Public ReadOnly Property ItemName As String
'        Get
'            Return _itemName
'        End Get
'    End Property

'    Public ReadOnly Property UnitPrice As Decimal
'        Get
'            Return _unitPrice
'        End Get
'    End Property

'    Public ReadOnly Property Stock As Integer
'        Get
'            Return _stock
'        End Get
'    End Property

'    ' ------------------------------------------------------------------
'    ' Populate card data — called by pos.vb after creating the card
'    ' ------------------------------------------------------------------
'    Public Sub SetProduct(id As Integer,
'                          name As String,
'                          price As Decimal,
'                          stock As Integer,
'                          imageFilename As String)
'        _itemId = id
'        _itemName = name
'        _unitPrice = price
'        _stock = stock

'        lblName.Text = name
'        lblPrice.Text = price.ToString("C2")

'        Try
'            If Not String.IsNullOrWhiteSpace(imageFilename) Then
'                Dim fullPath As String = ImageHelper.GetItemImagePath(imageFilename)
'                If IO.File.Exists(fullPath) Then
'                    picItem.Image = Image.FromFile(fullPath)
'                    Return
'                End If
'            End If
'            picItem.Image = ImageHelper.GetPlaceholderImage()
'        Catch
'            picItem.Image = ImageHelper.GetPlaceholderImage()
'        End Try
'    End Sub

'    ' ------------------------------------------------------------------
'    ' Route all child clicks to the card-level event so there are
'    ' no dead spots regardless of which visual element is clicked
'    ' ------------------------------------------------------------------
'    Private Sub RaiseCardClick(sender As Object, e As EventArgs) _
'        Handles Me.Click,
'                picItem.Click,
'                lblName.Click,
'                lblPrice.Click

'        RaiseEvent ProductClicked(Me)
'    End Sub

'End Class