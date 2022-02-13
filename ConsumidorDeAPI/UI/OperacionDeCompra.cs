using System;
using System.Collections.Generic;

namespace UI
{
    public class OperacionDeCompra : ISujeto
    {
        private Random _rng = new Random();
        private readonly List<IObservador> _observadores = new();

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

        public void Agregar(IObservador usuario)
        {
            if (!_observadores.Contains(usuario))
            {
                _observadores.Add(usuario);
            }
        }

        public void Quitar(IObservador usuario)
        {
            if (_observadores.Contains(usuario))
            {
                _observadores.Remove(usuario);
            }
        }

        void ISujeto.Notificar()
        {
            foreach (var observador in _observadores)
            {
                observador.Actualizar(this);
            }
        }
    }
}