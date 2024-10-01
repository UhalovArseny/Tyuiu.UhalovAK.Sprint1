using System;
using Tyuiu.UhalovAK.Sprint1.Task1.V30.Lib;
namespace Tyuiu.UhalovAK.Sprint1.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;

            var res = ds.Calculate(x);
            Assert.AreEqual(1.5, res);
        }
    }
}