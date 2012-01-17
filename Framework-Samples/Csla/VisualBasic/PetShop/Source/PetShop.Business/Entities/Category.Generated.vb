﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Category.vb.
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
    Public Partial Class Category 
        Inherits BusinessBase(Of Category)
    
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
    
        Friend Sub New(ByVal categoryId As System.String)
            Using(BypassPropertyChecks)
            LoadProperty(_categoryIdProperty, categoryId)
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
    
            BusinessRules.AddRule(New Csla.Rules.CommonRules.Required(_categoryIdProperty))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_categoryIdProperty, 10))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_nameProperty, 80))
            BusinessRules.AddRule(New Csla.Rules.CommonRules.MaxLength(_descriptionProperty, 255))
        End Sub
    
#End Region
#Region "Properties"
    
        Private Shared ReadOnly _categoryIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.CategoryId, String.Empty)
#If Not SILVERLIGHT Then
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property CategoryId() As System.String
#Else
        Public Property CategoryId() As System.String
#End If
            Get 
                Return GetProperty(_categoryIdProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_categoryIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _originalCategoryIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.OriginalCategoryId, String.Empty)
        ''' <summary>
        ''' Holds the original value for CategoryId. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalCategoryId() As System.String
            Get 
                Return GetProperty(_originalCategoryIdProperty) 
            End Get
            Set (value As System.String)
                SetProperty(_originalCategoryIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.Name, String.Empty, vbNullString)
        
        Public Property Name() As System.String
            Get 
                Return GetProperty(_nameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_nameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _descriptionProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Category) p.Description, String.Empty, vbNullString)
        
        Public Property Description() As System.String
            Get 
                Return GetProperty(_descriptionProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_descriptionProperty, value)
            End Set
        End Property

    
    
    
        'AssociatedOneToMany
        Private Shared ReadOnly _productsProperty As PropertyInfo(Of ProductList) = RegisterProperty(Of ProductList)(Function(p As Category) p.Products, Csla.RelationshipTypes.Child)
    Public ReadOnly Property Products() As ProductList
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_productsProperty, cancel)
                
                If Not cancel Then
                    If Not (FieldManager.FieldExists(_productsProperty)) Then
#If SILVERLIGHT Then
                        'Markbusy()
                        Dim criteria As New PetShop.Business.ProductCriteria()
                        criteria.CategoryId = CategoryId

                        If ((True)) Then
                            PetShop.Business.ProductList.Exists(criteria, Sub(o, e)
                                If Not (e.Error Is Nothing) Then
                                    Throw e.Error
                                End If

                                If Not (e.Object.Result) Then
                                    PetShop.Business.ProductList.NewListAsync(Sub(o1, e1)
                                        If Not (e1.Error Is Nothing) Then
                                            Throw e1.Error
                                        End If

                                        Me.LoadProperty(_productsProperty, e1.Object)

                                        'MarkIdle()
                                        OnPropertyChanged(_productsProperty)
                                    End Sub)
                                Else
                                    PetShop.Business.ProductList.GetByCategoryIdAsync(CategoryId, Sub(o2, e2)
                                        If Not (e2.Error Is Nothing) Then
                                            Throw e2.Error
                                        End If

                                        Me.LoadProperty(_productsProperty, e2.Object)

                                        'MarkIdle()
                                        OnPropertyChanged(_productsProperty)
                                    End Sub)
                                End If
                            End Sub)
                        End If
#Else
                        Dim criteria As New PetShop.Business.ProductCriteria()
                        criteria.CategoryId = CategoryId
    
                        If (Not PetShop.Business.ProductList.Exists(criteria)) Then
                            LoadProperty(_productsProperty, PetShop.Business.ProductList.NewList())
                        Else
                            LoadProperty(_productsProperty, PetShop.Business.ProductList.GetByCategoryId(CategoryId))
                        End If
#End If
                    End If
                End If

                Return GetProperty(_productsProperty) 
            End Get
        End Property

#End Region
    
#If Not SILVERLIGHT Then
#Region "Synchronous Root Factory Methods"
    
        Public Shared Function NewCategory() As Category 
            Return DataPortal.Create(Of Category)()
        End Function
    
        Public Shared Function GetByCategoryId(ByVal categoryId As System.String) As Category
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId
    
            Return DataPortal.Fetch(Of Category)(criteria)
        End Function
    
        Public Shared Sub DeleteCategory(ByVal categoryId As System.String)
            DataPortal.Delete(Of Category)(New CategoryCriteria (categoryId))
        End Sub
    
#End Region
#End If        
    
#Region "Asynchronous Root Factory Methods"
            
        Public Shared Sub NewCategoryAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Category)))
            Dim dp As New DataPortal(Of Category)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Public Shared Sub GetByCategoryIdAsync(ByVal categoryId As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of Category)))
            Dim dp As New DataPortal(Of Category)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub DeleteCategoryAsync(ByVal categoryId As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of Category)))
            Dim dp As New DataPortal(Of Category)()
            AddHandler dp.DeleteCompleted, handler
            dp.BeginDelete(New CategoryCriteria (categoryId))
        End Sub
    
            
#End Region
    
#If Not SILVERLIGHT Then
#Region "Synchronous Child Factory Methods"
    
        Friend Shared Function NewCategoryChild() As Category
            Return DataPortal.CreateChild(Of Category)()
        End Function
    
        Friend Shared Function GetByCategoryIdChild(ByVal categoryId As System.String) As Category
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId
    
            Return DataPortal.FetchChild(Of Category)(criteria)
        End Function
    
#End Region
#End If        
    
#Region "Asynchronous Child Factory Methods"
    
        Friend Shared Sub NewCategoryChildAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Category)))
            Dim dp As New DataPortal(Of Category)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub

        Friend Shared Sub GetByCategoryIdChildAsync(ByVal categoryId As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of Category)))
            Dim dp As New DataPortal(Of Category)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId

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
        Partial Private Sub OnFetching(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
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
        Partial Private Sub OnDeleting(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
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
        Partial Private Sub OnChildFetching(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
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

        Public Shared Function Exists(ByVal criteria As CategoryCriteria) As Boolean
            Return PetShop.Business.ExistsCommand.Execute(criteria)
        End Function

#Else

        Public Shared Sub Exists(ByVal criteria As CategoryCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Business.ExistsCommand.Execute(criteria, handler)
        End Sub

#End If

#End Region
    End Class
End Namespace