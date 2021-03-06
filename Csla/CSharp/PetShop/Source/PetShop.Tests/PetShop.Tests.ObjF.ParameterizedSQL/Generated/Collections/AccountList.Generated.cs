﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'AccountList.cs'.
//
//     Template: EditableChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Csla;
using Csla.Data;

namespace PetShop.Tests.ObjF.ParameterizedSQL
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.AccountListFactoryName)]
    public partial class AccountList : BusinessListBase<AccountList, Account>
    {
        #region Constructor(s)

        public AccountList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="AccountList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="AccountList"/>.</returns>
        internal static AccountList NewList()
        {
            return DataPortal.CreateChild<AccountList>();
        }     

        /// <summary>
        /// Returns a <see cref="AccountList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="accountId">No additional detail available.</param>
        /// <returns>A <see cref="AccountList"/> object of the specified criteria.</returns>
        internal static AccountList GetByAccountId(System.Int32 accountId)
        {
            var criteria = new AccountCriteria{AccountId = accountId};
            
            
            return DataPortal.Fetch<AccountList>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="AccountList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="uniqueID">No additional detail available.</param>
        /// <returns>A <see cref="AccountList"/> object of the specified criteria.</returns>
        internal static AccountList GetByUniqueID(System.Int32 uniqueID)
        {
            var criteria = new AccountCriteria{UniqueID = uniqueID};
            
            
            return DataPortal.Fetch<AccountList>(criteria);
        }

        internal static AccountList GetByCriteria(AccountCriteria criteria)
        {
            return DataPortal.Fetch<AccountList>(criteria);
        }

        internal static AccountList GetAll()
        {
            return DataPortal.Fetch<AccountList>(new AccountCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods

        internal static async Task<AccountList> NewListAsync()
        {
            return await DataPortal.CreateAsync<AccountList>();
        }

        internal static async Task<AccountList> GetByAccountIdAsync(System.Int32 accountId)
        {
            var criteria = new AccountCriteria{AccountId = accountId};
            
            
            return await DataPortal.FetchAsync<AsyncChildLoader<AccountList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<AccountList> GetByUniqueIDAsync(System.Int32 uniqueID)
        {
            var criteria = new AccountCriteria{UniqueID = uniqueID};
            
            
            return await DataPortal.FetchAsync<AsyncChildLoader<AccountList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<AccountList> GetByCriteriaAsync(AccountCriteria criteria)
        {  
            return await DataPortal.FetchAsync<AsyncChildLoader<AccountList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<AccountList> GetAllAsync()
        {
            return await DataPortal.FetchAsync<AsyncChildLoader<AccountList>>(new AccountCriteria()).ContinueWith(t => t.Result.Child);
        }

        #endregion

        #region Method Overrides
        
        protected override Account AddNewCore()
        {
            Account item = PetShop.Tests.ObjF.ParameterizedSQL.Account.NewAccount();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Tests.ObjF.ParameterizedSQL.Account.NewAccount();

                // Pass the parent value down to the child.
                //Profile profile = this.Parent as Profile;
                //if(profile != null)
                //    item.UniqueID = profile.UniqueID;


                Add(item);
            }

            return item;
        }

        protected async Task<Account> AddNewCoreAsync()
        {
            return await PetShop.Tests.ObjF.ParameterizedSQL.Account.NewAccountAsync().ContinueWith(t => 
            {
                 Account item = t.Result;
                
                bool cancel = false;
                OnAddNewCore(ref item, ref cancel);
                if (!cancel)
                {
                    // Check to see if someone set the item to null in the OnAddNewCore.
                    if(item != null)
                        Add(item);
                }
                
                return item;
            });
        }
        
        #endregion

        #region Property overrides

        /// <summary>
        /// Returns true if any children are dirty
        /// </summary>
        public new bool IsDirty
        {
            get
            {
                foreach(Account item in this.Items)
                {
                    if(item.IsDirty) return true;
                }
                
                return false;
            }
        }

        #endregion
        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="Account"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Account"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="Account"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="AccountCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(AccountCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Account"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Account"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Account"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Account"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="Account"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Account"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
        partial void OnAddNewCore(ref Account item, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the Account in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is a <see cref="AccountList"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(AccountCriteria criteria)
        {
            return PetShop.Tests.ObjF.ParameterizedSQL.Account.Exists(criteria);
        }
        /// <summary>
        /// Determines if a record exists in the Account in the database for the specified criteria. 
        /// </summary>
        public static async Task<bool> ExistsAsync(AccountCriteria criteria)
        {
            return await PetShop.Tests.ObjF.ParameterizedSQL.ExistsCommand.ExecuteAsync(criteria);
        }

        #endregion
 
        #region Enhancements

        public Account GetAccount(System.Int32 accountId)
        {
            return this.FirstOrDefault(i => i.AccountId == accountId);
        }

        public bool Contains(System.Int32 accountId)
        {
            return this.Count(i => i.AccountId == accountId) > 0;
        }
 
        public bool ContainsDeleted(System.Int32 accountId)
        {
            return DeletedList.Count(i => i.AccountId == accountId) > 0;
        }
        
        public void Remove(System.Int32 accountId)
        {
            var item = this.FirstOrDefault(i => i.AccountId == accountId);
            if (item != null)
                Remove(item);
        }

        #endregion
    }
}