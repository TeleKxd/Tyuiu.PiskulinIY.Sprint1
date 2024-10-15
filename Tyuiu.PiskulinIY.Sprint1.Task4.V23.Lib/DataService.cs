using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PiskulinIY.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Sqrt(Math.Abs(x+y))/Math.Abs(3-x);


            return Math.Round(res, 3);
        }
    }
}
