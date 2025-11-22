namespace Task14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> store = new Dictionary<string, int>();

            store.Add("A001", 10);
            store.Add("B205", 25);
            store.Add("C307", 15);


            bool searchKey = store.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205: {searchKey}");
            store["A001"] = 8;


            if (store.TryGetValue("C307", out int count))
            {
                Console.WriteLine($"Кол-во наушников: {count}");
            
            }

            store["B205"] += 5;

            store.Remove("C307");

            Console.WriteLine("Текущие товары:");
            foreach (KeyValuePair<string, int> item in store)
            {
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}");
            }

            bool isEmpty = store.Count == 0;
            Console.WriteLine($"Список пуст? - {isEmpty}");

            store.Clear();
            Console.WriteLine($"Кол-во артикулов после очистки: {store.Count}");


            Console.ReadKey();


        }
    }
}
