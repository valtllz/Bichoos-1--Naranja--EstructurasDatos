using Bichoos1;

ListaEnlazadaSimple lista = new();
MapaBosque mapa = new();
Mochila mochila = new();

int opcion;

do
{
    Console.WriteLine("\n===== BICHOOS =====");
    Console.WriteLine("1. Agregar insecto");
    Console.WriteLine("2. Mostrar insectos");
    Console.WriteLine("3. Buscar insecto");
    Console.WriteLine("4. Eliminar insecto");
    Console.WriteLine("5. Mostrar mapa");
    Console.WriteLine("6. Recolectar recurso");
    Console.WriteLine("7. Ver último recurso");
    Console.WriteLine("8. Retirar último recurso");
    Console.WriteLine("9. Salir");

    Console.Write("Opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Opción inválida");
        continue;
    }

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
                Console.WriteLine("Insecto encontrado");
            else
                Console.WriteLine("Insecto no encontrado");

            break;

        case 4:
            Console.Write("Insecto a eliminar: ");
            string eliminar = Console.ReadLine()!;
            lista.Eliminar(eliminar);
            break;

        case 5:
            mapa.MostrarMapa();
            break;

        case 6:
            Console.Write("Recurso recolectado: ");
            string recurso = Console.ReadLine()!;
            mochila.Recolectar(recurso);
            break;

        case 7:
            mochila.VerUltimo();
            break;

        case 8:
            mochila.Retirar();
            break;

        case 9:
            Console.WriteLine("Hasta luego.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 9);