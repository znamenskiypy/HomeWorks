namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int pos = 0;
            int neg = 0;
            int nul = 0;

            for (int i = 0; i < n; i++)
            {
                int rNum = rnd.Next(-20, 21);

                if (rNum > 0)
                {
                    pos++;
                }
                else if (rNum < 0)
                {
                    neg++;
                }
                else
                {
                    nul++;
                }
                array[i] = rNum;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("{0} Положительных, {1} отрицательных, {2} нулей", pos, neg, nul);
            Console.ReadKey();


        }
    }
}
