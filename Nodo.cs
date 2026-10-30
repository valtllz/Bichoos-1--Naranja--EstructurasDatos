namespace Bichoos1;

public class Nodo
{
    public string Nombre;
    public Nodo? Siguiente;

    public Nodo(string nombre)
    {
        Nombre = nombre;
        Siguiente = null;
    }
}