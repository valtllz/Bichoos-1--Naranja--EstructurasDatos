public class Nodo
{
    public string Momento;
    public Nodo Siguiente;

    public Nodo(string momento)
    {
        Momento = momento;
        Siguiente = null!;
    }
}