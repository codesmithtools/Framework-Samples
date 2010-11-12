Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports NHibernate
Imports NHibernate.Criterion

Namespace Sample.Data.Generated.Base
	Public Interface IManagerBase(Of T, TKey)
        Inherits IDisposable

        ' Get Methods
		Function GetById(ByVal Id As TKey) As T
		Function GetAll() As IList(Of T)
		Function GetAll(ByVal maxResults As Integer) As IList(Of T)
		Function GetByCriteria(ParamArray criterionList As ICriterion()) As IList(Of T)
		Function GetByCriteria(ByVal maxResults As Integer, ParamArray criterionList As ICriterion()) As IList(Of T)
        Function GetUniqueByCriteria(ParamArray criterionList As ICriterion()) As T
		Function GetByExample(ByVal exampleObject As T, ParamArray excludePropertyList As String()) As IList(Of T)
        Function GetByQuery(query As String) As IList(Of T)
        Function GetByQuery(maxResults As Integer, query As String) As IList(Of T)
        Function GetUniqueByQuery(query As String) As T

        ' Misc Methods
        Sub SetFetchMode(associationPath As String, mode As FetchMode)
        Function CreateCriteria() As ICriteria

		' CRUD Methods
		Function Save(ByVal entity As T) As Object
		Sub SaveOrUpdate(ByVal entity As T)
		Sub Delete(ByVal entity As T)
		Sub Update(ByVal entity As T)
		Sub Refresh(ByVal entity As T)
        Sub Evict(ByVal entity As T)

		' Properties
		ReadOnly Property Type() As System.Type
		ReadOnly Property Session() As INHibernateSession
	End Interface

	Public MustInherit Partial Class ManagerBase(Of T, TKey)
		Implements IManagerBase(Of T, TKey)
#region "Declarations"

		Protected _session As INHibernateSession
		Protected Const defaultMaxResults As Integer = 100
        
        Private _disposed As Boolean = False
        Private _fetchModeMap As New Dictionary(Of String, FetchMode)()
        
#End Region

#region "Constructors"

		Public Sub New()
			Me.New(NHibernateSessionManager.Instance.Session)
		End Sub
		Public Sub New(session As INHibernateSession)
			Me._session = session
			Me._session.IncrementRefCount()
		End Sub
        
		Protected Overrides Sub Finalize()
			Try
				Dispose(True)
			Finally
				MyBase.Finalize()
			End Try
		End Sub
        
#End Region

#region "Get Methods"

		Public Overridable Function GetById(ByVal id As TKey) As T Implements IManagerBase(Of T, TKey).GetById
			Return DirectCast(Session.GetISession().[Get](GetType(T), id), T)
		End Function

        Public Function GetAll() As IList(Of T) Implements IManagerBase(Of T, TKey).GetAll
			Return GetByCriteria(defaultMaxResults)
		End Function
		Public Function GetAll(ByVal maxResults As Integer) As IList(Of T) Implements IManagerBase(Of T, TKey).GetAll
			Return GetByCriteria(maxResults)
		End Function

        Public Function GetByCriteria(ParamArray criterionList As ICriterion()) As IList(Of T) Implements IManagerBase(Of T, TKey).GetByCriteria
			Return GetByCriteria(defaultMaxResults, criterionList)
		End Function
		Public Function GetByCriteria(ByVal maxResults As Integer, ParamArray criterionList As ICriterion()) As IList(Of T) Implements IManagerBase(Of T, TKey).GetByCriteria
			Dim criteria As ICriteria = CreateCriteria().SetMaxResults(maxResults)

			For Each criterion As ICriterion In criterionList
				criteria.Add(criterion)
			Next

			Return criteria.List(Of T)()
		End Function
        Public Function GetUniqueByCriteria(ParamArray criterionList As ICriterion()) As T Implements IManagerBase(Of T, TKey).GetUniqueByCriteria
            Dim criteria As ICriteria = CreateCriteria()
        
            For Each criterion As ICriterion In criterionList
                criteria.Add(criterion)
            Next
        
            Return criteria.UniqueResult(Of T)()
        End Function

        Public Function GetByExample(ByVal exampleObject As T, ParamArray excludePropertyList As String()) As IList(Of T) Implements IManagerBase(Of T, TKey).GetByExample
			Dim criteria As ICriteria = CreateCriteria()
			Dim example As Example = Example.Create(exampleObject)

			For Each excludeProperty As String In excludePropertyList
				example.ExcludeProperty(excludeProperty)
			Next

			criteria.Add(example)

			Return criteria.List(Of T)()
		End Function
        
        Public Function GetByQuery(query As String) As IList(Of T) Implements IManagerBase(Of T, TKey).GetByQuery
            Return GetByQuery(defaultMaxResults, query)
        End Function
        Public Function GetByQuery(maxResults As Integer, query As String) As IList(Of T) Implements IManagerBase(Of T, TKey).GetByQuery
            Dim iQuery As IQuery = Session.GetISession().CreateQuery(query).SetMaxResults(maxResults)
            Return iQuery.List(Of T)()
        End Function
        Public Function GetUniqueByQuery(query As String) As T Implements IManagerBase(Of T, TKey).GetUniqueByQuery
            Dim iQuery As IQuery = Session.GetISession().CreateQuery(query)
            Return iQuery.UniqueResult(Of T)()
        End Function
