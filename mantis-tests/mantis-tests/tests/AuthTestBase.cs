using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace mantis_tests
{
    public class AuthTestBase : TestBase
    {
        [TestFixtureSetUp]
        public void Auth()
        {
            AccountData account = new AccountData()
            {
                Name = "administrator",
                Password = "root"
            };
            app.authHelper.Login(account);
        }
    }
}