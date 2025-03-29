using System;
using System.Collections.Generic;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class AutoCombustion : Vehiculo
    {
        private int combustible;

        protected override int VelocidadMaxima { get; set; } = 160;
        protected override int CapacidadTanque { get; set; } = 12;
        protected override int ConsumoCombustible { get; set; } = 1;

        public AutoCombustion(int año, string elColor, string elModelo) : base(año, elColor, elModelo)
        {
            combustible = 100;
            TiposDeLicenciaAceptados = new List<string> { "C", "B", "A" };
        }

        public int ObtenerCombustible()
        {
            return combustible;
        }

        public void ConsumirCombustible(int cuanto)
        {
            combustible -= cuanto;
            if (combustible < 0)
            {
                combustible = 0;
            }
            Console.WriteLine($"Combustible consumido. Nivel actual: {combustible}%");
        }

        public override void Acelerar(int cuanto)
        {
            if (combustible <= 0)
            {
                Console.WriteLine("No se puede acelerar, el tanque está vacío.");
                return;
            }

            base.Acelerar(cuanto);
            ConsumirCombustible(5);
        }

        public override string InformacionVehiculo()
        {
            return base.InformacionVehiculo() + $"\nNivel de combustible: {combustible}%";
        }
    }
}