using System;

public class ListaCircular
{
    private Nodo cabeza = null!;

    public void Inicializar()
    {
        Agregar("Mañana");
        Agregar("Tarde");
        Agregar("Noche");
        Agregar("Madrugada");
    }

    public void Agregar(string momento)
    {
        Nodo nuevo = new Nodo(momento);

        if (cabeza == null)
        {
            cabeza = nuevo;
            nuevo.Siguiente = cabeza;
            return;
        }

        Nodo temp = cabeza;

        while (temp.Siguiente != cabeza)
        {
            temp = temp.Siguiente;
        }

        temp.Siguiente = nuevo;
        nuevo.Siguiente = cabeza;
    }

    public void Mostrar()
    {
        Nodo temp = cabeza;

        do
        {
            Console.Write(temp.Momento + " -> ");
            temp = temp.Siguiente;
        }
        while (temp != cabeza);

        Console.WriteLine("Inicio");
    }

    public void Avanzar()
    {
        Console.WriteLine("Actual: " + cabeza.Momento);

        cabeza = cabeza.Siguiente;

        Console.WriteLine("Nuevo: " + cabeza.Momento);
    }

    public void Buscar(string momento)
    {
        Nodo temp = cabeza;

        do
        {
            if (temp.Momento == momento)
            {
                Console.WriteLine("Encontrado");
                return;
            }

            temp = temp.Siguiente;

        } while (temp != cabeza);

        Console.WriteLine("No encontrado");
    }
}