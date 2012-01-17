﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'CategoryInfoList.cs'.
//
//     Template: ReadOnlyChildList.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------

#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.Collections.ReadOnlyChild
{
    public partial class CategoryInfoList
    {
        private void Child_Fetch(CategoryCriteria criteria)
        {
            IsReadOnly = false;

            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            // Fetch Child objects.
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Category_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue);
					command.Parameters.AddWithValue("@p_DescnHasValue", criteria.DescriptionHasValue);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                this.Add(new PetShop.Tests.Collections.ReadOnlyChild.CategoryInfo(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            RaiseListChangedEvents = true;

            OnFetched();

            IsReadOnly = true;
        }
    }
}
