using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint3.Task1.V18.Lib;

namespace Tyuiu.EmelianovaKP.Sprint3.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(0.121, ds.GetMultiplySeries(0.25, 1, 15));
        }
    }
}
