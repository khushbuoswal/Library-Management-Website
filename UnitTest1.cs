using NUnit.Framework;

namespace WinFormsApp6.Tests
{
    [TestFixture]
    public class UtilsTests
    {
        [Test]
        [TestCase("123@example.com", true)]
        [TestCase("student@example.co.uk", true)]
        [TestCase("student.name+alias@example.com", true)]
        [TestCase("student@.com", false)]
        [TestCase("student@", false)]
        [TestCase("@example.com", false)]
        [TestCase("studentexample.com", false)]
        [TestCase("", false)]
        [TestCase(null, false)]
        public void IsValidEmail_TestVariousEmails(string email, bool expectedResult)
        {
            bool result = Utils.IsValidEmail(email);
            Assert.AreEqual(expectedResult, result, $"Email: {email}");
        }
    }
}
