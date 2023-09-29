using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BardievaGA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.BardievaGA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ChekcedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
