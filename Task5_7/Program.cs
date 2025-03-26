namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] array = new int[n,m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int max = 1;
                for (int j = 0; j < m; j++)
                {
                    int rNum = rnd.Next(0, 11);
                    if (rNum > max)
                    {
                        max = rNum;
                    }
                    array[i,j] = rNum;
                    Console.Write("{0,3} ", rNum);
                    
                }
                Console.WriteLine(" Максимальное {0}" , max);
                Console.WriteLine();
            }   
            Console.ReadKey();
        }
    }
}
