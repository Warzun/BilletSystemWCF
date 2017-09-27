using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary.Tests
{
    [TestClass()]
    public class BillTests
    {
        [TestMethod()]
        public void BilTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PrisTest()
        {
            // Arrange
            var bilpris = new Bill("2345", true, new DateTime(2017, 08, 28), false, true);
            //Act
            int pris = bilpris.PrisStorebælt();
            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            // Arrange
            var køretøj = new Bill("234", true, new DateTime(2017, 08, 29), true, true);

            // Act
            string køretøjslags = køretøj.VehicleType();

            // Assert
            Assert.AreEqual("Bil", køretøjslags);
        }

        [TestMethod()]
        public void BrobizzTestBil()
        {
            // Arrange
            var bilmedbrobizz = new Bill("Ford", false, new DateTime(2017, 09, 01), true, false);

            // Act
            bool brobizzresult = bilmedbrobizz.Brobizz;

            // Assert
            Assert.AreEqual(true, brobizzresult);
        }

        
        
    }
}