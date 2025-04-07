using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ClsVehiculo
    {
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public string PotenciaCV { get; set; }

        public void getMatricula()
        {
            Console.WriteLine("Ingrese la matricula del vehiculo");
            Matricula = Console.ReadLine();
        }
        public void getModelo()
        {
            Console.WriteLine("Ingrese el modelo de su vehiculo");
            Modelo = Console.ReadLine();
        }
        public void getPotenciaCV()
        {
            Console.WriteLine("Ingrese la potencia de su vehiculo");
            PotenciaCV = Console.ReadLine();
        }
    }
    public class ClsTaxi : ClsVehiculo
    {
        public string numeroLicencia { get; set; }
        public void setNumeroLicencia(string Licencia)
        {
            numeroLicencia = Licencia;
        }
        public void getNumeroLicencia() 
        {
            Console.WriteLine("Ingrese el número de licencia de su Taxi");
            numeroLicencia = Console.ReadLine();
        }
    }
    public class ClsAutobus : ClsVehiculo
    {
        public string numeroPlazas { get; set; }
        public void setNumeroPlazas(string plazas)
        {
            numeroPlazas = plazas;
        }
        public void getNumeroPlazas()
        {
            Console.WriteLine("Ingrese el número de plazas de su autobus");
            numeroPlazas = Console.ReadLine();
        }
    }
}
