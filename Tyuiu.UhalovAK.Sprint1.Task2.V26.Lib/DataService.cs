using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UhalovAK.Sprint1.Task2.V26.Lib
{
    public class DataService : ISprint1Task2V26
    {
        public int CalculateMinutesSinceStart(int value, int valueTwo)
        {
            return 60 * value + valueTwo;
        }
    }
}
