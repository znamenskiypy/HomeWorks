using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static HW15.Program;

namespace HW15
{
    internal class Program
    {
        public class PC
        {
            public string Code { get; set; }
            public string Mark { get; set; }
            public string CPU { get; set; }
            public int RAM { get; set; }
            public int HDD { get; set; }
            public int VRAM { get; set; }
            public decimal Cost { get; set; }
            public int Count { get; set; }

            public override string ToString()
            {
                return Code + " " + Mark + " "+ CPU + " RAM "+Convert.ToString(RAM) + " HDD "+Convert.ToString(HDD) +" VRAM "+ Convert.ToString(VRAM) + " Цена "+Convert.ToString(Cost)
                    +" -" + Convert.ToString(Count)+" шт";
            }

        }






        static void Main(string[] args)
        {

            List<PC> list = new List<PC>()
            {
                new PC(){Code = "001", Mark= "Intel", CPU = "Core i5", RAM = 2, HDD = 500, VRAM = 4, Cost = 15000, Count= 3 },
                new PC(){Code = "00B", Mark= "Intel", CPU = "Core i7", RAM = 16, HDD = 1000, VRAM = 2, Cost = 25000, Count= 7 },
                new PC(){Code = "155", Mark= "AMD", CPU = "Ryzen 9", RAM = 8, HDD = 2000, VRAM = 8, Cost = 1000, Count= 303 },
                new PC(){Code = "002", Mark= "Intel", CPU = "Core i9", RAM = 64, HDD = 2000, VRAM = 4, Cost = 10000, Count = 100 },
                new PC(){Code = "00B", Mark= "Intel", CPU = "Core i7", RAM = 64, HDD = 2000, VRAM = 4, Cost = 10000, Count = 21 },
                new PC(){Code = "104", Mark= "AMD", CPU = "Ryzen 9", RAM = 128, HDD = 4000, VRAM = 16, Cost = 30000, Count = 1 },
                new PC(){Code = "AAA", Mark= "Noname", CPU = "Noname", RAM = 128, HDD = 4000, VRAM = 16, Cost = 30000, Count = 10 }
            };

            Console.WriteLine("Какой процессор интересует?");
            string cpuType = Convert.ToString(Console.ReadLine());

            List<PC> selectByCpu = list
                .Where(pc => pc.CPU == cpuType).ToList();

            foreach (PC pc in selectByCpu)
            {
                Console.WriteLine(pc);
            }

            Console.WriteLine("Сколько памяти нужно?");
            int minRam = Convert.ToInt32(Console.ReadLine());

            List<PC> selectByRam = list
                .Where(pc => pc.RAM > minRam)
                .ToList();

            foreach (PC pc in selectByRam)
            {
                Console.WriteLine(pc);
            }

            Console.WriteLine("---Сортировка по цене---");

            List <PC> orderedByPrice = list
                .OrderBy(pc => pc.Cost)
                .ToList();

            foreach (PC pc in orderedByPrice)
            {
                Console.WriteLine(pc);
            }
            
            Console.WriteLine("---Группировка по процессору---");

            var groupedByCpu = list
                .GroupBy(pc => pc.CPU)
                .ToList();

            foreach (var group in groupedByCpu)
            {
                foreach (PC pc in group)
                {
                    Console.WriteLine(pc);
                }    
            }

            Console.WriteLine("---Самый дорогой---");
            var maxprice = orderedByPrice
                .LastOrDefault();

            Console.WriteLine(maxprice);

            Console.WriteLine("---Самый дешевый---");
            var minprice = orderedByPrice
                .FirstOrDefault();
            Console.WriteLine(minprice);

            Console.WriteLine("---Есть ли больше 30 шт в наличии?---");
            bool moreThan30 = list
                .Any(pc => pc.Count > 30);
            Console.WriteLine(moreThan30);


            Console.ReadKey();
        }
    }
}
