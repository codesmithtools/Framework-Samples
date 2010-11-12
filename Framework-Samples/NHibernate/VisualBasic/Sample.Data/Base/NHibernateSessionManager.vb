Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Imports NHibernate
Imports NHibernate.Cfg

Namespace Sample.Data.Generated.Base
	Public Interface INHibernateSessionManager
		Inherits IDisposable
		' Methods
		Function CreateISession() As ISession

		' Properties
		ReadOnly Property Session() As INHibernateSession
	End Interface

	''' <summary>
	''' A Singleton that creates and persits a single SessionFactory for the to program to access globally.
	''' This uses the .Net CallContext to store a session for each thread.
	''' 
	''' This is heavely based on 'NHibernate Best Practices with ASP.NET' By Billy McCafferty.
	''' http://www.codeproject.com/KB/architecture/NHibernateBestPractices.aspx
	''' </summary>
	Public Class NHibernateSessionManager
		Implements INHibernateSessionManager
		#region "Static Content"

		Private Shared _nHibernateSessionManager As INHibernateSessionManager = Nothing
		''' <summary>
		''' Set method is exposed so that the INHibernateSessionManager can be swapped out for Unit Testing.
		''' NOTE: Cannot set Instance after it has been initialized, and calling Get will automatically intialize the Instance.
		''' </summary>
		Public Shared Property Instance() As INHibernateSessionManager
			Get
				If _nHibernateSessionManager Is Nothing Then
					_nHibernateSessionManager = New NHibernateSessionManager()
				End If
				Return _nHibernateSessionManager
			End Get
			Set
				If _nHibernateSessionManager IsNot Nothing Then
					Throw New Exception("Cannot set Instance after it has been initialized.")
				End If
				_nHibernateSessionManager = value
			End Set
		End Property
#End Region

		#region "Declarations"

		Private _sessionFactory As ISessionFactory = Nothing
		Private Const _sessionContextKey As String = "NHibernateSession-ContextKey"
#End Region

		#region "Constructors & Finalizers"

		''' <summary>
		''' This will load the NHibernate settings from the App.config.
		''' Note: This can/should be expanded to support multiple databases.
		''' </summary>
		Private Sub New()
			_sessionFactory = New Configuration().Configure().BuildSessionFactory()
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

		Private _isDisposed As Boolean = False
		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(False)
		End Sub
		Private Sub Dispose(ByVal finalizing As Boolean)
			If Not _isDisposed Then
				' Close SessionFactory
				_sessionFactory.Close()
				_sessionFactory.Dispose()

				' Flag as disposed.
				_isDisposed = True
				If Not finalizing Then
					GC.SuppressFinalize(Me)
				End If
			End If
		End Sub
#End Region

		#region "Methods"

		Public Function CreateISession() As ISession Implements INHibernateSessionManager.CreateISession
			Dim iSession As ISession
			SyncLock _sessionFactory
				iSession = _sessionFactory.OpenSession()
			End SyncLock
			Return iSession
		End Function
#End Region

		#region "Properties"

		Public ReadOnly Property Session() As INHibernateSession Implements INHibernateSessionManager.Session
			Get
				If ContextSession Is Nothing Then
					ContextSession = New NHibernateSession()
				End If
				Return ContextSession
			End Get
		End Property
		Private Property ContextSession() As INHibernateSession
			Get
				If IsWebContext Then
					Return DirectCast(System.Web.HttpContext.Current.Items(_sessionContextKey), NHibernateSession)
				Else
					Return DirectCast(System.Runtime.Remoting.Messaging.CallContext.GetData(_sessionContextKey), NHibernateSession)
				End If
			End Get
			Set
				If IsWebContext Then
					System.Web.HttpContext.Current.Items(_sessionContextKey) = value
				Else
					System.Runtime.Remoting.Messaging.CallContext.SetData(_sessionContextKey, value)
				End If
			End Set
		End Property
		Private ReadOnly Property IsWebContext() As Boolean
			Get
				Return (System.Web.HttpContext.Current IsNot Nothing)
			End Get
		End Property
#End Region
	End Class
End Namespace
