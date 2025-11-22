namespace Task12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] books1 = new Book <string, int>[]
            {
                new Book<string, int>("A-12f-1","Война и Мир",1869,"Толстой"),
                new Book<string, int>("F-1234", "Snuff", 2011, "Пелевин")
            };

            Book<int, string>[] books2 = new Book<int, string>[]
            {
                new Book<int, string>(42,"Стихи","Серебряный век","Блок"),
                new Book<int, string>(8845, "Сердце тьмы", "1900-е", "Конрад")
            };

            var book1 = FindBook(books1, "F-1234");
            Console.WriteLine(book1?.ToString()??"Не найдено");

            var book2 = FindBook(books2, 42);
            Console.WriteLine(book2?.ToString() ?? "Не найдено");


            Console.ReadKey();
        }
        
            


        public static Book<T, U> FindBook<T, U> (Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code))
                    return book;
            }
            return null;
        
        }

        public class Book<T, U>
        {
            public T Code { get; set; }
            public string Title { get; set; }
            public U PublicationYear { get; set; }
            public string Author { get; set; }


            public Book(T code, string title, U year, string author)
            {
                Code = code;
                Title = title;
                PublicationYear = year;
                Author = author;
            }

            public override string ToString()
            {
                return $"Код: {Code} ({typeof(T).Name}), Название:{Title}, Автор:{Author}, Год:{PublicationYear}";
            }

        }
    }
}
