using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Sample.Data.Generated.BusinessObjects;
using Sample.Data.Generated.Base;

namespace Sample.Data.Generated.ManagerObjects
{
    public partial interface IOrderManager : IManagerBase<Sample.Data.Generated.BusinessObjects.Order, int>
    {
		// Get Methods
    }

    partial class OrderManager : ManagerBase<Sample.Data.Generated.BusinessObjects.Order, int>, IOrderManager
    {
		#region Constructors
		
		public OrderManager() : base()
        {
        }
        public OrderManager(INHibernateSession session) : base(session)
        {
        }
		
		#endregion
		
        #region Get Methods

		
		#endregion
    }
}