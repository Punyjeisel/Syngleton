using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Aula_
{
    internal class CentroUsuario
    {
        Program program = new Program();
        private string nombreUsuario = "None";
        private int id = 0000;
        public bool loggedIn = false;

        public void MenuCentroUsuario()
        {
            Console.WriteLine("Perfil De usario");

            Console.WriteLine($"Nombre: {nombreUsuario}");
            Console.WriteLine($"ID: {id}");
            Configuracion.MostrarConfiguracion();


            int opcion = 0;
            Console.WriteLine("Menu Centro de Usuario");
            Console.WriteLine();
            Console.WriteLine("1. Crear Usuario");
            Console.WriteLine("2. Modificar perfil");
            Console.WriteLine("3. Modificar configuracion");
            Console.WriteLine("4. Volver al menu principal");
            Console.WriteLine();
            Console.Write("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (!loggedIn)
                    {
                        Console.Write("Ingrese su nombre de usuario: ");
                        nombreUsuario = Console.ReadLine();
                        Console.Write("Ingrese su ID de usuario: ");
                        id = int.Parse(Console.ReadLine());
                        loggedIn = true;
                        Console.WriteLine("Usuario creado exitosamente.");
                        MenuCentroUsuario();
                    }
                    else
                    {
                        Console.WriteLine("Ya hay un usuario logueado.");
                        MenuCentroUsuario();
                    }
                    break;
                case 2:
                    Console.WriteLine("Modificar perfil: ");
                    if (loggedIn)
                    {
                        Console.WriteLine($"Nombre: {nombreUsuario}");
                        Console.Write("Ingrese su nuevo nombre de usuario: ");
                        nombreUsuario = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine($"ID: {id}");
                        Console.Write("Ingrese su nuevo ID de usuario: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Perfil modificado exitosamente.");
                        MenuCentroUsuario();
                    }
                    else
                    {
                        Console.WriteLine("No hay ningun usuario logueado.");
                        MenuCentroUsuario();
                    }
                    break;
                case 3:

                    Configuracion.MostrarConfiguracion();
                    Console.WriteLine("QUe desea modificar?");
                    Console.WriteLine();
                    Console.WriteLine("1. Nombre de la aplicacion");
                    Console.WriteLine("2. Version");
                    Console.WriteLine("3. Idioma");
                    Console.WriteLine("4. Ambiente");
                    Console.WriteLine();
                    Console.Write("Seleccione una opcion: ");
                    int opcionConfig = int.Parse(Console.ReadLine());
                    switch (opcionConfig)
                    {
                        case 1:
                            Configuracion.ModificarNombre();
                            break;
                        case 2:
                            Configuracion.ModificarVersion();
                            break;
                        case 3:
                            Configuracion.ModificarIdioma();
                            break;
                        case 4:
                            Configuracion.ModificarAmbiente();
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                    MenuCentroUsuario();
                    break;
                case 4:
                    Console.WriteLine("Volviendo al menu principal...");
                    program.MenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}
