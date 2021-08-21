using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Quieres convertir Euros o Dolares?");
            Console.WriteLine(" ");
            Console.WriteLine($"Pressione '1' para Euro.");
            Console.WriteLine($"Pressione '2' para Dolares.");

            int seleccion = Int32.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    ConvertToEuro();
                    break;
                case 2:
                    ConvertToDolar();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            
        }

        private static void ConvertToEuro()
        {
            Conversor conversionEur = new Conversor();

            Console.WriteLine(" ");
            Console.WriteLine("Has seleccionado Euros.");
            Console.WriteLine(" ");
            Console.WriteLine("Cuantos Euros quieres convertir a Dolares?");
            double eurosConvertir = double.Parse(Console.ReadLine());

            Console.WriteLine($"Has convertido tus {eurosConvertir} Euros a {conversionEur.EuroToDolar(eurosConvertir)} Dolares");

        }
        private static void ConvertToDolar()
        {
            Conversor conversionToDolar = new Conversor();

            Console.WriteLine(" ");
            Console.WriteLine("Has seleccionado Dolares.");
            Console.WriteLine(" ");
            Console.WriteLine("Cuantos Dolares quieres convertir a Euros?");
            double dolaresConvertir = double.Parse(Console.ReadLine());

            Console.WriteLine($"Has convertido tus {dolaresConvertir} Dolares a {conversionToDolar.DolarToEuro(dolaresConvertir)} Euros"); ;
        }
    }

    class Conversor
    { 
        private const double _euro = 0.85;
        private const double _dolar = 1.17;
        public double EuroToDolar(double euro) => euro * _dolar;
        public double DolarToEuro(double dolar) => dolar * _euro;

    }
}
