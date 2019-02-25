using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraNetCore
{
    public interface ICalculadora
    {
        int Suma(int num1, int num2);
        int Resta(int num1, int num2);
        int Multiplicacion(int num1, int num2);
        int Division(int num1, int num2);
    }
}
