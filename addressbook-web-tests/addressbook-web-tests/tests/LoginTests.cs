﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            app.Auth.Logout();
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);
            Assert.IsTrue(app.Auth.isLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            app.Auth.Logout();
            AccountData account = new AccountData("admin", "123");
            app.Auth.Login(account);
            Assert.IsFalse(app.Auth.isLoggedIn(account));
        }
    }
}
