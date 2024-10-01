using Tyuiu.UhalovAK.Sprint1.Task2.V26.Lib;
namespace Tyuiu.UhalovAK.Sprint1.Task2.V26
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Задано текущее время в часах и минутах.                                 *");
            Console.WriteLine("* Вычислить,сколько минут прошло с начала суток.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* 60*x+y                                                                  *");
            Console.WriteLine("***************************************************************************");

            int  x, y;

            Console.WriteLine("Введите Часы:");
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите Минуты:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculateMinutesSinceStart(x,y));

            Console.ReadLine();
        }
    }
}