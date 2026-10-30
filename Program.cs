
class Program
{
    static void Main()
    {
        ListaCircularTiempo tiempo =
            new ListaCircularTiempo();

        tiempo.AgregarMomento("Mañana");
        tiempo.AgregarMomento("Tarde");
        tiempo.AgregarMomento("Noche");
        tiempo.AgregarMomento("Madrugada");

        int opcion;

        do
        {
            Console.WriteLine("\n=== BICHOOS ===");
            Console.WriteLine("1. Mostrar ciclo");
            Console.WriteLine("2. Avanzar tiempo");
            Console.WriteLine("3. Buscar momento");
            Console.WriteLine("4. Salir");

            Console.Write("Opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tiempo.MostrarCiclo();
                    break;

                case 2:
                    tiempo.AvanzarTiempo();
                    break;

                case 3:

                    Console.Write("Momento a buscar: ");

                    string buscar =
                    Console.ReadLine();

                    tiempo.BuscarMomento(buscar);

                    break;

                case 4:
                    Console.WriteLine("Adios.");
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta.");
                    break;
            }

        } while (opcion != 4);
    }
}