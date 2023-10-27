using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint3.Task5.V9.Lib;

namespace Tyuiu.EmelianovaKP.Sprint3.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(231.235, ds.GetSumSumSeries(5, 1, 1, 3, 14));
        }
    }
}
