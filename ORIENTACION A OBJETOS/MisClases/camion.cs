using System;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Camion : Vehiculo
    {
        private double capacidadCarga;
        private int numeroEjes;

        protected override int VelocidadMaxima { get; set; } = 120;
        protected override int CapacidadTanque { get; set; } = 50;
        protected override int ConsumoCombustible { get; set; } = 2;

        public Camion(int año, string elColor, string elModelo, double capacidadCarga, int numeroEjes)
            : base(año, elColor, elModelo)
        {
            this.capacidadCarga = capacidadCarga;
            this.numeroEjes = numeroEjes;
            TiposDeLicenciaAceptados = new List<string> { "A", "B" };
        }

        public double ObtenerCapacidadCarga()
        {
            return capacidadCarga;
        }

        public int ObtenerNumeroEjes()
        {
            return numeroEjes;
        }

        public void CargarMercancia(double peso)
        {
            if (peso <= capacidadCarga)
            {
                Console.WriteLine($"Mercancía cargada: {peso} toneladas.");
            }
            else
            {
                Console.WriteLine($"¡Advertencia! El camión no puede cargar {peso} toneladas. Capacidad máxima: {capacidadCarga} toneladas.");
            }
        }

        public override string InformacionVehiculo()
        {
            return base.InformacionVehiculo() + $"\nCapacidad de carga: {capacidadCarga} toneladas\nNúmero de ejes: {numeroEjes}";
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            Console.WriteLine("El camión acelera lentamente debido a su peso.");
        }
    }
}