﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Profile.vb.
'
'     Template: Criteria.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Imports System.Data.SqlClient

Imports Csla

Namespace PetShop.Tests.OF.ParameterizedSQL
    <Serializable(), ClassInterface(ClassInterfaceType.None)> _
    Public Partial Class ProfileCriteria
        Inherits CriteriaBase(Of ProfileCriteria)
        Implements IGeneratedCriteria
    
#Region "Private Read-Only Properties"
        
        Private ReadOnly _bag As New Dictionary(Of String, Object)()
        
#End Region
    
#Region "Constructors"
    
        Public Sub New()
        
        End Sub

        Public Sub New(ByVal uniqueID As System.Int32) 
            
            
            Me.UniqueID = uniqueID
        End Sub

#End Region

#Region "Public Properties"

#Region "Read-Write"
        
        Public Property UniqueID() As System.Int32
            Get
                Return GetValue(Of System.Int32)("UniqueID")
            End Get
            Set
                _bag("UniqueID") = value
            End Set
        End Property
        
        Public Property Username() As System.String
            Get
                Return GetValue(Of System.String)("Username")
            End Get
            Set
                _bag("Username") = value
            End Set
        End Property
        
        Public Property ApplicationName() As System.String
            Get
                Return GetValue(Of System.String)("ApplicationName")
            End Get
            Set
                _bag("ApplicationName") = value
            End Set
        End Property
        
        Public Property IsAnonymous() As System.Boolean?
            Get
                Return GetValue(Of System.Boolean?)("IsAnonymous")
            End Get
            Set
                _bag("IsAnonymous") = value
            End Set
        End Property
        
        Public Property LastActivityDate() As System.DateTime?
            Get
                Return GetValue(Of System.DateTime?)("LastActivityDate")
            End Get
            Set
                _bag("LastActivityDate") = value
            End Set
        End Property
        
        Public Property LastUpdatedDate() As System.DateTime?
            Get
                Return GetValue(Of System.DateTime?)("LastUpdatedDate")
            End Get
            Set
                _bag("LastUpdatedDate") = value
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
                Return "Profiles"
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