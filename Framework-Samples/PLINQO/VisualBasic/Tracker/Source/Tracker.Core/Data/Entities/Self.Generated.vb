﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO NOT MODIFY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------
Imports System
Imports System.Linq

Namespace Tracker.Core.Data
    ''' <summary>
    ''' The class representing the dbo.Self table.
    ''' </summary>
    <System.Data.Linq.Mapping.Table(Name:="dbo.Self")> _
    <System.Runtime.Serialization.DataContract(IsReference:=True)> _
    <System.ComponentModel.DataAnnotations.ScaffoldTable(True)> _
    <System.ComponentModel.DataAnnotations.MetadataType(GetType(Tracker.Core.Data.Self.Metadata))> _
    <System.Data.Services.Common.DataServiceKey("Id")> _
    <System.Diagnostics.DebuggerDisplay("Id: {Id}")> _
    Partial public Class Self
        Inherits LinqEntityBase
        Implements ICloneable

#Region "Static Constructor"
        ''' <summary>
        ''' Initializes the <see cref="Self"/> class.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Shared Sub New()
            AddSharedRules()
        End Sub
#End Region

#Region "Default Constructor"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="Self"/> class.
        ''' </summary>
        <System.Diagnostics.DebuggerNonUserCode()> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Sub New()
            Initialize()
        End Sub

        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private Sub Initialize()
            _mySelf = Nothing
            _mySelfList = New System.Data.Linq.EntitySet(Of Self)( _
                New System.Action(Of Self)(AddressOf Me.OnMySelfListAdd), _
                New System.Action(Of Self)(AddressOf Me.OnMySelfListRemove))
            OnCreated()
        End Sub
#End Region

#Region "Column Mapped Properties"

        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private _id As Integer = Nothing

        ''' <summary>
        ''' Gets the Id column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Id", Storage:="_id", DbType:="int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True, CanBeNull:=False)> _
        <System.Runtime.Serialization.DataMember(Order:=1)> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Property Id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                If ((Me._id = value) = False) Then
                    OnIdChanging(value)
                    SendPropertyChanging("Id")
                    _id = value
                    SendPropertyChanged("Id")
                    OnIdChanged()
                End If
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private _mySelfId As Nullable(Of Integer)

        ''' <summary>
        ''' Gets or sets the MySelfId column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="MySelfId", Storage:="_mySelfId", DbType:="int")> _
        <System.Runtime.Serialization.DataMember(Order:=2)> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Property MySelfId() As Nullable(Of Integer)
            Get
                Return _mySelfId
            End Get
            Set(ByVal value As Nullable(Of Integer))
                If (Me._mySelfId.Equals(value) = False) Then
                    If (_mySelf.HasLoadedOrAssignedValue) Then
                        Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
                    End If
                    OnMySelfIdChanging(value)
                    SendPropertyChanging("MySelfId")
                    _mySelfId = value
                    SendPropertyChanged("MySelfId")
                    OnMySelfIdChanged()
                End If
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private _name As String

        ''' <summary>
        ''' Gets or sets the Name column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Name", Storage:="_name", DbType:="nvarchar(50) NOT NULL", CanBeNull:=False)> _
        <System.ComponentModel.DataAnnotations.StringLength(50)> _
        <System.Runtime.Serialization.DataMember(Order:=3)> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._name, value) = False) Then
                    OnNameChanging(value)
                    SendPropertyChanging("Name")
                    _name = value
                    SendPropertyChanged("Name")
                    OnNameChanged()
                End If
            End Set
        End Property
#End Region

#Region "Association Mapped Properties"

        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private  _mySelf As System.Data.Linq.EntityRef(Of Self)

        ''' <summary>
        ''' Gets or sets the <see cref="Self"/> association.
        ''' </summary>
        <System.Data.Linq.Mapping.Association(Name:="Self_Self", Storage:="_mySelf", ThisKey:="MySelfId", OtherKey:="Id", IsForeignKey:=true)> _
        <System.Runtime.Serialization.DataMember(Order:=4, EmitDefaultValue:=False)> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Property MySelf() As Self
            Get
                If (serializing AndAlso Not _mySelf.HasLoadedOrAssignedValue) Then
                    Return Nothing
                Else
                    Return _mySelf.Entity
                End If
            End Get
            Set(ByVal value As Self)
                Dim previousValue As Self = _mySelf.Entity
                If ((Object.Equals(previousValue, value) = False) OrElse (Me._mySelf.HasLoadedOrAssignedValue = False)) Then
                    OnMySelfChanging(value)
                    SendPropertyChanging("MySelf")
                    If ((previousValue Is Nothing) = False) Then
                        _mySelf.Entity = Nothing
                        previousValue.MySelfList.Remove(Me)
                    End If
                    _mySelf.Entity = value
                    If ((value Is Nothing) = False) Then
                        value.MySelfList.Add(Me)
                        _mySelfId = value.Id
                    Else
                        _mySelfId = Nothing
                    End If
                    SendPropertyChanged("MySelf")
                    OnMySelfChanged()
                End If
            End Set
        End Property



        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private _mySelfList As System.Data.Linq.EntitySet(Of Self)

        ''' <summary>
        ''' Gets or sets the <see cref="Self"/> association.
        ''' </summary>
        <System.Data.Linq.Mapping.Association(Name:="Self_Self", Storage:="_mySelfList", ThisKey:="Id", OtherKey:="MySelfId")> _
        <System.Runtime.Serialization.DataMember(Order:=5, EmitDefaultValue:=False)> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        public Property MySelfList() As System.Data.Linq.EntitySet(Of Self)
            Get
                If (serializing AndAlso Not _mySelfList.HasLoadedOrAssignedValues) Then
                    Return Nothing
                Else
                    Return _mySelfList
                End If
            End Get
            Set(ByVal value As System.Data.Linq.EntitySet(Of Self))
                _mySelfList.Assign(value)
            End Set
        End Property



        <System.Diagnostics.DebuggerNonUserCode()> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private Sub OnMySelfListAdd(ByVal entity As Self)
            SendPropertyChanging(Nothing)
            entity.MySelf = Me
            SendPropertyChanged(Nothing)
        End Sub

        <System.Diagnostics.DebuggerNonUserCode()> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private Sub OnMySelfListRemove(ByVal entity As Self)
            SendPropertyChanging(Nothing)
            entity.MySelf = Nothing
            SendPropertyChanged(Nothing)
        End Sub

