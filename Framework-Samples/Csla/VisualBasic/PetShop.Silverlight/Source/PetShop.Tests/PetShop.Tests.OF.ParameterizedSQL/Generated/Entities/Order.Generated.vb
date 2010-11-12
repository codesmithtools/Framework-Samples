﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Order.vb.
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
Imports Csla.Data
Imports System.Data.SqlClient

Namespace PetShop.Tests.OF.ParameterizedSQL
    <Serializable()> _
    <Csla.Server.ObjectFactory(FactoryNames.OrderFactoryName)> _
    Public Partial Class Order 
        Inherits BusinessBase(Of Order)
    
#Region "Contructor(s)"
    
        Private Sub New()
            ' require use of factory method 
        End Sub
    
        Friend Sub New(ByVal orderId As System.Int32)
            Using(BypassPropertyChecks)
            LoadProperty(_orderIdProperty, orderId)
            End Using
        End Sub
    

#End Region    
    
#Region "Business Rules"
    
        Protected Overrides Sub AddBusinessRules()
    
            If AddBusinessValidationRules() Then Exit Sub
    
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_userIdProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_userIdProperty, 20))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_shipAddr1Property))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_shipAddr1Property, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_shipAddr2Property, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_shipCityProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_shipCityProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_shipStateProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_shipStateProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_shipZipProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_shipZipProperty, 20))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_shipCountryProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_shipCountryProperty, 20))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_billAddr1Property))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_billAddr1Property, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_billAddr2Property, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_billCityProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_billCityProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_billStateProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_billStateProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_billZipProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_billZipProperty, 20))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_billCountryProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_billCountryProperty, 20))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_courierProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_courierProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_billToFirstNameProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_billToFirstNameProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_billToLastNameProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_billToLastNameProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_shipToFirstNameProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_shipToFirstNameProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_shipToLastNameProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_shipToLastNameProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_localeProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_localeProperty, 20))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Order) p.OrderId, String.Empty)
        
		<System.ComponentModel.DataObjectField(true, true)> _
        Public Property OrderId() As System.Int32
            Get 
                Return GetProperty(_orderIdProperty)
            End Get
            Friend Set (ByVal value As System.Int32)
                SetProperty(_orderIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _userIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.UserId, String.Empty)
        
        Public Property UserId() As System.String
            Get 
                Return GetProperty(_userIdProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_userIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _orderDateProperty As PropertyInfo(Of System.DateTime) = RegisterProperty(Of System.DateTime)(Function(p As Order) p.OrderDate, String.Empty)
        
        Public Property OrderDate() As System.DateTime
            Get 
                Return GetProperty(_orderDateProperty)
            End Get
            Set (ByVal value As System.DateTime)
                SetProperty(_orderDateProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipAddr1Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipAddr1, String.Empty)
        
        Public Property ShipAddr1() As System.String
            Get 
                Return GetProperty(_shipAddr1Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipAddr1Property, value)
            End Set
        End Property

        Private Shared ReadOnly _shipAddr2Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipAddr2, String.Empty, vbNullString)
        
        Public Property ShipAddr2() As System.String
            Get 
                Return GetProperty(_shipAddr2Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipAddr2Property, value)
            End Set
        End Property

        Private Shared ReadOnly _shipCityProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipCity, String.Empty)
        
        Public Property ShipCity() As System.String
            Get 
                Return GetProperty(_shipCityProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipCityProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipStateProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipState, String.Empty)
        
        Public Property ShipState() As System.String
            Get 
                Return GetProperty(_shipStateProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipStateProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipZipProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipZip, String.Empty)
        
        Public Property ShipZip() As System.String
            Get 
                Return GetProperty(_shipZipProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipZipProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipCountryProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipCountry, String.Empty)
        
        Public Property ShipCountry() As System.String
            Get 
                Return GetProperty(_shipCountryProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipCountryProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billAddr1Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillAddr1, String.Empty)
        
        Public Property BillAddr1() As System.String
            Get 
                Return GetProperty(_billAddr1Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billAddr1Property, value)
            End Set
        End Property

        Private Shared ReadOnly _billAddr2Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillAddr2, String.Empty, vbNullString)
        
        Public Property BillAddr2() As System.String
            Get 
                Return GetProperty(_billAddr2Property)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billAddr2Property, value)
            End Set
        End Property

        Private Shared ReadOnly _billCityProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillCity, String.Empty)
        
        Public Property BillCity() As System.String
            Get 
                Return GetProperty(_billCityProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billCityProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billStateProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillState, String.Empty)
        
        Public Property BillState() As System.String
            Get 
                Return GetProperty(_billStateProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billStateProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billZipProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillZip, String.Empty)
        
        Public Property BillZip() As System.String
            Get 
                Return GetProperty(_billZipProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billZipProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billCountryProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillCountry, String.Empty)
        
        Public Property BillCountry() As System.String
            Get 
                Return GetProperty(_billCountryProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billCountryProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _courierProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.Courier, String.Empty)
        
        Public Property Courier() As System.String
            Get 
                Return GetProperty(_courierProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_courierProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _totalPriceProperty As PropertyInfo(Of System.Decimal) = RegisterProperty(Of System.Decimal)(Function(p As Order) p.TotalPrice, String.Empty)
        
        Public Property TotalPrice() As System.Decimal
            Get 
                Return GetProperty(_totalPriceProperty)
            End Get
            Set (ByVal value As System.Decimal)
                SetProperty(_totalPriceProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billToFirstNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillToFirstName, String.Empty)
        
        Public Property BillToFirstName() As System.String
            Get 
                Return GetProperty(_billToFirstNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billToFirstNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _billToLastNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.BillToLastName, String.Empty)
        
        Public Property BillToLastName() As System.String
            Get 
                Return GetProperty(_billToLastNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_billToLastNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipToFirstNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipToFirstName, String.Empty)
        
        Public Property ShipToFirstName() As System.String
            Get 
                Return GetProperty(_shipToFirstNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipToFirstNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _shipToLastNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.ShipToLastName, String.Empty)
        
        Public Property ShipToLastName() As System.String
            Get 
                Return GetProperty(_shipToLastNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_shipToLastNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _authorizationNumberProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Order) p.AuthorizationNumber, String.Empty)
        
        Public Property AuthorizationNumber() As System.Int32
            Get 
                Return GetProperty(_authorizationNumberProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_authorizationNumberProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _localeProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Order) p.Locale, String.Empty)
        
        Public Property Locale() As System.String
            Get 
                Return GetProperty(_localeProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_localeProperty, value)
            End Set
        End Property

        'AssociatedOneToMany
        Private Shared ReadOnly _lineItemsProperty As PropertyInfo(Of LineItemList) = RegisterProperty(Of LineItemList)(Function(p As Order) p.LineItems, Csla.RelationshipTypes.Child)
    Public ReadOnly Property LineItems() As LineItemList
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_lineItemsProperty, cancel)
                
                If Not cancel Then
                    If Not (FieldManager.FieldExists(_lineItemsProperty)) Then
                        Dim criteria As New PetShop.Tests.OF.ParameterizedSQL.LineItemCriteria()
                        criteria.OrderId = OrderId
    
                        If (Not PetShop.Tests.OF.ParameterizedSQL.LineItemList.Exists(criteria)) Then
                            LoadProperty(_lineItemsProperty, PetShop.Tests.OF.ParameterizedSQL.LineItemList.NewList())
                        Else
                            LoadProperty(_lineItemsProperty, PetShop.Tests.OF.ParameterizedSQL.LineItemList.GetByOrderId(OrderId))
                        End If
                    End If
                End If

                Return GetProperty(_lineItemsProperty) 
            End Get
        End Property

        'AssociatedOneToMany
        Private Shared ReadOnly _orderStatusesProperty As PropertyInfo(Of OrderStatusList) = RegisterProperty(Of OrderStatusList)(Function(p As Order) p.OrderStatuses, Csla.RelationshipTypes.Child)
    Public ReadOnly Property OrderStatuses() As OrderStatusList
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_orderStatusesProperty, cancel)
                
                If Not cancel Then
                    If Not (FieldManager.FieldExists(_orderStatusesProperty)) Then
                        Dim criteria As New PetShop.Tests.OF.ParameterizedSQL.OrderStatusCriteria()
                        criteria.OrderId = OrderId
    
                        If (Not PetShop.Tests.OF.ParameterizedSQL.OrderStatusList.Exists(criteria)) Then
                            LoadProperty(_orderStatusesProperty, PetShop.Tests.OF.ParameterizedSQL.OrderStatusList.NewList())
                        Else
                            LoadProperty(_orderStatusesProperty, PetShop.Tests.OF.ParameterizedSQL.OrderStatusList.GetByOrderId(OrderId))
                        End If
                    End If
                End If

                Return GetProperty(_orderStatusesProperty) 
            End Get
        End Property

