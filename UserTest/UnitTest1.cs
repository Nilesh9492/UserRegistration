using Microsoft.VisualStudio.TestTools.UnitTesting;
using USerRegistration;

namespace UserTest
{
    [TestClass]
    public class UnitTest1
    {

        Reg
        [TestInitialize]
        public void TestSetup()
        {
            userRegistration = new USerRegistration.);
        }
        [TestMethod]
        public void TestFirstName1()
        {
            string expected = "1";
            string name = "Nilesh";
            string actual = userRegistration.ValidatingFirstName(name);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestFirstName2()
        {
            string expected = "0";
            string name = "nil";
            string actual = userRegistration.ValidatingFirstName(name);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestFirstNameException()
        {
            string expected = "Name should not be empty";
            string name = "";
            try
            {
                string actual = userRegistration.ValidatingFirstName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(e.Message, expected);
            }
        }
        [TestMethod]
        public void TestLastName1()
        {
            string expected = "1";
            string name = "nilu";
            string actual = userRegistration.ValidatingFirstName(name);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastName2()
        {
            string expected = "1";
            string name = "nil2";
            string actual = userRegistration.ValidatingFirstName(name);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastNameException()
        {
            string expected = "Name should not be null";
            string name = null;
            try
            {
                string actual = userRegistration.ValidatingFirstName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(e.Message, expected);
            }
        }
        [TestCategory("Email")]
        [TestMethod]
        public void EmailTest1()
        {
            string expected = "1";
            string emailId = "abcdas455@yahoo.com";
            string actual = userRegistration.ValidatingEmail(emailId);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void EmailTest2()
        {
            string expected = "0";
            string emailId = "mnbv63@ya@gmail.com";
            string actual = userRegistration.ValidatingEmail(emailId);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void EmailExceptionTest()
        {
            string expected = "Email should not be null";
            string emailId = null;
            string actual = userRegistration.ValidatingEmail(emailId);
            Assert.AreEqual(actual, expected);
        }
        [TestCategory("Moblie number validation")]
        [TestMethod]
        public void MobileTest1()
        {
            string expected = "1";
            string mobileNo = "91 7896541230";
            string actual = userRegistration.ValidatingMobileNo(mobileNo);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void MobileTest2()
        {
            string expected = "0";
            string mobileNo = "919876543210";
            string actual = userRegistration.ValidatingMobileNo(mobileNo);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest1()
        {
            string expected = "1";
            string password = "fggS@774";
            string actual = userRegistration.ValidatingPassword(password);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest2()
        {
            string expected = "0";
            string password = "gfo*w5)9gD";
            string actual = userRegistration.ValidatingPassword(password);
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordExceptionTest()
        {
            string expected = "Password should not be empty";
            string password = "";
            try
            {
                string actual = userRegistration.ValidatingPassword(password);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual(ce.Message, expected);
            }
        }
    }
}
