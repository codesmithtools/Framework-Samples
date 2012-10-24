﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'LineItemList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
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
    public partial class LineItemList : BusinessListBase<LineItemList, LineItem>
    {    
        #region Contructor(s)

        public LineItemList()
        { 
            AllowNew = true;
        }

        #endregion

        #region Method Overrides
#if !SILVERLIGHT
        protected override LineItem AddNewCore()
        {
            LineItem item = PetShop.Business.LineItem.NewLineItemChild();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.LineItem.NewLineItemChild();

                // Pass the parent value down to the child.
                Order order = this.Parent as Order;
                if(order != null)
                    item.OrderId = order.OrderId;


                Add(item);
            }

            return item;
        }
#else
        protected override void AddNewCore()
        {
            PetShop.Business.LineItem.NewLineItemChildAsync().ContinueWith(t => 
            {
                LineItem item = t.Result;

                bool cancel = false;
                OnAddNewCore(ref item, ref cancel);
                if (!cancel)
                {
                    // Check to see if someone set the item to null in the OnAddNewCore.
                    if(item == null)
                        return;
                    // Pass the parent value down to the child.
                    Order order = this.Parent as Order;
                    if(order != null)
                        item.OrderId = order.OrderId;
    
                    Add(item);
                }
            });
        }
#endif
        
        #endregion

        #region Synchronous Factory Methods 
#if !SILVERLIGHT

        /// <summary>
        /// Creates a new object of type <see cref="LineItemList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="LineItemList"/>.</returns>
        public static LineItemList NewList()
        {
            return DataPortal.Create<LineItemList>();
        }      

        /// <summary>
        /// Returns a <see cref="LineItemList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <param name="lineNum">No additional detail available.</param>
        /// <returns>A <see cref="LineItemList"/> object of the specified criteria.</returns>
        public static LineItemList GetByOrderIdLineNum(System.Int32 orderId, System.Int32 lineNum)
        {
            var criteria = new LineItemCriteria{OrderId = orderId, LineNum = lineNum};
            
            
            return DataPortal.Fetch<LineItemList>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="LineItemList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <returns>A <see cref="LineItemList"/> object of the specified criteria.</returns>
        public static LineItemList GetByOrderId(System.Int32 orderId)
        {
            var criteria = new LineItemCriteria{OrderId = orderId};
            
            
            return DataPortal.Fetch<LineItemList>(criteria);
        }

        public static LineItemList GetByCriteria(LineItemCriteria criteria)
        {
            return DataPortal.Fetch<LineItemList>(criteria);
        }
        
        public static LineItemList GetAll()
        {
            return DataPortal.Fetch<LineItemList>(new LineItemCriteria());
        }

#endif
        #endregion

        #region Asynchronous Factory Methods

        public static async Task<LineItemList> NewListAsync()
        {
            return await DataPortal.CreateAsync<LineItemList>();
        }


        public static async Task<LineItemList> GetByOrderIdLineNumAsync(System.Int32 orderId, System.Int32 lineNum)
        {
            var criteria = new LineItemCriteria{OrderId = orderId, LineNum = lineNum};
            
            
            return await DataPortal.FetchAsync<LineItemList>(criteria);
        }

        public static async Task<LineItemList> GetByOrderIdAsync(System.Int32 orderId)
        {
            var criteria = new LineItemCriteria{OrderId = orderId};
            
            
            return await DataPortal.FetchAsync<LineItemList>(criteria);
        }

        public static async Task<LineItemList> GetByCriteriaAsync(LineItemCriteria criteria)
        {  
            return await DataPortal.FetchAsync<LineItemList>(criteria);
        }

        public static async Task<LineItemList> GetAllAsync()
        {
            return await DataPortal.FetchAsync<LineItemList>(new LineItemCriteria());
        }

        #endregion

        #region DataPortal partial methods

#if !SILVERLIGHT
        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="LineItem"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="LineItemCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(LineItemCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="LineItem"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="LineItem"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="LineItem"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
#endif
        partial void OnAddNewCore(ref LineItem item, ref bool cancel);

        #endregion

        #region Exists Command

#if !SILVERLIGHT
        /// <summary>
        /// Determines if a record exists in the LineItem in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is a <see cref="LineItemList"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(LineItemCriteria criteria)
        {
            return PetShop.Business.LineItem.Exists(criteria);
        }
#endif
        /// <summary>
        /// Determines if a record exists in the LineItem in the database for the specified criteria. 
        /// </summary>
        public static async Task<bool> ExistsAsync(LineItemCriteria criteria)
        {
            return await PetShop.Business.ExistsCommand.ExecuteAsync(criteria);
        }

        #endregion
 
        #region Enhancements

        public LineItem GetLineItem(System.Int32 orderId, System.Int32 lineNum)
        {
            return this.FirstOrDefault(i => i.OrderId == orderId && i.LineNum == lineNum);
        }

        public bool Contains(System.Int32 orderId, System.Int32 lineNum)
        {
            return this.Count(i => i.OrderId == orderId && i.LineNum == lineNum) > 0;
        }
 
        public bool ContainsDeleted(System.Int32 orderId, System.Int32 lineNum)
        {
            return DeletedList.Count(i => i.OrderId == orderId && i.LineNum == lineNum) > 0;
        }
        
        public void Remove(System.Int32 orderId, System.Int32 lineNum)
        {
            var item = this.FirstOrDefault(i => i.OrderId == orderId && i.LineNum == lineNum);
            if (item != null)
                Remove(item);
        }

        #endregion
    }
}