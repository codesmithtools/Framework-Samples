﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Supplier.cs'.
//
//     Template: ObjectFactory.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;
using Csla.Server;

using PetShop.Tests.ObjF.ParameterizedSQL;

#endregion

namespace PetShop.Tests.ObjF.ParameterizedSQL.DAL
{
    public partial class SupplierFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new Supplier with default values.
        /// </summary>
        /// <returns>new Supplier.</returns>
        [RunLocal]
        public Supplier Create()
        {
            var item = (Supplier)Activator.CreateInstance(typeof(Supplier), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            using (BypassPropertyChecks(item))
            {
                // Default values.
            }

            CheckRules(item);
            MarkNew(item);
            OnCreated();

            return item;
        }

        /// <summary>
        /// Creates new Supplier with default values.
        /// </summary>
        /// <returns>new Supplier.</returns>
        [RunLocal]
        private Supplier Create(SupplierCriteria criteria)
        {
            var item = (Supplier)Activator.CreateInstance(typeof(Supplier), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            var resource = Fetch(criteria);
            using (BypassPropertyChecks(item))
            {
                item.Name = resource.Name;
                item.Status = resource.Status;
                item.Addr1 = resource.Addr1;
                item.Addr2 = resource.Addr2;
                item.City = resource.City;
                item.State = resource.State;
                item.Zip = resource.Zip;
                item.Phone = resource.Phone;
            }

            CheckRules(item);
            MarkNew(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch Supplier.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public Supplier Fetch(SupplierCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return null;

            Supplier item;
            string commandText = string.Format("SELECT [SuppId], [Name], [Status], [Addr1], [Addr2], [City], [State], [Zip], [Phone] FROM [dbo].[Supplier] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                            item = Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'Supplier' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
            return item;
        }

        #endregion

        #region Insert

        private void DoInsert(ref Supplier item, bool stopProccessingChildren)
        {
            // Don't update if the item isn't dirty.
            if (!item.IsDirty) return;

            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            const string commandText = "INSERT INTO [dbo].[Supplier] ([SuppId], [Name], [Status], [Addr1], [Addr2], [City], [State], [Zip], [Phone]) VALUES (@p_SuppId, @p_Name, @p_Status, @p_Addr1, @p_Addr2, @p_City, @p_State, @p_Zip, @p_Phone)";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_SuppId", item.SuppId);
					command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(item.Name));
					command.Parameters.AddWithValue("@p_Status", item.Status);
					command.Parameters.AddWithValue("@p_Addr1", ADOHelper.NullCheck(item.Addr1));
					command.Parameters.AddWithValue("@p_Addr2", ADOHelper.NullCheck(item.Addr2));
					command.Parameters.AddWithValue("@p_City", ADOHelper.NullCheck(item.City));
					command.Parameters.AddWithValue("@p_State", ADOHelper.NullCheck(item.State));
					command.Parameters.AddWithValue("@p_Zip", ADOHelper.NullCheck(item.Zip));
					command.Parameters.AddWithValue("@p_Phone", ADOHelper.NullCheck(item.Phone));

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                        }
                    }
                }
            }

            item.OriginalSuppId = item.SuppId;

            MarkOld(item);
            CheckRules(item);
            
            if(!stopProccessingChildren)
            {
            // Update Child Items.



                Update_Item_Items_Supplier(ref item);
            }

            OnInserted();
        }

        #endregion

        #region Update

        [Transactional(TransactionalTypes.TransactionScope)]
        public Supplier Update(Supplier item)
        {
            return Update(item, false);
        }

        public Supplier Update(Supplier item, bool stopProccessingChildren)
        {
            if(item.IsDeleted)
            {
                DoDelete(ref item);
                MarkNew(item);
            }
            else if(item.IsNew)
            {
                DoInsert(ref item, stopProccessingChildren);
            }
            else
            {
                DoUpdate(ref item, stopProccessingChildren);
            }

            return item;
        }

