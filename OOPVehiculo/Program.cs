using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClsVehiculo> vehiculo = new List<ClsVehiculo>();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Seleccione su tipo de vehiculo \n\n1.Taxi \n2.Autobus \n3.salir");
                int opc = int.Parse(Console.ReadLine());
                
                switch (opc)
                {
                    case 1:
                        ClsTaxi taxi = new ClsTaxi();

                        taxi.getMatricula();
                        taxi.getModelo();
                        taxi.getPotenciaCV();
                        taxi.getNumeroLicencia();
                        vehiculo.Add(taxi);
                        Console.Clear();
                        break;
                    case 2:
                        ClsAutobus autobus = new ClsAutobus();

                        autobus.getMatricula();
                        autobus.getModelo();
                        autobus.getPotenciaCV();
                        autobus.getNumeroPlazas();
                        vehiculo.Add(autobus);
                        Console.Clear();
                        break;
                    case 3:
                        salir = true;
                        Console.Clear();
                    break;

                    default:
                        Console.WriteLine("Opción Invalida");
                        break;
                }
            }

            Console.WriteLine("\nVehículos registrados:");
            foreach (ClsVehiculo item in vehiculo)
            {
                if (item is ClsTaxi taxi)
                {
                    Console.WriteLine("Tipo de Vehículo: Taxi");
                    Console.WriteLine($"Matrícula: {taxi.Matricula}");
                    Console.WriteLine($"Modelo: {taxi.Modelo}");
                    Console.WriteLine($"Potencia: {taxi.PotenciaCV}");
                    Console.WriteLine($"Número de licencia: {taxi.numeroLicencia}");
                }
                else if (item is ClsAutobus autobus)
                {
                    Console.WriteLine("Tipo de Vehículo: Autobús");
                    Console.WriteLine($"Matrícula: {autobus.Matricula}");
                    Console.WriteLine($"Modelo: {autobus.Modelo}");
                    Console.WriteLine($"Potencia: {autobus.PotenciaCV}");
                    Console.WriteLine($"Número de plazas: {autobus.numeroPlazas}");
                }
                Console.WriteLine();
            }
        }
    }
}
