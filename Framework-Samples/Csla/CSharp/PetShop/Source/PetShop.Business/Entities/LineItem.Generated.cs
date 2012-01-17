﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'LineItem.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Rules;
#if SILVERLIGHT
using Csla.Serialization;
#else
using Csla.Data;
using System.Data.SqlClient;
#endif

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class LineItem : BusinessBase< LineItem >
    {
        #region Contructor(s)

#if !SILVERLIGHT
        private LineItem()
        { /* Require use of factory methods */ }
#else
    public LineItem()
        { /* Require use of factory methods */ }
#endif

        internal LineItem(System.Int32 orderId, System.Int32 lineNum)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_orderIdProperty, orderId);
                LoadProperty(_lineNumProperty, lineNum);
            }
        }

#if !SILVERLIGHT
        internal LineItem(SafeDataReader reader)
        {
            Map(reader);
            MarkAsChild();  
        }
#endif
        #endregion

        #region Business Rules

        /// <summary>
        /// Contains the Codesmith generated validation rules.
        /// </summary>
        protected override void AddBusinessRules()
        {
            // Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            base.AddBusinessRules();

            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_itemIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_itemIdProperty, 10));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.Int32 > _orderIdProperty = RegisterProperty< System.Int32 >(p => p.OrderId, string.Empty);
#if !SILVERLIGHT
		[System.ComponentModel.DataObjectField(true, false)]
