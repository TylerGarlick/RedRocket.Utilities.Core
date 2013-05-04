using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RedRocket.Utilities.Core.Tests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void StringReplacement_Works_Properly_With_One_Parameter()
        {
            Assert.AreEqual("This is my Fawesome string", "This is my {0} string".P("Fawesome"));
            Assert.AreEqual("This is my 1 string", "This is my {0} string".P(1));
            Assert.AreEqual("This is my 1 & 2 string", "This is my {0} & {1} string".P(1, 2));
        }
    }
}
