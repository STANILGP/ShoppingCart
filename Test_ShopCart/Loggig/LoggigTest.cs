using ShoppingCart.Commands.CommandApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ShopCart.Loggig
{
    [TestFixture]
    public class LoggigTests
    {
        private Logging logging;

        [SetUp]
        public void SetUp()
        {
            logging = new Logging();
        }

        [Test]
        public void Error()
        {
            string input = "Error";
            string expectedResult = "Error";

            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                string result = logging.LoginMessager();
                Assert.AreEqual(expectedResult, result);
            }
        }
        [Test]
        public void Warning()
        {
            string input = "Warnings";
            string expectedResult = "Warnings";

            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                string result = logging.LoginMessager();
                Assert.AreEqual(expectedResult, result);
            }
        }
        [Test]
        public void Info()
        {
            string input = "Info";
            string expectedResult = "Info";

            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                string result = logging.LoginMessager();
                Assert.AreEqual(expectedResult, result);
            }
        }
        [Test]
        public void Debug()
        {
            string input = "Debug";
            string expectedResult = "Debug";

            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                string result = logging.LoginMessager();
                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}
