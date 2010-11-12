﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
'     Changes to this template will not be lost.
'
'     Template: ADOHelper.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

#Region "Imports declarations"

Imports System
Imports System.Data
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq

Imports Csla
Imports Csla.Data

#End Region

Namespace PetShop.Business
    Public Class ADOHelper
        Private Sub New()
        End Sub
    
#Region "Preserved Code"
    
        Private Shared _connectionString As String = String.Empty
    
        ''' <summary>
        ''' Returns the Connection String.
        ''' </summary>
        Public Shared ReadOnly Property ConnectionString() As String
            Get
                If String.IsNullOrEmpty(_connectionString) Then
                    _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings("PetShopConnectionString").ConnectionString
                End If
    
                Return _connectionString
            End Get
        End Property
    
#End Region
    
#Region "Methods"
        
        ''' <summary>
        ''' Returns an array of SqlParameters
        ''' </summary>
        Public Shared Function SqlParameters(ByVal bag As Dictionary(Of String, Object)) As SqlParameter()
            Return New List(Of SqlParameter)(bag.[Select](Function(pair) New SqlParameter(String.Format("@p_{0}", pair.Key), pair.Value))).ToArray()
        End Function
    
        ''' <summary>
        ''' Returns a where clause for the current Criteria object.
        ''' </summary>
        ''' <returns>Returns a where clause for the current Criteria object.</returns>
        Public Shared Function BuildWhereStatement(ByVal bag As Dictionary(Of String, Object)) As String
            If bag.Count = 0 Then
                Return String.Empty
            End If
    
            Dim columnNames As String = bag.Keys.Aggregate(String.Empty, Function(current, columnName) current + String.Format("[{0}] = @p_{0} AND ", columnName))
            Return String.Format("WHERE {0}", columnNames.Remove(columnNames.Length - 5, 5))
        End Function
    
        ''' <summary>
        ''' Returns the Bytes stored in a binary column.
        ''' </summary>
        ''' <param name="reader">The reader.</param>
        ''' <param name="columnName">The column name.</param>
        ''' <returns>Bytes Stored in a column.</returns>
        Public Shared Function GetBytes(ByVal reader As SafeDataReader, ByVal columnName As String) As Byte()
            Dim buffer As Byte() = New Byte(1024) {}
            Dim fieldOffset As Long = 0
    
            Using stream As MemoryStream = New MemoryStream()
                Dim bytesRead As Integer = 0
    
                bytesRead = CInt(reader.GetBytes(columnName, fieldOffset, buffer, 0, buffer.Length))
                While bytesRead > 0
                    Dim actualRead As Byte() = New Byte(bytesRead) {}
                    Array.Copy(buffer, 0, actualRead, 0, bytesRead)
                    stream.Write(actualRead, 0, actualRead.Length)
                    fieldOffset += bytesRead
    
                    bytesRead = CInt(reader.GetBytes(columnName, fieldOffset, buffer, 0, buffer.Length))
                End While
    
                Return stream.ToArray()
            End Using
        End Function  
        
#End Region
    
#Region "Nullable Helpers" 'This code is here to help in the Data access implementation of handling DBNull.Value.
    
        ''' <summary>
        ''' Simple empty string to DBNull.Value function.
        ''' </summary>
        ''' <param name="value"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Overloads Shared Function NullCheck(ByVal value As String) As Object
            If value Is Nothing OrElse value.Trim = vbNullString Then
                Return DBNull.Value
            Else
                Return value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Char)) As Object
            If value Is Nothing OrElse CStr(value) = vbNullString Then
                Return DBNull.Value
            Else
                Return value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Byte)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of SByte)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Single)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Short)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of UShort)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Integer)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of UInteger)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Long)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of ULong)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Decimal)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Double)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Boolean)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of DateTime)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of DateTimeOffset)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As Nullable(Of Guid)) As Object
            If value Is Nothing OrElse Not value.HasValue Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
        Friend Overloads Shared Function NullCheck(ByVal value As System.Xml.XmlDocument) As Object
            If value Is Nothing Then
                Return DBNull.Value
            Else
                Return value.Value
            End If
        End Function
    
#End Region
        
    End Class
End Namespace