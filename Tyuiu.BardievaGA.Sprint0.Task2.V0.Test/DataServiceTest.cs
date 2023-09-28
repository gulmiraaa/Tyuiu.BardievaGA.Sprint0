using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BardievaGA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BardievaGA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CkeckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Гулмира";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Гулмира", res);
        }
    }
}
