using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{  
    class Program
    {
        public static bool q = false;
        static void Main(string[] args)
        {
            while (q == false)
                nicepro();
        }
        static void nicepro()
        {
            Song[] songs = new Song[10];
            Console.Clear();
            Console.WriteLine("Выберите действие:\r\n1. Плейлист\r\n2. Новая песня\r\n3. Удалить песню");
            ConsoleKeyInfo x = Console.ReadKey();
            int y = 0;
            if ((x.Key == ConsoleKey.D1) || (x.Key == ConsoleKey.NumPad1)) y = 1;
            if ((x.Key == ConsoleKey.D2) || (x.Key == ConsoleKey.NumPad2)) y = 2;
            if ((x.Key == ConsoleKey.D3) || (x.Key == ConsoleKey.NumPad3)) y = 3;
            Console.Clear();
            int n = 0;
            switch (y)
            {
                case 1: //Плейлист
                    if (songs[0].rate != 0)
                        foreach (Song s in songs)
                            s.Info();
                    else
                        Console.WriteLine("Песни отсуствуют в плейлисте");
                    Console.ReadKey();
                    break;
                case 2:
                    
                    for (int i = 0; i < 10; i++)
                        if (songs[i].rate != 0)
                            n++;
                    songs[n].NewSong();
                    break;
                case 3: //Удаление песни
                    Console.WriteLine("Введите номер песни, которую хотите удалить"); //замутить выход
                    int iddel = int.Parse(Console.ReadLine()) +1;
                    songs[iddel].DelSong();
                    n--;
                    break;
                default:
                    break;
            }
        }
    }
    struct Song
    {

        public string name;
        public string group;
        public string longtime;
        public int gogod;
        public int rate;
        public void Info()
        {
            if (rate != 0)
                Console.WriteLine("{1} - {0} [{2}] ({3}) \r\nРейтинг: {4}/10", name, group, longtime, gogod, rate);
        }
        public void NewSong()
        {
            Console.WriteLine("~Создание новой песни~\r\nВведите название песни");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("~Создание новой песни~\r\nНазвание: {0}\r\nВведите название группы",name);
            group = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("~Создание новой песни~\r\nНазвание: {0}\r\nГруппа: {1}\r\nВведите длительность песни", name, group);
            longtime = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("~Создание новой песни~\r\nНазвание: {0}\r\nГруппа: {1}\r\nДлительность: {2}\r\nВведите год выпуска", name, group, longtime);
            gogod = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("~Создание новой песни~\r\nНазвание: {0}\r\nГруппа: {1}\r\nДлительность: {2}\r\nГод выпуска: {3}\r\nДайте песне оценку (По 10 балльной шкале)", name, group, longtime, gogod);
            rate = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("~Новая песня добавлена в плейлист~\r\nНазвание: {0}\r\nГруппа: {1}\r\nДлительность: {2}\r\nГод выпуска: {3}\r\nРейтинг: {4}/10", name, group, longtime, gogod, rate);
            Console.ReadKey();
        }
        public void DelSong() //Удаление
        {
            name = null;
            group = null;
            longtime = null;
            gogod = 0;
            rate = 0;
        }
    }
}
