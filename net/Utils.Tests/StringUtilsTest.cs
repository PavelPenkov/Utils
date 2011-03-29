using Microsoft.VisualStudio.TestTools.UnitTesting;
using Synapse.Utils;

namespace Utils.Tests
{
    [TestClass]
    public class StringUtilsTest
    {
        [TestMethod]
        public void Should_Return_Lower() {
            var bs = new byte[] {255, 255};
            string result = bs.ToHexString();

            Assert.AreEqual("ffff", result);
        }
    }
}
