﻿using System.Reflection.Metadata;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PiskulinIY.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(Math.E, x) - (((Math.Pow(y, 2)) + Math.Cos(Math.Pow(x, 3)) + 12 * x * y - 3 * Math.Pow(x, 2))) / ((Math.Cos(Math.Pow(x, 3) + 3) + 18 * y - 1));
            
            return Math.Round(res, 3);
        }
    }
}
