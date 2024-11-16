using System;

class Program
{
    public static bool Laberinto(int[][] laberinto, int filaInicial, int columnaInicial, int filaFinal, int columnaFinal)
    {
        if (filaInicial < 0 || filaInicial >= laberinto.Length || columnaInicial < 0 || columnaInicial >= laberinto[0].Length)
        {
            return false;
        }
        if (laberinto[filaInicial][columnaInicial] == 1)
        {
            return false;
        }

        if (filaInicial == filaFinal && columnaInicial == columnaFinal)
        {
            return true;
        }
        laberinto[filaInicial][columnaInicial] = 1;

        if (Laberinto(laberinto, filaInicial - 1, columnaInicial, filaFinal, columnaFinal)) 
            return true;
        if (Laberinto(laberinto, filaInicial + 1, columnaInicial, filaFinal, columnaFinal)) 
            return true;
        if (Laberinto(laberinto, filaInicial, columnaInicial - 1, filaFinal, columnaFinal)) 
            return true;
        if (Laberinto(laberinto, filaInicial, columnaInicial + 1, filaFinal, columnaFinal))
            return true;

        laberinto[filaInicial][columnaInicial] = 0;

        return false;
    }

    public static void Main(string[] args)
    {
        // Laberinto 1
        int[][] laberinto1 = new int[][] {
            new int[] { 0, 1, 0, 0, 0 },
            new int[] { 0, 1, 1, 1, 0 },
            new int[] { 0, 0, 0, 1, 0 },
            new int[] { 1, 1, 0, 1, 1 },
            new int[] { 0, 0, 0, 0, 0 }
        };
        Console.WriteLine(Laberinto(laberinto1, 0, 0, 4, 4));

        // Laberinto 2
        int[][] laberinto2 = new int[][] {
            new int[] { 0, 0, 1, 1, 1, 0, 0, 0 },
            new int[] { 1, 0, 1, 0, 0, 0, 1, 1 },
            new int[] { 1, 0, 0, 0, 1, 1, 0, 1 },
            new int[] { 0, 1, 1, 1, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 1, 1, 1, 1, 0 },
            new int[] { 1, 1, 0, 0, 0, 0, 1, 0 },
            new int[] { 0, 1, 1, 1, 0, 1, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 1, 1, 0 }
        };
        Console.WriteLine(Laberinto(laberinto2, 0, 0, 7, 4)); 

        // Laberinto 3
        int[][] laberinto3 = new int[][] {
            new int[] { 0, 1, 0, 0, 0, 1, 0, 0, 0, 1 },
            new int[] { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 },
            new int[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 1 },
            new int[] { 1, 1, 0, 1, 1, 1, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 0 },
            new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
            new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 0, 1, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };
        Console.WriteLine(Laberinto(laberinto3, 0, 0, 9, 9)); 
    }
}
