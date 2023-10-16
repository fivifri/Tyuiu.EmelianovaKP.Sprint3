using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint3.Task0.V21.Lib;

namespace Tyuiu.EmelianovaKP.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(-63.727, ds.GetSumSeries(1.5, 1, 13));
        }
    }
}
