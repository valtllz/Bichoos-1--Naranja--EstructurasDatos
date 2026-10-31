using System;

class Program
{
    static void Main()
    {
        ListaCircular tiempo = new ListaCircular();

        DiccionarioBichoos diccionario =
            new DiccionarioBichoos();

        diccionario.Agregar();

        GrafoBosque grafo =
            new GrafoBosque();

        grafo.AgregarZona("Bosque");
        grafo.AgregarZona("Pantano");
        grafo.AgregarZona("Flores");

        grafo.Conectar("Bosque", "Pantano");
        grafo.Conectar("Bosque", "Flores");

        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("===== BICHOOS =====");
            Console.WriteLine("1. Lista Circular");
            Console.WriteLine("2. Diccionario");
            Console.WriteLine("3. Grafo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");

            string entrada = Console.ReadLine()!;

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Debe ingresar un numero.");
                continue;
            }

            switch (opcion)
            {
                case 1:

                    Console.WriteLine("\nCICLO DIA/NOCHE");

                    tiempo.Mostrar();
                    tiempo.Avanzar();

                    break;

                case 2:

                    Console.WriteLine("\nINSECTOS");

                    diccionario.Mostrar();

                    break;

                case 3:

                    Console.WriteLine("\nMAPA DEL BOSQUE");

                    grafo.Mostrar();

                    break;

                case 0:

                    Console.WriteLine("Hasta luego.");
                    break;

                default:

                    Console.WriteLine("Opcion incorrecta.");
                    break;
            }

        } while (opcion != 0);
    }
}