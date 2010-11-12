using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Sample.Data.Generated.ManagerObjects;
using Sample.Data.Generated.BusinessObjects;

namespace Sample.Data.Generated.Base
{
    public class UNuitTestBase
    {
        protected IManagerFactory managerFactory = new ManagerFactory();
    }
}