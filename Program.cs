using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool[] zbior = new bool[100];
        int[] indeksy = new int[100];

        for (int i = 2; i < indeksy.Length; i++)
        {
            indeksy[i] = i;
        }

        for (int i = 2; i < 100; i++)
        {
            zbior[i] = true;
        }
        for (int i = 2; i < 10; i++)
        {
            if (zbior[i])
            {
                for (int j = 2 * i; j < 100; j++)
                {
                    zbior[j] = false;
                }
            }
        }
        for (int i = 2; i < 100; i++)
        {
            if (zbior[i])
            {
                Console.Write($"{indeksy[i]} ");
            }
        }
    }
}
