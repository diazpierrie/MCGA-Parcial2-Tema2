using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/{rangoEtario}")]
    public class OperacionesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<OperacionDeCompra> Get(string rangoEtario)
        {

            int edadMinima;
            int edadMaxima;
            var rng = new Random();

            switch (rangoEtario)
            {
                case "juventud":
                    edadMinima = 18;
                    edadMaxima = 26;
                    break;
                case "adultos":
                    edadMinima = 27;
                    edadMaxima = 59;
                    break;
                case "personasMayores":
                    edadMinima = 60;
                    edadMaxima = 99;
                    break;
                default:
                    edadMinima = 18;
                    edadMaxima = 99;
                    break;
            }

            return Enumerable.Range(1, 3).Select(_ => new OperacionDeCompra(
                rng.Next(edadMinima, edadMaxima),
                OperacionDeCompra.Generos[rng.Next(OperacionDeCompra.Generos.Length)],
                rng.NextDouble() * rng.Next(1, 9) * OperacionDeCompra.Ceros[rng.Next(OperacionDeCompra.Ceros.Length)],
                rng.NextDouble() * rng.Next(1, 9) * OperacionDeCompra.Ceros[rng.Next(OperacionDeCompra.Ceros.Length)])).ToArray();
        }
    }
}