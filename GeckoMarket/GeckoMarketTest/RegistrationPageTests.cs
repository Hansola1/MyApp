using GeckoMarket.Views;
using System;
using System.Windows;
using System.Windows.Controls;
using Xunit;

namespace GeckoMarketTest
{
    public class RegistrationPageTests
    {
        public RegistrationPage _testClass; 

        public RegistrationPageTests()
        {
            _testClass = new RegistrationPage(); 
        }

        [Fact]
        public void ValidationData_ValidInputs_ReturnsTrue()
        {
            _testClass.SetRegistrationData("Test User", "validLogin", "test@example.com", "validPassword", "validPassword");

            // Act
            bool result = _testClass.validationData();

            // Assert
            Assert.True(result);
        }

    }
}