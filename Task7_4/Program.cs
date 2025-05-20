namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 32, 5, 77, 11, 864, 9, 62, 312 };
            int maxNum = FindMax(numbers);
            Console.WriteLine($"Самое большое число в массиве: {maxNum}");
            Console.ReadKey();
        }
        static int FindMax(params int[] array)
        {
            int max = 0;
            foreach (int number in array)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }
    }

    
}
