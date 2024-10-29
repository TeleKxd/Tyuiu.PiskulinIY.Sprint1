using System.Security.Cryptography;
using Tyuiu.PiskulinIY.Sprint1.Task3.V10.Lib;
namespace Tyuiu.PiskulinIY.Sprint1.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Пискулин Игорь Юрьевич | ИСТНб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая преобразует введенное с клавиатуры дробное  *");
            Console.WriteLine("* число в денежный формат. Ответ округлите до 3 знаков после запятой.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double number;
            Console.Write("Введите дробное число -> ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{number} руб. - это {Math.Truncate(number)} руб. {(number * 100 % 100)} коп. "); Console.WriteLine(ds.NumberToMoney(number));
            Console.ReadKey();
        }
    }
}
