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
    [System.Diagnostics.DebuggerDisplay("OrderId: {OrderId}")]
    public partial class Order : EntityBase
    {
        #region Static Constructor
        
        /// <summary>
        /// Initializes the <see cref="Account"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        static Order()
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
        public Order()
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
        private System.Int32 _orderId;
        
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.Int32 OrderId
        {
            get { return _orderId; }
            set
            {
                OnOrderIdChanging(value, _orderId);
                SendPropertyChanging("OrderId");
                _orderId = value;
                SendPropertyChanged("OrderId");
                OnOrderIdChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _userId;
        
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String UserId
        {
            get { return _userId; }
            set
            {
                OnUserIdChanging(value, _userId);
                SendPropertyChanging("UserId");
                _userId = value;
                SendPropertyChanged("UserId");
                OnUserIdChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.DateTime _orderDate;
        
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.DateTime OrderDate
        {
            get { return _orderDate; }
            set
            {
                OnOrderDateChanging(value, _orderDate);
                SendPropertyChanging("OrderDate");
                _orderDate = value;
                SendPropertyChanged("OrderDate");
                OnOrderDateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _shipAddr1;
        
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String ShipAddr1
        {
            get { return _shipAddr1; }
            set
            {
                OnShipAddr1Changing(value, _shipAddr1);
                SendPropertyChanging("ShipAddr1");
                _shipAddr1 = value;
                SendPropertyChanged("ShipAddr1");
                OnShipAddr1Changed(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _shipAddr2;
        
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String ShipAddr2
        {
            get { return _shipAddr2; }
            set
            {
                OnShipAddr2Changing(value, _shipAddr2);
                SendPropertyChanging("ShipAddr2");
                _shipAddr2 = value;
                SendPropertyChanged("ShipAddr2");
                OnShipAddr2Changed(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _shipCity;
        
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String ShipCity
        {
            get { return _shipCity; }
            set
            {
                OnShipCityChanging(value, _shipCity);
                SendPropertyChanging("ShipCity");
                _shipCity = value;
                SendPropertyChanged("ShipCity");
                OnShipCityChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _shipState;
        
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String ShipState
        {
            get { return _shipState; }
            set
            {
                OnShipStateChanging(value, _shipState);
                SendPropertyChanging("ShipState");
                _shipState = value;
                SendPropertyChanged("ShipState");
                OnShipStateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _shipZip;
        
        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String ShipZip
        {
            get { return _shipZip; }
            set
            {
                OnShipZipChanging(value, _shipZip);
                SendPropertyChanging("ShipZip");
                _shipZip = value;
                SendPropertyChanged("ShipZip");
                OnShipZipChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _shipCountry;
        
        [System.Runtime.Serialization.DataMember(Order = 9)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String ShipCountry
        {
            get { return _shipCountry; }
            set
            {
                OnShipCountryChanging(value, _shipCountry);
                SendPropertyChanging("ShipCountry");
                _shipCountry = value;
                SendPropertyChanged("ShipCountry");
                OnShipCountryChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _billAddr1;
        
        [System.Runtime.Serialization.DataMember(Order = 10)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String BillAddr1
        {
            get { return _billAddr1; }
            set
            {
                OnBillAddr1Changing(value, _billAddr1);
                SendPropertyChanging("BillAddr1");
                _billAddr1 = value;
                SendPropertyChanged("BillAddr1");
                OnBillAddr1Changed(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _billAddr2;
        
        [System.Runtime.Serialization.DataMember(Order = 11)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String BillAddr2
        {
            get { return _billAddr2; }
            set
            {
                OnBillAddr2Changing(value, _billAddr2);
                SendPropertyChanging("BillAddr2");
                _billAddr2 = value;
                SendPropertyChanged("BillAddr2");
                OnBillAddr2Changed(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _billCity;
        
        [System.Runtime.Serialization.DataMember(Order = 12)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String BillCity
        {
            get { return _billCity; }
            set
            {
                OnBillCityChanging(value, _billCity);
                SendPropertyChanging("BillCity");
                _billCity = value;
                SendPropertyChanged("BillCity");
                OnBillCityChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _billState;
        
        [System.Runtime.Serialization.DataMember(Order = 13)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String BillState
        {
            get { return _billState; }
            set
            {
                OnBillStateChanging(value, _billState);
                SendPropertyChanging("BillState");
                _billState = value;
                SendPropertyChanged("BillState");
                OnBillStateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _billZip;
        
        [System.Runtime.Serialization.DataMember(Order = 14)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String BillZip
        {
            get { return _billZip; }
            set
            {
                OnBillZipChanging(value, _billZip);
                SendPropertyChanging("BillZip");
                _billZip = value;
                SendPropertyChanged("BillZip");
                OnBillZipChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _billCountry;
        
        [System.Runtime.Serialization.DataMember(Order = 15)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String BillCountry
        {
            get { return _billCountry; }
            set
            {
                OnBillCountryChanging(value, _billCountry);
                SendPropertyChanging("BillCountry");
                _billCountry = value;
                SendPropertyChanged("BillCountry");
                OnBillCountryChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _courier;
        
        [System.Runtime.Serialization.DataMember(Order = 16)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String Courier
        {
            get { return _courier; }
            set
            {
                OnCourierChanging(value, _courier);
                SendPropertyChanging("Courier");
                _courier = value;
                SendPropertyChanged("Courier");
                OnCourierChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Decimal _totalPrice;
        
        [System.Runtime.Serialization.DataMember(Order = 17)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.Decimal TotalPrice
        {
            get { return _totalPrice; }
            set
            {
                OnTotalPriceChanging(value, _totalPrice);
                SendPropertyChanging("TotalPrice");
                _totalPrice = value;
                SendPropertyChanged("TotalPrice");
                OnTotalPriceChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _billToFirstName;
        
        [System.Runtime.Serialization.DataMember(Order = 18)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String BillToFirstName
        {
            get { return _billToFirstName; }
            set
            {
                OnBillToFirstNameChanging(value, _billToFirstName);
                SendPropertyChanging("BillToFirstName");
                _billToFirstName = value;
                SendPropertyChanged("BillToFirstName");
                OnBillToFirstNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _billToLastName;
        
        [System.Runtime.Serialization.DataMember(Order = 19)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String BillToLastName
        {
            get { return _billToLastName; }
            set
            {
                OnBillToLastNameChanging(value, _billToLastName);
                SendPropertyChanging("BillToLastName");
                _billToLastName = value;
                SendPropertyChanged("BillToLastName");
                OnBillToLastNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _shipToFirstName;
        
        [System.Runtime.Serialization.DataMember(Order = 20)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String ShipToFirstName
        {
            get { return _shipToFirstName; }
            set
            {
                OnShipToFirstNameChanging(value, _shipToFirstName);
                SendPropertyChanging("ShipToFirstName");
                _shipToFirstName = value;
                SendPropertyChanged("ShipToFirstName");
                OnShipToFirstNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _shipToLastName;
        
        [System.Runtime.Serialization.DataMember(Order = 21)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String ShipToLastName
        {
            get { return _shipToLastName; }
            set
            {
                OnShipToLastNameChanging(value, _shipToLastName);
                SendPropertyChanging("ShipToLastName");
                _shipToLastName = value;
                SendPropertyChanged("ShipToLastName");
                OnShipToLastNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Int32 _authorizationNumber;
        
        [System.Runtime.Serialization.DataMember(Order = 22)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.Int32 AuthorizationNumber
        {
            get { return _authorizationNumber; }
            set
            {
                OnAuthorizationNumberChanging(value, _authorizationNumber);
                SendPropertyChanging("AuthorizationNumber");
                _authorizationNumber = value;
                SendPropertyChanged("AuthorizationNumber");
                OnAuthorizationNumberChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.String _locale;
        
        [System.Runtime.Serialization.DataMember(Order = 23)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual System.String Locale
        {
            get { return _locale; }
            set
            {
                OnLocaleChanging(value, _locale);
                SendPropertyChanging("Locale");
                _locale = value;
                SendPropertyChanged("Locale");
                OnLocaleChanged(value);
            }
        }
        
        #endregion
        
        #region Associations Mappings
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private IList<LineItem> _lineItemList;
        
        [System.Runtime.Serialization.DataMember(Order = 24, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual IList<LineItem> LineItemList
        {
            get { return _lineItemList; }
            set
            {
                OnLineItemListChanging(value, _lineItemList);
                SendPropertyChanging("LineItemList");
                _lineItemList = value;
                SendPropertyChanged("LineItemList");
                OnLineItemListChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private IList<OrderStatus> _orderStatusList;
        
        [System.Runtime.Serialization.DataMember(Order = 25, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual IList<OrderStatus> OrderStatusList
        {
            get { return _orderStatusList; }
            set
            {
                OnOrderStatusListChanging(value, _orderStatusList);
                SendPropertyChanging("OrderStatusList");
                _orderStatusList = value;
                SendPropertyChanged("OrderStatusList");
                OnOrderStatusListChanged(value);
            }
        }
        
        #endregion
        
        #region Extensibility Method
        
        static partial void AddSharedRules();
        
        partial void OnCreated();
        
        partial void OnOrderIdChanging(System.Int32 newValue, System.Int32 oldValue);
        
        partial void OnOrderIdChanged(System.Int32 value);
        
        partial void OnUserIdChanging(System.String newValue, System.String oldValue);
        
        partial void OnUserIdChanged(System.String value);
        
        partial void OnOrderDateChanging(System.DateTime newValue, System.DateTime oldValue);
        
        partial void OnOrderDateChanged(System.DateTime value);
        
        partial void OnShipAddr1Changing(System.String newValue, System.String oldValue);
        
        partial void OnShipAddr1Changed(System.String value);
        
        partial void OnShipAddr2Changing(System.String newValue, System.String oldValue);
        
        partial void OnShipAddr2Changed(System.String value);
        
        partial void OnShipCityChanging(System.String newValue, System.String oldValue);
        
        partial void OnShipCityChanged(System.String value);
        
        partial void OnShipStateChanging(System.String newValue, System.String oldValue);
        
        partial void OnShipStateChanged(System.String value);
        
        partial void OnShipZipChanging(System.String newValue, System.String oldValue);
        
        partial void OnShipZipChanged(System.String value);
        
        partial void OnShipCountryChanging(System.String newValue, System.String oldValue);
        
        partial void OnShipCountryChanged(System.String value);
        
        partial void OnBillAddr1Changing(System.String newValue, System.String oldValue);
        
        partial void OnBillAddr1Changed(System.String value);
        
        partial void OnBillAddr2Changing(System.String newValue, System.String oldValue);
        
        partial void OnBillAddr2Changed(System.String value);
        
        partial void OnBillCityChanging(System.String newValue, System.String oldValue);
        
        partial void OnBillCityChanged(System.String value);
        
        partial void OnBillStateChanging(System.String newValue, System.String oldValue);
        
        partial void OnBillStateChanged(System.String value);
        
        partial void OnBillZipChanging(System.String newValue, System.String oldValue);
        
        partial void OnBillZipChanged(System.String value);
        
        partial void OnBillCountryChanging(System.String newValue, System.String oldValue);
        
        partial void OnBillCountryChanged(System.String value);
        
        partial void OnCourierChanging(System.String newValue, System.String oldValue);
        
        partial void OnCourierChanged(System.String value);
        
        partial void OnTotalPriceChanging(System.Decimal newValue, System.Decimal oldValue);
        
        partial void OnTotalPriceChanged(System.Decimal value);
        
        partial void OnBillToFirstNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnBillToFirstNameChanged(System.String value);
        
        partial void OnBillToLastNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnBillToLastNameChanged(System.String value);
        
        partial void OnShipToFirstNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnShipToFirstNameChanged(System.String value);
        
        partial void OnShipToLastNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnShipToLastNameChanged(System.String value);
        
        partial void OnAuthorizationNumberChanging(System.Int32 newValue, System.Int32 oldValue);
        
        partial void OnAuthorizationNumberChanged(System.Int32 value);
        
        partial void OnLocaleChanging(System.String newValue, System.String oldValue);
        
        partial void OnLocaleChanged(System.String value);
        
        
        partial void OnLineItemListChanging(IList<LineItem> newValue, IList<LineItem> oldValue);
        
        partial void OnLineItemListChanged(IList<LineItem> value);
        
        partial void OnOrderStatusListChanging(IList<OrderStatus> newValue, IList<OrderStatus> oldValue);
        
        partial void OnOrderStatusListChanged(IList<OrderStatus> value);
        
        #endregion
        
        #region Clone
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public virtual Order Clone()
        {
            return (Order)((ICloneable)this).Clone();
        }
        
        #endregion
        
        #region Serialization
        
        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Order FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Order));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Order;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Order FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Order));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Order;
            }
        }
        
        #endregion
    }
}

#pragma warning restore 1591
#pragma warning restore 0414
