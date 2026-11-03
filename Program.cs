using Bichoos1;

ListaEnlazadaSimple lista = new();
MapaBosque mapa = new();
Mochila mochila = new();

// NUEVAS ESTRUCTURAS DEL PAQUETE 2
ListaDoble listaDoble = new();
ListaGenerica listaGenerica = new();
ColaGenerica colaGenerica = new();

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

    // PAQUETE 2
    Console.WriteLine("9. Probar Lista Doblemente Enlazada");
    Console.WriteLine("10. Probar List<T>");
    Console.WriteLine("11. Probar Queue<T>");

    Console.WriteLine("0. Salir");

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

        // LISTA DOBLEMENTE ENLAZADA
        case 9:

            listaDoble.Insertar(10);
            listaDoble.Insertar(20);
            listaDoble.Insertar(30);

            Console.WriteLine("\nLista doble:");
            listaDoble.Mostrar();

            Console.WriteLine($"Buscar 20: {listaDoble.Buscar(20)}");

            listaDoble.Eliminar(20);

            Console.WriteLine("Después de eliminar 20:");
            listaDoble.Mostrar();
            break;

        // LIST<T>
        case 10:

            listaGenerica.Agregar("Escarabajo");
            listaGenerica.Agregar("Araña");
            listaGenerica.Agregar("Hormiga");

            Console.WriteLine("\nEnemigos activos:");
            listaGenerica.Mostrar();

            Console.WriteLine(
                $"¿Existe Araña? {listaGenerica.Buscar("Araña")}"
            );

            listaGenerica.Eliminar("Araña");

            Console.WriteLine("Después de eliminar Araña:");
            listaGenerica.Mostrar();

            break;

        // QUEUE<T>
        case 11:

            colaGenerica.Agregar("Oleada 1");
            colaGenerica.Agregar("Oleada 2");
            colaGenerica.Agregar("Oleada 3");

            Console.WriteLine("\nCola actual:");
            colaGenerica.Mostrar();

            colaGenerica.MostrarSiguiente();

            colaGenerica.Atender();

            Console.WriteLine("Después de atender:");
            colaGenerica.Mostrar();

            break;

        case 0:
            Console.WriteLine("Hasta luego.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 0);