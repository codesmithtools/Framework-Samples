﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ProductList.cs'.
//
//     Template: DynamicRootList.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#if !SILVERLIGHT
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Business
{
    public partial class ProductList
    {
        private void DataPortal_Create()
        {
        }

        private void DataPortal_Fetch(ProductCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            // Fetch Child objects.
            string commandText = String.Format("SELECT [ProductId], [CategoryId], [Name], [Descn], [Image] FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                this.Add(PetShop.Business.Product.GetProduct(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            RaiseListChangedEvents = true;

            OnFetched();
        }
    }
}
#endif
