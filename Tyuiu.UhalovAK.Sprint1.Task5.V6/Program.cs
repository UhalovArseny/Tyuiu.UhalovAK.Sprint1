using Tyuiu.UhalovAK.Sprint1.Task5.V6.Lib;
namespace Tyuiu.UhalovAK.Sprint1.Task5.V6
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Присвоить целой переменной n значение 1,2,...,7 в зависимости от того,  *");
            Console.WriteLine("* на какой день недели  приходится k-й день невисокосного года             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int k;
            Console.WriteLine("Введите к (день невысокосного года): ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("День недели: " + ds.Calculate(k));
            Console.ReadKey();
        }
    }
}