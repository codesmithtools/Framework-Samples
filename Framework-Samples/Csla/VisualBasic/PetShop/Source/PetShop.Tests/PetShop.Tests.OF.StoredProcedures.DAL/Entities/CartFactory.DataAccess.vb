﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Cart.vb'.
'
'     Template: ObjectFactory.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Server

Imports PetShop.Tests.OF.StoredProcedures

Namespace PetShop.Tests.OF.StoredProcedures.DAL
    Public Partial Class CartFactory
        Inherits ObjectFactory
    
#Region "Create"
    
        ''' <summary>
        ''' Creates New Cart with default values.
        ''' </summary>
        ''' <Returns>New Cart.</Returns>
        <RunLocal()> _
        Public Function Create() As Cart
            Dim item As Cart = CType(Activator.CreateInstance(GetType(Cart), True), Cart)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            Using BypassPropertyChecks(item)
                ' Default values.
    
                CheckRules(item)
                MarkNew(item)
                MarkAsChild(item)
            End Using
    
            OnCreated()
    
            Return item
        End Function
    
        ''' <summary>
        ''' Creates New Cart with default values.
        ''' </summary>
        ''' <Returns>New Cart.</Returns>
        <RunLocal()> _
        Private Function Create(ByVal criteria As CartCriteria) As  Cart
            Dim item As Cart = CType(Activator.CreateInstance(GetType(Cart), True), Cart)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            Dim resource As Cart = Fetch(criteria)
    
            Using BypassPropertyChecks(item)
                item.ItemId = resource.ItemId
                item.Name = resource.Name
                item.Type = resource.Type
                item.Price = resource.Price
                item.CategoryId = resource.CategoryId
                item.ProductId = resource.ProductId
                item.IsShoppingCart = resource.IsShoppingCart
                item.Quantity = resource.Quantity
            End Using
    
            CheckRules(item)
            MarkNew(item)
            MarkAsChild(item)
    
            OnCreated()
    
            Return item
        End Function
    
#End Region

