﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
//     Changes to this template will be lost, excluding the Preserved Code region.
//
//     Template: ADOHelper.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

using Csla.Data;


#endregion

namespace PetShop.Tests.ObjF.StoredProcedures.DAL
{
    public static class ADOHelper
    {
        #region "Preserved Code"

        private static string _connectionString = string.Empty;

        /// <summary>
        /// Returns the Connection String.
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                if(string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PetShopConnectionString"].ConnectionString;
                }
                
                return _connectionString;
            }
        }

        #endregion

        #region Methods
        
        /// <summary>
        /// Returns an array of SqlParameters
        /// </summary>
        public static SqlParameter[] SqlParameters(Dictionary<string, object> bag)
        {
            return new List<SqlParameter>(bag.Select(pair => new SqlParameter(string.Format("@p_{0}", pair.Key), pair.Value))).ToArray();
        }

        /// <summary>
        /// Returns a where clause for the current Criteria object.
        /// </summary>
        /// <returns>Returns a where clause for the current Criteria object.</returns>
        public static string BuildWhereStatement(Dictionary<string, object> bag)
        {
            if (bag.Count == 0)
                return string.Empty;

            string columnNames = bag.Keys.Aggregate(string.Empty, (current, columnName) => current + string.Format("[{0}] = @p_{0} AND ", columnName));
            return string.Format("WHERE {0}", columnNames.Remove(columnNames.Length - 5, 5));
        }

        /// <summary>
        /// Returns the Bytes stored in a binary column.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="columnName">The column name.</param>
        /// <returns>Bytes Stored in a column.</returns>
        public static byte[] GetBytes(SafeDataReader reader, string columnName)
        {
            var buffer = new byte[1024];
            long fieldOffset = 0;
            
            using (var stream = new MemoryStream())
            {
                long bytesRead;

                while ((bytesRead = reader.GetBytes(columnName, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    var actualRead = new byte[bytesRead];
                    Buffer.BlockCopy(buffer, 0, actualRead, 0, (int)bytesRead);
                    stream.Write(actualRead, 0, actualRead.Length);
                    fieldOffset += bytesRead;
                }

                return stream.ToArray();
            }
        }

        #endregion
        
        #region Nullable Helpers //This code is here to help in the Data access implementation of handling DBNull.Value.

        /// <summary>
        /// Simple empty string to DBNull.Value function.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        internal static object NullCheck(string value)
        {
            return string.IsNullOrEmpty(value) ? (object) DBNull.Value : value;
        }

        internal static object NullCheck(char? value)
        {
            return value ?? (object) DBNull.Value;
        }

        internal static object NullCheck(byte? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(sbyte? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(float? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(short? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(ushort? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(int? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(uint? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(long? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(ulong? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(decimal? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        internal static object NullCheck(double? value)
        {
            return value ?? (object)DBNull.Value;
        }

        internal static object NullCheck(bool? value)
        {
            return value ?? (object)DBNull.Value;
        }

        internal static object NullCheck(DateTime? value)
        {
            return value ?? (object)DBNull.Value;
        }

        internal static object NullCheck(DateTimeOffset? value)
        {
            return value ?? (object)DBNull.Value;
        }

        internal static object NullCheck(System.Xml.XmlDocument value)
        {
            return value ?? (object)DBNull.Value;
        }

        internal static object NullCheck(Guid? value)
        {
            return value ?? (object)DBNull.Value;
        }
        
        #endregion
    }
}
