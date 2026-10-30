namespace Bichoos1;

public class Mochila
{
    private Stack<string> recursos = new();

    public void Recolectar(string recurso)
    {
        recursos.Push(recurso);
    }

    public void VerUltimo()
    {
        if (recursos.Count > 0)
        {
            Console.WriteLine("Último recurso: " + recursos.Peek());
        }
        else
        {
            Console.WriteLine("La mochila está vacía.");
        }
    }

    public void Retirar()
    {
        if (recursos.Count > 0)
        {
            Console.WriteLine("Retirado: " + recursos.Pop());
        }
        else
        {
            Console.WriteLine("La mochila está vacía.");
        }
    }
}