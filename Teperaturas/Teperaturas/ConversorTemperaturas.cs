using System;
namespace Tempersturas
{
    public static class ConversorTemperaturas
    {
        public static double FtoC(double temp)
        {
            return Math.Round((temp - 32) / 1.8, 2);
        }
    }
}
