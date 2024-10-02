using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UhalovAK.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double res = (2 * (Math.Cos(3 * x) / Math.Sin(3 * x))) - ((Math.Log(x)) / Math.Log(1 + (Math.Pow(x, 2))));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
