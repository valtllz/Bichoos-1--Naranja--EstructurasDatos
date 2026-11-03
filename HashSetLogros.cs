namespace Bichoos1;

public class HashSetLogros
{
    private HashSet<string> logros = new();

    public void Agregar(string logro)
    {
        if (logros.Add(logro))
            Console.WriteLine("Logro agregado.");
        else
            Console.WriteLine("El logro ya existe.");
    }

    public bool Buscar(string logro)
    {
        return logros.Contains(logro);
    }

    public void Mostrar()
    {
        Console.WriteLine("\nLogros desbloqueados:");

        foreach (string logro in logros)
        {
            Console.WriteLine(logro);
        }
    }
}