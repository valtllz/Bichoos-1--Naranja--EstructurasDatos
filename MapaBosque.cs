namespace Bichoos1;

public class MapaBosque
{
    private string[,] mapa =
    {
        {"B", ".", ".", "I"},
        {".", ".", "I", "."},
        {".", "A", ".", "."},
        {"I", ".", ".", "."}
    };

    public void MostrarMapa()
    {
        Console.WriteLine("\n=== MAPA DEL BOSQUE ===");

        for (int i = 0; i < mapa.GetLength(0); i++)
        {
            for (int j = 0; j < mapa.GetLength(1); j++)
            {
                Console.Write(mapa[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public void ModificarCasilla(int fila, int columna, string valor)
    {
        mapa[fila, columna] = valor;
    }

    public string ConsultarCasilla(int fila, int columna)
    {
        return mapa[fila, columna];
    }
}