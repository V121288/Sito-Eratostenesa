internal class Program
{
    private static void Main(string[] args)
    {
        int[] tablica = new int[100];
        for (int i = 2; i < tablica.Length; i++)
        {
            tablica[i] = i;

        }

        for (int j = 2; j < tablica.Length; j++)
        {

            if (tablica[j] % 2 == 0 && tablica[j] != 2)
            {
                tablica[j] = 0;
            }
            if (tablica[j] % 3 == 0 && tablica[j] != 3)
            {
                tablica[j] = 0;
            }
            if (tablica[j] % 5 == 0 && tablica[j] != 5)
            {
                tablica[j] = 0;
            }
            if (tablica[j] % 7 == 0 && tablica[j] != 7)
            {
                tablica[j] = 0;
            }
            if (tablica[j] % 11 == 0 && tablica[j] != 7)
            {
                tablica[j] = 0;
            }
            if (tablica[j] % 13 == 0 && tablica[j] != 7)
            {
                tablica[j] = 0;
            }


        }
        for (int i = 2; i < tablica.Length; i++)
        {
            Console.WriteLine(tablica[i]);
        }
    }
}

        
    
