using System;

namespace API
{
    public class OperacionDeCompra
    {
        private Random rng = new Random();

        public static readonly string[] Generos = new[]
        {
            "Masculino", "Femenino", "Otros"
        };

        public static readonly int[] Ceros = new[]
        {
            10, 100, 1000
        };
        public OperacionDeCompra(int edad, string genero, double valorCompra, double cantidad)
        {
            Edad = edad;
            Genero = genero;
            ValorCompra = valorCompra;
            Cantidad = cantidad;
        }
        public int Edad { get; set; }

        public string Genero { get; set; }

        public double ValorCompra { get; set; }
        public double Cantidad { get; set; }

    }
}
