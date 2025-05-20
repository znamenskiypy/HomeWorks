namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] array = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                int a = i % 2 == 0 ? 0 : 1;
                for (int j = 0; j < n; j++)
                {
                    if (a == 0)
                    {
                        array[i, j] = j % 2 == 0 ? 1 : 0;
                    }
                    else 
                    {
                        array[i, j] = j % 2 == 0 ? 0 : 1;
                    }
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
