'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
'       Changes to this template will not be lost.
'
'     Template: EditableChildList.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla

Namespace PetShop.Business
    Public Partial Class CartList
#Region "Authorization Rules"
    
#If Not SILVERLIGHT Then
        Private Sub AddAuthorizationRules()
            'Csla.Rules.BusinessRules.AddRule(GetType(CartList), New Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, "SomeRole"))
            'Csla.Rules.BusinessRules.AddRule(GetType(CartList), New Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, "SomeRole"))
            'Csla.Rules.BusinessRules.AddRule(GetType(CartList), New Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, "SomeRole", "SomeAdminRole"))
        End Sub
#End If
#End Region

#Region "Custom Factory Methods"

    Friend Shared Function GetCart(ByVal uniqueID As Integer, ByVal isShoppingCart As Boolean) As CartList
        Dim criteria As New CartCriteria
        criteria.UniqueID = uniqueID
        criteria.IsShoppingCart = isShoppingCart

        Return DataPortal.FetchChild(Of CartList)(criteria)
    End Function

#End Region

#Region "Properties"

    ''' <summary>
    ''' Calculate the total for all the Items in the Cart.
    ''' </summary>
    Public ReadOnly Property Total() As Decimal
        Get
            Dim totalValue As Decimal = 0
            For Each cart As Cart In Me
                totalValue += cart.Price * cart.Quantity
            Next

            Return totalValue
        End Get
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Update the quantity for item that exists in the cart.
    ''' </summary>
    ''' <param name="itemId">Item Id</param>
    ''' <param name="quantity">Quantity</param>
    Public Sub SetQuantity(ByVal itemId As String, ByVal quantity As Integer)
        Dim index As Integer = 0
        For Each cart As Cart In Me
            If cart.ItemId = itemId Then
                Exit For
            End If

            System.Math.Max(System.Threading.Interlocked.Increment(index), index - 1)
        Next

        Me(index).Quantity = quantity
    End Sub

    ''' <summary>
    ''' Add an item to the cart.
    ''' When ItemId to be added has already existed, this method will update the quantity instead.
    ''' </summary>
    ''' <param name="itemId">Item to add</param>
    ''' <param name="uniqueID">Cart's Unique ID</param>
    ''' <param name="isShoppingCart">Cart is a shopping cart.</param>
    Public Overloads Sub Add(ByVal itemId As String, ByVal uniqueID As Integer, ByVal isShoppingCart As Boolean)
        Add(itemId, uniqueID, isShoppingCart, 1)
    End Sub
    ''' <summary>
    ''' Add an item to the cart.
    ''' When ItemId to be added has already existed, this method will update the quantity instead.
    ''' </summary>
    ''' <param name="itemId">Item to add</param>
    ''' <param name="uniqueID">Cart's Unique ID</param>
    ''' <param name="isShoppingCart">Cart is a shopping cart.</param>
    ''' <param name="quantity">Item Quanitity</param>
    Public Overloads Sub Add(ByVal itemId As String, ByVal uniqueID As Integer, ByVal isShoppingCart As Boolean, ByVal quantity As Integer)
            Dim index As Integer = 0
            Dim found As Boolean = False

            For Each cart As Cart In Me
                If cart.ItemId = itemId Then
                    found = True
                    Exit For
                End If

                index += 1
            Next

            If found Then
                Items(index).Quantity += quantity
            Else
#If Not Silverlight Then
                Dim item2 As Item = PetShop.Business.Item.GetByItemId(itemId)
                Dim product3 As Product = Product.GetByProductId(item2.ProductId)
                Dim cart1 As Cart = Cart.NewCart()
                cart1.UniqueID = uniqueID
                cart1.ItemId = itemId
                cart1.Name = item2.Name
                cart1.ProductId = item2.ProductId
                cart1.IsShoppingCart = isShoppingCart
                cart1.Price = If(item2.ListPrice, If(item2.UnitCost, 0))
                cart1.Type = product3.Name
                cart1.CategoryId = product3.CategoryId
                cart1.Quantity = quantity

                Add(cart1)
#Else
                PetShop.Business.Item.GetByItemIdAsync(itemId, Sub(o, e)
                                                                   If e.[Error] Is Nothing Then
                                                                       Return
                                                                   End If

                                                                   Dim item2 As Item = e.[Object]
                                                                   Product.GetByProductIdAsync(item2.ProductId, Sub(o1, e1)
                                                                                                                    Dim product3 As Product = e1.[Object]

                                                                                                                    Cart.NewCartAsync(Sub(o2, e2)
                                                                                                                                          Dim cart1 As Cart = e2.[Object]

                                                                                                                                          cart1.UniqueID = uniqueID
                                                                                                                                          cart1.ItemId = itemId
                                                                                                                                          cart1.Name = item2.Name
                                                                                                                                          cart1.ProductId = item2.ProductId
                                                                                                                                          cart1.IsShoppingCart = isShoppingCart
                                                                                                                                          cart1.Price = If(item2.ListPrice, If(item2.UnitCost, 0))
                                                                                                                                          cart1.Type = product3.Name
                                                                                                                                          cart1.CategoryId = product3.CategoryId
                                                                                                                                          cart1.Quantity = quantity

                                                                                                                                          Add(cart1)

                                                                                                                                      End Sub)
                                                                                                                End Sub)
                                                               End Sub)
#End If
End If
    End Sub

    ''' <summary>
    ''' Remove item from the cart based on itemId.
    ''' </summary>
    ''' <param name="itemId">ItemId of item to remove</param>
    Public Overloads Sub Remove(ByVal itemId As String)
        Dim index As Integer = 0
        For Each cart As Cart In Me
            If cart.ItemId = itemId Then
                Exit For
            End If

            System.Math.Max(System.Threading.Interlocked.Increment(index), index - 1)
        Next

        RemoveItem(index)
    End Sub

    ''' <summary>
    ''' Method to convert all cart items to order line items
    ''' </summary>
    Public Sub SaveOrderLineItems(ByVal orderId As Integer)
            Dim lineNum As Integer = 0

            For Each item As Cart In Me
#If Not Silverlight Then
	Dim lineItem As LineItem = LineItem.NewLineItem()
	lineItem.OrderId = orderId
	lineItem.ItemId = item.ItemId
	lineItem.LineNum = System.Threading.Interlocked.Increment(lineNum)
	lineItem.Quantity = item.Quantity
	lineItem.UnitPrice = item.Price

	lineItem = lineItem.Save()

#Else
                LineItem.NewLineItemAsync(Sub(o, e)
                                              If e.Error Is Nothing Then
                                                  Return
                                              End If

                                              Dim lineItem As LineItem = e.[Object]
                                              lineItem.OrderId = orderId
                                              lineItem.ItemId = item.ItemId
                                              lineItem.LineNum = System.Threading.Interlocked.Increment(lineNum)
                                              lineItem.Quantity = item.Quantity
                                              lineItem.UnitPrice = item.Price

                                              item.BeginSave()
                                          End Sub)
#End If
            Next
    End Sub

#End Region

    End Class
End Namespace