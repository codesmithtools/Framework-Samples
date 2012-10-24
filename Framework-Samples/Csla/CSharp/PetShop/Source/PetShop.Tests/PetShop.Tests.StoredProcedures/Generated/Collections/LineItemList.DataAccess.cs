﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'LineItemList.cs'.
//
//     Template: EditableRootList.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;

namespace PetShop.Tests.StoredProcedures
{
    public partial class LineItemList
    {
        [RunLocal]
        protected override void DataPortal_Create()
        {
        }

        private void DataPortal_Fetch(LineItemCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            // Fetch Child objects.
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[CSLA_LineItem_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                this.Add(PetShop.Tests.StoredProcedures.LineItem.GetLineItem(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            RaiseListChangedEvents = true;

            OnFetched();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            for (int index = 0; index < DeletedList.Count; index++)
            {
                DeletedList[index] = DeletedList[index].Save();
            }
           
            DeletedList.Clear();

            for (int index = 0; index < Items.Count; index++)
            {
                Items[index] = Items[index].Save();
            }

            RaiseListChangedEvents = true;

            OnUpdated();
        }
    }
}
