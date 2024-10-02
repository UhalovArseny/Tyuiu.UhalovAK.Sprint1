using Tyuiu.UhalovAK.Sprint1.Task4.V23.Lib;
namespace Tyuiu.UhalovAK.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;

            double y = 2;


            double wait = 2;

            var res = ds.Calculate(x,y);

            Assert.AreEqual(wait, res);
        }
    }
}