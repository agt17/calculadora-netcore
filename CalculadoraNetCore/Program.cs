using Serilog;
using System;

namespace CalculadoraNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                        .WriteTo.Console()
                        .WriteTo.File("log.txt",
                            outputTemplate: ConfigHelper.Configuration["logOutputTemplate"])
                        .CreateLogger();

            Calculadora calculadora = new Calculadora();
            int suma = calculadora.Suma(2, 2);
            int resta = calculadora.Resta(4, 2);
            int multiplicacion = calculadora.Multiplicacion(4, 2);
            int division = calculadora.Division(4, 0);
            
            Console.ReadKey();
        }
    }
}
