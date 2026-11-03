namespace Bichoos1;

public class ColaPrioridadEnemigos
{
    private PriorityQueue<string, int> cola = new();

    public void Agregar(string enemigo, int prioridad)
    {
        cola.Enqueue(enemigo, prioridad);
    }

    public void Atender()
    {
        if (cola.Count > 0)
        {
            string enemigo = cola.Dequeue();

            Console.WriteLine(
                $"Enemigo atendido: {enemigo}"
            );
        }
        else
        {
            Console.WriteLine("No hay enemigos.");
        }
    }

    public void MostrarSiguiente()
    {
        if (cola.Count > 0)
        {
            string enemigo = cola.Peek();

            Console.WriteLine(
                $"Siguiente enemigo: {enemigo}"
            );
        }
        else
        {
            Console.WriteLine("No hay enemigos.");
        }
    }
}