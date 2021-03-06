﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Account.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

using Csla;

namespace PetShop.Tests.ObjF.ParameterizedSQL
{
    [Serializable]
    public partial class AccountCriteria : CriteriaBase<AccountCriteria>, IGeneratedCriteria
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public AccountCriteria(){}

        public AccountCriteria(System.Int32 accountId)
        {
            AccountId = accountId;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.Int32 AccountId
        {
            get { return GetValue<System.Int32>("AccountId"); }
            set { _bag["AccountId"] = value; }
        }

        public System.Int32 UniqueID
        {
            get { return GetValue<System.Int32>("UniqueID"); }
            set { _bag["UniqueID"] = value; }
        }

        public System.String Email
        {
            get { return GetValue<System.String>("Email"); }
            set { _bag["Email"] = value; }
        }

        public System.String FirstName
        {
            get { return GetValue<System.String>("FirstName"); }
            set { _bag["FirstName"] = value; }
        }

        public System.String LastName
        {
            get { return GetValue<System.String>("LastName"); }
            set { _bag["LastName"] = value; }
        }

        public System.String Address1
        {
            get { return GetValue<System.String>("Address1"); }
            set { _bag["Address1"] = value; }
        }

        public System.String Address2
        {
            get { return GetValue<System.String>("Address2"); }
            set { _bag["Address2"] = value; }
        }

        public System.String City
        {
            get { return GetValue<System.String>("City"); }
            set { _bag["City"] = value; }
        }

        public System.String State
        {
            get { return GetValue<System.String>("State"); }
            set { _bag["State"] = value; }
        }

        public System.String Zip
        {
            get { return GetValue<System.String>("Zip"); }
            set { _bag["Zip"] = value; }
        }

        public System.String Country
        {
            get { return GetValue<System.String>("Country"); }
            set { _bag["Country"] = value; }
        }

        public System.String Phone
        {
            get { return GetValue<System.String>("Phone"); }
            set { _bag["Phone"] = value; }
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
                return "[dbo].[Account]";
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
        
    }
}