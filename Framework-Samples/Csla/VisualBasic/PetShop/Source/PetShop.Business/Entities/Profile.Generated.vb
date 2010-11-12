﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Profile.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Validation
Imports Csla.Data
Imports System.Data.SqlClient

Namespace PetShop.Business
    <Serializable()> _
    Public Partial Class Profile 
        Inherits BusinessBase(Of Profile)
    
#Region "Contructor(s)"
    
        Private Sub New()
            ' require use of factory method 
        End Sub
    
        Friend Sub New(ByVal uniqueID As System.Int32)
            Using(BypassPropertyChecks)
            LoadProperty(_uniqueIDProperty, uniqueID)
            End Using
        End Sub
    
        Friend Sub New(Byval reader As SafeDataReader)
            Map(reader)
            MarkAsChild()   
        End Sub

#End Region    
    
#Region "Business Rules"
    
        Protected Overrides Sub AddBusinessRules()
    
            If AddBusinessValidationRules() Then Exit Sub
    
            ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _usernameProperty)
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_usernameProperty, 256))
            ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _applicationNameProperty)
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_applicationNameProperty, 256))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _uniqueIDProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Profile) p.UniqueID, String.Empty)
        
		<System.ComponentModel.DataObjectField(true, true)> _
        Public Property UniqueID() As System.Int32
            Get 
                Return GetProperty(_uniqueIDProperty)
            End Get
            Friend Set (ByVal value As System.Int32)
                SetProperty(_uniqueIDProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _usernameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Profile) p.Username, String.Empty)
        
        Public Property Username() As System.String
            Get 
                Return GetProperty(_usernameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_usernameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _applicationNameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Profile) p.ApplicationName, String.Empty)
        
        Public Property ApplicationName() As System.String
            Get 
                Return GetProperty(_applicationNameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_applicationNameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _isAnonymousProperty As PropertyInfo(Of System.Nullable(Of System.Boolean)) = RegisterProperty(Of System.Nullable(Of System.Boolean))(Function(p As Profile) p.IsAnonymous, String.Empty)
        
        Public Property IsAnonymous() As System.Nullable(Of System.Boolean)
            Get 
                Return GetProperty(_isAnonymousProperty)
            End Get
            Set (ByVal value As System.Nullable(Of System.Boolean))
                SetProperty(_isAnonymousProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _lastActivityDateProperty As PropertyInfo(Of System.Nullable(Of System.DateTime)) = RegisterProperty(Of System.Nullable(Of System.DateTime))(Function(p As Profile) p.LastActivityDate, String.Empty)
        
        Public Property LastActivityDate() As System.Nullable(Of System.DateTime)
            Get 
                Return GetProperty(_lastActivityDateProperty)
            End Get
            Set (ByVal value As System.Nullable(Of System.DateTime))
                SetProperty(_lastActivityDateProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _lastUpdatedDateProperty As PropertyInfo(Of System.Nullable(Of System.DateTime)) = RegisterProperty(Of System.Nullable(Of System.DateTime))(Function(p As Profile) p.LastUpdatedDate, String.Empty)
        
        Public Property LastUpdatedDate() As System.Nullable(Of System.DateTime)
            Get 
                Return GetProperty(_lastUpdatedDateProperty)
            End Get
            Set (ByVal value As System.Nullable(Of System.DateTime))
                SetProperty(_lastUpdatedDateProperty, value)
            End Set
        End Property

        'AssociatedOneToMany
        Private Shared ReadOnly _accountsProperty As PropertyInfo(Of AccountList) = RegisterProperty(Of AccountList)(Function(p As Profile) p.Accounts, Csla.RelationshipTypes.Child)
    Public ReadOnly Property Accounts() As AccountList
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_accountsProperty, cancel)
                
                If Not cancel Then
                    If Not (FieldManager.FieldExists(_accountsProperty)) Then
                        Dim criteria As New PetShop.Business.AccountCriteria()
                        criteria.UniqueID = UniqueID
    
                        If (Not PetShop.Business.AccountList.Exists(criteria)) Then
                            LoadProperty(_accountsProperty, PetShop.Business.AccountList.NewList())
                        Else
                            LoadProperty(_accountsProperty, PetShop.Business.AccountList.GetByUniqueID(UniqueID))
                        End If
                    End If
                End If

                Return GetProperty(_accountsProperty) 
            End Get
        End Property

        'AssociatedOneToMany
        Private Shared ReadOnly _cartsProperty As PropertyInfo(Of CartList) = RegisterProperty(Of CartList)(Function(p As Profile) p.Carts, Csla.RelationshipTypes.Child)
    Public ReadOnly Property Carts() As CartList
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_cartsProperty, cancel)
                
                If Not cancel Then
                    If Not (FieldManager.FieldExists(_cartsProperty)) Then
                        Dim criteria As New PetShop.Business.CartCriteria()
                        criteria.UniqueID = UniqueID
    
                        If (Not PetShop.Business.CartList.Exists(criteria)) Then
                            LoadProperty(_cartsProperty, PetShop.Business.CartList.NewList())
                        Else
                            LoadProperty(_cartsProperty, PetShop.Business.CartList.GetByUniqueID(UniqueID))
                        End If
                    End If
                End If

                Return GetProperty(_cartsProperty) 
            End Get
        End Property

#End Region
    
#Region "Synchronous Root Factory Methods"
    
        Public Shared Function NewProfile() As Profile 
            Return DataPortal.Create(Of Profile)()
        End Function
    
        Public Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As Profile
            Dim criteria As New ProfileCriteria()
            criteria.UniqueID = uniqueID
    
            Return DataPortal.Fetch(Of Profile)(criteria)
        End Function
    
        Public Shared Function GetByUsernameApplicationName(ByVal username As System.String, ByVal applicationName As System.String) As Profile
            Dim criteria As New ProfileCriteria()
            criteria.Username = username
			criteria.ApplicationName = applicationName
    
            Return DataPortal.Fetch(Of Profile)(criteria)
        End Function
    
        Public Shared Sub DeleteProfile(ByVal uniqueID As System.Int32)
            DataPortal.Delete(New ProfileCriteria (uniqueID))
        End Sub
    
#End Region
#Region "Synchronous Child Factory Methods"
    
        Friend Shared Function NewProfileChild() As Profile
            Return DataPortal.CreateChild(Of Profile)()
        End Function
    
        Friend Shared Function GetByUniqueIDChild(ByVal uniqueID As System.Int32) As Profile
            Dim criteria As New ProfileCriteria()
            criteria.UniqueID = uniqueID
    
            Return DataPortal.FetchChild(Of Profile)(criteria)
        End Function
    
        Friend Shared Function GetByUsernameApplicationNameChild(ByVal username As System.String, ByVal applicationName As System.String) As Profile
            Dim criteria As New ProfileCriteria()
            criteria.Username = username
            criteria.ApplicationName = applicationName
    
            Return DataPortal.FetchChild(Of Profile)(criteria)
        End Function
    
#End Region
#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As ProfileCriteria, ByRef cancel As Boolean)
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
        Partial Private Sub OnDeleting(ByVal criteria As ProfileCriteria, ByRef cancel As Boolean)
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
        Partial Private Sub OnChildFetching(ByVal criteria As ProfileCriteria, ByRef cancel As Boolean)
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

        Public Shared Function Exists(ByVal criteria As ProfileCriteria) As Boolean
            Return PetShop.Business.ExistsCommand.Execute(criteria)
        End Function


#End Region
    End Class
End Namespace