﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PiskulinIY.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            return Convert.ToDouble(Math.Truncate(number).ToString() + "," + (number * 100 % 100).ToString());
        }
    }
}


