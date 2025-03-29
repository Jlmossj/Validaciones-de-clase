using System;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private string tipo;
        private bool tieneMaletas;

        protected override int VelocidadMaxima { get; set; } = 200;
        protected override int CapacidadTanque { get; set; } = 5;
        protected override int ConsumoCombustible { get; set; } = 1;

        public Motocicleta(int año, string elColor, string elModelo, string tipo, bool tieneMaletas)
            : base(año, elColor, elModelo)
        {
            this.tipo = tipo;
            this.tieneMaletas = tieneMaletas;
            TiposDeLicenciaAceptados = new List<string> { "M" };
        }

        public string ObtenerTipo()
        {
            return tipo;
        }

        public bool TieneMaletas()
        {
            return tieneMaletas;
        }

        public void HacerCaballito()
        {
            if (VelocidadActual > 0)
            {
                Console.WriteLine("La motocicleta está haciendo un caballito.");
            }
            else
            {
                Console.WriteLine("No se puede hacer un caballito, la moto no está en movimiento.");
            }
        }

        public override string InformacionVehiculo()
        {
            return base.InformacionVehiculo() + $"\nTipo de manillar: {tipo}\nTiene maletas: {(tieneMaletas ? "Sí" : "No")}";
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            Console.WriteLine("La motocicleta acelera rápidamente.");
        }
    }
}