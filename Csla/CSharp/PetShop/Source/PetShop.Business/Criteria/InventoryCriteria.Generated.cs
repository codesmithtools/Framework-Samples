﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Inventory.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Csla.Core;
#if SILVERLIGHT
using Csla.Serialization;
#endif
using Csla.Serialization.Mobile;
#if !SILVERLIGHT
using System.Data.SqlClient;
#endif

using Csla;

namespace PetShop.Business
{
    [Serializable]
    public partial class InventoryCriteria : CriteriaBase<InventoryCriteria>, IGeneratedCriteria
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public InventoryCriteria(){}

        public InventoryCriteria(System.String itemId)
        {
            ItemId = itemId;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.String ItemId
        {
            get { return GetValue<System.String>("ItemId"); }
            set { _bag["ItemId"] = value; }
        }

        public System.Int32 Qty
        {
            get { return GetValue<System.Int32>("Qty"); }
            set { _bag["Qty"] = value; }
        }

        #endregion
        
        #region Read-Only

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
        {
            get
            {
                return _bag;
            }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[dbo].[Inventory]";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public override string ToString()
        {
            var result = String.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !String.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

        #endregion

        #region Private Methods
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
        #region Serialization
        
        protected override void OnGetState(SerializationInfo info, StateMode mode)
        {
            base.OnGetState(info, mode);
            if (_bag.ContainsKey("ItemId")) info.AddValue("ItemId", GetValue<System.String>("ItemId"));
            if (_bag.ContainsKey("Qty")) info.AddValue("Qty", GetValue<System.Int32>("Qty"));
        }

        protected override void OnSetState(SerializationInfo info, StateMode mode)
        {
            base.OnSetState(info, mode);
            if(info.Values.ContainsKey("ItemId")) _bag["ItemId"] = info.GetValue<System.String>("ItemId");
            if(info.Values.ContainsKey("Qty")) _bag["Qty"] = info.GetValue<System.Int32>("Qty");
        }

        #endregion
    }
}