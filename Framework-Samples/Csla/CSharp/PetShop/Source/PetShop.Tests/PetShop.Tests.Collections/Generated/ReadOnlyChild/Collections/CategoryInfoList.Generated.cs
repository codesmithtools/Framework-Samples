﻿
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template: ReadOnlyChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.Collections.ReadOnlyChild
{
    [Serializable]
    public partial class CategoryInfoList : ReadOnlyListBase< CategoryInfoList, CategoryInfo >
    {
    
        #region Constructor(s)

        private CategoryInfoList()
        { /* Require use of factory methods */ }
        
        #endregion
    
        #region Synchronous Factory Methods     

        internal static CategoryInfoList GetByCategoryId(System.String categoryId)
        {
            var criteria = new CategoryCriteria{CategoryId = categoryId};
            
            
            return DataPortal.FetchChild< CategoryInfoList >(criteria);
        }

        internal static CategoryInfoList GetAll()
        {
            return DataPortal.FetchChild< CategoryInfoList >(new CategoryCriteria());
        }
    
        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(CategoryCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref CategoryInfo item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(CategoryCriteria criteria)
        {
            return PetShop.Tests.Collections.ReadOnlyChild.CategoryInfo.Exists(criteria);
        }

        #endregion

    }
}