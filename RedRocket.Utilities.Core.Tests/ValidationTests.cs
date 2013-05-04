using System.Linq;
using FlitBit.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedRocket.Utilities.Core.Tests.Dto;


namespace RedRocket.Utilities.Core.Tests
{
    [TestClass]
    public class ValidationTests
    {
        
        [TestMethod]
        public void Dto_AttributeTests()
        {
            var person = Create.NewInit<IPerson>().Init(new
                                                            {
                                                                FirstName = "Tyler",
                                                                LastName = "Garlick",
                                                                Age = 31
                                                            });

            Assert.IsTrue(person.IsObjectValid());

            person = Create.NewInit<IPerson>().Init(new
                                                        {
                                                            FirstName = "Tyler",
                                                            LastName = "Garlick",
                                                            Age = 250
                                                        });
            
            Assert.IsFalse(person.IsObjectValid());
            Assert.AreEqual(1, person.GetValidationErrors().Count());

            person = Create.NewInit<IPerson>().Init(new
                                                        {
                                                            LastName = "Garlick",
                                                            Age = 31
                                                        });
            Assert.IsFalse(person.IsObjectValid());
            Assert.AreEqual(2, person.GetValidationErrors().Count());
        }
    }
}