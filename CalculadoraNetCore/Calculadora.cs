using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraNetCore
{
    public class Calculadora : ICalculadora
    {
        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            int result;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Log.Error(e.StackTrace);
                Log.Information(e.Message);
                throw;
            }
            PrintResultOfCalc(result);
            return result;
        }

        public void PrintResultOfCalc(int result)
        {
            Console.WriteLine(ConfigHelper.Configuration["calucladoraResult"], this.GetType().FullName, result);
        }
    }
}
