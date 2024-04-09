// See https://aka.ms/new-console-template for more information
using System;
namespace PruebasUnitarias
{
    public class Calculadora
    {
        public int SumaDosNumeros()
        {
            int numero1 = 2;
            int numero2 = 5;

            return numero1 + numero2;
        }

        public void MostrarPantalla()
        {
            int suma = SumaDosNumeros();
            Console.WriteLine($"la suma de los numeros 2 y 5 es: {suma}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.MostrarPantalla();
        }
    }
}
