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
    public class MCTests
    {
        //[TestMethod()]
        //public void MCTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void PrisTestMC()
        {
            // Arrange
            var mc = new MC("222", false, new DateTime(2017, 08, 22), true, true);
            // Act
            int pris = mc.PrisStorebælt();

            // Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void VehicleTest()
        {
            // Arrange
            var mc1 = new MC("378", false, new DateTime(2017, 08, 15), true, false);

            // Act
            string vehicletype = mc1.VehicleType();

            // Assert
            Assert.AreEqual("MC", vehicletype);
        }

        [TestMethod()]
        public void NummerpladeTest()
        {
            // Arrange
            MC mortercykel01 = new MC("711111211", false, new DateTime(2017, 09, 02), false, true);
            // Act
            string nummerpladelængde = mortercykel01.Nummerplade;
            // Assert
            Assert.AreEqual(9, nummerpladelængde);
        }

        [TestMethod()]
        public void BrobizzTestMC()
        {
            // Arrange
            var mcmedbrobizz = new MC("123", true, new DateTime(2017, 09, 02), false, false);

            // Act
            bool brobizzresult = mcmedbrobizz.Brobizz;

            // Assert
            Assert.AreEqual(true, brobizzresult);
        }
    }
}