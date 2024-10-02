using Tyuiu.UhalovAK.Sprint1.Task7.V10.Lib;
namespace Tyuiu.UhalovAK.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = -14.031;
            var res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }
    }
}