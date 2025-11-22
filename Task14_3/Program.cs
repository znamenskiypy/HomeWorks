using System.Reflection.Metadata;

namespace Task14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> users = new HashSet<string>();
            users.Add("alice@example.com");
            users.Add("bob@example.com");
            users.Add("charlie@example.com");

            bool checkAdd = users.Add("bob@example.com");
            Console.WriteLine($"Добавлен ли дубликат bob? - {checkAdd}");

            Console.WriteLine($"Есть ли alice? - {users.Contains("alice@example.com")}");


            HashSet<string> users2 = new HashSet<string>();
            users2.Add("bob@example.com");
            users2.Add("dave@example.com");
            users2.Add("eve@example.com");

            users.UnionWith(users2);

            Console.WriteLine("---Список после объединения:---");

            foreach (string user in users)
            {
                Console.WriteLine(user);
            }

            HashSet<string> intersection = new HashSet<string>(users);
            intersection.IntersectWith(users2);
            Console.WriteLine("---Общие c users2:---");
            foreach (string user in intersection)
            {
                Console.WriteLine(user);
            }

            users.Remove("charlie@example.com");
            Console.WriteLine("---Удалили Чарли---");

            foreach (string user in users)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine($"users2 является подмножеством users? - {users2.IsSubsetOf(users)}");

            users.Clear();
            Console.WriteLine($"Кол-во юзеров после очистки: {users.Count}");

            Console.ReadKey();
        }
    }
}