#End Region

#region "Misc Methods"

        Public Sub SetFetchMode(associationPath As String, mode As FetchMode) Implements IManagerBase(Of T, TKey).SetFetchMode
            If Not _fetchModeMap.ContainsKey(associationPath) Then
                _fetchModeMap.Add(associationPath, mode)
            End If
        End Sub
        
        Public Function CreateCriteria() As ICriteria Implements IManagerBase(Of T, TKey).CreateCriteria
            Dim criteria As ICriteria = Session.GetISession().CreateCriteria(GetType(T))
        
            For Each pair As KeyValuePair(Of String, NHibernate.FetchMode) In _fetchModeMap
                criteria = criteria.SetFetchMode(pair.Key, pair.Value)
            Next
        
            Return criteria
        End Function
#End Region

#region "CRUD Methods"

		Public Function Save(ByVal entity As T) As Object Implements IManagerBase(Of T, TKey).Save
			Return Session.GetISession().Save(entity)
		End Function
		Public Sub SaveOrUpdate(ByVal entity As T) Implements IManagerBase(Of T, TKey).SaveOrUpdate
			Session.GetISession().SaveOrUpdate(entity)
		End Sub
		Public Sub Delete(ByVal entity As T) Implements IManagerBase(Of T, TKey).Delete
			Session.GetISession().Delete(entity)
		End Sub
		Public Sub Update(ByVal entity As T) Implements IManagerBase(Of T, TKey).Update
			Session.GetISession().Update(entity)
		End Sub
		Public Sub Refresh(ByVal entity As T) Implements IManagerBase(Of T, TKey).Refresh
			Session.GetISession().Refresh(entity)
		End Sub
        Public Sub Evict(ByVal entity As T) Implements IManagerBase(Of T, TKey).Evict
			Session.GetISession().Evict(entity)
		End Sub
#End Region

#region "Properties"

		''' <summary>
		''' The NHibernate Session object is exposed only to the Manager class.
		''' It is recommended that you...
		''' ...use the the NHibernateSession methods to control Transactions (unless you specifically want nested transactions).
		''' ...do not directly expose the Flush method (to prevent open transactions from locking your DB).
		''' </summary>
		Public ReadOnly Property Type() As System.Type Implements IManagerBase(Of T, TKey).Type
			Get
				Return GetType(T)
			End Get
		End Property
		Public ReadOnly Property Session() As INHibernateSession Implements IManagerBase(Of T, TKey).Session
			Get
				Return _session
			End Get
		End Property
#End Region

#region "IDisposable Members"
		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(False)
		End Sub
		Private Sub Dispose(finalizing As Boolean)
			If Not _disposed Then
				session.DecrementRefCount()

				If Not finalizing Then
					GC.SuppressFinalize(Me)
				End If

				_disposed = True
			End If
		End Sub
#End Region

	End Class
End Namespace
