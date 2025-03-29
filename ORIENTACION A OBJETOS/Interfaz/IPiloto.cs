using System;

namespace ORIENTACION_A_OBJETOS.Interfaz
{
    internal interface IPiloto
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        char TipoLicencia { get; set; }
        void MostrarInfo();
    }
}