using System.Linq;
using FlitBit.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedRocket.Utilities.Core.Tests.Dto;

namespace RedRocket.Utilities.Core.Tests
{
    [TestClass]
    public class ValidationTests : AbstractTests
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
            Assert.AreEqual(1, person.GetValidationErrors().Count());
            Assert.AreEqual("The FirstName field is required.", person.GetValidationErrors().First().Message);

            person = Create.NewInit<IPerson>().Init(new
            {
                FirstName = "t",
                LastName = "Garlick",
                Age = 31
            });

            Assert.IsFalse(person.IsObjectValid());
            Assert.AreEqual(1, person.GetValidationErrors().Count());
            Assert.AreEqual("The field FirstName must be a string with a minimum length of 3 and a maximum length of 150.", person.GetValidationErrors().First().Message);

            person = Create.NewInit<IPerson>().Init(new
            {
                FirstName = "t",
                LastName = "Garlick",
                Age = 31
            });

            Assert.IsFalse(person.IsObjectValid());
            Assert.AreEqual(1, person.GetValidationErrors().Count());
            Assert.AreEqual("The field FirstName must be a string with a minimum length of 3 and a maximum length of 150.", person.GetValidationErrors().First().Message);
        }
    }
}