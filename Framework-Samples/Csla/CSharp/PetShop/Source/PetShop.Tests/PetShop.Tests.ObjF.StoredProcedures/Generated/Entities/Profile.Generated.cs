﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Profile.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;

using Csla;
using Csla.Data;
using System.Data.SqlClient;
using Csla.Rules;

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.ProfileFactoryName)]
    public partial class Profile : BusinessBase<Profile>
    {
        #region Contructor(s)

        public Profile()
        { /* Require use of factory methods */ }

        #endregion

        #region Business Rules

        /// <summary>
        /// Contains the CodeSmith generated validation rules.
        /// </summary>
        protected override void AddBusinessRules()
        {
            // Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            base.AddBusinessRules();

            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_usernameProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_usernameProperty, 256));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_applicationNameProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_applicationNameProperty, 256));
        }

        #endregion


        #region Properties

        private static readonly PropertyInfo<System.Int32> _uniqueIDProperty = RegisterProperty<System.Int32>(p => p.UniqueID, "Unique I D");
        [System.ComponentModel.DataObjectField(true, true)]
        public System.Int32 UniqueID
        {
            get { return GetProperty(_uniqueIDProperty); }
            internal set{ SetProperty(_uniqueIDProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _usernameProperty = RegisterProperty<System.String>(p => p.Username, "Username");
        public System.String Username
        {
            get { return GetProperty(_usernameProperty); }
            set{ SetProperty(_usernameProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _applicationNameProperty = RegisterProperty<System.String>(p => p.ApplicationName, "Application Name");
        public System.String ApplicationName
        {
            get { return GetProperty(_applicationNameProperty); }
            set{ SetProperty(_applicationNameProperty, value); }
        }

        private static readonly PropertyInfo<System.Boolean?> _isAnonymousProperty = RegisterProperty<System.Boolean?>(p => p.IsAnonymous, "Is Anonymous", (System.Boolean?)null);
        public System.Boolean? IsAnonymous
        {
            get { return GetProperty(_isAnonymousProperty); }
            set{ SetProperty(_isAnonymousProperty, value); }
        }

        private static readonly PropertyInfo<System.DateTime?> _lastActivityDateProperty = RegisterProperty<System.DateTime?>(p => p.LastActivityDate, "Last Activity Date", (System.DateTime?)null);
        public System.DateTime? LastActivityDate
        {
            get { return GetProperty(_lastActivityDateProperty); }
            set{ SetProperty(_lastActivityDateProperty, value); }
        }

        private static readonly PropertyInfo<System.DateTime?> _lastUpdatedDateProperty = RegisterProperty<System.DateTime?>(p => p.LastUpdatedDate, "Last Updated Date", (System.DateTime?)null);
        public System.DateTime? LastUpdatedDate
        {
            get { return GetProperty(_lastUpdatedDateProperty); }
            set{ SetProperty(_lastUpdatedDateProperty, value); }
        }

        // OneToMany
        private static readonly PropertyInfo<AccountList> _accountsProperty = RegisterProperty<AccountList>(p => p.Accounts, Csla.RelationshipTypes.Child);
        public AccountList Accounts
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_accountsProperty, ref cancel);
    
                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_accountsProperty))
                    {
                        var criteria = new PetShop.Tests.ObjF.StoredProcedures.AccountCriteria {UniqueID = UniqueID};
                        
    
                        if(!PetShop.Tests.ObjF.StoredProcedures.AccountList.Exists(criteria))
                            LoadProperty(_accountsProperty, PetShop.Tests.ObjF.StoredProcedures.AccountList.NewList());
                        else
                            LoadProperty(_accountsProperty, PetShop.Tests.ObjF.StoredProcedures.AccountList.GetByUniqueID(UniqueID));
                    }
                }

                return GetProperty(_accountsProperty);
            }
        }

        // OneToMany
        private static readonly PropertyInfo<CartList> _cartsProperty = RegisterProperty<CartList>(p => p.Carts, Csla.RelationshipTypes.Child);
        public CartList Carts
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_cartsProperty, ref cancel);
    
                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_cartsProperty))
                    {
                        var criteria = new PetShop.Tests.ObjF.StoredProcedures.CartCriteria {UniqueID = UniqueID};
                        
    
                        if(!PetShop.Tests.ObjF.StoredProcedures.CartList.Exists(criteria))
                            LoadProperty(_cartsProperty, PetShop.Tests.ObjF.StoredProcedures.CartList.NewList());
                        else
                            LoadProperty(_cartsProperty, PetShop.Tests.ObjF.StoredProcedures.CartList.GetByUniqueID(UniqueID));
                    }
                }

                return GetProperty(_cartsProperty);
            }
        }


        #endregion

        #region Synchronous Root Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="Profile"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="Profile"/>.</returns>    
        public static Profile NewProfile()
        {
            return DataPortal.Create<Profile>();
        }

        /// <summary>
        /// Returns a <see cref="Profile"/> object of the specified criteria. 
        /// </summary>
        /// <param name="uniqueID">No additional detail available.</param>
        /// <returns>A <see cref="Profile"/> object of the specified criteria.</returns>
        public static Profile GetByUniqueID(System.Int32 uniqueID)
        {
            var criteria = new ProfileCriteria {UniqueID = uniqueID};
            
            
            return DataPortal.Fetch<Profile>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Profile"/> object of the specified criteria. 
        /// </summary>
        /// <param name="username">No additional detail available.</param>
        /// <param name="applicationName">No additional detail available.</param>
        /// <returns>A <see cref="Profile"/> object of the specified criteria.</returns>
        public static Profile GetByUsernameApplicationName(System.String username, System.String applicationName)
        {
            var criteria = new ProfileCriteria {Username = username, ApplicationName = applicationName};
            
            
            return DataPortal.Fetch<Profile>(criteria);
        }

        public static void DeleteProfile(System.Int32 uniqueID)
        {
                DataPortal.Delete<Profile>(new ProfileCriteria (uniqueID));
        }

        #endregion

        #region Asynchronous Root Factory Methods
        
        public static void NewProfileAsync(EventHandler<DataPortalResult<Profile>> handler)
        {
            var dp = new DataPortal<Profile>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        public static void GetByUniqueIDAsync(System.Int32 uniqueID, EventHandler<DataPortalResult<Profile>> handler)
        {
            var criteria = new ProfileCriteria{UniqueID = uniqueID};
            

            var dp = new DataPortal<Profile>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByUsernameApplicationNameAsync(System.String username, System.String applicationName, EventHandler<DataPortalResult<Profile>> handler)
        {
            var criteria = new ProfileCriteria{Username = username, ApplicationName = applicationName};
            

            var dp = new DataPortal<Profile>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void DeleteProfileAsync(System.Int32 uniqueID, EventHandler<DataPortalResult<Profile>> handler)
        {
            var criteria = new ProfileCriteria{UniqueID = uniqueID};
            

            var dp = new DataPortal<Profile>();
            dp.DeleteCompleted += handler;
            dp.BeginDelete(criteria);
        }
        
        #endregion

        #region Synchronous Child Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="Profile"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="Profile"/>.</returns>
        internal static Profile NewProfileChild()
        {
            return DataPortal.CreateChild<Profile>();
        }

        /// <summary>
        /// Returns a <see cref="Profile"/> object of the specified criteria. 
        /// </summary>
        /// <param name="uniqueID">No additional detail available.</param>
        /// <returns>A <see cref="Profile"/> object of the specified criteria.</returns>

        internal static Profile GetByUniqueIDChild(System.Int32 uniqueID)
        {
            var criteria = new ProfileCriteria {UniqueID = uniqueID};
            

            return DataPortal.Fetch<Profile>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Profile"/> object of the specified criteria. 
        /// </summary>
        /// <param name="username">No additional detail available.</param>
        /// <param name="applicationName">No additional detail available.</param>
        /// <returns>A <see cref="Profile"/> object of the specified criteria.</returns>

        internal static Profile GetByUsernameApplicationNameChild(System.String username, System.String applicationName)
        {
            var criteria = new ProfileCriteria {Username = username, ApplicationName = applicationName};
            

            return DataPortal.Fetch<Profile>(criteria);
        }

        #endregion

        #region Asynchronous Child Factory Methods
        
        internal static void NewProfileChildAsync(EventHandler<DataPortalResult<Profile>> handler)
        {
            DataPortal<Profile> dp = new DataPortal<Profile>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        internal static void GetByUniqueIDChildAsync(System.Int32 uniqueID, EventHandler<DataPortalResult<Profile>> handler)
        {
            var criteria = new ProfileCriteria{ UniqueID = uniqueID};
            
            
            // Mark as child?
            var dp = new DataPortal<Profile>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        internal static void GetByUsernameApplicationNameChildAsync(System.String username, System.String applicationName, EventHandler<DataPortalResult<Profile>> handler)
        {
            var criteria = new ProfileCriteria{ Username = username, ApplicationName = applicationName};
            
            
            // Mark as child?
            var dp = new DataPortal<Profile>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Profile"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ProfileCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(ProfileCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Profile"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Profile"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Profile"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Profile"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Profile"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ProfileCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(ProfileCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Profile"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region ChildPortal partial methods


        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ProfileCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(ProfileCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="Profile"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Profile"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();
        #endregion

        #region Overridden properties

        /// <summary>
        /// Returns true if the business object or any of its children properties are dirty.
        /// </summary>
        public override bool IsDirty
        {
            get
            {
                if (base.IsDirty) return true;
                if (FieldManager.FieldExists(_accountsProperty) && Accounts.IsDirty) return true;
                if (FieldManager.FieldExists(_cartsProperty) && Carts.IsDirty) return true;

                return false;
            }
        }

        #endregion


        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the Profiles table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="Profile"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(ProfileCriteria criteria)
        {
            return PetShop.Tests.ObjF.StoredProcedures.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the Profiles table in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(ProfileCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            PetShop.Tests.ObjF.StoredProcedures.ExistsCommand.ExecuteAsync(criteria, handler);
        }

        #endregion

    }
}