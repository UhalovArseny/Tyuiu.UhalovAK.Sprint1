using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UhalovAK.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            double res = startAmount * (percent / 365 / 100) * timeDays ;


            double amount = Math.Round(res, 3);

            return amount;
        }
    }
}
