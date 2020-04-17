using System;
using acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTest()
        {
            //--Arange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
           
            //--Act
            var actual = source.InsertSpaces();
            //--Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void InsertSpaceTestWithExistingSpace()
        {
            //--Arange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
           
            //--Act
            var actual = source.InsertSpaces();
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
