using Tyuiu.UhalovAK.Sprint1.Task3.V8.Lib;
namespace Tyuiu.UhalovAK.Sprint1.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ухалов А. К. | АСОиУБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* z * (x / 100 / 365 ) * c                                                *");
            Console.WriteLine("***************************************************************************");

            double z, x, c;

            Console.WriteLine("Введите сумму вклада");
            z = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите процентную ставку");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество дней");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Доход " + ds.IncomeAmount(z, x, c));

            double sum = z + ds.IncomeAmount(z, x, c);
            Console.WriteLine(" Сумма по окончании срока вклада: " + sum );
            Console.ReadLine();
        }
    }
}