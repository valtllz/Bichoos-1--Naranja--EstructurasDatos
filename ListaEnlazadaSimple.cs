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
}