namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int evens = 0;
            int odds = 0;
            for (int i = 0; i < n; i++)
            {
                int rNum = rnd.Next(0, 101);
                
                if (rNum % 2 ==0)
                {
                    evens ++ ;
                }
                else 
                {
                    odds++;
                }
                array[i] = rNum;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            if (evens > odds)
            {
                Console.WriteLine("Нечетных больше");
            }
            else if (evens < odds)
            {
                Console.WriteLine("Четных больше");
            }
            else 
            {
                Console.WriteLine("Четных и нечетных поровну");
            }

            Console.ReadKey();
        }
    }
}
