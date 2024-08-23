using NUnit.Framework;

namespace scalySTy.WebUtility.Tests
{
    public class WebApplicationTests
    {
        [Test]
        public void InBackgroundShouldReturnFalse()
        {
            Assert.IsFalse(WebApplication.InBackground);
        }
    }
}
