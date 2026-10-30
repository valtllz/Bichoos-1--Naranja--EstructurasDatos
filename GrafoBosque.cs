using System;
using System.Collections.Generic;

public class GrafoBosque
{
    private Dictionary<string,
            List<string>> grafo =
            new Dictionary<string,
            List<string>>();

    public void AgregarZona(string zona)
    {
        if (!grafo.ContainsKey(zona))
        {
            grafo[zona] =
                new List<string>();
        }
    }

    public void Conectar(
        string origen,
        string destino)
    {
        grafo[origen].Add(destino);
    }

    public void Mostrar()
    {
        foreach (var zona in grafo)
        {
            Console.Write(zona.Key + ": ");

            foreach (var vecino
                in zona.Value)
            {
                Console.Write(
                    vecino + " ");
            }

            Console.WriteLine();
        }
    }

    public void BuscarZona(string zona)
    {
        if (grafo.ContainsKey(zona))
        {
            Console.WriteLine(
                "Zona encontrada");
        }
        else
        {
            Console.WriteLine(
                "Zona inexistente");
        }
    }
}