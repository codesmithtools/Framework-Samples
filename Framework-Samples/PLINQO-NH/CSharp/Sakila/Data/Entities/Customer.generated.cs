#pragma warning disable 1591
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
using Sakila.Data;

namespace Sakila.Data.Entities
{
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.Diagnostics.DebuggerDisplay("CustomerId: {CustomerId}")]
    public partial class Customer : EntityBase
    {
        #region Static Constructor
        
        /// <summary>
        /// Initializes the <see cref="Account"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        static Customer()
        {
            AddSharedRules();
        }
        
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public Customer()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected override void Initialize()
        {
            OnCreated();
        }
        
        #endregion
        
        #region Column Mapped Properties
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.Int16 _customerId;
        
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.Int16 CustomerId
        {
            get { return _customerId; }
            set
            {
                OnCustomerIdChanging(value, _customerId);
                SendPropertyChanging("CustomerId");
                _customerId = value;
                SendPropertyChanged("CustomerId");
                OnCustomerIdChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _firstName;
        
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String FirstName
        {
            get { return _firstName; }
            set
            {
                OnFirstNameChanging(value, _firstName);
                SendPropertyChanging("FirstName");
                _firstName = value;
                SendPropertyChanged("FirstName");
                OnFirstNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _lastName;
        
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String LastName
        {
            get { return _lastName; }
            set
            {
                OnLastNameChanging(value, _lastName);
                SendPropertyChanging("LastName");
                _lastName = value;
                SendPropertyChanged("LastName");
                OnLastNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _email;
        
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String Email
        {
            get { return _email; }
            set
            {
                OnEmailChanging(value, _email);
                SendPropertyChanging("Email");
                _email = value;
                SendPropertyChanged("Email");
                OnEmailChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _active;
        
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String Active
        {
            get { return _active; }
            set
            {
                OnActiveChanging(value, _active);
                SendPropertyChanging("Active");
                _active = value;
                SendPropertyChanged("Active");
                OnActiveChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.DateTime _createDate;
        
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.DateTime CreateDate
        {
            get { return _createDate; }
            set
            {
                OnCreateDateChanging(value, _createDate);
                SendPropertyChanging("CreateDate");
                _createDate = value;
                SendPropertyChanged("CreateDate");
                OnCreateDateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.DateTime _lastUpdate;
        
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.DateTime LastUpdate
        {
            get { return _lastUpdate; }
            set
            {
                OnLastUpdateChanging(value, _lastUpdate);
                SendPropertyChanging("LastUpdate");
                _lastUpdate = value;
                SendPropertyChanged("LastUpdate");
                OnLastUpdateChanged(value);
            }
        }
        
        #endregion
        
        #region Associations Mappings
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private Address _address;
        
        [System.Runtime.Serialization.DataMember(Order = 8, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual Address Address
        {
            get { return _address; }
            set
            {
                OnAddressChanging(value, _address);
                SendPropertyChanging("Address");
                _address = value;
                SendPropertyChanged("Address");
                OnAddressChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private Store _store;
        
        [System.Runtime.Serialization.DataMember(Order = 9, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual Store Store
        {
            get { return _store; }
            set
            {
                OnStoreChanging(value, _store);
                SendPropertyChanging("Store");
                _store = value;
                SendPropertyChanged("Store");
                OnStoreChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private IList<Payment> _paymentList;
        
        [System.Runtime.Serialization.DataMember(Order = 10, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual IList<Payment> PaymentList
        {
            get { return _paymentList; }
            set
            {
                OnPaymentListChanging(value, _paymentList);
                SendPropertyChanging("PaymentList");
                _paymentList = value;
                SendPropertyChanged("PaymentList");
                OnPaymentListChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private IList<Rental> _rentalList;
        
        [System.Runtime.Serialization.DataMember(Order = 11, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual IList<Rental> RentalList
        {
            get { return _rentalList; }
            set
            {
                OnRentalListChanging(value, _rentalList);
                SendPropertyChanging("RentalList");
                _rentalList = value;
                SendPropertyChanged("RentalList");
                OnRentalListChanged(value);
            }
        }
        
        #endregion
        
        #region Extensibility Method
        
        static partial void AddSharedRules();
        
        partial void OnCreated();
        
        partial void OnCustomerIdChanging(System.Int16 newValue, System.Int16 oldValue);
        
        partial void OnCustomerIdChanged(System.Int16 value);
        
        partial void OnFirstNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnFirstNameChanged(System.String value);
        
        partial void OnLastNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnLastNameChanged(System.String value);
        
        partial void OnEmailChanging(System.String newValue, System.String oldValue);
        
        partial void OnEmailChanged(System.String value);
        
        partial void OnActiveChanging(System.String newValue, System.String oldValue);
        
        partial void OnActiveChanged(System.String value);
        
        partial void OnCreateDateChanging(System.DateTime newValue, System.DateTime oldValue);
        
        partial void OnCreateDateChanged(System.DateTime value);
        
        partial void OnLastUpdateChanging(System.DateTime newValue, System.DateTime oldValue);
        
        partial void OnLastUpdateChanged(System.DateTime value);
        
        
        partial void OnAddressChanging(Address newValue, Address oldValue);
        
        partial void OnAddressChanged(Address value);
        
        partial void OnStoreChanging(Store newValue, Store oldValue);
        
        partial void OnStoreChanged(Store value);
        
        partial void OnPaymentListChanging(IList<Payment> newValue, IList<Payment> oldValue);
        
        partial void OnPaymentListChanged(IList<Payment> value);
        
        partial void OnRentalListChanging(IList<Rental> newValue, IList<Rental> oldValue);
        
        partial void OnRentalListChanged(IList<Rental> value);
        
        #endregion
        
        #region Clone
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual Customer Clone()
        {
            return (Customer)((ICloneable)this).Clone();
        }
        
        #endregion
        
        #region Serialization
        
        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Customer FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Customer));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Customer;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Customer FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Customer));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Customer;
            }
        }
        
        #endregion
    }
}

#pragma warning restore 1591
#pragma warning restore 0414

