namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int max = array[0];
            int min = array[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < n; i++)
            {
                int rNum = rnd.Next(0, 51);

                if (rNum > max)
                {
                    max = rNum;
                    maxIndex = i;
                }
                else if (rNum < min)
                {
                    min = rNum;
                    minIndex = i;
                }
           
                array[i] = rNum;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное {0} (индекс {1}), Минимальное {2} (индекс {3})", max,maxIndex, min, minIndex);
            Console.ReadKey();


        }
    }
}
