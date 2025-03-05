//расположить дома на участке
namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите габариты участка:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите габариты первого дома:");
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите габариты второго дома:");
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());

            // инициализируем размеры  элементов
            int SiteL = 0; //длина участка
            int SiteB = 0; //ширина участка
            int l1 = 0;  //длина первого дома
            int b1 = 0; //ширина первого дома
            int l2 = 0; //длина второго дома
            int b2 = 0; //ширина второго дома

            if (a >= b)   //находим длину и ширину участка
            {
                SiteL = a;
                SiteB = b;
            }
            else
            {
                SiteL = b;
                SiteB = a;
            }

            if (p >= q)   //находим длину и ширину первого дома
            {
                l1 = p;
                b1 = q;
            }
            else
            {
                l1 = q;
                b1 = p;
            }

            if (r >= s)   //находим длину и ширину второго дома
            {
                l2 = r;
                b2 = s;
            }
            else
            {
                l2 = s;
                b2 = r;
            }

            int longestSide = 0; // находим наибольшую длину дома из двух
            if (l1 >= l2)
            {
                longestSide = l1;
            }
            else
            {
                longestSide = l2;
            }
            //по-хорошему определения длин/ширин надо вынести в блок else проверки по площади, но там что-то с областями видимости ломается, надо разбираться


            if (a * b < (p * q) + (r * s))  //можно обойтись без этой проверки, но так экономим на дальнейших проверках по габаритам
            {
                Console.WriteLine("Не влезаем по площади!");
            }
            else
            {
                if (SiteL < longestSide)   //проверяем, хватает ли длины участка для самого длинного дома
                {
                    Console.WriteLine("Не влезаем по длине!");
                }
                else // если длинный дом уместился, то короткий дом точно войдет по длине. теперь проверяем ширину
                {                              // второй дом пытаемся расположить тоже вдоль участка
                    if (SiteB >= b1 + b2)   //  суммарная ширина домов не превышает ширину участка?
                    {
                        Console.WriteLine("Всё уместилось!");
                    }
                    else   //если ширины участка не хватило, второй дом пробуем расположить перпендикулярно участку (и первому дому)
                    {
                        if (SiteL >= l1 + b2 && SiteB >= l2)  //хватает ли еще длины для ширины второго дома? (&& длина дома не должна превысить ширину участка)
                        {
                            Console.WriteLine("Всё уместилось!");
                        }
                        else
                        {
                            Console.WriteLine("Не уместилось!");
                        }
                    }
                }


            }

            Console.ReadKey();
        }
    }
}

