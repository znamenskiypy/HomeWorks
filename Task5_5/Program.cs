namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            //int[] array = { 3, 2, 4, 5, 6, 8, 9, 1, 0, 7 };
            // Создаем массив
            for (int i = 0; i < n; i++)
            {
                
                array[i] = rnd.Next(-50, 51);
                Console.Write("{0} ", array[i]);
                
            }
            Console.WriteLine();

            // Сортируем первую половину
            int h = n / 2;  // находим индекс в середине
            for (int i = 0; i < h - 1; i++)
            {
                for (int j = i + 1; j < h; j++) 
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            // Сортируем вторую половину
            for (int i = h; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            // Выводим
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
                Console.ReadKey();


        }
    }
}
