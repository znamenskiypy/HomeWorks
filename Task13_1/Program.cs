namespace Task13_1
{
    internal class Program
    {
        public delegate int Transformer(int number);
        public static int[] Transform (int[] array, Transformer transformer)
        {
            
            int counter = 0;

            foreach (int n in array)
            {
                counter++;
            }
            int[] result = new int[counter];
            int index = 0;
            foreach (int number in array)
            {
                result[index] = transformer(number);
                index++;
                 
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] {-3,-1,0,1,2,3,5};

            var res1 = Transform (numbers, n => n * 2);
            var res2 = Transform (numbers, n => n * n);
            var res3 = Transform (numbers, n => Math.Abs(n));
            
            Console.WriteLine (string.Join (',', res1));
            Console.WriteLine (string.Join (',', res2));
            Console.WriteLine (string.Join (',', res3));


            Console.ReadKey();
        }
    }
}
