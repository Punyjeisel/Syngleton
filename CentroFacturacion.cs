using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Aula_
{
    internal class CentroFacturacion
    {
        CentroUsuario centroUsuario = new CentroUsuario();
        Program program = new Program();
        bool credito = true;
        int debito = 0;

        public void MenuCentroFacturacion()
        {
            MenuFacturacion();
        }

        public void MenuFacturacion()
        {
            Configuracion.MostrarConfiguracion();
            Console.WriteLine($"Credito: pendiente");

            int opcion = 0;
            Console.WriteLine();
            Console.WriteLine("Menu Centro de Facturacion");
            Console.WriteLine();
            Console.WriteLine("1. Pagar factura");
            Console.WriteLine("2. Modificar configuracion");
            Console.WriteLine("3. Volver al menu principal");
            Console.WriteLine();
            Console.Write("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    string valor;
                    if (credito == true)
                    {
                        Console.WriteLine("desea pagar (s/S)");
                        valor = Console.ReadLine();

                        if (valor == "s" && valor == "S")
                        {
                            Console.WriteLine("Credito pagado");
                            credito = false;
                        }
                        else
                        {
                            MenuFacturacion();
                        }
                        MenuFacturacion();
                    }else
                    {
                        Console.WriteLine("No tiene creditos pendientes");
                        MenuFacturacion();
                    }
                    break;
                case 2:
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
                    MenuFacturacion();
                    break;
                case 3:
                    Console.WriteLine("Volviendo al menu principal...");
                    program.MenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    MenuFacturacion();
                    break;
            }
        }
    }
}
