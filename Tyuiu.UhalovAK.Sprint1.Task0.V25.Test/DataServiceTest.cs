using System;
using Tyuiu.UhalovAK.Sprint1.Task0.V25.Lib;

namespace Tyuiu.UhalovAK.Sprint1.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}