using System;
using System.Collections.Generic;

public class DiccionarioBichoos
{
    Dictionary<string, string> insectos =
        new Dictionary<string, string>();

    public void Agregar()
    {
        insectos["Vitalis"] = "Cura";
        insectos["Espectral"] = "Invisibilidad";
        insectos["Melifera"] = "Velocidad";
    }

    public void Mostrar()
    {
        foreach (var item in insectos)
        {
            Console.WriteLine(item.Key +
                              " -> " +
                              item.Value);
        }
    }

    public void Buscar(string nombre)
    {
        if (insectos.ContainsKey(nombre))
        {
            Console.WriteLine(
                insectos[nombre]);
        }
        else
        {
            Console.WriteLine(
                "No existe");
        }
    }
}