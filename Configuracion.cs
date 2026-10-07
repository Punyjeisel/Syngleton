using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Aula_
{
    public class Configuracion
    {
        private static Configuracion instancia;

        private string _nombreAplicacion;
        private string _version;
        private string _idioma;
        private string _ambiente;
        private Configuracion()
        {
            Console.WriteLine("Configuracion");
        }

        public static Configuracion ObtenerInstancia(string nombre, string version, string idioma, string ambiente)
        {
            // Retorna la instancia de la clase Configuracion.

            if (instancia == null)
            {
                instancia = new Configuracion();
                instancia._nombreAplicacion = nombre;
                instancia._version = version;
                instancia._idioma = idioma;
                instancia._ambiente = ambiente;
            }

            return instancia;
        }

        public static void MostrarConfiguracion()
        {
            Console.WriteLine($"Nombre de la aplicacion: {instancia._nombreAplicacion}");
            Console.WriteLine($"Version: {instancia._version}");
            Console.WriteLine($"Idioma: {instancia._idioma}");
            Console.WriteLine($"Ambiente: {instancia._ambiente}");
        }

        public static void ModificarNombre()
        {
            Console.WriteLine("Modificar Nombre de la aplicacion");
            instancia._nombreAplicacion = Console.ReadLine();
            Console.WriteLine("Nombre modificado");
        }
        public static void ModificarVersion() {
            Console.WriteLine("Modificar version");
            instancia._version = Console.ReadLine();
            Console.WriteLine("Version modificada");
        }
        public static void ModificarIdioma()
        {
            int opcion = 0;
            Console.WriteLine("Modificar Idioma");
            Console.WriteLine();
            Console.WriteLine("1. Español");
            Console.WriteLine("2. Inglés");
            Console.WriteLine();
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    instancia._idioma = "ESP";
                    Console.WriteLine("Idioma modificado a Español");
                    break;
                case 2:
                    instancia._idioma = "ING";
                    Console.WriteLine("Idioma modificado a Inglés");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    ModificarIdioma();
                    break;
            }
        }
        public static void ModificarAmbiente()
        {
            Console.WriteLine("Modificar Ambiente");
            Console.WriteLine();
            Console.WriteLine("1. Dev");
            Console.WriteLine("2. Prod");
            Console.WriteLine();
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    instancia._ambiente = "Dev";
                    Console.WriteLine("Ambiente modificado a Dev");
                    break;
                case 2:
                    instancia._ambiente = "Prod";
                    Console.WriteLine("Ambiente modificado a Prod");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    ModificarAmbiente();
                    break;
            }
        }
    }
}
