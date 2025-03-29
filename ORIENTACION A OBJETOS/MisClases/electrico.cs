using System;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Electrico : Vehiculo
    {
        private int bateria;

        protected override int VelocidadMaxima { get; set; } = 180;
        protected override int CapacidadTanque { get; set; } = 0;
        protected override int ConsumoCombustible { get; set; } = 0;

        public Electrico(int año, string elColor, string elModelo) : base(año, elColor, elModelo)
        {
            bateria = 50;
            TiposDeLicenciaAceptados = new List<string> { "C", "B" };
        }

        public int CargarBateria()
        {
            return bateria;
        }

        public void CargarBateria(int cuanto)
        {
            bateria += cuanto;
            if (bateria > 100)
            {
                bateria = 100;
            }
            Console.WriteLine($"Batería cargada, nivel actual: {bateria}%");
        }

        public override void Acelerar(int cuanto)
        {
            if (bateria <= 0)
            {
                Console.WriteLine("No se puede acelerar, la batería está agotada.");
                return;
            }

            base.Acelerar(cuanto);
            bateria -= 1;
            if (bateria < 0)
            {
                bateria = 0;
            }
            Console.WriteLine($"Batería restante: {bateria}%");
        }

        public override string InformacionVehiculo()
        {
            return base.InformacionVehiculo() + $"\nNivel de batería: {bateria}%";
        }
    }
}