namespace Bichoos1;

public class ListaEnlazadaSimple
{
    private Nodo? cabeza;

    public void Agregar(string nombre)
    {
        Nodo nuevo = new Nodo(nombre);

        if (cabeza == null)
        {
            cabeza = nuevo;
            return;
        }

        Nodo actual = cabeza;

        while (actual.Siguiente != null)
        {
            actual = actual.Siguiente;
        }

        actual.Siguiente = nuevo;
    }

    public void Mostrar()
    {
        Nodo? actual = cabeza;

        Console.WriteLine("\n=== INSECTOS ENCONTRADOS ===");

        while (actual != null)
        {
            Console.WriteLine(actual.Nombre);
            actual = actual.Siguiente;
        }
    }

    public bool Buscar(string nombre)
    {
        Nodo? actual = cabeza;

        while (actual != null)
        {
            if (actual.Nombre == nombre)
            {
                return true;
            }

            actual = actual.Siguiente;
        }

        return false;
    }
}