using System.Collections.Generic;

public class ColaGenerica
{
    private Queue<string> cola = new();

    public void Agregar(string enemigo)
    {
        cola.Enqueue(enemigo);
    }

    public void Atender()
    {
        if (cola.Count > 0)
        {
            Console.WriteLine($"Sale: {cola.Dequeue()}");
        }
    }

    public void MostrarSiguiente()
    {
        if (cola.Count > 0)
        {
            Console.WriteLine($"Siguiente: {cola.Peek()}");
        }
    }

    public void Mostrar()
    {
        foreach (string enemigo in cola)
        {
            Console.WriteLine(enemigo);
        }
    }
}