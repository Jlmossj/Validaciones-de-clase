using System;
using System.Collections.Generic;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }
        protected int VelocidadActual = 0;
        private int estadovehiculo = 0; // 0 = apagado, 1 = encendido, 2 = en movimiento
        private Chofer piloto = null;

        protected virtual int VelocidadMaxima { get; set; } = 100;
        protected virtual int CapacidadTanque { get; set; } = 10;
        protected virtual int ConsumoCombustible { get; set; } = 1;

        protected List<string> TiposDeLicenciaAceptados = new List<string> { "A", "B", "C" };

        public Vehiculo(int año, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = año;
        }

        public virtual string InformacionVehiculo()
        {
            string estadoTexto = estadovehiculo switch
            {
                0 => "Apagado",
                1 => "Encendido",
                2 => "En movimiento",
                _ => "Desconocido"
            };

            return $"Color: {Color}\n" +
                   $"Modelo: {Modelo}\n" +
                   $"Año: {Year}\n" +
                   $"Velocidad actual: {VelocidadActual} km/h\n" +
                   $"Velocidad máxima: {VelocidadMaxima} km/h\n" +
                   $"Estado: {estadoTexto}\n" +
                   $"Piloto asignado: {(piloto != null ? piloto.Nombre : "Ninguno")}";
        }

        public string Encender()
        {
            if (piloto == null)
            {
                return "No se puede encender el vehículo sin un piloto";
            }

            if (estadovehiculo == 0)
            {
                estadovehiculo = 1;
                return "Vehículo encendido";
            }
            return "Vehículo ya encendido";
        }

        public virtual void Acelerar(int cuanto)
        {
            if (estadovehiculo == 0)
            {
                Console.WriteLine("No se puede acelerar, el vehículo está apagado.");
                return;
            }

            int nuevaVelocidad = VelocidadActual + cuanto;
            if (nuevaVelocidad > VelocidadMaxima)
            {
                Console.WriteLine($"¡Alerta! No se puede superar la velocidad máxima de {VelocidadMaxima} km/h.");
                VelocidadActual = VelocidadMaxima;
            }
            else
            {
                VelocidadActual = nuevaVelocidad;
            }
            estadovehiculo = 2;
            Console.WriteLine($"Vas a {VelocidadActual} km/h");
        }

        public void Frenar(int cuanto)
        {
            if (estadovehiculo == 0)
            {
                Console.WriteLine("No se puede frenar, el vehículo está apagado.");
                return;
            }

            VelocidadActual -= cuanto;
            if (VelocidadActual <= 0)
            {
                VelocidadActual = 0;
                estadovehiculo = 1;
                Console.WriteLine("El vehículo se ha detenido.");
            }
            else
            {
                Console.WriteLine($"Frenando... Velocidad actual: {VelocidadActual} km/h");
            }
        }

        public string Apagar()
        {
            if (VelocidadActual > 0)
            {
                return "No se puede apagar el vehículo en movimiento.";
            }
            if (estadovehiculo == 1)
            {
                estadovehiculo = 0;
                return "Vehículo apagado";
            }
            return "El vehículo ya está apagado";
        }

        public string AsignarPiloto(Chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!TiposDeLicenciaAceptados.Contains(elPiloto.TipoLicencia.ToString()))
            {
                return "El piloto no tiene la licencia adecuada";
            }
            if (piloto != null)
            {
                return "Piloto ya asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado exitosamente";
        }
    }
}