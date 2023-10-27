using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint3.Task6.V2.Lib;

namespace Tyuiu.EmelianovaKP.Sprint3.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(29, ds.GetSumTheDivisors(12, 18));
        }
    }
}
