﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Profile.cs'.
//
//     Template: ObjectFactoryList.DataAccess.StoredProcedures.cst
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

using PetShop.Tests.ObjF.StoredProcedures;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures.DAL
{
    public partial class ProfileListFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new ProfileList with default values.
        /// </summary>
        /// <returns>new ProfileList.</returns>
        [RunLocal]
        public ProfileList Create()
        {
            var item = (ProfileList)Activator.CreateInstance(typeof(ProfileList), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            CheckRules(item);
            MarkNew(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch ProfileList.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public ProfileList Fetch(ProfileCriteria criteria)
        {
            ProfileList item = (ProfileList)Activator.CreateInstance(typeof(ProfileList), true);

            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return item;

            // Fetch Child objects.
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Profile_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_IsAnonymousHasValue", criteria.IsAnonymousHasValue);
					command.Parameters.AddWithValue("@p_LastActivityDateHasValue", criteria.LastActivityDateHasValue);
					command.Parameters.AddWithValue("@p_LastUpdatedDateHasValue", criteria.LastUpdatedDateHasValue);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                item.Add(new ProfileFactory().Map(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            MarkOld(item);
            OnFetched();
            return item;
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// Codesmith generated stub method that is called when creating the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Profile"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// Codesmith generated stub method that is called when fetching the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ProfileCriteria"/> object containg the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(ProfileCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Profile"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// Codesmith generated stub method that is called when mapping the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Profile"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// Codesmith generated stub method that is called when updating the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Profile"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
        partial void OnAddNewCore(ref Profile item, ref bool cancel);

        #endregion
    }
}