#End Region
    
#Region "Synchronous Root Factory Methods"
    
        Public Shared Function NewOrder() As Order 
            Return DataPortal.Create(Of Order)()
        End Function
    
        Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As Order
            Dim criteria As New OrderCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.Fetch(Of Order)(criteria)
        End Function
    
        Public Shared Sub DeleteOrder(ByVal orderId As System.Int32)
            DataPortal.Delete(Of Order)(New OrderCriteria (orderId))
        End Sub
    
#End Region
#Region "Synchronous Child Factory Methods"
    
        Friend Shared Function NewOrderChild() As Order
            Return DataPortal.CreateChild(Of Order)()
        End Function
    
        Friend Shared Function GetByOrderIdChild(ByVal orderId As System.Int32) As Order
            Dim criteria As New OrderCriteria()
            criteria.OrderId = orderId
    
            Return DataPortal.FetchChild(Of Order)(criteria)
        End Function
    
#End Region
#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
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
        Partial Private Sub OnDeleting(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
        Private Partial Sub OnChildLoading(ByVal childProperty As Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
    
#Region "ChildPortal partial methods"

        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildCreated()
        End Sub
        Partial Private Sub OnChildFetching(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
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
    
#End Region

#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As OrderCriteria) As Boolean
            Return PetShop.Tests.OF.ParameterizedSQL.ExistsCommand.Execute(criteria)
        End Function


#End Region
#Region "Overridden properties"
    
            ''' <summary>
            ''' Returns true if the business object or any of its children properties are dirty.
            ''' </summary>
            Public Overloads Overrides ReadOnly Property IsDirty() As Boolean
                Get
                    If MyBase.IsDirty Then
                        Return True
                    End If
    
                    If (FieldManager.FieldExists(_lineItemsProperty) AndAlso LineItems.IsDirty) Then
                        Return True
                    End If
                    If (FieldManager.FieldExists(_orderStatusesProperty) AndAlso OrderStatuses.IsDirty) Then
                        Return True
                    End If
                    Return False
                End Get
            End Property
    
#End Region
    
    End Class
End Namespace