﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'CartList.vb.
'
'     Template: EditableChildList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Linq

Imports Csla
#If SILVERLIGHT Then
Imports Csla.Serialization
#Else
Imports Csla.Data
#End If

Namespace PetShop.Business
    <Serializable()> _
    Public Partial Class CartList 
        Inherits BusinessListBase(Of CartList, Cart)
    
#Region "Contructor(s)"

        public Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    
#End Region

#Region "Synchronous Factory Methods" 
#If Not SILVERLIGHT Then

        ''' <summary>
        ''' Creates a new object of type <see cref="CartList"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="CartList"/>.</returns>
        Friend Shared Function NewList() As CartList
            Return DataPortal.CreateChild(Of CartList)()
        End Function

        ''' <summary>
        ''' Returns a <see cref="CartList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="cartId">No additional detail available.</param>
        ''' <returns>A <see cref="CartList"/> object of the specified criteria.</returns>
        Friend Shared Function GetByCartId(ByVal cartId As System.Int32) As CartList 
            Dim criteria As New CartCriteria()
                        criteria.CartId = cartId
    
            Return DataPortal.FetchChild(Of CartList)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="CartList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="uniqueID">No additional detail available.</param>
        ''' <returns>A <see cref="CartList"/> object of the specified criteria.</returns>
        Friend Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As CartList 
            Dim criteria As New CartCriteria()
                        criteria.UniqueID = uniqueID
    
            Return DataPortal.FetchChild(Of CartList)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="CartList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="isShoppingCart">No additional detail available.</param>
        ''' <returns>A <see cref="CartList"/> object of the specified criteria.</returns>
        Friend Shared Function GetByIsShoppingCart(ByVal isShoppingCart As System.Boolean) As CartList 
            Dim criteria As New CartCriteria()
                        criteria.IsShoppingCart = isShoppingCart
    
            Return DataPortal.FetchChild(Of CartList)(criteria)
        End Function

        Friend Shared Function GetByCriteria(ByVal criteria As CartCriteria) As CartList
            Return DataPortal.Fetch(Of CartList)(criteria)
        End Function

        Friend Shared Function GetAll() As CartList
            Return DataPortal.FetchChild(Of CartList)(New CartCriteria())
        End Function

#End If
#End Region
    
#Region "Asynchronous Factory Methods"

        Friend Shared Sub NewListAsync(ByVal handler As EventHandler(Of DataPortalResult(Of CartList)))
            Dim dp As New DataPortal(Of CartList)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Friend Shared Sub GetByCartIdAsync(ByVal cartId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of CartList))))
            Dim criteria As New CartCriteria()
                        criteria.CartId = cartId

            DataPortal.BeginFetch(Of AsyncChildLoader(Of CartList))(criteria, handler)
        End Sub
    
        Friend Shared Sub GetByUniqueIDAsync(ByVal uniqueID As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of CartList))))
            Dim criteria As New CartCriteria()
                        criteria.UniqueID = uniqueID

            DataPortal.BeginFetch(Of AsyncChildLoader(Of CartList))(criteria, handler)
        End Sub
    
        Friend Shared Sub GetByIsShoppingCartAsync(ByVal isShoppingCart As System.Boolean, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of CartList))))
            Dim criteria As New CartCriteria()
                        criteria.IsShoppingCart = isShoppingCart

            DataPortal.BeginFetch(Of AsyncChildLoader(Of CartList))(criteria, handler)
        End Sub

        Friend Shared Sub GetByCriteriaAsync(ByVal criteria As CartCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of CartList)))
            Dim dp As New DataPortal(Of CartList)()
            AddHandler dp.FetchCompleted, handler

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

        Friend Shared Sub GetAllAsync(ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of CartList))))
            DataPortal.BeginFetch(Of AsyncChildLoader(Of CartList))(New CartCriteria(), handler)
        End Sub 

#End Region
    
#Region "Method Overrides"
    
#If Not SILVERLIGHT Then
        Protected Overrides Function AddNewCore() As Cart
            Dim item As Cart = PetShop.Business.Cart.NewCart()

            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null In the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Business.Cart.NewCart()
                End If
            ' Pass the parent value down to the child.
                Dim profile As Profile = CType(Me.Parent, Profile)
                If Not(profile Is Nothing)
                    item.UniqueID = profile.UniqueID
                End If
                Add(item)
            End If

            Return item
        End Function
#Else
        Protected Overrides Sub AddNewCore() 
            PetShop.Business.Cart.NewCartAsync(Sub(o, e)
                    Dim item As Cart = e.Object
        
                    Dim cancel As Boolean = False
                    OnAddNewCore(item, cancel)
                    If Not (cancel) Then
                        ' Check to see if someone set the item to null In the OnAddNewCore.
                        If(item Is Nothing) Then
                            Return
                        End If
                        ' Pass the parent value down to the child.
                        Dim profile As Profile = CType(Me.Parent, Profile)
                        If Not(profile Is Nothing)
                            item.UniqueID = profile.UniqueID
                        End If
                        Add(item)
                    End If
                End Sub)
        End Sub
#End If
#End Region

        Protected Sub AddNewCoreAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Cart)))
            PetShop.Business.Cart.NewCartAsync(Sub(o, e)
                    If e.Error Is Nothing Then
                        Add(e.Object)
                        handler.Invoke(Me, New DataPortalResult(Of Cart)(e.Object, Nothing, Nothing))
                    End If
                End Sub)
        End Sub

#Region "DataPortal partial methods"
    
#If Not SILVERLIGHT Then
        ''' <summary>
        ''' Codesmith generated stub method that is called when creating the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when fetching the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CartCriteria"/> object containg the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As CartCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the child <see cref="Cart"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when updating the <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Cart"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
#End If
        Partial Private Sub OnAddNewCore(ByRef item As Cart, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"
#If Not SILVERLIGHT Then

        ''' <summary>
        ''' Determines if a record exists in the Cart in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is a <see cref="CartList"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As CartCriteria) As Boolean
            Return PetShop.Business.Cart.Exists(criteria)
        End Function

#End If

        ''' <summary>
        ''' Determines if a record exists in the Cart in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As CartCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Business.Cart.ExistsAsync(criteria, handler)
        End Sub

#End Region
 
#region "Enhancements"

        Public Function GetCart(ByVal cartId As System.Int32) As Cart
            Return Me.FirstOrDefault(Function(i As Cart) i.CartId = cartId)
        End Function
        
        Public Overloads Function Contains(ByVal cartId As System.Int32) As Boolean
            Return Me.Where(Function(i As Cart) i.CartId = cartId).Count() > 0
        End Function

        Public Overloads Function ContainsDeleted(ByVal cartId As System.Int32) As Boolean
            Return DeletedList.Where(Function(i As Cart) i.CartId = cartId).Count() > 0
        End Function

        Public Overloads Sub Remove(ByVal cartId As System.Int32)
            Dim item As Cart = Me.FirstOrDefault(Function(i As Cart) i.CartId = cartId)
            If item IsNot Nothing Then
                Remove(item)
            End If
        End Sub
        
#End Region
    End Class
End Namespace