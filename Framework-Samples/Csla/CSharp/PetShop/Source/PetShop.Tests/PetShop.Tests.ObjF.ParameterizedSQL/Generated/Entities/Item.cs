﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v3.8.4.
//       Changes to this template will not be lost.
//
//     Template: SwitchableObject.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Security;
using Csla.Validation;

#endregion

namespace PetShop.Tests.ObjF.ParameterizedSQL
{
    public partial class Item
    {
        #region Business Rules

        /// <summary>
        /// All custom rules need to be placed in this method.
        /// </summary>
        /// <returns>Return true to override the generated rules; If false generated rules will be run.</returns>
        protected bool AddBusinessValidationRules()
        {
            // TODO: add validation rules
            //ValidationRules.AddRule(RuleMethod, "");

            return false;
        }

        #endregion

        #region Authorization Rules

        protected override void AddAuthorizationRules()
        {
            //// More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

            //string[] canWrite = { "AdminUser", "RegularUser" };
            //string[] canRead = { "AdminUser", "RegularUser", "ReadOnlyUser" };
            //string[] admin = { "AdminUser" };

            // AuthorizationRules.AllowCreate(typeof(Item), admin);
            // AuthorizationRules.AllowDelete(typeof(Item), admin);
            // AuthorizationRules.AllowEdit(typeof(Item), canWrite);
            // AuthorizationRules.AllowGet(typeof(Item), canRead);

            //// ItemId
            // AuthorizationRules.AllowRead(_itemIdProperty, canRead);

            //// ProductId
            // AuthorizationRules.AllowRead(_productIdProperty, canRead);

            //// ListPrice
            // AuthorizationRules.AllowRead(_listPriceProperty, canRead);

            //// UnitCost
            // AuthorizationRules.AllowRead(_unitCostProperty, canRead);

            //// Supplier
            // AuthorizationRules.AllowRead(_supplierProperty, canRead);

            //// Status
            // AuthorizationRules.AllowRead(_statusProperty, canRead);

            //// Name
            // AuthorizationRules.AllowRead(_nameProperty, canRead);

            //// Image
            // AuthorizationRules.AllowRead(_imageProperty, canRead);

            //// ProductMember
            // AuthorizationRules.AllowRead(_productMemberProperty, canRead);

            //// SupplierMember
            // AuthorizationRules.AllowRead(_supplierMemberProperty, canRead);

// NOTE: Many-To-Many support coming soon.
        }
        #endregion
    }
}