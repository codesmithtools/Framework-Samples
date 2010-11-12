﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'     Changes to Me file will be lost after each regeneration.
'
'     Template: ExistsCommand.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.Collections.ReadOnlyRoot
    <Serializable()> _
    Public Class ExistsCommand
        Inherits CommandBase

#Region "Constructor(s)"

        Private Sub New()
        End Sub

#End Region

#Region "Authorization Methods"

        Public Shared Function CanExecuteCommand() As Boolean
            Return True
        End Function

#End Region

#Region "Synchronous Factory Methods"

        Public Shared Function Execute(Of T As IGeneratedCriteria)(ByVal criteria As T) As Boolean
            If Not CanExecuteCommand() Then
                Throw New System.Security.SecurityException("Not authorized to execute command")
            End If

            Dim cmd As New ExistsCommand()
            cmd.BeforeServer(criteria)
            cmd = DataPortal.Execute(cmd)
            cmd.AfterServer()

            Return cmd.Result
        End Function

#End Region

#Region "Client-side Code"

        Private _criteria As IGeneratedCriteria
        Private Property Criteria() As IGeneratedCriteria
            Get
                Return _criteria
            End Get
            Set(ByVal value As IGeneratedCriteria)
                _criteria = value
            End Set
        End Property

        Private _result As Boolean
        Private Property Result() As Boolean
            Get
                Return _result
            End Get
            Set(ByVal value As Boolean)
                _result = value
            End Set
        End Property

        Private Sub BeforeServer(ByVal criteria As IGeneratedCriteria)
            Me.Criteria = criteria
            Me.Result = False
        End Sub

        Private Sub AfterServer()
        End Sub

#End Region

#Region "Data Access"

        Protected Overloads Overrides Sub DataPortal_Execute()
            Dim commandText As String = String.Format("SELECT COUNT(1) FROM {0} {1}", Criteria.TableFullName, ADOHelper.BuildWhereStatement(Criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(Criteria.StateBag))
                    Result = (CInt(command.ExecuteScalar()) > 0)
                End Using
            End Using
        End Sub

#End Region
    End Class
End Namespace