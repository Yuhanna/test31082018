using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CrossSolar.Models;
using Xunit;

namespace CrossSolar.Tests.Models
{
    public class PanelModelTest
    {
        [Fact]
        public void ValidatePanelModel_Range()
        {
            var panelModelNotValid = new PanelModel
            {
                Brand = "Test",
                Latitude = 90.000001,
                Longitude = 180.000000,
                Serial = "AAAA1111BBBB2222"
            };

            var context1 = new ValidationContext(panelModelNotValid, null, null);
            var results1 = new List<ValidationResult>();
            var isModelStateNotValid = Validator.TryValidateObject(panelModelNotValid, context1, results1, true);

            var panelModelValid = new PanelModel
            {
                Brand = "Test",
                Latitude = -90.00000,
                Longitude = -180.000000,
                Serial = "AAAA1111BBBB2222"
            };

            var context2 = new ValidationContext(panelModelValid, null, null);
            var results2 = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(panelModelValid, context2, results2, true);


            // assert
            Assert.False(isModelStateNotValid);
            Assert.True(isModelStateValid);
        }

        [Fact]
        public void ValidatePanelModel_Regex()
        {
            var panelModelNotValid = new PanelModel
            {
                Brand = "Test",
                Latitude = 90.0000000,
                Longitude = 179.0000001,
                Serial = "AAAA1111BBBB2222"
            };

            var context1 = new ValidationContext(panelModelNotValid, null, null);
            var results1 = new List<ValidationResult>();
            var isModelStateNotValid = Validator.TryValidateObject(panelModelNotValid, context1, results1, true);

            var panelModelValid = new PanelModel
            {
                Brand = "Test",
                Latitude = -11.11,
                Longitude = 179.999999,
                Serial = "AAAA1111BBBB2222"
            };

            var context2 = new ValidationContext(panelModelValid, null, null);
            var results2 = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(panelModelValid, context2, results2, true);


            // Assert 
            Assert.False(isModelStateNotValid);
            Assert.True(isModelStateValid);
        }
    }
}
