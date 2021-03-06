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
using System.Collections;
using System.Collections.Generic;
using Petshop.Data;

namespace Petshop.Data.Entities
{
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.Diagnostics.DebuggerDisplay("UniqueID: {UniqueID}")]
    public partial class Profile : EntityBase
    {
        #region Static Constructor
        
        /// <summary>
        /// Initializes the <see cref="Account"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        static Profile()
        {
            AddSharedRules();
        }
        
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Profile()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        protected override void Initialize()
        {
            OnCreated();
        }
        
        #endregion
        
        #region Column Mapped Properties
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Int32 _uniqueID;
        
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.Int32 UniqueID
        {
            get { return _uniqueID; }
            set
            {
                OnUniqueIDChanging(value, _uniqueID);
                SendPropertyChanging("UniqueID");
                _uniqueID = value;
                SendPropertyChanged("UniqueID");
                OnUniqueIDChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _username;
        
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String Username
        {
            get { return _username; }
            set
            {
                OnUsernameChanging(value, _username);
                SendPropertyChanging("Username");
                _username = value;
                SendPropertyChanged("Username");
                OnUsernameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _applicationName;
        
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String ApplicationName
        {
            get { return _applicationName; }
            set
            {
                OnApplicationNameChanging(value, _applicationName);
                SendPropertyChanging("ApplicationName");
                _applicationName = value;
                SendPropertyChanged("ApplicationName");
                OnApplicationNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Boolean? _isAnonymous;
        
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.Boolean? IsAnonymous
        {
            get { return _isAnonymous; }
            set
            {
                OnIsAnonymousChanging(value, _isAnonymous);
                SendPropertyChanging("IsAnonymous");
                _isAnonymous = value;
                SendPropertyChanged("IsAnonymous");
                OnIsAnonymousChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.DateTime? _lastActivityDate;
        
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.DateTime? LastActivityDate
        {
            get { return _lastActivityDate; }
            set
            {
                OnLastActivityDateChanging(value, _lastActivityDate);
                SendPropertyChanging("LastActivityDate");
                _lastActivityDate = value;
                SendPropertyChanged("LastActivityDate");
                OnLastActivityDateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.DateTime? _lastUpdatedDate;
        
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.DateTime? LastUpdatedDate
        {
            get { return _lastUpdatedDate; }
            set
            {
                OnLastUpdatedDateChanging(value, _lastUpdatedDate);
                SendPropertyChanging("LastUpdatedDate");
                _lastUpdatedDate = value;
                SendPropertyChanged("LastUpdatedDate");
                OnLastUpdatedDateChanged(value);
            }
        }
        
        #endregion
        
        #region Associations Mappings
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private IList<Account> _accountList;
        
        [System.Runtime.Serialization.DataMember(Order = 7, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual IList<Account> AccountList
        {
            get { return _accountList; }
            set
            {
                OnAccountListChanging(value, _accountList);
                SendPropertyChanging("AccountList");
                _accountList = value;
                SendPropertyChanged("AccountList");
                OnAccountListChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private IList<Cart> _cartList;
        
        [System.Runtime.Serialization.DataMember(Order = 8, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual IList<Cart> CartList
        {
            get { return _cartList; }
            set
            {
                OnCartListChanging(value, _cartList);
                SendPropertyChanging("CartList");
                _cartList = value;
                SendPropertyChanged("CartList");
                OnCartListChanged(value);
            }
        }
        
        #endregion
        
        #region Extensibility Method
        
        static partial void AddSharedRules();
        
        partial void OnCreated();
        
        partial void OnUniqueIDChanging(System.Int32 newValue, System.Int32 oldValue);
        
        partial void OnUniqueIDChanged(System.Int32 value);
        
        partial void OnUsernameChanging(System.String newValue, System.String oldValue);
        
        partial void OnUsernameChanged(System.String value);
        
        partial void OnApplicationNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnApplicationNameChanged(System.String value);
        
        partial void OnIsAnonymousChanging(System.Boolean? newValue, System.Boolean? oldValue);
        
        partial void OnIsAnonymousChanged(System.Boolean? value);
        
        partial void OnLastActivityDateChanging(System.DateTime? newValue, System.DateTime? oldValue);
        
        partial void OnLastActivityDateChanged(System.DateTime? value);
        
        partial void OnLastUpdatedDateChanging(System.DateTime? newValue, System.DateTime? oldValue);
        
        partial void OnLastUpdatedDateChanged(System.DateTime? value);
        
        
        partial void OnAccountListChanging(IList<Account> newValue, IList<Account> oldValue);
        
        partial void OnAccountListChanged(IList<Account> value);
        
        partial void OnCartListChanging(IList<Cart> newValue, IList<Cart> oldValue);
        
        partial void OnCartListChanged(IList<Cart> value);
        
        #endregion
        
        #region Clone
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual Profile Clone()
        {
            return (Profile)((ICloneable)this).Clone();
        }
        
        #endregion
        
        #region Serialization
        
        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the XML String.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Profile FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Profile));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Profile;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Profile FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Profile));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Profile;
            }
        }
        
        #endregion
    }
}

#pragma warning restore 1591
#pragma warning restore 0414

