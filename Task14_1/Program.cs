namespace Task14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> players = new List<string>();
            players.Add("Иванов");
            players.Add("Петров");
            players.Add("Сидоров");
            players.Add("Гинзбург");

            players.Insert(1, "Козлов");


            Console.WriteLine($"Есть ли Петров? {players.Contains("Петров")}");
            players.Remove("Сидоров");

            for (int i =0 ; i < players.Count; i++)
            {
                Console.WriteLine($"{i} {players[i]}");
            }


            int kozlovIndex = players.IndexOf("Козлов");
            Console.WriteLine($"Индекс Козлова: {kozlovIndex}");

            players.Sort();


            foreach (string player in players)
            {
                Console.WriteLine(player);
            }

            bool isEmpty = players.Count == 0;
            Console.WriteLine($"Список пуст? - {isEmpty}");
            players.Clear();
            Console.WriteLine($"Кол-во игроков после очистки {players.Count}");


            Console.ReadKey();
        }
    }
}