        private void DoUpdate(ref Supplier item, bool stopProccessingChildren)
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            // Don't update if the item isn't dirty.
            if (item.IsDirty)
            {
                if(item.OriginalSuppId != item.SuppId)
                {
                    // Insert new child.
                    var temp = (Supplier)Activator.CreateInstance(typeof(Supplier), true);
                    temp.SuppId = item.SuppId;
                    temp.Name = item.Name;
                    temp.Status = item.Status;
                    temp.Addr1 = item.Addr1;
                    temp.Addr2 = item.Addr2;
                    temp.City = item.City;
                    temp.State = item.State;
                    temp.Zip = item.Zip;
                    temp.Phone = item.Phone;
                    temp = temp.Save();
    
                    // Mark child lists as dirty. This code may need to be updated to one-to-one relationships.
                    foreach(Item itemToUpdate in item.Items)
                    {
				itemToUpdate.Supplier = item.SuppId;
                    }

                    // Update Children



                    Update_Item_Items_Supplier(ref item);
    
                    // Delete the old.
                    var criteria = new SupplierCriteria {SuppId = item.OriginalSuppId};
                    
                    Delete(criteria);
    
                    // Mark the original as the new one.
                    item.OriginalSuppId = item.SuppId;

                    MarkOld(item);
                    CheckRules(item);
                    OnUpdated();

                    return;
                }

                const string commandText = "UPDATE [dbo].[Supplier]  SET [SuppId] = @p_SuppId, [Name] = @p_Name, [Status] = @p_Status, [Addr1] = @p_Addr1, [Addr2] = @p_Addr2, [City] = @p_City, [State] = @p_State, [Zip] = @p_Zip, [Phone] = @p_Phone WHERE [SuppId] = @p_SuppId; SELECT [SuppId] FROM [dbo].[Supplier] WHERE [SuppId] = @p_OriginalSuppId";
                using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("@p_OriginalSuppId", item.OriginalSuppId);
					command.Parameters.AddWithValue("@p_SuppId", item.SuppId);
					command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(item.Name));
					command.Parameters.AddWithValue("@p_Status", item.Status);
					command.Parameters.AddWithValue("@p_Addr1", ADOHelper.NullCheck(item.Addr1));
					command.Parameters.AddWithValue("@p_Addr2", ADOHelper.NullCheck(item.Addr2));
					command.Parameters.AddWithValue("@p_City", ADOHelper.NullCheck(item.City));
					command.Parameters.AddWithValue("@p_State", ADOHelper.NullCheck(item.State));
					command.Parameters.AddWithValue("@p_Zip", ADOHelper.NullCheck(item.Zip));
					command.Parameters.AddWithValue("@p_Phone", ADOHelper.NullCheck(item.Phone));

                        //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        int result = command.ExecuteNonQuery();
                        if (result == 0)
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                    }
                }
            }

            item.OriginalSuppId = item.SuppId;

            MarkOld(item);
            CheckRules(item);

            if(!stopProccessingChildren)
            {
                // Update Child Items.



                Update_Item_Items_Supplier(ref item);
            }

            OnUpdated();
        }
        #endregion

        #region Delete

        [Transactional(TransactionalTypes.TransactionScope)]
        public void Delete(SupplierCriteria criteria)
        {
            // Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
            DoDelete(criteria);
        }

        protected void DoDelete(ref Supplier item)
        {
            // If we're not dirty then don't update the database.
            if (!item.IsDirty) return;

            // If we're new then don't call delete.
            if (item.IsNew) return;

            var criteria = new SupplierCriteria{SuppId = item.SuppId};
            
            DoDelete(criteria);

            MarkNew(item);
        }

        /// <summary>
        /// This call to delete is for immediate deletion and doesn't keep track of any entity state.
        /// </summary>
        /// <param name="criteria">The Criteria.</param>
        private void DoDelete(SupplierCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("DELETE FROM [dbo].[Supplier] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        #endregion

        #region Helper Methods

        public Supplier Map(SafeDataReader reader)
        {
            var item = (Supplier)Activator.CreateInstance(typeof(Supplier), true);
            using (BypassPropertyChecks(item))
            {
                item.SuppId = reader.GetInt32("SuppId");
                item.OriginalSuppId = reader.GetInt32("SuppId");
                item.Name = reader.GetString("Name");
                item.Status = reader.GetString("Status");
                item.Addr1 = reader.GetString("Addr1");
                item.Addr2 = reader.GetString("Addr2");
                item.City = reader.GetString("City");
                item.State = reader.GetString("State");
                item.Zip = reader.GetString("Zip");
                item.Phone = reader.GetString("Phone");
            }
            
            MarkOld(item);

            return item;
        }




        //AssociatedOneToMany
        private static void Update_Item_Items_Supplier(ref Supplier item)
        {
            foreach(Item itemToUpdate in item.Items)
            {
				itemToUpdate.Supplier = item.SuppId;

                new ItemFactory().Update(itemToUpdate, true);
            }
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// Codesmith generated stub method that is called when creating the <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Supplier"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// Codesmith generated stub method that is called when fetching the <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="SupplierCriteria"/> object containg the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(SupplierCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Supplier"/> object has been fetched. 
        /// </summary>	
        partial void OnFetched();

        /// <summary>
        /// Codesmith generated stub method that is called when mapping the <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Supplier"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// Codesmith generated stub method that is called when inserting the <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Supplier"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// Codesmith generated stub method that is called when updating the <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Supplier"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// Codesmith generated stub method that is called when self deleting the <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Supplier"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// Codesmith generated stub method that is called when deleting the <see cref="Supplier"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="SupplierCriteria"/> object containg the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(SupplierCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Supplier"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
    }
}