﻿#pragma warning disable 1591
#pragma warning disable 0414        
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace Tracker.Core.Data
{
    /// <summary>
    /// The class representing the dbo.Role table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Role")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Tracker.Core.Data.Role.Metadata))]
    [System.Data.Services.Common.DataServiceKey("Id")]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class Role
        : LinqEntityBase, ICloneable, Tracker.Core.Data.Interfaces.IRole  
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Role"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static Role()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Role()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void Initialize()
        {
            _userRoleList = new System.Data.Linq.EntitySet<UserRole>(OnUserRoleListAdd, OnUserRoleListRemove);
            OnCreated();
        }
        #endregion

        #region Column Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _id = default(int);

        /// <summary>
        /// Gets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    OnIdChanging(value);
                    SendPropertyChanging("Id");
                    _id = value;
                    SendPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _name;

        /// <summary>
        /// Gets or sets the Name column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Name", Storage = "_name", DbType = "nvarchar(50) NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    OnNameChanging(value);
                    SendPropertyChanging("Name");
                    _name = value;
                    SendPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _description;

        /// <summary>
        /// Gets or sets the Description column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Description", Storage = "_description", DbType = "nvarchar(150)", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    OnDescriptionChanging(value);
                    SendPropertyChanging("Description");
                    _description = value;
                    SendPropertyChanged("Description");
                    OnDescriptionChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.DateTime _createdDate;

        /// <summary>
        /// Gets or sets the CreatedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CreatedDate", Storage = "_createdDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                if (_createdDate != value)
                {
                    OnCreatedDateChanging(value);
                    SendPropertyChanging("CreatedDate");
                    _createdDate = value;
                    SendPropertyChanged("CreatedDate");
                    OnCreatedDateChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.DateTime _modifiedDate;

        /// <summary>
        /// Gets or sets the ModifiedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ModifiedDate", Storage = "_modifiedDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set
            {
                if (_modifiedDate != value)
                {
                    OnModifiedDateChanging(value);
                    SendPropertyChanging("ModifiedDate");
                    _modifiedDate = value;
                    SendPropertyChanged("ModifiedDate");
                    OnModifiedDateChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.Binary _rowVersion = default(System.Data.Linq.Binary);

        /// <summary>
        /// Gets the RowVersion column value.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Data.Linq.Mapping.Column(Name = "RowVersion", Storage = "_rowVersion", DbType = "timestamp NOT NULL", IsDbGenerated = true, IsVersion = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Data.Linq.Binary RowVersion
        {
            get { return _rowVersion; }
            set
            {
                if (_rowVersion != value)
                {
                    OnRowVersionChanging(value);
                    SendPropertyChanging("RowVersion");
                    _rowVersion = value;
                    SendPropertyChanged("RowVersion");
                    OnRowVersionChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntitySet<UserRole> _userRoleList;

        /// <summary>
        /// Gets or sets the <see cref="UserRole"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Role_UserRole", Storage = "_userRoleList", ThisKey = "Id", OtherKey = "RoleId")]
        [System.Runtime.Serialization.DataMember(Order=7, EmitDefaultValue=false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Data.Linq.EntitySet<UserRole> UserRoleList
        {
            get { return (serializing && !_userRoleList.HasLoadedOrAssignedValues) ? null : _userRoleList; }
            set { _userRoleList.Assign(value); }
        }
        
        System.Collections.Generic.IEnumerable<Tracker.Core.Data.Interfaces.IUserRole> Tracker.Core.Data.Interfaces.IRole.UserRoleList
        {
            get
            {
                return this.UserRoleList.Cast<Tracker.Core.Data.Interfaces.IUserRole>();
            }
            set
            {
                if (value == null)
                    this.UserRoleList.Clear();
                else
                    this.UserRoleList.SetSource(value.Cast<Tracker.Core.Data.UserRole>());
            }
        }
        

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnUserRoleListAdd(UserRole entity)
        {
            SendPropertyChanging(null);
            entity.Role = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnUserRoleListRemove(UserRole entity)
        {
            SendPropertyChanging(null);
            entity.Role = null;
            SendPropertyChanged(null);
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntitySet<User> _userList;

        /// <summary>
        /// Gets or sets the Many To Many UserList list.
        /// </summary>
        /// <value>The UserList list.</value>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Data.Linq.EntitySet<User> UserList
        {
            get
            {
                if (serializing)
                    return null;

                if (_userList == null)
                {
                    _userList = new System.Data.Linq.EntitySet<User>(OnUserListAdd, OnUserListRemove);
                    _userList.SetSource(UserRoleList.Select(c => c.User));
                }
                return _userList;
            }
            set
            {
                _userList.Assign(value);
            }
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnUserListAdd(User entity)
        {
            SendPropertyChanging(null);
            UserRoleList.Add(new UserRole { Role = this, User = entity });
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnUserListRemove(User entity)
        {
            SendPropertyChanging(null);
            var userRole = UserRoleList.FirstOrDefault(c => c.RoleId == Id
                && c.UserId == entity.Id);
            UserRoleList.Remove( userRole);
            SendPropertyChanged(null);
        }

        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreated();
        /// <summary>Called when <see cref="Id"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdChanging(int value);
        /// <summary>Called after <see cref="Id"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIdChanged();
        /// <summary>Called when <see cref="Name"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNameChanging(string value);
        /// <summary>Called after <see cref="Name"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNameChanged();
        /// <summary>Called when <see cref="Description"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnDescriptionChanging(string value);
        /// <summary>Called after <see cref="Description"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnDescriptionChanged();
        /// <summary>Called when <see cref="CreatedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreatedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="CreatedDate"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreatedDateChanged();
        /// <summary>Called when <see cref="ModifiedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnModifiedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="ModifiedDate"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnModifiedDateChanged();
        /// <summary>Called when <see cref="RowVersion"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnRowVersionChanging(System.Data.Linq.Binary value);
        /// <summary>Called after <see cref="RowVersion"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnRowVersionChanged();

        #endregion

        #region Serialization
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Role"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Role"/> instance.</param>
        /// <returns>An instance of <see cref="Role"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Role FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Role));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Role;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Role"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Role"/> instance.</param>
        /// <returns>An instance of <see cref="Role"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Role FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Role));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Role;
            }
        }
        
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Role Clone()
        {
            return (Role)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
            _userRoleList = Detach(_userRoleList, OnUserRoleListAdd, OnUserRoleListRemove);
        }
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414

