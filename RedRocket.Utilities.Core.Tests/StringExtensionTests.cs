using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RedRocket.Utilities.Core.Tests
{
    [TestClass]
    public class StringExtensionTests : AbstractTests
    {
        [TestMethod]
        public void StringReplacement_Works_Properly_With_One_Parameter()
        {
            Assert.AreEqual("This is my Fawesome string", "This is my {0} string".P("Fawesome"));
            Assert.AreEqual("This is my 1 string", "This is my {0} string".P(1));
            Assert.AreEqual("This is my 1 & 2 string", "This is my {0} & {1} string".P(1, 2));
        }

        [TestMethod]
        public void ToCamelCase_Works_Properly_Given_Valid_Input()
        {
            Assert.AreEqual("ThisIsMyFawesomeString", "this_is_my_fawesome_string".ToCamelCase("_"));
            Assert.AreEqual("".ToCamelCase(""), string.Empty);
            Assert.AreEqual("ThisIsMyFawesomeString", "This_Is_My_Fawesome_String".ToCamelCase("_"));
            Assert.AreEqual("ThisIsMyFawesomeString", "ThIs_Is_My_faWesome_String".ToCamelCase("_"));
            Assert.AreEqual("ThisIsMyFawesomeString", "this_is_my_fawesome string".ToCamelCase("_", " "));
            Assert.AreEqual("ThisIsMyFawesomeString", "this1is1my1fawesome1string".ToCamelCase("1"));
            Assert.AreEqual("ThisIsMyFawesomeString", "THIS_IS_MY_FAWESOME_STRING".ToCamelCase("_"));
            Assert.AreEqual("ThisIsMyFawesomeString", "THIS__IS_MY_FAWESOME_STRING".ToCamelCase("_"));
            Assert.AreEqual("ThisIsMyFawesomeString", "THIS                                   IS_MY_FAWESOME_STRING".ToCamelCase("_", " "));
            Assert.AreEqual("1ThisIsMyFawesomeString", "1_this_is_my_fawesome_string".ToCamelCase("_"));
            Assert.AreEqual("!ThisIsMyFawesomeString", "!_this_is_my_fawesome_string".ToCamelCase("_"));
            Assert.AreEqual("'ThisIsMyFawesomeString'''", "'_this_is_my_fawesome_string'''".ToCamelCase("_"));
        }
    }
}
