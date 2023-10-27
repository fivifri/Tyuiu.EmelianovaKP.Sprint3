using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint3.Task7.V13.Lib;

namespace Tyuiu.EmelianovaKP.Sprint3.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] res = {-9.10,  1.55, 292.78, -0.57, -0.35, 2.00, 4.35, 4.57, -288.78, 2.45, 13.10};

            CollectionAssert.AreEqual(res, ds.GetMassFunction(-5, 5));
        }
    }
}
