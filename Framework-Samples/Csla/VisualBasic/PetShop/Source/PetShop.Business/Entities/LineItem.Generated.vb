﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItem.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Rules
#If SILVERLIGHT Then
Imports Csla.Serialization
#Else
Imports Csla.Data
Imports System.Data.SqlClient
#End If

Namespace PetShop.Business
    <Serializable()> _
    Public Partial Class LineItem 
        Inherits BusinessBase(Of LineItem)
    
#Region "Contructor(s)"
    
#If Not SILVERLIGHT Then
        Private Sub New()
            ' require use of factory method 
        End Sub
#Else
        public Sub New()
            ' require use of factory method 
        End Sub
#End If
    
        Friend Sub New(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
            Using(BypassPropertyChecks)
            LoadProperty(_orderIdProperty, orderId)
            LoadProperty(_lineNumProperty, lineNum)
            End Using
        End Sub
    
#If Not SILVERLIGHT Then
        Friend Sub New(Byval reader As SafeDataReader)
            Map(reader)
            MarkAsChild()   
        End Sub
#End If

#End Region    
#Region "Business Rules"
    
        Protected Overrides Sub AddBusinessRules()
            ' Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            MyBase.AddBusinessRules()

            If AddBusinessValidationRules() Then Exit Sub
    
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_itemIdProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_itemIdProperty, 10))
        End Sub
    
#End Region
#Region "Properties"
    
        Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OrderId, String.Empty)
#If Not SILVERLIGHT Then
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property OrderId() As System.Int32
#Else
        Public Property OrderId() As System.Int32
#End If
            Get 
                Return GetProperty(_orderIdProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_orderIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _originalOrderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OriginalOrderId, String.Empty)
        ''' <summary>
        ''' Holds the original value for OrderId. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalOrderId() As System.Int32
            Get 
                Return GetProperty(_originalOrderIdProperty) 
            End Get
            Set (value As System.Int32)
                SetProperty(_originalOrderIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _lineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.LineNum, String.Empty)
#If Not SILVERLIGHT Then
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property LineNum() As System.Int32
#Else
        Public Property LineNum() As System.Int32
#End If
            Get 
                Return GetProperty(_lineNumProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_lineNumProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _originalLineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OriginalLineNum, String.Empty)
        ''' <summary>
        ''' Holds the original value for LineNum. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalLineNum() As System.Int32
            Get 
                Return GetProperty(_originalLineNumProperty) 
            End Get
            Set (value As System.Int32)
                SetProperty(_originalLineNumProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _itemIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As LineItem) p.ItemId, String.Empty)
        
        Public Property ItemId() As System.String
            Get 
                Return GetProperty(_itemIdProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_itemIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _quantityProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.Quantity, String.Empty)
        
        Public Property Quantity() As System.Int32
            Get 
                Return GetProperty(_quantityProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_quantityProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _unitPriceProperty As PropertyInfo(Of System.Decimal) = RegisterProperty(Of System.Decimal)(Function(p As LineItem) p.UnitPrice, String.Empty)
        
        Public Property UnitPrice() As System.Decimal
            Get 
                Return GetProperty(_unitPriceProperty)
            End Get
            Set (ByVal value As System.Decimal)
                SetProperty(_unitPriceProperty, value)
            End Set
        End Property

    
    
        'AssociatedManyToOne
        Private Shared ReadOnly _orderMemberProperty As PropertyInfo(Of Order) = RegisterProperty(Of Order)(Function(p As LineItem) p.OrderMember, Csla.RelationshipTypes.Child)
        Public ReadOnly Property OrderMember() As Order
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_orderMemberProperty, cancel)
                
                If Not cancel Then
                    If(False) Then
                        Return Nothing
                    End If
    
                    If Not(FieldManager.FieldExists(_orderMemberProperty))
                        Dim criteria As New PetShop.Business.OrderCriteria()
                        criteria.OrderId = OrderId

#If SILVERLIGHT Then
                        'Markbusy()
                        PetShop.Business.Order.Exists(criteria, Sub(o, e)
                            If Not (e.Error Is Nothing) Then
                                Throw e.Error
                            End If
                            
                            If (e.Object.Result) Then
                                PetShop.Business.Order.GetByOrderIdAsync(OrderId, Sub(o1, e1)
                                    If Not (e1.Error Is Nothing) Then
                                        Throw e1.Error
                                    End If

                                    Me.LoadProperty(_orderMemberProperty, e1.Object)

                                    'MarkIdle()
                                    OnPropertyChanged(_orderMemberProperty)
                                End Sub)
                            End If
                        End Sub)
#Else
                        If (PetShop.Business.Order.Exists(criteria)) Then
                            LoadProperty(_orderMemberProperty, PetShop.Business.Order.GetByOrderId(OrderId))
                        End If
