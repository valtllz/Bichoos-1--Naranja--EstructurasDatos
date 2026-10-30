using Bichoos1;

ListaEnlazadaSimple lista = new();

int opcion;

do
{
    Console.WriteLine("\n===== BICHOOS =====");
    Console.WriteLine("1. Agregar insecto");
    Console.WriteLine("2. Mostrar insectos");
    Console.WriteLine("3. Buscar insecto");
    Console.WriteLine("4. Eliminar insecto");
    Console.WriteLine("5. Salir");

    Console.Write("Seleccione una opcion: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Nombre del insecto: ");
            string nombre = Console.ReadLine()!;
            lista.Agregar(nombre);
            break;

        case 2:
            lista.Mostrar();
            break;

        case 3:
            Console.Write("Insecto a buscar: ");
            string buscar = Console.ReadLine()!;

            if (lista.Buscar(buscar))
                Console.WriteLine("✅ Insecto encontrado");
            else
                Console.WriteLine("❌ Insecto no encontrado");

            break;

        case 4:
            Console.Write("Insecto a eliminar: ");
            string eliminar = Console.ReadLine()!;

            lista.Eliminar(eliminar);
            Console.WriteLine("Proceso completado");
            break;

        case 5:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opcion invalida");
            break;
    }

} while (opcion != 5);