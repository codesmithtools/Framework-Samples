﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Category.vb.
'
'     Template: ReadOnlyChildList.Generated.cst
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

Namespace PetShop.Tests.Collections.ReadOnlyChild
    <Serializable()> _
    Public Partial Class CategoryInfoList 
        Inherits ReadOnlyListBase(Of CategoryInfoList, CategoryInfo)
    
#Region "Contructor(s)"

        public Sub New()
            ' require use of factory method 
        End Sub

#End Region
#Region "Synchronous Factory Methods"
    
        ''' <summary>
        ''' Returns a <see cref="CategoryInfoList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="categoryId">No additional detail available.</param>
        ''' <returns>A <see cref=
        Friend Shared Function GetByCategoryId(ByVal categoryId As System.String) As CategoryInfoList
            Dim criteria As New CategoryCriteria()
                        criteria.CategoryId = categoryId
    
            Return DataPortal.FetchChild(Of CategoryInfoList)(criteria)
        End Function
    
        Friend Shared Function GetByCriteria(ByVal criteria As CategoryCriteria) As CategoryInfoList
            Return DataPortal.Fetch(Of CategoryInfoList)(criteria)
        End Function

        Friend Shared Function GetAll() As CategoryInfoList
            Return DataPortal.FetchChild(Of CategoryInfoList)(New CategoryCriteria())
        End Function
    
#End Region

    
#Region "Asynchronous Factory Methods"
    
        Friend Shared Sub GetByCategoryIdAsync(ByVal categoryId As System.String, ByVal handler As EventHandler(Of DataPortalResult(Of CategoryInfoList)))
            Dim dp As New DataPortal(Of CategoryInfoList)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

        Friend Shared Sub GetByCriteriaAsync(ByVal criteria As CategoryCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of CategoryInfoList)))
            Dim dp As New DataPortal(Of CategoryInfoList)()
            AddHandler dp.FetchCompleted, handler

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

        Friend Shared Sub GetAllAsync(ByVal handler As EventHandler(Of DataPortalResult(Of CategoryInfoList)))
            Dim dp As New DataPortal(Of CategoryInfoList)()
            AddHandler dp.FetchCompleted, handler

            ' Mark as child?
            dp.BeginFetch(New CategoryCriteria())
        End Sub  
#End Region

#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' CodeSmith generated stub method that is called when creating the child <see cref="CategoryInfo"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="CategoryInfo"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when fetching the child <see cref="CategoryInfo"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CategoryInfoCriteria"/> object containing the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="CategoryInfo"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="CategoryInfo"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="CategoryInfo"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="CategoryInfo"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the <see cref="CategoryInfo"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="CategoryInfo"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByRef item As CategoryInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"

        ''' <summary>
        ''' Determines if a record exists in the CategoryInfo in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is a <see cref="CategoryInfoList"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As CategoryCriteria) As Boolean
            Return PetShop.Tests.Collections.ReadOnlyChild.CategoryInfo.Exists(criteria)
        End Function

        ''' <summary>
        ''' Determines if a record exists in the CategoryInfo in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As CategoryCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Tests.Collections.ReadOnlyChild.CategoryInfo.ExistsAsync(criteria, handler)
        End Sub

#End Region
 
#region "Enhancements"

        Public Function GetCategoryInfo(ByVal categoryId As System.String) As CategoryInfo
            Return Me.FirstOrDefault(Function(i As CategoryInfo) i.CategoryId = categoryId)
        End Function
        
        Public Overloads Function Contains(ByVal categoryId As System.String) As Boolean
            Return Me.Where(Function(i As CategoryInfo) i.CategoryId = categoryId).Count() > 0
        End Function
        
#End Region
    End Class
End Namespace