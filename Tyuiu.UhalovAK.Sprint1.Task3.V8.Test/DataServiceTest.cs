using Tyuiu.UhalovAK.Sprint1.Task3.V8.Lib;
namespace Tyuiu.UhalovAK.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double z = 2500;

            double x = 20;

            double c = 30;

            double wait = 41.096;

            var res = ds.IncomeAmount(z, x, c);

            Assert.AreEqual(wait, res);
        }
    }
}