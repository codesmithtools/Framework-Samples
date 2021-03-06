﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Category.vb.
'
'     Template: SwitchableObject.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.StoredProcedures
    Public Partial Class Category
    
#Region "Root Data Access"
    
        <RunLocal()> _
        Protected Overrides Sub DataPortal_Create()
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return
            End If
    

            BusinessRules.CheckRules()
    
            OnCreated()
        End Sub
    
        Private Shadows Sub DataPortal_Fetch(ByVal criteria As CategoryCriteria )
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Category_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue)
                command.Parameters.AddWithValue("@p_DescnHasValue", criteria.DescriptionHasValue)
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found In 'dbo.Category' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnFetched()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Overrides Sub DataPortal_Insert()
            Dim cancel As Boolean = False
            OnInserting(cancel)
            If (cancel) Then
                Return
            End If

            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Category_Insert]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
    
                    command.ExecuteNonQuery()
    
                    Using (BypassPropertyChecks)
                    End Using
                End Using
                
                LoadProperty(_originalCategoryIdProperty, Me.CategoryId)
    
                FieldManager.UpdateChildren(Me, connection)
            End Using
    
            OnInserted()

        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Overrides Sub DataPortal_Update()
            Dim cancel As Boolean = False
            OnUpdating(cancel)
            If (cancel) Then
                Return
            End If
    
            If Not OriginalCategoryId = CategoryId Then
                ' Insert new child.
                Dim item As New Category()
                            item.CategoryId = CategoryId
            item.Name = Name
            item.Description = Description
                item = item.Save()
    
                ' Mark editable child lists as dirty. This code may need to be updated to one-to-one relationships.
    
                For Each itemToUpdate As Product In Products
            itemToUpdate.CategoryId = CategoryId
                Next
    
                ' Create a new connection.
                Using connection As New SqlConnection(ADOHelper.ConnectionString)
                    connection.Open()
                    FieldManager.UpdateChildren(Me, connection)
                End Using
    
                ' Delete the old.
                Dim criteria As New CategoryCriteria()
                            criteria.CategoryId = OriginalCategoryId
                DataPortal_Delete(criteria)
    
                ' Mark the original as the new one.
                OriginalCategoryId = CategoryId
                OnUpdated()
    
                Return
            End If
    
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Category_Update]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_OriginalCategoryId", Me.OriginalCategoryId)
                command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
    
                LoadProperty(_originalCategoryIdProperty, Me.CategoryId)
                End Using
    
                FieldManager.UpdateChildren(Me, connection)
            End Using
    
            OnUpdated()
        End Sub
    
        Protected Overrides Sub DataPortal_DeleteSelf()
            Dim cancel As Boolean = False
            OnSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New CategoryCriteria (CategoryId))
        
            OnSelfDeleted()
        End Sub
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As CategoryCriteria )
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If

            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Category_Delete]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using
    
            OnDeleted()
        End Sub
    
        '<Transactional(TransactionalTypes.TransactionScope)> _
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As CategoryCriteria, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If

            Using command As New SqlCommand("[dbo].[CSLA_Category_Delete]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
    
            OnDeleted()
        End Sub
    
#End Region
    
#Region "Child Data Access"
    
        <RunLocal()> _
        Protected Overrides Sub Child_Create()
            Dim cancel As Boolean = False
            OnChildCreating(cancel)
            If (cancel) Then
                Return
            End If
    

            BusinessRules.CheckRules()
    
            OnChildCreated()
        End Sub
        
        Private Sub Child_Fetch(ByVal criteria As CategoryCriteria)
            Dim cancel As Boolean = False
            OnChildFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Category_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue)
                command.Parameters.AddWithValue("@p_DescnHasValue", criteria.DescriptionHasValue)
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found In 'dbo.Category' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnChildFetched()
            MarkAsChild()
        End Sub
    
#Region "Child_Insert"
    
        Private Sub Child_Insert(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If

            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Category_Insert]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
    
                command.ExecuteNonQuery()
    
    
                ' Update the original non-identity primary key value.
                LoadProperty(_originalCategoryIdProperty, Me.CategoryId)
    
            End Using
    
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
#End Region
    
#Region "Child_Update"
    
        Private Sub Child_Update(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(connection, cancel)
            If (cancel) Then
                Return
            End If

            If Not connection.State = ConnectionState.Open Then connection.Open()
            Using command As New SqlCommand("[dbo].[CSLA_Category_Update]", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@p_OriginalCategoryId", Me.OriginalCategoryId)
                command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(Me.Name))
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(Me.Description))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
                ' Update non-identity primary key value.
                LoadProperty(_categoryIdProperty, DirectCast(command.Parameters("@p_CategoryId").Value, System.String))
                ' Update non-identity primary key value.
                LoadProperty(_originalCategoryIdProperty, Me.CategoryId)
            End Using
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
#End Region
    
        Private Sub Child_DeleteSelf()
            Dim cancel As Boolean = False
            OnChildSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New CategoryCriteria (CategoryId))
        
            OnChildSelfDeleted()
        End Sub
    
        Private Sub Child_DeleteSelf(ParamArray args As Object())
        Dim connection As SqlConnection = args.OfType(Of SqlConnection)().FirstOrDefault()
        If connection Is Nothing Then
            Throw New ArgumentNullException("args", "Must contain a SqlConnection parameter.")
        End If
        
            Dim cancel As Boolean = False
            OnChildSelfDeleting(cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New CategoryCriteria (CategoryId), connection)
        
            OnChildSelfDeleted()
        End Sub
    
#End Region
    
#Region "Map"

        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            Using(BypassPropertyChecks)
                LoadProperty(_categoryIdProperty, reader.Item("CategoryId"))
                LoadProperty(_originalCategoryIdProperty, reader.Item("CategoryId"))
                LoadProperty(_nameProperty, reader.Item("Name"))
                LoadProperty(_descriptionProperty, reader.Item("Descn"))
            End Using
    
            OnMapped()
        End Sub

        Private Sub Child_Fetch(reader As SafeDataReader)
            Map(reader)
        End Sub

#End Region
    End Class
End Namespace
