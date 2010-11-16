using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Data.Generated.Base
{
    interface IBusinessBase<T>
    {
        // Methods
        int GetHashCode();
        bool Equals(object obj);

        // Properties
        T Id { get; }
    }

    /// <summary>
    /// Base for all business objects.
    /// 
    /// For an explanation of why Equals and GetHashCode are overriden, read the following...
    /// http://devlicio.us/blogs/billy_mccafferty/archive/2007/04/25/using-equals-gethashcode-effectively.aspx
    /// </summary>
    /// <typeparam name="T">DataType of the primary key.</typeparam>
    public abstract class BusinessBase<T> : IBusinessBase<T>
    {
        #region Declarations

        private T _id = default(T);

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            BusinessBase<T> compareTo = obj as BusinessBase<T>;

            return compareTo != null
                && HasSameNonDefaultIdAs(compareTo)
                && HasSameBusinessSignatureAs(compareTo);
        }

        /// <summary>  
        /// Transient objects are not associated with an   
        /// item already in storage.  For instance, a   
        /// Customer is transient if its ID is 0.  
        /// </summary>  
        public virtual bool IsTransient()
        {
            return Id == null || Id.Equals(default(T));
        }

        /// <summary>  
        /// Must be implemented to compare two objects  
        /// </summary>  
        public abstract override int GetHashCode();

        private bool HasSameBusinessSignatureAs(BusinessBase<T> compareTo)
        {
            return GetHashCode().Equals(compareTo.GetHashCode());
        }

        /// <summary>  
        /// Returns true if self and the provided domain   
        /// object have the same ID values and the IDs   
        /// are not of the default ID value  
        /// </summary>  
        private bool HasSameNonDefaultIdAs(BusinessBase<T> compareTo)
        {
            return IsTransient() || compareTo.IsTransient() || Id.Equals(compareTo.Id);
        }  
  
        #endregion

        #region Properties

        public virtual T Id
        {
            get { return _id; }
            set { _id = value; }
        }

        #endregion
    }
}
