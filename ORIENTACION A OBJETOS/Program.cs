using System;
using ORIENTACION_A_OBJETOS.MisClases;

namespace ORIENTACION_A_OBJETOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miCarro = new Vehiculo(2090, "Amarillo", "Mitsubishi");
            Electrico miBYD = new Electrico(2021, "Blanco", "Changan");
            AutoCombustion miAuto = new AutoCombustion(2015, "Rojo", "Toyota");
            Motocicleta miMoto = new Motocicleta(2025, "Amarillo", "Suzuki Vstrom", "Crucero", true);
            Camion miCamion = new Camion(2018, "Blanco", "Volkswagen", 15.5, 3);
            Trailer miTrailer = new Trailer(2020, "Gris", "Peterbilt", 20.0);

            while (true)
            {
                Console.WriteLine("\n--- Menú de Vehículos ---");
                Console.WriteLine("1. Ver auto normal");
                Console.WriteLine("2. Ver auto eléctrico");
                Console.WriteLine("3. Ver auto de combustión");
                Console.WriteLine("4. Ver motocicleta");
                Console.WriteLine("5. Ver camión");
                Console.WriteLine("6. Ver tráiler");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        InteractuarConAuto(miCarro);
                        break;
                    case 2:
                        InteractuarConElectrico(miBYD);
                        break;
                    case 3:
                        InteractuarConAutoCombustion(miAuto);
                        break;
                    case 4:
                        InteractuarConMotocicleta(miMoto);
                        break;
                    case 5:
                        InteractuarConCamion(miCamion);
                        break;
                    case 6:
                        InteractuarConTrailer(miTrailer);
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void InteractuarConAuto(Vehiculo auto)
        {
            Console.WriteLine("\n--- Interactuando con el Auto Normal ---");
            Chofer chofer = new Chofer("Ana", 20, 'C');
            auto.AsignarPiloto(chofer);
            auto.InformacionVehiculo();
            auto.Color = "Rojo";
            Console.WriteLine("Nuevo color:");
            auto.InformacionVehiculo();
            auto.Encender();
            auto.Acelerar(50);
            auto.Frenar(20);
        }

        static void InteractuarConElectrico(Electrico electrico)
        {
            Console.WriteLine("\n--- Interactuando con el Auto Eléctrico ---");
            Chofer chofer = new Chofer("Luis", 22, 'C');
            electrico.AsignarPiloto(chofer);
            electrico.InformacionVehiculo();
            electrico.CargarBateria(20);
            electrico.Encender();
            electrico.Acelerar(100);
        }

        static void InteractuarConAutoCombustion(AutoCombustion autoCombustion)
        {
            Console.WriteLine("\n--- Interactuando con el Auto de Combustión ---");
            Chofer chofer = new Chofer("María", 25, 'C');
            autoCombustion.AsignarPiloto(chofer);
            autoCombustion.InformacionVehiculo();
            autoCombustion.Encender();
            autoCombustion.Acelerar(30);
            Console.WriteLine("Nivel de combustible: " + autoCombustion.ObtenerCombustible() + "%");
        }

        static void InteractuarConMotocicleta(Motocicleta motocicleta)
        {
            Console.WriteLine("\n--- Interactuando con la Motocicleta ---");
            Chofer chofer = new Chofer("José", 18, 'M');
            motocicleta.AsignarPiloto(chofer);
            motocicleta.InformacionVehiculo();
            motocicleta.Encender();
            motocicleta.Acelerar(80);
            motocicleta.HacerCaballito();
            Console.WriteLine(motocicleta.TieneMaletas() ? "La motocicleta tiene maletas laterales." : "La motocicleta no tiene maletas laterales.");
        }

        static void InteractuarConCamion(Camion camion)
        {
            Console.WriteLine("\n--- Interactuando con el Camión ---");
            Chofer chofer = new Chofer("Juan", 30, 'A');
            camion.AsignarPiloto(chofer);
            camion.InformacionVehiculo();
            camion.Encender();
            camion.Acelerar(50);
            camion.CargarMercancia(10.0);
        }

        static void InteractuarConTrailer(Trailer trailer)
        {
            Console.WriteLine("\n--- Interactuando con el Tráiler ---");
            Chofer chofer = new Chofer("Carlos", 25, 'A');
            trailer.AsignarPiloto(chofer);
            trailer.InformacionVehiculo();
            trailer.Encender();
            trailer.EngancharRemolque();
            trailer.Acelerar(50);
            trailer.Frenar(50);
            trailer.DesengancharRemolque();
        }
    }
}﻿
