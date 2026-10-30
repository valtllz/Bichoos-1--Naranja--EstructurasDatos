using System;

class Program
{
    static void Main()
    {
        ListaCircular ciclo =
            new ListaCircular();

        ciclo.Inicializar();

        DiccionarioBichoos dic =
            new DiccionarioBichoos();

        dic.Agregar();

        GrafoBosque grafo =
            new GrafoBosque();

        grafo.AgregarZona("Bosque");
        grafo.AgregarZona("Pantano");
        grafo.AgregarZona("Flores");

        grafo.Conectar(
            "Bosque",
            "Pantano");

        grafo.Conectar(
            "Bosque",
            "Flores");

        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("=== BICHOOS ===");
            Console.WriteLine("1 Lista Circular");
            Console.WriteLine("2 Diccionario");
            Console.WriteLine("3 Grafo");
            Console.WriteLine("0 Salir");

            opcion =
            Convert.ToInt32(
            Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    ciclo.Mostrar();
                    ciclo.Avanzar();

                    break;

                case 2:

                    dic.Mostrar();

                    break;

                case 3:

                    grafo.Mostrar();

                    break;
            }

        } while (opcion != 0);
    }
}