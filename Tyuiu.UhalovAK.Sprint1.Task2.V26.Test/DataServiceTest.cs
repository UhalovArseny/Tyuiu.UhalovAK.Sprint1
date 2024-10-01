 
namespace Tyuiu.UhalovAK.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 15;

            var res = ds.CalculateMinutesSinceStart(x, y);
            Assert.AreEqual(135, res);
        }
    }
}