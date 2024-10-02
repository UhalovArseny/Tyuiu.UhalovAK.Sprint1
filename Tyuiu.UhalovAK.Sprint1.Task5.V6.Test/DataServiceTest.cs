using Tyuiu.UhalovAK.Sprint1.Task5.V6.Lib;
namespace Tyuiu.UhalovAK.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int k = 17;
            int res = ds.Calculate(k);
            Assert.AreEqual(3, res);
        }
    }
}