#Region "Fetch"
    
        ''' <summary>
        ''' Fetch Cart.
        ''' </summary>
        ''' <param name="criteria">The criteria.</param>
        ''' <Returns></Returns>
        Public Function Fetch(ByVal criteria As CartCriteria) As Cart
            Dim item As Cart = Nothing
            
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return item
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Cart_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            item = Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found In 'dbo.Cart' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            MarkOld(item)
            MarkAsChild(item)
    
            OnFetched()
    
            Return item
        End Function
    
#End Region
    
#Region "Insert"
    
        Private Sub DoInsert(ByRef item As Cart, ByVal stopProccessingChildren As Boolean)
            ' Don't update If the item isn't dirty.
            If Not (item.IsDirty) Then
                Return
            End If
    
            Dim cancel As Boolean = False
            OnInserting(cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Cart_Insert]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_CartId", item.CartId)
                command.Parameters("@p_CartId").Direction = ParameterDirection.Output
                command.Parameters.AddWithValue("@p_UniqueID", item.UniqueID)
                command.Parameters.AddWithValue("@p_ItemId", item.ItemId)
                command.Parameters.AddWithValue("@p_Name", item.Name)
                command.Parameters.AddWithValue("@p_Type", item.Type)
                command.Parameters.AddWithValue("@p_Price", item.Price)
                command.Parameters.AddWithValue("@p_CategoryId", item.CategoryId)
                command.Parameters.AddWithValue("@p_ProductId", item.ProductId)
                command.Parameters.AddWithValue("@p_IsShoppingCart", item.IsShoppingCart)
                command.Parameters.AddWithValue("@p_Quantity", item.Quantity)
    
                    command.ExecuteNonQuery()
    
                        item.CartId = DirectCast(command.Parameters("@p_CartId").Value, System.Int32)
                End Using
            End Using
    
    
            MarkOld(item)
            CheckRules(item)
            
            If Not (stopProccessingChildren) Then
                ' Update Child Items.
    
    
                Update_Profiles_Profiles_FK_Cart_Profiles(item)
    
            End If
    
            OnInserted()
        End Sub
    
#End Region

#Region "Update"
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Public Function Update(ByVal item As Cart) As Cart
            Return Update(item, false)
        End Function
    
        Public Function Update(ByVal item As Cart, ByVal stopProccessingChildren as Boolean) As Cart
            If(item.IsDeleted) Then
                DoDelete(item)
                MarkNew(item)
            Else If(item.IsNew) Then
                DoInsert(item, stopProccessingChildren)
            Else
            DoUpdate(item, stopProccessingChildren)
            End If
    
            Return item
        End Function
    
        Private Sub DoUpdate(ByRef item As Cart, ByVal stopProccessingChildren As Boolean)
            Dim cancel As Boolean = False
            OnUpdating(cancel)
            If (cancel) Then
                Return
            End If
    
            ' Don't update If the item isn't dirty.
            If (item.IsDirty) Then
    
                Using connection As New SqlConnection(ADOHelper.ConnectionString)
                    connection.Open()
                    Using command As New SqlCommand("[dbo].[CSLA_Cart_Update]", connection)
                        command.CommandType = CommandType.StoredProcedure
                        command.Parameters.AddWithValue("@p_CartId", item.CartId)
                command.Parameters.AddWithValue("@p_UniqueID", item.UniqueID)
                command.Parameters.AddWithValue("@p_ItemId", item.ItemId)
                command.Parameters.AddWithValue("@p_Name", item.Name)
                command.Parameters.AddWithValue("@p_Type", item.Type)
                command.Parameters.AddWithValue("@p_Price", item.Price)
                command.Parameters.AddWithValue("@p_CategoryId", item.CategoryId)
                command.Parameters.AddWithValue("@p_ProductId", item.ProductId)
                command.Parameters.AddWithValue("@p_IsShoppingCart", item.IsShoppingCart)
                command.Parameters.AddWithValue("@p_Quantity", item.Quantity)
    
                        'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        Dim result As Integer = command.ExecuteNonQuery()
                        If (result = 0) Then
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                        End If
                        
                        item.CartId = DirectCast(command.Parameters("@p_CartId").Value, System.Int32)
                    End Using
                End Using
            End If
    

            MarkOld(item)
            CheckRules(item)

            If Not (stopProccessingChildren) Then
                ' Update Child Items.
    
    
                Update_Profiles_Profiles_FK_Cart_Profiles(item)
    
            End If

            OnUpdated()
        End Sub

#End Region

#Region "Delete"

        <Transactional(TransactionalTypes.TransactionScope)> _
        Public Sub Delete(ByVal criteria As CartCriteria)
            ' Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
            DoDelete(criteria)
        End Sub

        Protected Sub DoDelete(ByRef item As Cart)
            ' If we're not dirty then don't update the database.
            If Not (item.IsDirty) Then
                Return
            End If

            ' If we're New then don't call delete.
            If (item.IsNew) Then
                Return
            End If
    
            Dim criteria As New CartCriteria()
                criteria.CartId = item.CartId
            DoDelete(criteria)

            MarkNew(item)
        End Sub

        Private Sub DoDelete(ByVal criteria As CartCriteria)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If

            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Cart_Delete]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))

                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using

            OnDeleted()
        End Sub

#End Region

#Region "Helper Methods"
    
        Public Function Map(ByVal reader As SafeDataReader) As Cart
            Dim item As Cart = CType(Activator.CreateInstance(GetType(Cart), True), Cart)
            Using BypassPropertyChecks(item)
                item.CartId = reader.GetInt32("CartId")
                item.UniqueID = reader.GetInt32("UniqueID")
                item.ItemId = reader.GetString("ItemId")
                item.Name = reader.GetString("Name")
                item.Type = reader.GetString("Type")
                item.Price = reader.GetDecimal("Price")
                item.CategoryId = reader.GetString("CategoryId")
                item.ProductId = reader.GetString("ProductId")
                item.IsShoppingCart = reader.GetBoolean("IsShoppingCart")
                item.Quantity = reader.GetInt32("Quantity")
            End Using

            MarkOld(item)
            MarkAsChild(item)

            Return item
        End Function
    
    
    
        'Associations.Where(Function(a) a.AssociationType = AssociationType.ManyToOne OrElse a.AssociationType = AssociationType.ManyToZeroOrOne)
        Private Shared Sub Update_Profiles_Profiles_FK_Cart_Profiles(ByRef item As Cart)
            item.Profiles.UniqueID = item.UniqueID

            Dim factory As New ProfileFactory
            factory.Update(item.Profiles, True)
        End Sub
    

#End Region

#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' Codesmith generated stub method that is called when creating the <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Cart"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when fetching the <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CartCriteria"/> object containg the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As CartCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Cart"/> object has been fetched. 
        ''' </summary>    
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub
 
        ''' <summary>
        ''' Codesmith generated stub method that is called when mapping the <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Cart"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when inserting the <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Cart"/> object has been inserted. 
        ''' </summary>
        Partial Private Sub OnInserted()
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
        ''' <summary>
        ''' Codesmith generated stub method that is called when self deleting the <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Cart"/> object has been deleted. 
        ''' </summary>
        Partial Private Sub OnSelfDeleted()
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called when deleting the <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CartCriteria"/> object containg the criteria of the object to delete.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        Partial Private Sub OnDeleting(ByVal criteria As CartCriteria, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' Codesmith generated stub method that is called after the <see cref="Cart"/> object with the specified criteria has been deleted. 
        ''' </summary>
        Partial Private Sub OnDeleted()
        End Sub
        Private Partial Sub OnChildLoading(ByVal childProperty As Global.Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
    End Class
End Namespace