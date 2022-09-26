using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var answer = (fahrenheit - 32) / 1.8;

            return answer;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}
