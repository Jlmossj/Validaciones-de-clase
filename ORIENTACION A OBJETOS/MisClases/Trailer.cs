using System;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Trailer : Vehiculo
    {
        private double capacidadRemolque;
        private bool remolqueEnganchado;

        protected override int VelocidadMaxima { get; set; } = 100;
        protected override int CapacidadTanque { get; set; } = 80;
        protected override int ConsumoCombustible { get; set; } = 3;

        public Trailer(int año, string elColor, string elModelo, double capacidadRemolque)
            : base(año, elColor, elModelo)
        {
            this.capacidadRemolque = capacidadRemolque;
            this.remolqueEnganchado = false;
            TiposDeLicenciaAceptados = new List<string> { "A" };
        }

        public double ObtenerCapacidadRemolque()
        {
            return capacidadRemolque;
        }

        public bool RemolqueEnganchado()
        {
            return remolqueEnganchado;
        }

        public void EngancharRemolque()
        {
            if (VelocidadActual > 0)
            {
                Console.WriteLine("No se puede enganchar el remolque mientras el tráiler está en movimiento.");
            }
            else if (remolqueEnganchado)
            {
                Console.WriteLine("El remolque ya está enganchado.");
            }
            else
            {
                remolqueEnganchado = true;
                Console.WriteLine("Remolque enganchado exitosamente.");
            }
        }

        public void DesengancharRemolque()
        {
            if (VelocidadActual > 0)
            {
                Console.WriteLine("No se puede desenganchar el remolque mientras el tráiler está en movimiento.");
            }
            else if (!remolqueEnganchado)
            {
                Console.WriteLine("No hay remolque enganchado para desenganchar.");
            }
            else
            {
                remolqueEnganchado = false;
                Console.WriteLine("Remolque desenganchado exitosamente.");
            }
        }

        public override string InformacionVehiculo()
        {
            return base.InformacionVehiculo() + $"\nCapacidad del remolque: {capacidadRemolque} toneladas\nRemolque enganchado: {(remolqueEnganchado ? "Sí" : "No")}";
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            Console.WriteLine(remolqueEnganchado ? "El tráiler acelera lentamente con el remolque." : "El tráiler acelera sin remolque.");
        }
    }
}