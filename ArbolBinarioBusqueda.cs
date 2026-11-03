namespace Bichoos1;

public class NodoArbol
{
    public int Valor;
    public NodoArbol? Izquierdo;
    public NodoArbol? Derecho;

    public NodoArbol(int valor)
    {
        Valor = valor;
    }
}

public class ArbolBinarioBusqueda
{
    private NodoArbol? raiz;

    public void Insertar(int valor)
    {
        raiz = InsertarRecursivo(raiz, valor);
    }

    private NodoArbol InsertarRecursivo(NodoArbol? nodo, int valor)
    {
        if (nodo == null)
            return new NodoArbol(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);

        return nodo;
    }

    public bool Buscar(int valor)
    {
        return BuscarRecursivo(raiz, valor);
    }

    private bool BuscarRecursivo(NodoArbol? nodo, int valor)
    {
        if (nodo == null)
            return false;

        if (nodo.Valor == valor)
            return true;

        if (valor < nodo.Valor)
            return BuscarRecursivo(nodo.Izquierdo, valor);

        return BuscarRecursivo(nodo.Derecho, valor);
    }

    public void Mostrar()
    {
        Console.Write("InOrden: ");
        InOrden(raiz);
        Console.WriteLine();
    }

    private void InOrden(NodoArbol? nodo)
    {
        if (nodo == null)
            return;

        InOrden(nodo.Izquierdo);
        Console.Write($"{nodo.Valor} ");
        InOrden(nodo.Derecho);
    }
}