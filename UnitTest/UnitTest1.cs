using gas_station;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace gas_station.Tests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void EmailIsRequired()
        {
            var login = new Login { PasswordHash = "password" };
            var context = new ValidationContext(login, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(login, context, results, true);

            Assert.IsFalse(isValid);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Email is required!", results[0].ErrorMessage);
        }

        [TestMethod]
        public void PasswordIsRequired()
        {
            var login = new Login { Email = "example@example.com" };
            var context = new ValidationContext(login, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(login, context, results, true);

            Assert.IsFalse(isValid);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Password is required!", results[0].ErrorMessage);
        }
    }

    [TestClass]
    public class FuelTypeTests
    {
        [TestMethod]
        public void FuelTypeInitialization()
        {
            var fuelType = new FuelType { Name = "Gasoline", Description = "Regular gasoline" };

            Assert.AreEqual("Gasoline", fuelType.Name);
            Assert.AreEqual("Regular gasoline", fuelType.Description);
        }
    }
}
