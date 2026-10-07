using Singleton_Aula_;

internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("Bienvenido al sistema academico de MKG");
        Console.WriteLine();
        Console.WriteLine("Ingrese valores de CONFIGURACION");

        Console.Write("Nombre de la aplicacion: ");
        string nombreApp = Console.ReadLine();
        Console.Write("Version: ");
        string versionApp = Console.ReadLine();
        Console.Write("Idioma: ESP o ING");
        string idiomaApp = Console.ReadLine();
        Console.Write("Ambiente: Dev o Prod");
        string ambienteApp = Console.ReadLine();

        Configuracion.ObtenerInstancia(nombreApp, versionApp,idiomaApp, ambienteApp);

        Console.WriteLine("Perfecto, ya podemos empezar");
        Program program = new Program();
        program.MenuPrincipal();
    }

    public void MenuPrincipal()
    {
        int opcion = 0;
        Console.WriteLine("Menu Principal");
        Console.WriteLine();
        Console.WriteLine("1. Centro de usuario");
        Console.WriteLine("2. Centro de facturacion");
        Console.WriteLine("3. Salir");
        Console.WriteLine();
        Console.Write("Seleccione una opcion: ");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                CentroUsuario centroUsuario = new CentroUsuario();
                Console.WriteLine("Bienvenido al centro de Usuario");
                centroUsuario.MenuCentroUsuario();
                break;
            case 2:
                CentroFacturacion centroFacturacion = new CentroFacturacion();
                Console.WriteLine("Bienvenido al Centro de facturacion");
                centroFacturacion.MenuCentroFacturacion();
                break;
            case 3:
                Console.WriteLine("Saliendo del sistema...");
                Console.WriteLine();
                Console.WriteLine("Reflexion breve: ");
                Console.WriteLine();
                Console.WriteLine("En caso de que cada uno de las clases tubieran que acceder de manera individual a la clase singleton, los registro se reiniciaria y cada uno tendria una unformacion diferente para cada ver que consulran, aparte que a gran escala es mas lento");
                Console.ReadKey();
                Console.WriteLine();
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opcion no valida");
                MenuPrincipal();
                break;
        }
        MenuPrincipal();
    }
}