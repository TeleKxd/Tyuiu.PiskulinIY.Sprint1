using System.Security.Cryptography;
using Tyuiu.PiskulinIY.Sprint1.Task3.V10.Lib;
namespace Tyuiu.PiskulinIY.Sprint1.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds3 = new DataService();
            DataService1 ds33 = new DataService1();

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

            Console.WriteLine("Введите дробное число: ");
            number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(+number + " руб. - это " + ds3.NumberToMoney(number) + " руб. " + ds33.NumberToMoney(number) + " коп. ");

            Console.ReadKey();
        }
    }
}
