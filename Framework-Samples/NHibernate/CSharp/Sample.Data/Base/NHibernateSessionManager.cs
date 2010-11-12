using System;
using System.Collections.Generic;
using System.Text;

using NHibernate;
using NHibernate.Cfg;

namespace Sample.Data.Generated.Base
{
    public interface INHibernateSessionManager : IDisposable
    {
        // Methods
		ISession CreateISession();

        // Properties
        INHibernateSession Session { get; }
    }

    /// <summary>
    /// A Singleton that creates and persits a single SessionFactory for the to program to access globally.
    /// This uses the .Net CallContext to store a session for each thread.
    /// 
    /// This is heavely based on 'NHibernate Best Practices with ASP.NET' By Billy McCafferty.
    /// http://www.codeproject.com/KB/architecture/NHibernateBestPractices.aspx
    /// </summary>
    public class NHibernateSessionManager : INHibernateSessionManager
    {
        #region Static Content

        private static INHibernateSessionManager _nHibernateSessionManager = null;
        /// <summary>
        /// Set method is exposed so that the INHibernateSessionManager can be swapped out for Unit Testing.
        /// NOTE: Cannot set Instance after it has been initialized, and calling Get will automatically intialize the Instance.
        /// </summary>
        public static INHibernateSessionManager Instance
        {
            get
            {
                if(_nHibernateSessionManager == null)
                    _nHibernateSessionManager = new NHibernateSessionManager();
                return _nHibernateSessionManager;
            }
            set
            {
                if (_nHibernateSessionManager != null)
                    throw new Exception("Cannot set Instance after it has been initialized.");
                _nHibernateSessionManager = value;
            }
        }

        #endregion

        #region Declarations

        private ISessionFactory _sessionFactory = null;
        private const string _sessionContextKey = "NHibernateSession-ContextKey";

        #endregion

        #region Constructors & Finalizers

        /// <summary>
        /// This will load the NHibernate settings from the App.config.
        /// Note: This can/should be expanded to support multiple databases.
        /// </summary>
        private NHibernateSessionManager()
        {
            _sessionFactory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
        }
        ~NHibernateSessionManager()
        {
            Dispose(true);
        }

        #endregion

        #region IDisposable

        private bool _isDisposed = false;
        public void Dispose()
        {
            Dispose(false);
        }
        private void Dispose(bool finalizing)
        {
            if (!_isDisposed)
            {
                // Close SessionFactory
                _sessionFactory.Close();
                _sessionFactory.Dispose();

                // Flag as disposed.
                _isDisposed = true;
                if (!finalizing)
                    GC.SuppressFinalize(this);
            }
        }

        #endregion

        #region Methods

        public ISession CreateISession()
        {
            ISession iSession;
            lock (_sessionFactory)
            {
                iSession = _sessionFactory.OpenSession();
            }
            return iSession;
        }

        #endregion

        #region Properties

        public INHibernateSession Session
        {
            get
            {
                if(ContextSession == null)
                    ContextSession = new NHibernateSession();
                return ContextSession;
            }
        }
        private INHibernateSession ContextSession
        {
            get
            {
                if (IsWebContext)
                    return (NHibernateSession)System.Web.HttpContext.Current.Items[_sessionContextKey];
                else
                    return (NHibernateSession)System.Runtime.Remoting.Messaging.CallContext.GetData(_sessionContextKey);
            }
            set
            {
                if (IsWebContext)
                    System.Web.HttpContext.Current.Items[_sessionContextKey] = value;
                else
                    System.Runtime.Remoting.Messaging.CallContext.SetData(_sessionContextKey, value);
            }
        }
        private bool IsWebContext
        {
            get { return (System.Web.HttpContext.Current != null); }
        }

        #endregion
    }
}