#End If
                    End If
                End If

                Return GetProperty(_orderMemberProperty) 
            End Get
        End Property

    
#End Region
    
#If Not SILVERLIGHT Then
#Region "Synchronous Root Factory Methods"
    
        Public Shared Function NewLineItem() As LineItem 
            Return DataPortal.Create(Of LineItem)()
        End Function
    
        Public Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItem
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
			criteria.LineNum = lineNum
    
            Return DataPortal.Fetch(Of LineItem)(criteria)
        End Function
    
        Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As LineItem
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.Fetch(Of LineItem)(criteria)
        End Function
    
        Public Shared Sub DeleteLineItem(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
            DataPortal.Delete(Of LineItem)(New LineItemCriteria (orderId, lineNum))
        End Sub
    
#End Region
#End If        
    
#Region "Asynchronous Root Factory Methods"
            
        Public Shared Sub NewLineItemAsync(ByVal handler As EventHandler(Of DataPortalResult(Of LineItem)))
            Dim dp As New DataPortal(Of LineItem)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Public Shared Sub GetByOrderIdLineNumAsync(ByVal orderId As System.Int32, ByVal lineNum As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of LineItem)))
            Dim dp As New DataPortal(Of LineItem)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
            criteria.LineNum = lineNum
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub GetByOrderIdAsync(ByVal orderId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of LineItem)))
            Dim dp As New DataPortal(Of LineItem)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub DeleteLineItemAsync(ByVal orderId As System.Int32, ByVal lineNum As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of LineItem)))
            Dim dp As New DataPortal(Of LineItem)()
            AddHandler dp.DeleteCompleted, handler
            dp.BeginDelete(New LineItemCriteria (orderId, lineNum))
        End Sub
    
            
#End Region
    
#If Not SILVERLIGHT Then
#Region "Synchronous Child Factory Methods"
    
        Friend Shared Function NewLineItemChild() As LineItem
            Return DataPortal.CreateChild(Of LineItem)()
        End Function
    
        Friend Shared Function GetByOrderIdLineNumChild(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItem
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
            criteria.LineNum = lineNum
    
            Return DataPortal.FetchChild(Of LineItem)(criteria)
        End Function
    
        Friend Shared Function GetByOrderIdChild(ByVal orderId As System.Int32) As LineItem
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.FetchChild(Of LineItem)(criteria)
        End Function
    
#End Region
#End If        
    
#Region "Asynchronous Child Factory Methods"
    
        Friend Shared Sub NewLineItemChildAsync(ByVal handler As EventHandler(Of DataPortalResult(Of LineItem)))
            Dim dp As New DataPortal(Of LineItem)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub

        Friend Shared Sub GetByOrderIdLineNumChildAsync(ByVal orderId As System.Int32, ByVal lineNum As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of LineItem)))
            Dim dp As New DataPortal(Of LineItem)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId
            criteria.LineNum = lineNum

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

        Friend Shared Sub GetByOrderIdChildAsync(ByVal orderId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of LineItem)))
            Dim dp As New DataPortal(Of LineItem)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New LineItemCriteria()
            criteria.OrderId = orderId

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

#End Region

#Region "DataPortal partial methods"
    
#If Not SILVERLIGHT Then
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As LineItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnInserted()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnSelfDeleted()
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As LineItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
#End If
        Private Partial Sub OnChildLoading(ByVal childProperty As Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
    
#Region "ChildPortal partial methods"

#If Not SILVERLIGHT Then
        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildCreated()
        End Sub
        Partial Private Sub OnChildFetching(ByVal criteria As LineItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildFetched()
        End Sub
        Partial Private Sub OnChildInserting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildInserted()
        End Sub
        Partial Private Sub OnChildUpdating(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildUpdated()
        End Sub
        Partial Private Sub OnChildSelfDeleting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildSelfDeleted()
        End Sub
#End If 
    
#End Region
#Region "Exists Command"
#If Not SILVERLIGHT Then

        Public Shared Function Exists(ByVal criteria As LineItemCriteria) As Boolean
            Return PetShop.Business.ExistsCommand.Execute(criteria)
        End Function

#Else

        Public Shared Sub Exists(ByVal criteria As LineItemCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Business.ExistsCommand.Execute(criteria, handler)
        End Sub

#End If

#End Region

#Region "Protected Overriden Method(s)"
        
        ' NOTE: This is needed for Composite Keys. 
        Private ReadOnly _guidID As Guid = Guid.NewGuid()
        Protected Overrides Function GetIdValue() As Object
            Return _guidID
        End Function
        
#End Region
    End Class
End Namespace