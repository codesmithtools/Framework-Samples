﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'SupplierList.cs'.
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
#if SILVERLIGHT || NETFX_CORE
using Csla.Serialization;
#else
using Csla.Data;
#endif

namespace PetShop.Business
{
    [Serializable]
    public partial class SupplierList : BusinessListBase<SupplierList, Supplier>
    {
        #region Constructor(s)

        public SupplierList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Synchronous Factory Methods 
#if !SILVERLIGHT && !NETFX_CORE

        /// <summary>
        /// Creates a new object of type <see cref="SupplierList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="SupplierList"/>.</returns>
        internal static SupplierList NewList()
        {
            return DataPortal.CreateChild<SupplierList>();
        }     

        /// <summary>
        /// Returns a <see cref="SupplierList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="suppId">No additional detail available.</param>
        /// <returns>A <see cref="SupplierList"/> object of the specified criteria.</returns>
        internal static SupplierList GetBySuppId(System.Int32 suppId)
        {
            var criteria = new SupplierCriteria{SuppId = suppId};
            
            
            return DataPortal.FetchChild<SupplierList>(criteria);
        }

        internal static SupplierList GetByCriteria(SupplierCriteria criteria)
        {
            return DataPortal.Fetch<SupplierList>(criteria);
        }

        internal static SupplierList GetAll()
        {
            return DataPortal.FetchChild<SupplierList>(new SupplierCriteria());
        }

#endif
        #endregion

        #region Asynchronous Factory Methods

        internal static async Task<SupplierList> NewListAsync()
        {
            return await DataPortal.CreateAsync<SupplierList>();
        }

        internal static async Task<SupplierList> GetBySuppIdAsync(System.Int32 suppId)
        {
            var criteria = new SupplierCriteria{SuppId = suppId};
            
            
            return await DataPortal.FetchAsync<AsyncChildLoader<SupplierList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<SupplierList> GetByCriteriaAsync(SupplierCriteria criteria)
        {  
            return await DataPortal.FetchAsync<AsyncChildLoader<SupplierList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<SupplierList> GetAllAsync()
        {
            return await DataPortal.FetchAsync<AsyncChildLoader<SupplierList>>(new SupplierCriteria()).ContinueWith(t => t.Result.Child);
        }

        #endregion

        #region Method Overrides
        
#if !SILVERLIGHT && !NETFX_CORE
        protected override Supplier AddNewCore()
        {
            Supplier item = PetShop.Business.Supplier.NewSupplier();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Supplier.NewSupplier();


                Add(item);
            }

            return item;
        }
#else
        protected override void AddNewCore()
        {
            PetShop.Business.Supplier.NewSupplierAsync().ContinueWith(t => 
            {
                Supplier item = t.Result;

                bool cancel = false;
                OnAddNewCore(ref item, ref cancel);
                if (!cancel)
                {
                    // Check to see if someone set the item to null in the OnAddNewCore.
                    if(item == null)
                        return;
                    Add(item);
                }
            });
        }
#endif

        protected async Task<Supplier> AddNewCoreAsync()
        {
            return await PetShop.Business.Supplier.NewSupplierAsync().ContinueWith(t => 
            {
                 Supplier item = t.Result;
                
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

        #region DataPortal partial methods

#if !SILVERLIGHT && !NETFX_CORE
        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Supplier"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="SupplierCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(SupplierCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Supplier"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Supplier"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Supplier"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
#endif
        partial void OnAddNewCore(ref Supplier item, ref bool cancel);

        #endregion

        #region Exists Command

#if !SILVERLIGHT && !NETFX_CORE
        /// <summary>
        /// Determines if a record exists in the Supplier in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is a <see cref="SupplierList"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(SupplierCriteria criteria)
        {
            return PetShop.Business.Supplier.Exists(criteria);
        }
#endif
        /// <summary>
        /// Determines if a record exists in the Supplier in the database for the specified criteria. 
        /// </summary>
        public static async Task<bool> ExistsAsync(SupplierCriteria criteria)
        {
            return await PetShop.Business.ExistsCommand.ExecuteAsync(criteria);
        }

        #endregion
 
        #region Enhancements

        public Supplier GetSupplier(System.Int32 suppId)
        {
            return this.FirstOrDefault(i => i.SuppId == suppId);
        }

        public bool Contains(System.Int32 suppId)
        {
            return this.Count(i => i.SuppId == suppId) > 0;
        }
 
        public bool ContainsDeleted(System.Int32 suppId)
        {
            return DeletedList.Count(i => i.SuppId == suppId) > 0;
        }
        
        public void Remove(System.Int32 suppId)
        {
            var item = this.FirstOrDefault(i => i.SuppId == suppId);
            if (item != null)
                Remove(item);
        }

        #endregion
    }
}