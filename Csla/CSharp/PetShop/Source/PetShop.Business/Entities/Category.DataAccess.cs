﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#if !SILVERLIGHT && !NETFX_CORE
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using Csla;
using Csla.Data;

namespace PetShop.Business
{
    public partial class Category
    {
        #region Root Data Access

        [RunLocal]
        protected override void DataPortal_Create()
        {
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;


            BusinessRules.CheckRules();

            OnCreated();
        }

        private void DataPortal_Fetch(CategoryCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("SELECT [CategoryId], [Name], [Descn] FROM [dbo].[Category] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'dbo.Category' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            const string commandText = "INSERT INTO [dbo].[Category] ([CategoryId], [Name], [Descn]) VALUES (@p_CategoryId, @p_Name, @p_Descn)";
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                    LoadProperty(_originalCategoryIdProperty, this.CategoryId);
                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnInserted();

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            if(OriginalCategoryId != CategoryId)
            {
                // Insert new child.
                Category item = new Category {CategoryId = CategoryId, Name = Name, Description = Description};
                
                item = item.Save();

                // Mark editable child lists as dirty. This code may need to be updated to one-to-one relationships.
                foreach(Product itemToUpdate in Products)
                {
                itemToUpdate.CategoryId = CategoryId;
                }

                // Create a new connection.
                using (var connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    FieldManager.UpdateChildren(this, connection);
                }

                // Delete the old.
                var criteria = new CategoryCriteria {CategoryId = OriginalCategoryId};
                
                DataPortal_Delete(criteria);

                // Mark the original as the new one.
                OriginalCategoryId = CategoryId;

                OnUpdated();

                return;
            }

            const string commandText = "UPDATE [dbo].[Category] SET [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn WHERE [CategoryId] = @p_OriginalCategoryId; SELECT [CategoryId] FROM [dbo].[Category] WHERE [CategoryId] = @p_OriginalCategoryId";
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_OriginalCategoryId", this.OriginalCategoryId);
                command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                    LoadProperty(_originalCategoryIdProperty, this.CategoryId);
                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnUpdated();
        }

        protected override void DataPortal_DeleteSelf()
        {
            bool cancel = false;
            OnSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new CategoryCriteria (CategoryId));
        
            OnSelfDeleted();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(CategoryCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("DELETE FROM [dbo].[Category] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
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

        //[Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(CategoryCriteria criteria, SqlConnection connection)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("DELETE FROM [dbo].[Category] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            OnDeleted();
        }

        #endregion

        #region Child Data Access

        protected override void Child_Create()
        {
            bool cancel = false;
            OnChildCreating(ref cancel);
            if (cancel) return;


            BusinessRules.CheckRules();

            OnChildCreated();
        }

        private void Child_Fetch(CategoryCriteria criteria)
        {
            bool cancel = false;
            OnChildFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("SELECT [CategoryId], [Name], [Descn] FROM [dbo].[Category] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'dbo.Category' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnChildFetched();


            MarkAsChild();
        }

        #region Child_Insert

        private void Child_Insert(SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "INSERT INTO [dbo].[Category] ([CategoryId], [Name], [Descn]) VALUES (@p_CategoryId, @p_Name, @p_Descn)";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update the original non-identity primary key value.
                LoadProperty(_originalCategoryIdProperty, this.CategoryId);
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildInserted();
        }

        #endregion

        #region Child_Update

        private void Child_Update(SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "UPDATE [dbo].[Category] SET [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn WHERE [CategoryId] = @p_OriginalCategoryId; SELECT [CategoryId] FROM [dbo].[Category] WHERE [CategoryId] = @p_OriginalCategoryId";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_OriginalCategoryId", this.OriginalCategoryId);
                command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));

                // result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update non-identity primary key value.
                LoadProperty(_originalCategoryIdProperty, this.CategoryId);
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }
        #endregion

        private void Child_DeleteSelf()
        {
            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new CategoryCriteria (CategoryId));
        
            OnChildSelfDeleted();
        }

        private void Child_DeleteSelf(params object[] args)
        {
            var connection = args.OfType<SqlConnection>().FirstOrDefault();
            if(connection == null)
                throw new ArgumentNullException("args", "Must contain a SqlConnection parameter.");

            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;

            DataPortal_Delete(new CategoryCriteria (CategoryId), connection);

            OnChildSelfDeleted();
        }

        #endregion

        #region Map

        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                LoadProperty(_categoryIdProperty, reader["CategoryId"]);
                LoadProperty(_originalCategoryIdProperty, reader["CategoryId"]);
                LoadProperty(_nameProperty, reader["Name"]);
                LoadProperty(_descriptionProperty, reader["Descn"]);
            }

            OnMapped();
        }
        
        private void Child_Fetch(SafeDataReader reader)
        {
            Map(reader);
        }

        #endregion
    }
}
#endif