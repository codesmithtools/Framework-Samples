﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Cart.vb.
'
'     Template: Criteria.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

#Region "Using declarations"

Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Imports System.Data.SqlClient

Imports Csla

#End Region

Namespace PetShop.Business
    <Serializable(), ClassInterface(ClassInterfaceType.None)> _
    Public Partial Class CartCriteria
        Inherits CriteriaBase
        Implements IGeneratedCriteria
    
#Region "Private Read-Only Members"
        
        Private ReadOnly _bag As New Dictionary(Of String, Object)()
        
#End Region
    
#Region "Constructors"
    
        Public Sub New()
        MyBase.New(GetType(PetShop.Business.Cart))
        End Sub
        
        Public Sub New(ByVal cartId As System.Int32) 
            MyBase.New(GetType(PetShop.Business.Cart))
            
            Me.CartId = cartId
        End Sub
    
#End Region
    
#Region "Public Properties"
        
#Region "Read-Write"
    
        
        Public Property CartId() As System.Int32
            Get
                Return GetValue(Of System.Int32)("CartId")
            End Get
            Set
                _bag("CartId") = value
            End Set
        End Property
        
        Public Property UniqueID() As System.Int32
            Get
                Return GetValue(Of System.Int32)("UniqueID")
            End Get
            Set
                _bag("UniqueID") = value
            End Set
        End Property
        
        Public Property ItemId() As System.String
            Get
                Return GetValue(Of System.String)("ItemId")
            End Get
            Set
                _bag("ItemId") = value
            End Set
        End Property
        
        Public Property Name() As System.String
            Get
                Return GetValue(Of System.String)("Name")
            End Get
            Set
                _bag("Name") = value
            End Set
        End Property
        
        Public Property Type() As System.String
            Get
                Return GetValue(Of System.String)("Type")
            End Get
            Set
                _bag("Type") = value
            End Set
        End Property
        
        Public Property Price() As System.Decimal
            Get
                Return GetValue(Of System.Decimal)("Price")
            End Get
            Set
                _bag("Price") = value
            End Set
        End Property
        
        Public Property CategoryId() As System.String
            Get
                Return GetValue(Of System.String)("CategoryId")
            End Get
            Set
                _bag("CategoryId") = value
            End Set
        End Property
        
        Public Property ProductId() As System.String
            Get
                Return GetValue(Of System.String)("ProductId")
            End Get
            Set
                _bag("ProductId") = value
            End Set
        End Property
        
        Public Property IsShoppingCart() As System.Boolean
            Get
                Return GetValue(Of System.Boolean)("IsShoppingCart")
            End Get
            Set
                _bag("IsShoppingCart") = value
            End Set
        End Property
        
        Public Property Quantity() As System.Int32
            Get
                Return GetValue(Of System.Int32)("Quantity")
            End Get
            Set
                _bag("Quantity") = value
            End Set
        End Property
    
#End Region
        
#Region "Read-Only"
    
        ''' <summary>
        ''' Returns a list of all the modified properties and values.
        ''' </summary>
        Public ReadOnly Property StateBag() As Dictionary(Of String, Object) Implements IGeneratedCriteria.StateBag
            Get
                Return _bag
            End Get
        End Property
    
        ''' <summary>
        ''' Returns a list of all the modified properties and values.
        ''' </summary>
        Public ReadOnly Property TableFullName() As String Implements IGeneratedCriteria.TableFullName
            Get
                Return "[dbo].Cart"
            End Get
        End Property
    
#End Region
    
#End Region
    
#Region "Overrides"
    
        Public Overrides Function ToString() As String
            Dim result As String = String.Empty
            Dim cancel As Boolean = False
            
            OnToString(result, cancel)
            If(cancel AndAlso Not String.IsNullOrEmpty(result)) Then
                Return result
            End If
        
            If _bag.Count = 0 Then
                Return "No criterion was specified."
            End If
    
            For Each key As KeyValuePair(Of String, Object) In _bag
                result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value)
            Next
    
            Return result.Remove(result.Length - 5, 5)
        End Function
    
#End Region
    
#Region "Private Methods"
        
        Private Function GetValue(Of T)(name As String) As T
            Dim value As New Object
            If _bag.TryGetValue(name, value) Then
                Return DirectCast(value, T)
            End If
        
            Return Nothing
        End Function
        
#End Region
        
#Region "Partial Methods"

        Partial Private Sub OnToString(ByRef result As String, ByRef cancel As Boolean)
        End Sub

#End Region

    End Class
End Namespace