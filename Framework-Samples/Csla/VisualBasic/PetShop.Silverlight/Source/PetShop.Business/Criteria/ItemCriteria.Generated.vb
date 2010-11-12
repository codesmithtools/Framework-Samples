﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Item.vb.
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

#If Not SILVERLIGHT Then
Imports System.Data.SqlClient
#End If

Imports Csla
Imports Csla.Core
#If SILVERLIGHT Then
Imports Csla.Serialization
#End If
Imports Csla.Serialization.Mobile

#End Region

Namespace PetShop.Business
    <Serializable(), ClassInterface(ClassInterfaceType.None)> _
    Public Partial Class ItemCriteria
        Inherits CriteriaBase(Of ItemCriteria)
        Implements IGeneratedCriteria
    
#Region "Private Read-Only Members"
        
        Private ReadOnly _bag As New Dictionary(Of String, Object)()
        
#End Region
    
#Region "Constructors"
    
        Public Sub New()
        
        End Sub
        
        Public Sub New(ByVal itemId As System.String) 
            
            
            Me.ItemId = itemId
        End Sub
    
#End Region
    
#Region "Public Properties"
        
#Region "Read-Write"
    
        
        Public Property ItemId() As System.String
            Get
                Return GetValue(Of System.String)("ItemId")
            End Get
            Set
                _bag("ItemId") = value
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
        
        Public Property ListPrice() As System.Nullable(Of System.Decimal)
            Get
                Return GetValue(Of System.Nullable(Of System.Decimal))("ListPrice")
            End Get
            Set
                _bag("ListPrice") = value
            End Set
        End Property
        
        Public Property UnitCost() As System.Nullable(Of System.Decimal)
            Get
                Return GetValue(Of System.Nullable(Of System.Decimal))("UnitCost")
            End Get
            Set
                _bag("UnitCost") = value
            End Set
        End Property
        
        Public Property Supplier() As System.Nullable(Of System.Int32)
            Get
                Return GetValue(Of System.Nullable(Of System.Int32))("Supplier")
            End Get
            Set
                _bag("Supplier") = value
            End Set
        End Property
        
        Public Property Status() As System.String
            Get
                Return GetValue(Of System.String)("Status")
            End Get
            Set
                _bag("Status") = value
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
        
        Public Property Image() As System.String
            Get
                Return GetValue(Of System.String)("Image")
            End Get
            Set
                _bag("Image") = value
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
                Return "[dbo].Item"
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

#Region "Serialization"

        Protected Overrides Sub OnGetState(ByVal info As SerializationInfo, ByVal mode As StateMode)
            MyBase.OnGetState(info, mode)
            
            If _bag.ContainsKey("ItemId") Then
                info.AddValue("ItemId", GetValue(Of System.String)("ItemId"))
            End If
            If _bag.ContainsKey("ProductId") Then
                info.AddValue("ProductId", GetValue(Of System.String)("ProductId"))
            End If
            If _bag.ContainsKey("ListPrice") Then
                info.AddValue("ListPrice", GetValue(Of System.Nullable(Of System.Decimal))("ListPrice"))
            End If
            If _bag.ContainsKey("UnitCost") Then
                info.AddValue("UnitCost", GetValue(Of System.Nullable(Of System.Decimal))("UnitCost"))
            End If
            If _bag.ContainsKey("Supplier") Then
                info.AddValue("Supplier", GetValue(Of System.Nullable(Of System.Int32))("Supplier"))
            End If
            If _bag.ContainsKey("Status") Then
                info.AddValue("Status", GetValue(Of System.String)("Status"))
            End If
            If _bag.ContainsKey("Name") Then
                info.AddValue("Name", GetValue(Of System.String)("Name"))
            End If
            If _bag.ContainsKey("Image") Then
                info.AddValue("Image", GetValue(Of System.String)("Image"))
            End If
        End Sub
        
        Protected Overrides Sub OnSetState(ByVal info As SerializationInfo, ByVal mode As StateMode)
            MyBase.OnSetState(info, mode)
            
            If info.Values.ContainsKey("ItemId") Then
                _bag("ItemId") = info.GetValue(Of System.String)("ItemId")
            End If
            If info.Values.ContainsKey("ProductId") Then
                _bag("ProductId") = info.GetValue(Of System.String)("ProductId")
            End If
            If info.Values.ContainsKey("ListPrice") Then
                _bag("ListPrice") = info.GetValue(Of System.Nullable(Of System.Decimal))("ListPrice")
            End If
            If info.Values.ContainsKey("UnitCost") Then
                _bag("UnitCost") = info.GetValue(Of System.Nullable(Of System.Decimal))("UnitCost")
            End If
            If info.Values.ContainsKey("Supplier") Then
                _bag("Supplier") = info.GetValue(Of System.Nullable(Of System.Int32))("Supplier")
            End If
            If info.Values.ContainsKey("Status") Then
                _bag("Status") = info.GetValue(Of System.String)("Status")
            End If
            If info.Values.ContainsKey("Name") Then
                _bag("Name") = info.GetValue(Of System.String)("Name")
            End If
            If info.Values.ContainsKey("Image") Then
                _bag("Image") = info.GetValue(Of System.String)("Image")
            End If
        End Sub

#End Region

    End Class
End Namespace