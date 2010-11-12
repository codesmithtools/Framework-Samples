using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Sample.Data.Generated.BusinessObjects;
using Sample.Data.Generated.Base;

namespace Sample.Data.Generated.ManagerObjects
{
    public partial interface ICategoryManager : IManagerBase<Sample.Data.Generated.BusinessObjects.Category, string>
    {
		// Get Methods
    }

    partial class CategoryManager : ManagerBase<Sample.Data.Generated.BusinessObjects.Category, string>, ICategoryManager
    {
		#region Constructors
		
		public CategoryManager() : base()
        {
        }
        public CategoryManager(INHibernateSession session) : base(session)
        {
        }
		
		#endregion
		
        #region Get Methods

		
		#endregion
    }
}