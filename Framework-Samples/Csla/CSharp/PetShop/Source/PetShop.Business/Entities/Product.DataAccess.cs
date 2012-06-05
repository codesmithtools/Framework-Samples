﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Product.cs'.
//
//     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#if !SILVERLIGHT
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using Csla;
using Csla.Data;

namespace PetShop.Business
{
    public partial class Product
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

        private void DataPortal_Fetch(ProductCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("SELECT [ProductId], [CategoryId], [Name], [Descn], [Image] FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
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
                            throw new Exception(String.Format("The record was not found in 'dbo.Product' using the following criteria: {0}.", criteria));
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

            const string commandText = "INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [Name], [Descn], [Image]) VALUES (@p_ProductId, @p_CategoryId, @p_Name, @p_Descn, @p_Image)";
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                    LoadProperty(_originalProductIdProperty, this.ProductId);
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

            if(OriginalProductId != ProductId)
            {
                // Insert new child.
                Product item = new Product {ProductId = ProductId, CategoryId = CategoryId, Name = Name, Description = Description, Image = Image};
                
                item = item.Save();

                // Mark editable child lists as dirty. This code may need to be updated to one-to-one relationships.
                foreach(Item itemToUpdate in Items)
                {
                itemToUpdate.ProductId = ProductId;
                }

                // Create a new connection.
                using (var connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    FieldManager.UpdateChildren(this, connection);
                }

                // Delete the old.
                var criteria = new ProductCriteria {ProductId = OriginalProductId};
                
                DataPortal_Delete(criteria);

                // Mark the original as the new one.
                OriginalProductId = ProductId;

                OnUpdated();

                return;
            }

            const string commandText = "UPDATE [dbo].[Product] SET [ProductId] = @p_ProductId, [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image WHERE [ProductId] = @p_OriginalProductId; SELECT [ProductId] FROM [dbo].[Product] WHERE [ProductId] = @p_OriginalProductId";
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_OriginalProductId", this.OriginalProductId);
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                    LoadProperty(_originalProductIdProperty, this.ProductId);
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
            
            DataPortal_Delete(new ProductCriteria (ProductId));
        
            OnSelfDeleted();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(ProductCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("DELETE FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
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
        protected void DataPortal_Delete(ProductCriteria criteria, SqlConnection connection)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("DELETE FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
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

        private void Child_Fetch(ProductCriteria criteria)
        {
            bool cancel = false;
            OnChildFetching(criteria, ref cancel);
            if (cancel) return;

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
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'dbo.Product' using the following criteria: {0}.", criteria));
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
            const string commandText = "INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [Name], [Descn], [Image]) VALUES (@p_ProductId, @p_CategoryId, @p_Name, @p_Descn, @p_Image)";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update the original non-identity primary key value.
                LoadProperty(_originalProductIdProperty, this.ProductId);
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildInserted();
        }

        private void Child_Insert(Category category, SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(category, connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [Name], [Descn], [Image]) VALUES (@p_ProductId, @p_CategoryId, @p_Name, @p_Descn, @p_Image)";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_CategoryId", category != null ? category.CategoryId : this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(category != null && category.CategoryId != this.CategoryId)
                    LoadProperty(_categoryIdProperty, category.CategoryId);

                // Update the original non-identity primary key value.
                LoadProperty(_originalProductIdProperty, this.ProductId);
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildInserted() and insert this child manually.
            // FieldManager.UpdateChildren(this, null, connection);

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
            const string commandText = "UPDATE [dbo].[Product] SET [ProductId] = @p_ProductId, [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image WHERE [ProductId] = @p_OriginalProductId; SELECT [ProductId] FROM [dbo].[Product] WHERE [ProductId] = @p_OriginalProductId";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_OriginalProductId", this.OriginalProductId);
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                // result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update non-identity primary key value.
                LoadProperty(_originalProductIdProperty, this.ProductId);
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }
 
        private void Child_Update(Category category, SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(category, connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "UPDATE [dbo].[Product] SET [ProductId] = @p_ProductId, [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image WHERE [ProductId] = @p_OriginalProductId; SELECT [ProductId] FROM [dbo].[Product] WHERE [ProductId] = @p_OriginalProductId";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_OriginalProductId", this.OriginalProductId);
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_CategoryId", category != null ? category.CategoryId : this.CategoryId);
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                // result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(category != null && category.CategoryId != this.CategoryId)
                    LoadProperty(_categoryIdProperty, category.CategoryId);

                // Update non-identity primary key value.
                LoadProperty(_originalProductIdProperty, this.ProductId);
            }
    
            FieldManager.UpdateChildren(this, null, connection);

            OnChildUpdated();
        }
        #endregion

        private void Child_DeleteSelf()
        {
            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new ProductCriteria (ProductId));
        
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

            DataPortal_Delete(new ProductCriteria (ProductId), connection);

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
                LoadProperty(_productIdProperty, reader["ProductId"]);
                LoadProperty(_originalProductIdProperty, reader["ProductId"]);
                LoadProperty(_categoryIdProperty, reader["CategoryId"]);
                LoadProperty(_nameProperty, reader["Name"]);
                LoadProperty(_descriptionProperty, reader["Descn"]);
                LoadProperty(_imageProperty, reader["Image"]);
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
