using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UhalovAK.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            if (k % 7 == 1) return 1;
            if (k % 7 == 2) return 2;
            if (k % 7 == 3) return 3;
            if (k % 7 == 4) return 4;
            if (k % 7 == 5) return 5;
            if (k % 7 == 6) return 6;
            if (k % 7 == 0) return 7;
            return 0;
        }
    }
}
