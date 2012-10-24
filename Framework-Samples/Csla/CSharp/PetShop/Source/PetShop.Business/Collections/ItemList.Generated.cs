﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ItemList.cs'.
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
#if SILVERLIGHT
using Csla.Serialization;
#else
using Csla.Data;
#endif

namespace PetShop.Business
{
    [Serializable]
    public partial class ItemList : BusinessListBase<ItemList, Item>
    {
        #region Constructor(s)

        public ItemList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Synchronous Factory Methods 
#if !SILVERLIGHT

        /// <summary>
        /// Creates a new object of type <see cref="ItemList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="ItemList"/>.</returns>
        internal static ItemList NewList()
        {
            return DataPortal.CreateChild<ItemList>();
        }     

        /// <summary>
        /// Returns a <see cref="ItemList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="itemId">No additional detail available.</param>
        /// <returns>A <see cref="ItemList"/> object of the specified criteria.</returns>
        internal static ItemList GetByItemId(System.String itemId)
        {
            var criteria = new ItemCriteria{ItemId = itemId};
            
            
            return DataPortal.FetchChild<ItemList>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="ItemList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="productId">No additional detail available.</param>
        /// <returns>A <see cref="ItemList"/> object of the specified criteria.</returns>
        internal static ItemList GetByProductId(System.String productId)
        {
            var criteria = new ItemCriteria{ProductId = productId};
            
            
            return DataPortal.FetchChild<ItemList>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="ItemList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="supplier">No additional detail available.</param>
        /// <returns>A <see cref="ItemList"/> object of the specified criteria.</returns>
        internal static ItemList GetBySupplier(System.Int32? supplier)
        {
            var criteria = new ItemCriteria{};
                            if(supplier.HasValue) criteria.Supplier = supplier.Value;
            
            return DataPortal.FetchChild<ItemList>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="ItemList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="productId">No additional detail available.</param>
        /// <param name="itemId">No additional detail available.</param>
        /// <param name="listPrice">No additional detail available.</param>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="ItemList"/> object of the specified criteria.</returns>
        internal static ItemList GetByProductIdItemIdListPriceName(System.String productId, System.String itemId, System.Decimal? listPrice, System.String name)
        {
            var criteria = new ItemCriteria{ProductId = productId, ItemId = itemId, Name = name};
                            if(listPrice.HasValue) criteria.ListPrice = listPrice.Value;
            
            return DataPortal.FetchChild<ItemList>(criteria);
        }

        internal static ItemList GetByCriteria(ItemCriteria criteria)
        {
            return DataPortal.Fetch<ItemList>(criteria);
        }

        internal static ItemList GetAll()
        {
            return DataPortal.FetchChild<ItemList>(new ItemCriteria());
        }

#endif
        #endregion

        #region Asynchronous Factory Methods

        internal static async Task<ItemList> NewListAsync()
        {
            return await DataPortal.CreateAsync<ItemList>();
        }

        internal static async Task<ItemList> GetByItemIdAsync(System.String itemId)
        {
            var criteria = new ItemCriteria{ItemId = itemId};
            
            
            return await DataPortal.FetchAsync<AsyncChildLoader<ItemList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<ItemList> GetByProductIdAsync(System.String productId)
        {
            var criteria = new ItemCriteria{ProductId = productId};
            
            
            return await DataPortal.FetchAsync<AsyncChildLoader<ItemList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<ItemList> GetBySupplierAsync(System.Int32? supplier)
        {
            var criteria = new ItemCriteria{};
                            if(supplier.HasValue) criteria.Supplier = supplier.Value;
            
            return await DataPortal.FetchAsync<AsyncChildLoader<ItemList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<ItemList> GetByProductIdItemIdListPriceNameAsync(System.String productId, System.String itemId, System.Decimal? listPrice, System.String name)
        {
            var criteria = new ItemCriteria{ProductId = productId, ItemId = itemId, Name = name};
                            if(listPrice.HasValue) criteria.ListPrice = listPrice.Value;
            
            return await DataPortal.FetchAsync<AsyncChildLoader<ItemList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<ItemList> GetByCriteriaAsync(ItemCriteria criteria)
        {  
            return await DataPortal.FetchAsync<AsyncChildLoader<ItemList>>(criteria).ContinueWith(t => t.Result.Child);
        }

        internal static async Task<ItemList> GetAllAsync()
        {
            return await DataPortal.FetchAsync<AsyncChildLoader<ItemList>>(new ItemCriteria()).ContinueWith(t => t.Result.Child);
        }

        #endregion

        #region Method Overrides
        
#if !SILVERLIGHT
        protected override Item AddNewCore()
        {
            Item item = PetShop.Business.Item.NewItemChild();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Item.NewItemChild();

                // Pass the parent value down to the child.
                Product product = this.Parent as Product;
                if(product != null)
                    item.ProductId = product.ProductId;

                // Pass the parent value down to the child.
                Supplier supplier = this.Parent as Supplier;
                if(supplier != null)
                    item.Supplier = supplier.SuppId;


                Add(item);
            }

            return item;
        }
#else
        protected override void AddNewCore()
        {
            PetShop.Business.Item.NewItemChildAsync().ContinueWith(t => 
            {
                Item item = t.Result;

                bool cancel = false;
                OnAddNewCore(ref item, ref cancel);
                if (!cancel)
                {
                    // Check to see if someone set the item to null in the OnAddNewCore.
                    if(item == null)
                        return;
                    // Pass the parent value down to the child.
                    Product product = this.Parent as Product;
                    if(product != null)
                        item.ProductId = product.ProductId;
    
                    // Pass the parent value down to the child.
                    Supplier supplier = this.Parent as Supplier;
                    if(supplier != null)
                        item.Supplier = supplier.SuppId;
    
                    Add(item);
                }
            });
        }
#endif

        protected async Task<Item> AddNewCoreAsync()
        {
            return await PetShop.Business.Item.NewItemChildAsync().ContinueWith(t => 
            {
                 Item item = t.Result;
                
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

#if !SILVERLIGHT
        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="Item"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Item"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="Item"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ItemCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(ItemCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Item"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Item"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="Item"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Item"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="Item"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Item"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
#endif
        partial void OnAddNewCore(ref Item item, ref bool cancel);

        #endregion

        #region Exists Command

#if !SILVERLIGHT
        /// <summary>
        /// Determines if a record exists in the Item in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is a <see cref="ItemList"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(ItemCriteria criteria)
        {
            return PetShop.Business.Item.Exists(criteria);
        }
#endif
        /// <summary>
        /// Determines if a record exists in the Item in the database for the specified criteria. 
        /// </summary>
        public static async Task<bool> ExistsAsync(ItemCriteria criteria)
        {
            return await PetShop.Business.ExistsCommand.ExecuteAsync(criteria);
        }

        #endregion
 
        #region Enhancements

        public Item GetItem(System.String itemId)
        {
            return this.FirstOrDefault(i => i.ItemId == itemId);
        }

        public bool Contains(System.String itemId)
        {
            return this.Count(i => i.ItemId == itemId) > 0;
        }
 
        public bool ContainsDeleted(System.String itemId)
        {
            return DeletedList.Count(i => i.ItemId == itemId) > 0;
        }
        
        public void Remove(System.String itemId)
        {
            var item = this.FirstOrDefault(i => i.ItemId == itemId);
            if (item != null)
                Remove(item);
        }

        #endregion
    }
}