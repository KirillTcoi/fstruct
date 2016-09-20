using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struc2
{
    public static int nomb = 1;
    class Program
    {
        public static Song[] songs = new Song[10];
        
        public static bool q = false;
        public static void Main(string[] args)
        {
            while (q == false)
                nicepro();
        }
        public static void nicepro()
        {
            
            Console.Clear();
            Console.WriteLine("Выберите действие:\r\n1.Плейлист\r\n2. Новая песня\r\n3. Удалить песню");
            ConsoleKeyInfo x = Console.ReadKey();
            int y = 0;
            if ((x.Key == ConsoleKey.D1) || (x.Key == ConsoleKey.NumPad1)) y = 1;
            if ((x.Key == ConsoleKey.D2) || (x.Key == ConsoleKey.NumPad2)) y = 2;
            if ((x.Key == ConsoleKey.D3) || (x.Key == ConsoleKey.NumPad3)) y = 3;
            Console.Clear();
            switch (y)
            {
                case 1:
                    foreach (Song s in songs)
                    {
                        s.Info();
                        nomb++;
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    
                    songs[1].newsongs();
                    break;
                case 3:
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
        public TimeSpan longtime;
        public int gogod;
        public int rate;
        public void Info()
        {
            if (gogod != 0)
            Console.WriteLine("{4}. {1} - {2} ({3}) {2}\r\nРейтинг: ", name, group, longtime, gogod, nomb);
        }
        public void Sort()
        {
            
        }
        public void newsongs()
        {
            Console.WriteLine("Создание новой песни:");
            Console.ReadLine(songs.name);
        }
        public void delete()
        {
            name = "/0";
            group = "/0";
            longtime = new TimeSpan(0, 0, 0);
            gogod = 0;
        }
    }
}