#End Region

#Region "Extensibility Method Definitions"

        ''' <summary>Called by the Shared constructor to add shared rules.</summary>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Shared Sub AddSharedRules()
        End Sub
        ''' <summary>Called when this instance is loaded.</summary>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnLoaded()
        End Sub
        ''' <summary>Called when this instance is being saved.</summary>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        End Sub
        ''' <summary>Called when this instance is created.</summary>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnCreated()
        End Sub
        ''' <summary>Called when <see cref="Id"/> is changing.</summary>
        ''' <param name="value">The new value.</param>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnIdChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after <see cref="Id"/> has Changed.</summary>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnIdChanged()
        End Sub
        ''' <summary>Called when <see cref="MySelfId"/> is changing.</summary>
        ''' <param name="value">The new value.</param>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnMySelfIdChanging(ByVal value As Nullable(Of Integer))
        End Sub
        ''' <summary>Called after <see cref="MySelfId"/> has Changed.</summary>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnMySelfIdChanged()
        End Sub
        ''' <summary>Called when <see cref="Name"/> is changing.</summary>
        ''' <param name="value">The new value.</param>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnNameChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after <see cref="Name"/> has Changed.</summary>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnNameChanged()
        End Sub
        ''' <summary>Called when <see cref="MySelf"/> is changing.</summary>
        ''' <param name="value">The new value.</param>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnMySelfChanging(ByVal value As Self)
        End Sub
        ''' <summary>Called after <see cref="MySelf"/> has Changed.</summary>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Partial Private Sub OnMySelfChanged()
        End Sub

#End Region

#Region "Serialization"

        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private serializing As Boolean

        ''' <summary>
        ''' Called when serializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Sub OnSerializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = True
        End Sub

        ''' <summary>
        ''' Called when serialized.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerialized(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Sub OnSerialized(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = False
        End Sub

        ''' <summary>
        ''' Called when deserializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnDeserializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Sub OnDeserializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            Initialize()
        End Sub

        ''' <summary>
        ''' Deserializes an instance of <see cref="Self"/> from XML.
        ''' </summary>
        ''' <param name="xml">The XML string representing a <see cref="Self"/> instance.</param>
        ''' <returns>An instance of <see cref="Self"/> that is deserialized from the XML string.</returns>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Shared Function FromXml(ByVal xml As String) As Self
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(Self))

            Using sr = New System.IO.StringReader(xml)
                Using reader = System.Xml.XmlReader.Create(sr)
                    Return TryCast(deserializer.ReadObject(reader), Self)
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Deserializes an instance of <see cref="Self"/>.
        ''' </summary>
        ''' <param name="buffer">The byte array representing a <see cref="Self"/> instance.</param>
        ''' <returns>An instance of <see cref="Self"/> that is deserialized from the byte array.</returns>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Shared Function FromBinary(ByVal buffer As Byte()) As Self
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(Self))

            Using ms = New System.IO.MemoryStream(buffer)
                Using reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max)
                    Return TryCast(deserializer.ReadObject(reader), Self)
                End Using
            End Using
        End Function
#End Region

#Region "Clone"
        ''' <summary>
        ''' Creates a new object that is a copy of the current instance.
        ''' </summary>
        ''' <returns>
        ''' A new object that is a copy of this instance.
        ''' </returns>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
            Dim serializer As New System.Runtime.Serialization.DataContractSerializer([GetType]())
            Using ms As New System.IO.MemoryStream()
                serializer.WriteObject(ms, Me)
                ms.Position = 0
                Return serializer.ReadObject(ms)
            End Using
        End Function

        ''' <summary>
        ''' Creates a new object that is a copy of the current instance.
        ''' </summary>
        ''' <returns>
        ''' A new object that is a copy of this instance.
        ''' </returns>
        ''' <remarks>
        ''' Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        ''' </remarks>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Function Clone() As Self
            Return DirectCast(DirectCast(Me, ICloneable).Clone(), Self)
        End Function
#End Region

#Region "Detach Methods"
        ''' <summary>
        ''' Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        ''' </summary>
        ''' <remarks>
        ''' Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        ''' </remarks>
        <System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")> _
        Public Overrides Sub Detach()

            If (Not IsAttached()) Then
                Return
            End If

            MyBase.Detach()
            _mySelf = Detach(_mySelf)
            _mySelfList = Detach(_mySelfList, AddressOf OnMySelfListAdd, AddressOf OnMySelfListRemove)
        End Sub
#End Region
    End Class
End Namespace
