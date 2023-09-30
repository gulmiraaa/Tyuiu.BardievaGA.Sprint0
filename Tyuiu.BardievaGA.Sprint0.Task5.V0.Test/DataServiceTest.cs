﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BardievaGA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.BardievaGA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckSubstractValid()
        {
            Assert.AreEqual(5, DataService.Substract(10, 5));
        }
        [TestMethod]
        public void CheckMuptiplicateValid()
        {   
            Assert.AreEqual(50, DataService.Mplicate(10, 5));
        }
        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.division(9, 3));
        }
    }
}
