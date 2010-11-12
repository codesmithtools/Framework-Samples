Imports System
Imports System.Collections.Generic
Imports System.Text

Imports NHibernate

Namespace Sample.Data.Generated.Base
	Public Interface INHibernateSession
		Inherits IDisposable
		' Methods
		Sub CommitChanges()
		Sub Close()
		Sub BeginTransaction()
		Sub CommitTransaction()
		Sub RollbackTransaction()
		Sub IncrementRefCount()
		Sub DecrementRefCount()
		Function GetISession() As ISession

		' Properties
		ReadOnly Property HasOpenTransaction() As Boolean
		ReadOnly Property IsOpen() As Boolean
		Property AutoCloseSession() As Boolean
	End Interface

	Public Class NHibernateSession
		Implements INHibernateSession
		#region "Declarations"

		Protected transaction As ITransaction = Nothing
		Protected iSession As ISession = Nothing

		Private _autoCloseSession As Boolean = True
		Private _isDisposed As Boolean = False
		Private _refCount As Integer = 0
#End Region

		#region "Constructor & Destructor"

		Public Sub New()
		End Sub
		Protected Overrides Sub Finalize()
			Try
				Dispose(True)
			Finally
				MyBase.Finalize()
			End Try
		End Sub
#End Region

		#region "IDisposable"

		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(False)
		End Sub
		Private Sub Dispose(finalizing As Boolean)
			If Not _isDisposed Then
				Close()

				If Not finalizing Then
					GC.SuppressFinalize(Me)
				End If

				_isDisposed = True
			End If
		End Sub
#End Region

		#region "Methods"

		Public Sub CommitChanges() Implements INHibernateSession.CommitChanges
			If HasOpenTransaction Then
				CommitTransaction()
			Else
				iSession.Flush()
			End If
		End Sub
		Public Sub Close() Implements INHibernateSession.Close
			If iSession Is Nothing Then
				Return
			End If

			If HasOpenTransaction Then
				RollbackTransaction()
			End If

			If iSession.IsOpen Then
				iSession.Close()
			End If
			iSession.Dispose()
			iSession = Nothing
		End Sub

		Public Sub BeginTransaction() Implements INHibernateSession.BeginTransaction
			transaction = GetISession().BeginTransaction()
		End Sub
		Public Sub CommitTransaction() Implements INHibernateSession.CommitTransaction
			If transaction Is Nothing Then
				Return
			End If

			Try
				transaction.Commit()
				transaction.Dispose()
				transaction = Nothing
			Catch generatedExceptionName As HibernateException
				RollbackTransaction()
				Throw
			End Try
		End Sub
		Public Sub RollbackTransaction() Implements INHibernateSession.RollbackTransaction
			If transaction Is Nothing Then
				Return
			End If

			transaction.Rollback()
			transaction.Dispose()
			transaction = Nothing
		End Sub

		Public Sub IncrementRefCount() Implements INHibernateSession.IncrementRefCount
			_refCount = _refCount + 1
		End Sub
		Public Sub DecrementRefCount() Implements INHibernateSession.DecrementRefCount
			_refCount = _refCount - 1
			If _refCount = 0 AndAlso _autoCloseSession Then
                Close()
			End If
		End Sub

		Public Function GetISession() As ISession Implements INHibernateSession.GetISession
			If iSession Is Nothing Then
				iSession = NHibernateSessionManager.Instance.CreateISession()
			End If
			Return iSession
		End Function
#End Region

		#region "Properties"

		Public ReadOnly Property HasOpenTransaction() As Boolean Implements INHibernateSession.HasOpenTransaction
			Get
				Return (transaction IsNot Nothing)
			End Get
		End Property
		Public ReadOnly Property IsOpen() As Boolean Implements INHibernateSession.IsOpen
			Get
				Return (iSession IsNot Nothing AndAlso iSession.IsOpen)
			End Get
		End Property
		Public Property AutoCloseSession() As Boolean Implements INHibernateSession.AutoCloseSession
			Get
				Return _autoCloseSession
			End Get
			Set
				_autoCloseSession = value
				If _refCount = 0 AndAlso _autoCloseSession Then
					Close()
				End If
			End Set
		End Property

#End Region
	End Class
End Namespace
