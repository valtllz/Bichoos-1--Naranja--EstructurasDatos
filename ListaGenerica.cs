using System.Collections.Generic;

public class ListaGenerica
{
    private List<string> enemigos = new();

    public void Agregar(string enemigo)
    {
        enemigos.Add(enemigo);
    }

    public void Mostrar()
    {
        foreach (string enemigo in enemigos)
        {
            Console.WriteLine(enemigo);
        }
    }

    public bool Buscar(string enemigo)
    {
        return enemigos.Contains(enemigo);
    }

    public void Eliminar(string enemigo)
    {
        enemigos.Remove(enemigo);
    }
}