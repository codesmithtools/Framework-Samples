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

namespace PetShop.Core.Data
{
    /// <summary>
    /// The class representing the dbo.Cart table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Cart")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(PetShop.Core.Data.Cart.Metadata))]
    [System.Data.Services.Common.DataServiceKey("CartId")]
    [System.Diagnostics.DebuggerDisplay("CartId: {CartId}")]
    public partial class Cart
        : LinqEntityBase, ICloneable 
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Cart"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static Cart()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Cart"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Cart()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void Initialize()
        {
            _profile = default(System.Data.Linq.EntityRef<Profile>);
            OnCreated();
        }
        #endregion

        #region Column Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _uniqueID;

        /// <summary>
        /// Gets or sets the UniqueID column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "UniqueID", Storage = "_uniqueID", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int UniqueID
        {
            get { return _uniqueID; }
            set
            {
                if (_uniqueID != value)
                {
                    if (_profile.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUniqueIDChanging(value);
                    SendPropertyChanging("UniqueID");
                    _uniqueID = value;
                    SendPropertyChanged("UniqueID");
                    OnUniqueIDChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _itemId;

        /// <summary>
        /// Gets or sets the ItemId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ItemId", Storage = "_itemId", DbType = "varchar(10) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                if (_itemId != value)
                {
                    OnItemIdChanging(value);
                    SendPropertyChanging("ItemId");
                    _itemId = value;
                    SendPropertyChanged("ItemId");
                    OnItemIdChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _name;

        /// <summary>
        /// Gets or sets the Name column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Name", Storage = "_name", DbType = "varchar(80) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
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
        private string _type;

        /// <summary>
        /// Gets or sets the Type column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Type", Storage = "_type", DbType = "varchar(80) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    OnTypeChanging(value);
                    SendPropertyChanging("Type");
                    _type = value;
                    SendPropertyChanged("Type");
                    OnTypeChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private decimal _price;

        /// <summary>
        /// Gets or sets the Price column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Price", Storage = "_price", DbType = "decimal(10,2) NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    OnPriceChanging(value);
                    SendPropertyChanging("Price");
                    _price = value;
                    SendPropertyChanged("Price");
                    OnPriceChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _categoryId;

        /// <summary>
        /// Gets or sets the CategoryId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CategoryId", Storage = "_categoryId", DbType = "varchar(10) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string CategoryId
        {
            get { return _categoryId; }
            set
            {
                if (_categoryId != value)
                {
                    OnCategoryIdChanging(value);
                    SendPropertyChanging("CategoryId");
                    _categoryId = value;
                    SendPropertyChanged("CategoryId");
                    OnCategoryIdChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _productId;

        /// <summary>
        /// Gets or sets the ProductId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ProductId", Storage = "_productId", DbType = "varchar(10) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string ProductId
        {
            get { return _productId; }
            set
            {
                if (_productId != value)
                {
                    OnProductIdChanging(value);
                    SendPropertyChanging("ProductId");
                    _productId = value;
                    SendPropertyChanged("ProductId");
                    OnProductIdChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private bool _isShoppingCart;

        /// <summary>
        /// Gets or sets the IsShoppingCart column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IsShoppingCart", Storage = "_isShoppingCart", DbType = "bit NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public bool IsShoppingCart
        {
            get { return _isShoppingCart; }
            set
            {
                if (_isShoppingCart != value)
                {
                    OnIsShoppingCartChanging(value);
                    SendPropertyChanging("IsShoppingCart");
                    _isShoppingCart = value;
                    SendPropertyChanged("IsShoppingCart");
                    OnIsShoppingCartChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _quantity;

        /// <summary>
        /// Gets or sets the Quantity column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Quantity", Storage = "_quantity", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 9)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    OnQuantityChanging(value);
                    SendPropertyChanging("Quantity");
                    _quantity = value;
                    SendPropertyChanged("Quantity");
                    OnQuantityChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _cartId = default(int);

        /// <summary>
        /// Gets the CartId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CartId", Storage = "_cartId", DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 10)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int CartId
        {
            get { return _cartId; }
            set
            {
                if (_cartId != value)
                {
                    OnCartIdChanging(value);
                    SendPropertyChanging("CartId");
                    _cartId = value;
                    SendPropertyChanged("CartId");
                    OnCartIdChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntityRef<Profile> _profile;

        /// <summary>
        /// Gets or sets the <see cref="Profile"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Profile_Cart", Storage = "_profile", ThisKey = "UniqueID", OtherKey = "UniqueID", IsForeignKey = true, DeleteRule = "CASCADE")]
        [System.Runtime.Serialization.DataMember(Order = 11, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Profile Profile
        {
            get { return (serializing && !_profile.HasLoadedOrAssignedValue) ? null : _profile.Entity; }
            set
            {
                Profile previousValue = _profile.Entity;
                if (previousValue != value || _profile.HasLoadedOrAssignedValue == false)
                {
                    OnProfileChanging(value);
                    SendPropertyChanging("Profile");
                    if (previousValue != null)
                    {
                        _profile.Entity = null;
                        previousValue.CartList.Remove(this);
                    }
                    _profile.Entity = value;
                    if (value != null)
                    {
                        value.CartList.Add(this);
                        _uniqueID = value.UniqueID;
                    }
                    else
                    {
                        _uniqueID = default(int);
                    }
                    SendPropertyChanged("Profile");
                    OnProfileChanged();
                }
            }
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
        /// <summary>Called when <see cref="UniqueID"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUniqueIDChanging(int value);
        /// <summary>Called after <see cref="UniqueID"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUniqueIDChanged();
        /// <summary>Called when <see cref="ItemId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnItemIdChanging(string value);
        /// <summary>Called after <see cref="ItemId"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnItemIdChanged();
        /// <summary>Called when <see cref="Name"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNameChanging(string value);
        /// <summary>Called after <see cref="Name"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnNameChanged();
        /// <summary>Called when <see cref="Type"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTypeChanging(string value);
        /// <summary>Called after <see cref="Type"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnTypeChanged();
        /// <summary>Called when <see cref="Price"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPriceChanging(decimal value);
        /// <summary>Called after <see cref="Price"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnPriceChanged();
        /// <summary>Called when <see cref="CategoryId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCategoryIdChanging(string value);
        /// <summary>Called after <see cref="CategoryId"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCategoryIdChanged();
        /// <summary>Called when <see cref="ProductId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnProductIdChanging(string value);
        /// <summary>Called after <see cref="ProductId"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnProductIdChanged();
        /// <summary>Called when <see cref="IsShoppingCart"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIsShoppingCartChanging(bool value);
        /// <summary>Called after <see cref="IsShoppingCart"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIsShoppingCartChanged();
        /// <summary>Called when <see cref="Quantity"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnQuantityChanging(int value);
        /// <summary>Called after <see cref="Quantity"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnQuantityChanged();
        /// <summary>Called when <see cref="CartId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCartIdChanging(int value);
        /// <summary>Called after <see cref="CartId"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCartIdChanged();
        /// <summary>Called when <see cref="Profile"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnProfileChanging(Profile value);
        /// <summary>Called after <see cref="Profile"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnProfileChanged();

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
        /// Deserializes an instance of <see cref="Cart"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Cart"/> instance.</param>
        /// <returns>An instance of <see cref="Cart"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Cart FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Cart));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Cart;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Cart"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Cart"/> instance.</param>
        /// <returns>An instance of <see cref="Cart"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Cart FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Cart));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Cart;
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
        public Cart Clone()
        {
            return (Cart)((ICloneable)this).Clone();
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
            _profile = Detach(_profile);
        }
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414

