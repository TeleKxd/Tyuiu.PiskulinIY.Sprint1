﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PiskulinIY.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {

            double res = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));


            return (int)res;





        }
    }
}
