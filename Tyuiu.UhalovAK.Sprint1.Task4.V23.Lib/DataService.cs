using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UhalovAK.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Sqrt(x + y)) / Math.Abs(3 - x);
            return Math.Round(res, 3);

        }
    }
}
