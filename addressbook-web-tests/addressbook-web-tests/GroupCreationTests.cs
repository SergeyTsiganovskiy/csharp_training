using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
   
    {
         [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            // if there are a lot of  parameters in constructor. 
            // Easier to maintain in future
            GroupData group = new GroupData("aaa");
            group.Header = "sss";
            group.Footer = "ddd";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
        }
        
    }
}

