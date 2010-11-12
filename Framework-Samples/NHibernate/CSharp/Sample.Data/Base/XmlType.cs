using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Xml;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;

namespace Sample.Data.Generated.Base
{
    /// <summary>
    /// UserType allowing easy saving of NHIbernate XmlDocument property.
    /// 
    /// Example:
    /// Message.cs - Example class with a XmlDocument
    /// public class Message
    /// {
    ///    public XmlDocument Body{get;set;}
    /// }
    /// Document.hbm.xml - The mapping
    /// <hibernate-mapping xmlns="urn:nhibernate-mapping-2.2">
    ///   <class name="Message">
    ///     <property name="Body" type="NHibernate.Custom.XmlType, NHibernate.Custom" />
    ///   </class>
    /// </hibernate-mapping>
    /// 
    /// Notes:
    /// - This code was found online somewhere, sorry, I can't remember where :-( 
    /// - I've tweaked it a little to work with 2nd level cache and NHibernate 2.1.x. 
    /// - Tobin Harris
    /// </summary>
    public class XmlType : IUserType
    {
        public new bool Equals(object x, object y)
        {
            if (x == null || y == null)
                return false;

            var xdoc_x = (XmlDocument)x;
            var xdoc_y = (XmlDocument)y;
            return xdoc_y.OuterXml == xdoc_x.OuterXml;
        }

        public int GetHashCode(object x)
        {
            return x.GetHashCode();
        }

        public object NullSafeGet(IDataReader rs, string[] names, object owner)
        {
            if (names.Length != 1)
                throw new InvalidOperationException("names array has more than one element. can't handle this!");

            var document = new XmlDocument();

            var val = rs[names[0]] as string;

            if (val != null)
            {
                document.LoadXml(val);
                return document;
            }

            return null;
        }

        public void NullSafeSet(IDbCommand cmd, object value, int index)
        {
            var parameter = (DbParameter)cmd.Parameters[index];

            if (value == null)
            {
                parameter.Value = DBNull.Value;
                return;
            }

            parameter.Value = ((XmlDocument)value).OuterXml;
        }

        public object DeepCopy(object value)
        {

            var toCopy = value as XmlDocument;

            if (toCopy == null)
                return null;

            var copy = new XmlDocument();
            copy.LoadXml(toCopy.OuterXml);
            return copy;
        }

        public object Replace(object original, object target, object owner)
        {
            throw new NotImplementedException();
        }

        public object Assemble(object cached, object owner)
        {
            var str = cached as string;
            if (str != null)
            {
                var doc = new XmlDocument();
                doc.LoadXml(str);
                return doc;
            }
            else
            {
                return null;
            }

        }

        public object Disassemble(object value)
        {
            var val = value as XmlDocument;
            if (val != null)
            {
                return val.OuterXml;
            }
            else
            {
                return null;
            }
        }

        public SqlType[] SqlTypes
        {
            get
            {
                return new SqlType[] { new SqlXmlStringType() };
            }
        }

        public System.Type ReturnedType
        {
            get { return typeof(XmlDocument); }
        }

        public bool IsMutable
        {
            get { return true; }
        }
    }

    public class SqlXmlType : SqlType
    {
        public SqlXmlType()
            : base(DbType.Xml)
        {
        }
    }

    public class SqlXmlStringType : SqlType
    {
        public SqlXmlStringType()
            : base(DbType.String, 4000)
        {
        }
    }
}