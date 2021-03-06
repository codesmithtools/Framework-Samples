﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v3.8.4.
//       Changes to this template will not be lost.
//
//     Template: EditableRootList.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using Csla;

#endregion

namespace PetShop.Tests.StoredProcedures
{
    public partial class OrderList
    {
        #region Authorization Rules

        protected void AddAuthorizationRules()
        {
            //// More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

            //string[] canWrite = { "AdminUser", "RegularUser" };
            //string[] canRead = { "AdminUser", "RegularUser", "ReadOnlyUser" };
            //string[] admin = { "AdminUser" };

            // AuthorizationRules.AllowCreate(typeof(OrderList), admin);
            // AuthorizationRules.AllowDelete(typeof(OrderList), admin);
            // AuthorizationRules.AllowEdit(typeof(OrderList), canWrite);
            // AuthorizationRules.AllowGet(typeof(OrderList), canRead);

            //// OrderId
            // AuthorizationRules.AllowWrite(_orderIdProperty, canWrite);
            // AuthorizationRules.AllowRead(_orderIdProperty, canRead);

            //// UserId
            // AuthorizationRules.AllowRead(_userIdProperty, canRead);

            //// OrderDate
            // AuthorizationRules.AllowRead(_orderDateProperty, canRead);

            //// ShipAddr1
            // AuthorizationRules.AllowRead(_shipAddr1Property, canRead);

            //// ShipAddr2
            // AuthorizationRules.AllowRead(_shipAddr2Property, canRead);

            //// ShipCity
            // AuthorizationRules.AllowRead(_shipCityProperty, canRead);

            //// ShipState
            // AuthorizationRules.AllowRead(_shipStateProperty, canRead);

            //// ShipZip
            // AuthorizationRules.AllowRead(_shipZipProperty, canRead);

            //// ShipCountry
            // AuthorizationRules.AllowRead(_shipCountryProperty, canRead);

            //// BillAddr1
            // AuthorizationRules.AllowRead(_billAddr1Property, canRead);

            //// BillAddr2
            // AuthorizationRules.AllowRead(_billAddr2Property, canRead);

            //// BillCity
            // AuthorizationRules.AllowRead(_billCityProperty, canRead);

            //// BillState
            // AuthorizationRules.AllowRead(_billStateProperty, canRead);

            //// BillZip
            // AuthorizationRules.AllowRead(_billZipProperty, canRead);

            //// BillCountry
            // AuthorizationRules.AllowRead(_billCountryProperty, canRead);

            //// Courier
            // AuthorizationRules.AllowRead(_courierProperty, canRead);

            //// TotalPrice
            // AuthorizationRules.AllowRead(_totalPriceProperty, canRead);

            //// BillToFirstName
            // AuthorizationRules.AllowRead(_billToFirstNameProperty, canRead);

            //// BillToLastName
            // AuthorizationRules.AllowRead(_billToLastNameProperty, canRead);

            //// ShipToFirstName
            // AuthorizationRules.AllowRead(_shipToFirstNameProperty, canRead);

            //// ShipToLastName
            // AuthorizationRules.AllowRead(_shipToLastNameProperty, canRead);

            //// AuthorizationNumber
            // AuthorizationRules.AllowRead(_authorizationNumberProperty, canRead);

            //// Locale
            // AuthorizationRules.AllowRead(_localeProperty, canRead);

// NOTE: Many-To-Many support coming soon.
            //// LineItems
            // AuthorizationRules.AllowRead(_lineItemsProperty, canRead);

            //// OrderStatuses
            // AuthorizationRules.AllowRead(_orderStatusesProperty, canRead);

        }
        #endregion

    }
}