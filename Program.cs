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
//Niech A będzie tablicą wartości typu logicznego indeksowaną liczbami
//całkowitymi od 2 do n (indeksy 0 i 1 nie są brane pod uwagę w czasie
//działania algorytmu), początkowo wypełniona wartościami true
//for i := 2, 3, 4, ..., nie więcej niż √𝑛:
//if A[i] = true:
//for j := 2 * i, 3 * i, 4 * i, ..., nie więcej niż n :
//A[j] := false
//Wyjście: wartości i takie, że A[i] zawiera wartość true.
