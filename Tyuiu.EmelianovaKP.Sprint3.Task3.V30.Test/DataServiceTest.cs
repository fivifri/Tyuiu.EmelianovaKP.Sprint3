using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint3.Task3.V30.Lib;

namespace Tyuiu.EmelianovaKP.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(4, ds.GetMaxCharCount("fyyklbtyn ygrc vfyyyyh", 'y'));
        }
    }
}
