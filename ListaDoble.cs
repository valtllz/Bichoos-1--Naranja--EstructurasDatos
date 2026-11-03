public class Nodo
{
    public int Dato;
    public Nodo? Siguiente;
    public Nodo? Anterior;

    public Nodo(int dato)
    {
        Dato = dato;
    }
}

public class ListaDoble
{
    private Nodo? primero;
    private Nodo? ultimo;

    public void Insertar(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (primero == null)
        {
            primero = ultimo = nuevo;
        }
        else
        {
            nuevo.Anterior = ultimo;
            ultimo!.Siguiente = nuevo;
            ultimo = nuevo;
        }
    }

    public bool Buscar(int dato)
    {
        Nodo? actual = primero;

        while (actual != null)
        {
            if (actual.Dato == dato)
                return true;

            actual = actual.Siguiente;
        }

        return false;
    }

    public bool Eliminar(int dato)
    {
        Nodo? actual = primero;

        while (actual != null && actual.Dato != dato)
            actual = actual.Siguiente;

        if (actual == null)
            return false;

        if (actual.Anterior != null)
            actual.Anterior.Siguiente = actual.Siguiente;
        else
            primero = actual.Siguiente;

        if (actual.Siguiente != null)
            actual.Siguiente.Anterior = actual.Anterior;
        else
            ultimo = actual.Anterior;

        return true;
    }

    public void Mostrar()
    {
        Nodo? actual = primero;

        while (actual != null)
        {
            Console.Write(actual.Dato + " <-> ");
            actual = actual.Siguiente;
        }

        Console.WriteLine("null");
    }
}