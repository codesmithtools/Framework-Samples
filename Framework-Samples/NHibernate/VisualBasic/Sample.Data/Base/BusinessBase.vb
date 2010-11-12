Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Sample.Data.Generated.Base
	Interface IBusinessBase(Of T)
		' Methods
		Function GetHashCode() As Integer
		Function Equals(ByVal obj As Object) As Boolean

		' Properties
		Property Id() As T
	End Interface

	''' <summary>
	''' Base for all business objects.
	''' 
	''' For an explanation of why Equals and GetHashCode are overriden, read the following...
	''' http://devlicio.us/blogs/billy_mccafferty/archive/2007/04/25/using-equals-gethashcode-effectively.aspx
	''' </summary>
	''' <typeparam name="T">DataType of the primary key.</typeparam>
	Public MustInherit Class BusinessBase(Of T)
		Implements IBusinessBase(Of T)
#region "Declarations"

		Private _id As T = Nothing
#End Region

#region "Methods"

		Public MustOverride Overloads Overrides Function GetHashCode() As Integer Implements IBusinessBase(Of T).GetHashCode
		Public Overloads Overrides Function Equals(ByVal obj As Object) As Boolean Implements IBusinessBase(Of T).Equals
				' 1) Object is not null.
				' 2) Object is of same Type.
			Return (obj IsNot Nothing) AndAlso (obj.[GetType]().Equals(Me.[GetType]())) AndAlso (MatchingIds(DirectCast(obj, BusinessBase(Of T))) OrElse MatchingHashCodes(obj))
			' 3) Ids or Hashcodes match.
		End Function
		Private Function MatchingIds(ByVal obj As BusinessBase(Of T)) As Boolean
				' 1) this.Id is not null/default.
				' 1.5) obj.Id is not null/default.
			Return (Me.Id IsNot Nothing) AndAlso (obj.Id IsNot Nothing) AndAlso (Me.Id.Equals(obj.Id))
			' 2) Ids match.
		End Function
		Private Function MatchingHashCodes(ByVal obj As Object) As Boolean
			Return Me.GetHashCode().Equals(obj.GetHashCode())
			' 1) Hashcodes match.
		End Function
#End Region

#region "Properties"

		Public Overridable Property Id() As T Implements IBusinessBase(Of T).Id
			Get
				Return _id
			End Get
			Set
				_id = value
			End Set
		End Property
#End Region
	End Class
End Namespace
