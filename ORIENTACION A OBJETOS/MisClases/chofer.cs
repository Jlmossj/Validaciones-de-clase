using System;
using ORIENTACION_A_OBJETOS.Interfaz;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Chofer : IPiloto
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char TipoLicencia { get; set; }

        public Chofer(string nombre, int edad, char tipoLicencia)
        {
            Nombre = nombre;
            Edad = edad;

            // Validación de tipo de licencia y edad según requisitos de Guatemala
            switch (tipoLicencia)
            {
                case 'C':
                case 'M':
                    if (edad < 18)
                        throw new ArgumentException("La edad mínima para licencias Tipo C o M es 18 años.");
                    break;
                case 'B':
                    if (edad < 21)
                        throw new ArgumentException("La edad mínima para licencia Tipo B es 21 años y requiere 2 años con Tipo C.");
                    break;
                case 'A':
                    if (edad < 23)
                        throw new ArgumentException("La edad mínima para licencia Tipo A es 23 años y requiere 3 años con Tipo B o C.");
                    break;
                case 'E':
                    if (edad < 21)
                        throw new ArgumentException("La edad mínima para licencia Tipo E es 21 años.");
                    break;
                default:
                    throw new ArgumentException("Tipo de licencia no válido. Use A, B, C, M o E.");
            }
            TipoLicencia = tipoLicencia;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("El nombre del piloto es: {0}", Nombre);
            Console.WriteLine("La edad del piloto es: {0}", Edad);
            Console.WriteLine("Tipo de Licencia: {0}", TipoLicencia);
        }
    }
}