﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatusList.vb.
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
Imports Csla.Data

Namespace PetShop.Tests.OF.StoredProcedures
    <Serializable()> _
    <Csla.Server.ObjectFactory(FactoryNames.OrderStatusListFactoryName)> _
    Public Partial Class OrderStatusList 
        Inherits BusinessListBase(Of OrderStatusList, OrderStatus)
    
#Region "Contructor(s)"

        public Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    
#End Region

#Region "Synchronous Factory Methods" 

        ''' <summary>
        ''' Creates a new object of type <see cref="OrderStatusList"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="OrderStatusList"/>.</returns>
        Friend Shared Function NewList() As OrderStatusList
            Return DataPortal.CreateChild(Of OrderStatusList)()
        End Function

        ''' <summary>
        ''' Returns a <see cref="OrderStatusList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="orderId">No additional detail available.</param>
        ''' <param name="lineNum">No additional detail available.</param>
        ''' <returns>A <see cref="OrderStatusList"/> object of the specified criteria.</returns>
        Friend Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As OrderStatusList 
            Dim criteria As New OrderStatusCriteria()
                        criteria.OrderId = orderId
            criteria.LineNum = lineNum
    
            Return DataPortal.Fetch(Of OrderStatusList)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="OrderStatusList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="orderId">No additional detail available.</param>
        ''' <returns>A <see cref="OrderStatusList"/> object of the specified criteria.</returns>
        Friend Shared Function GetByOrderId(ByVal orderId As System.Int32) As OrderStatusList 
            Dim criteria As New OrderStatusCriteria()
                        criteria.OrderId = orderId
    
            Return DataPortal.Fetch(Of OrderStatusList)(criteria)
        End Function

        Friend Shared Function GetByCriteria(ByVal criteria As OrderStatusCriteria) As OrderStatusList
            Return DataPortal.Fetch(Of OrderStatusList)(criteria)
        End Function

        Friend Shared Function GetAll() As OrderStatusList
            Return DataPortal.Fetch(Of OrderStatusList)(New OrderStatusCriteria())
        End Function

#End Region
    
#Region "Asynchronous Factory Methods"

        Friend Shared Sub NewListAsync(ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatusList)))
            Dim dp As New DataPortal(Of OrderStatusList)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Friend Shared Sub GetByOrderIdLineNumAsync(ByVal orderId As System.Int32, ByVal lineNum As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of OrderStatusList))))
            Dim criteria As New OrderStatusCriteria()
                        criteria.OrderId = orderId
            criteria.LineNum = lineNum

            DataPortal.BeginFetch(Of AsyncChildLoader(Of OrderStatusList))(criteria, handler)
        End Sub
    
        Friend Shared Sub GetByOrderIdAsync(ByVal orderId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of OrderStatusList))))
            Dim criteria As New OrderStatusCriteria()
                        criteria.OrderId = orderId

            DataPortal.BeginFetch(Of AsyncChildLoader(Of OrderStatusList))(criteria, handler)
        End Sub

        Friend Shared Sub GetByCriteriaAsync(ByVal criteria As OrderStatusCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatusList)))
            Dim dp As New DataPortal(Of OrderStatusList)()
            AddHandler dp.FetchCompleted, handler

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

        Friend Shared Sub GetAllAsync(ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of OrderStatusList))))
            DataPortal.BeginFetch(Of AsyncChildLoader(Of OrderStatusList))(New OrderStatusCriteria(), handler)
        End Sub 

#End Region
    
#Region "Method Overrides"
    
        Protected Overrides Function AddNewCore() As OrderStatus
            Dim item As OrderStatus = PetShop.Tests.OF.StoredProcedures.OrderStatus.NewOrderStatus()

            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null In the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.OF.StoredProcedures.OrderStatus.NewOrderStatus()
                End If
            ' Pass the parent value down to the child.
                'Dim order As Order = CType(Me.Parent, Order)
                'If Not(order Is Nothing)
                '    item.OrderId = order.OrderId
                'End If
                Add(item)
            End If

            Return item
        End Function
#End Region

        Protected Sub AddNewCoreAsync(ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatus)))
            PetShop.Tests.OF.StoredProcedures.OrderStatus.NewOrderStatusAsync(Sub(o, e)
                    If e.Error Is Nothing Then
                        Add(e.Object)
                        handler.Invoke(Me, New DataPortalResult(Of OrderStatus)(e.Object, Nothing, Nothing))
                    End If
                End Sub)
        End Sub

#Region "Property overrides"
    
            ''' <summary>
            ''' Returns true if any children are dirty
            ''' </summary>
            Public Shadows ReadOnly Property IsDirty() As Boolean
                Get
                    For Each item As OrderStatus In Me.Items
                        If item.IsDirty Then
                            Return True
                        End If
                    Next
            
                    Return False
                End Get
            End Property
    
#End Region
    
#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' CodeSmith generated stub method that is called when creating the child <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="OrderStatus"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when fetching the child <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderStatusCriteria"/> object containing the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As OrderStatusCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="OrderStatus"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="OrderStatus"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="OrderStatus"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByRef item As OrderStatus, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"

        ''' <summary>
        ''' Determines if a record exists in the OrderStatus in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is a <see cref="OrderStatusList"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As OrderStatusCriteria) As Boolean
            Return PetShop.Tests.OF.StoredProcedures.OrderStatus.Exists(criteria)
        End Function

        ''' <summary>
        ''' Determines if a record exists in the OrderStatus in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As OrderStatusCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Tests.OF.StoredProcedures.OrderStatus.ExistsAsync(criteria, handler)
        End Sub

#End Region
 
#region "Enhancements"

        Public Function GetOrderStatus(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As OrderStatus
            Return Me.FirstOrDefault(Function(i As OrderStatus) i.OrderId = orderId AndAlso i.LineNum = lineNum)
        End Function
        
        Public Overloads Function Contains(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As Boolean
            Return Me.Where(Function(i As OrderStatus) i.OrderId = orderId AndAlso i.LineNum = lineNum).Count() > 0
        End Function

        Public Overloads Function ContainsDeleted(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As Boolean
            Return DeletedList.Where(Function(i As OrderStatus) i.OrderId = orderId AndAlso i.LineNum = lineNum).Count() > 0
        End Function

        Public Overloads Sub Remove(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
            Dim item As OrderStatus = Me.FirstOrDefault(Function(i As OrderStatus) i.OrderId = orderId AndAlso i.LineNum = lineNum)
            If item IsNot Nothing Then
                Remove(item)
            End If
        End Sub
        
#End Region
    End Class
End Namespace