#endif
        public System.Int32 OrderId
        {
            get { return GetProperty(_orderIdProperty); }
            set{ SetProperty(_orderIdProperty, value); }
        }

        private static readonly PropertyInfo< System.Int32 > _originalOrderIdProperty = RegisterProperty< System.Int32 >(p => p.OriginalOrderId, string.Empty);
        /// <summary>
        /// Holds the original value for OrderId. This is used for non identity primary keys.
        /// </summary>
        internal System.Int32 OriginalOrderId
        {
            get { return GetProperty(_originalOrderIdProperty); }
            set{ SetProperty(_originalOrderIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _lineNumProperty = RegisterProperty< System.Int32 >(p => p.LineNum, string.Empty);
#if !SILVERLIGHT
		[System.ComponentModel.DataObjectField(true, false)]
#endif
        public System.Int32 LineNum
        {
            get { return GetProperty(_lineNumProperty); }
            set{ SetProperty(_lineNumProperty, value); }
        }

        private static readonly PropertyInfo< System.Int32 > _originalLineNumProperty = RegisterProperty< System.Int32 >(p => p.OriginalLineNum, string.Empty);
        /// <summary>
        /// Holds the original value for LineNum. This is used for non identity primary keys.
        /// </summary>
        internal System.Int32 OriginalLineNum
        {
            get { return GetProperty(_originalLineNumProperty); }
            set{ SetProperty(_originalLineNumProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _itemIdProperty = RegisterProperty< System.String >(p => p.ItemId, string.Empty);
        public System.String ItemId
        {
            get { return GetProperty(_itemIdProperty); }
            set{ SetProperty(_itemIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _quantityProperty = RegisterProperty< System.Int32 >(p => p.Quantity, string.Empty);
        public System.Int32 Quantity
        {
            get { return GetProperty(_quantityProperty); }
            set{ SetProperty(_quantityProperty, value); }
        }
        private static readonly PropertyInfo< System.Decimal > _unitPriceProperty = RegisterProperty< System.Decimal >(p => p.UnitPrice, string.Empty);
        public System.Decimal UnitPrice
        {
            get { return GetProperty(_unitPriceProperty); }
            set{ SetProperty(_unitPriceProperty, value); }
        }


        //AssociatedManyToOne
        private static readonly PropertyInfo< Order > _orderMemberProperty = RegisterProperty< Order >(p => p.OrderMember, Csla.RelationshipTypes.Child);
        public Order OrderMember
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_orderMemberProperty, ref cancel);

                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_orderMemberProperty))
                    {
                        var criteria = new PetShop.Business.OrderCriteria {OrderId = OrderId};
                        
#if SILVERLIGHT
                        //MarkBusy();
                        PetShop.Business.Order.Exists(criteria, (o,e) =>
                        {
                            if(e.Error != null)
                                throw e.Error;
                                
                            if(e.Object.Result)
                                PetShop.Business.Order.GetByOrderIdAsync(OrderId, (o1, e1) =>
                                    {
                                        if (e1.Error != null)
                                            throw e1.Error; 
    
                                        this.LoadProperty(_orderMemberProperty, e1.Object);
    
                                        //MarkIdle();
                                        OnPropertyChanged(_orderMemberProperty);
                                    });
                        });
#else
                        if(PetShop.Business.Order.Exists(criteria))
                            LoadProperty(_orderMemberProperty, PetShop.Business.Order.GetByOrderId(OrderId));
#endif
                    }
                }

                return GetProperty(_orderMemberProperty); 
            }
        }



        #endregion

#if !SILVERLIGHT
        #region Synchronous Root Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="LineItem"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="LineItem"/>.</returns>	
        public static LineItem NewLineItem()
        {
            return DataPortal.Create< LineItem >();
        }

        /// <summary>
        /// Returns a <see cref="LineItem"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <param name="lineNum">No additional detail available.</param>
        /// <returns>A <see cref="LineItem"/> object of the specified criteria.</returns>
        public static LineItem GetByOrderIdLineNum(System.Int32 orderId, System.Int32 lineNum)
        {
            var criteria = new LineItemCriteria {OrderId = orderId, LineNum = lineNum};
            
            
            return DataPortal.Fetch< LineItem >(criteria);
        }

        /// <summary>
        /// Returns a <see cref="LineItem"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <returns>A <see cref="LineItem"/> object of the specified criteria.</returns>
        public static LineItem GetByOrderId(System.Int32 orderId)
        {
            var criteria = new LineItemCriteria {OrderId = orderId};
            
            
            return DataPortal.Fetch< LineItem >(criteria);
        }

        public static void DeleteLineItem(System.Int32 orderId, System.Int32 lineNum)
        {
                DataPortal.Delete< LineItem >(new LineItemCriteria (orderId, lineNum));
        }
        
        #endregion
#endif        

        #region Asynchronous Root Factory Methods
        
        public static void NewLineItemAsync(EventHandler<DataPortalResult<LineItem>> handler)
        {
            var dp = new DataPortal< LineItem >();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        public static void GetByOrderIdLineNumAsync(System.Int32 orderId, System.Int32 lineNum, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{OrderId = orderId, LineNum = lineNum};
            

            var dp = new DataPortal< LineItem >();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByOrderIdAsync(System.Int32 orderId, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{OrderId = orderId};
            

            var dp = new DataPortal< LineItem >();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void DeleteLineItemAsync(System.Int32 orderId, System.Int32 lineNum, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{OrderId = orderId, LineNum = lineNum};
            

            var dp = new DataPortal< LineItem >();
            dp.DeleteCompleted += handler;
            dp.BeginDelete(criteria);
        }
        
        #endregion

#if !SILVERLIGHT

        #region Synchronous Child Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="LineItem"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="LineItem"/>.</returns>
        internal static LineItem NewLineItemChild()
        {
            return DataPortal.CreateChild< LineItem >();
        }

        /// <summary>
        /// Returns a <see cref="LineItem"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <param name="lineNum">No additional detail available.</param>
        /// <returns>A <see cref="LineItem"/> object of the specified criteria.</returns>

        internal static LineItem GetByOrderIdLineNumChild(System.Int32 orderId, System.Int32 lineNum)
        {
            var criteria = new LineItemCriteria {OrderId = orderId, LineNum = lineNum};
            

            return DataPortal.FetchChild< LineItem >(criteria);
        }

        /// <summary>
        /// Returns a <see cref="LineItem"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <returns>A <see cref="LineItem"/> object of the specified criteria.</returns>

        internal static LineItem GetByOrderIdChild(System.Int32 orderId)
        {
            var criteria = new LineItemCriteria {OrderId = orderId};
            

            return DataPortal.FetchChild< LineItem >(criteria);
        }

        #endregion
#endif        

        #region Asynchronous Child Factory Methods
        
        internal static void NewLineItemChildAsync(EventHandler<DataPortalResult<LineItem>> handler)
        {
            DataPortal<LineItem> dp = new DataPortal<LineItem>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        internal static void GetByOrderIdLineNumChildAsync(System.Int32 orderId, System.Int32 lineNum, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{ OrderId = orderId, LineNum = lineNum};
            
            
            // Mark as child?
            var dp = new DataPortal< LineItem >();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        internal static void GetByOrderIdChildAsync(System.Int32 orderId, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{ OrderId = orderId};
            
            
            // Mark as child?
            var dp = new DataPortal< LineItem >();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        #endregion
        #region DataPortal partial methods

#if !SILVERLIGHT
        /// <summary>
        /// Codesmith generated stub method that is called when creating the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="LineItem"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// Codesmith generated stub method that is called when fetching the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="LineItemCriteria"/> object containg the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(LineItemCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="LineItem"/> object has been fetched. 
        /// </summary>	
        partial void OnFetched();

        /// <summary>
        /// Codesmith generated stub method that is called when mapping the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="LineItem"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// Codesmith generated stub method that is called when inserting the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="LineItem"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// Codesmith generated stub method that is called when updating the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="LineItem"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// Codesmith generated stub method that is called when self deleting the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="LineItem"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// Codesmith generated stub method that is called when deleting the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="LineItemCriteria"/> object containg the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(LineItemCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="LineItem"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
#endif
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region ChildPortal partial methods

#if !SILVERLIGHT

        /// <summary>
        /// Codesmith generated stub method that is called when creating the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="LineItem"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// Codesmith generated stub method that is called when fetching the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="LineItemCriteria"/> object containg the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(LineItemCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="LineItem"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// Codesmith generated stub method that is called when inserting the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel);
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="LineItem"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// Codesmith generated stub method that is called when updating the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel);
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="LineItem"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// Codesmith generated stub method that is called when self deleting the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="LineItem"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();
#endif
        #endregion
        #region Exists Command
#if !SILVERLIGHT

        /// <summary>
        /// Determines if a record exists in the LineItem table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="LineItem"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(LineItemCriteria criteria)
        {
            return PetShop.Business.ExistsCommand.Execute(criteria);
		}

#else

        public static void Exists(LineItemCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            PetShop.Business.ExistsCommand.Execute(criteria, handler);
        }

#endif

        #endregion


        #region Protected Overriden Method(s)

        /// <summary>
        /// Creates a GUID identifier needed to uniquely identify records with a composite key.
        /// </summary>
        /// <returns>Returns a new GUID identifier.</returns>
        private readonly Guid _guidID = Guid.NewGuid();
        protected override object GetIdValue()
        {
            return _guidID;
        }

        #endregion
    }
}