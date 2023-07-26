using ShoppingCart.Commands.CommandApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ShopCart.LoginTest
{
    [TestFixture]
    public class LoginTests
    {
        private Login login;

        [SetUp]
        public void SetUp()
        {
            login = new Login();
        }

        [Test]
        public void LoginRole_Client()
        {
            string input = "Client";
            string expectedResult = "Client";

            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                string result = login.LoginRole();
                Assert.AreEqual(expectedResult, result);
            }
        }
        [Test]
        public void LoginRole_Admin()
        {
            string input = "Admin";
            string expectedResult = "Admin";

            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                string result = login.LoginRole();
                Assert.AreEqual(expectedResult, result);
            }
        }
        [Test]
        public void LoginRole_Employee()
        {
            string input = "Employee";
            string expectedResult = "Employee";

            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                string result = login.LoginRole();
                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}
