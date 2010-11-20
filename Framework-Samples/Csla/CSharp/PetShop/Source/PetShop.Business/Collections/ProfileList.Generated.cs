﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ProfileList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class ProfileList : BusinessListBase< ProfileList, Profile >
    {    
        #region Contructor(s)

        private ProfileList()
        { 
            AllowNew = true;
        }
        
        #endregion

        #region Method Overrides
        
        protected override object AddNewCore()
        {
            Profile item = PetShop.Business.Profile.NewProfile();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Profile.NewProfile();


                Add(item);
            }

            return item;
        }
        
        #endregion

        #region Synchronous Factory Methods 
        
        public static ProfileList NewList()
        {
            return DataPortal.Create< ProfileList >();
        }      

        public static ProfileList GetByUniqueID(System.Int32 uniqueID)
        {
            var criteria = new ProfileCriteria{UniqueID = uniqueID};
            
            
            return DataPortal.Fetch< ProfileList >(criteria);
        }

        public static ProfileList GetByUsernameApplicationName(System.String username, System.String applicationName)
        {
            var criteria = new ProfileCriteria{Username = username, ApplicationName = applicationName};
            
            
            return DataPortal.Fetch< ProfileList >(criteria);
        }

        public static ProfileList GetAll()
        {
            return DataPortal.Fetch< ProfileList >(new ProfileCriteria());
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ProfileCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref Profile item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(ProfileCriteria criteria)
        {
            return PetShop.Business.Profile.Exists(criteria);
        }

        #endregion

    }
}