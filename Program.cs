using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{  
    class Program
    {
        public static int nm = 1;
        public static bool q = false;
        
        static int Main(string[] args)
        {
            while (q == false)
                nicepro();
            return 0;
        }
        public static int n = 0;
        public static Song[] songs = new Song[100];
        static void nicepro()
        {
            Console.Clear();
            Console.WriteLine("Выберите действие:\r\n1. Плейлист\r\n2. Новая песня\r\n3. Удалить песню\r\n4. Топ 10 песен");
            ConsoleKeyInfo x = Console.ReadKey();
            int y = 0;
            if ((x.Key == ConsoleKey.D1) || (x.Key == ConsoleKey.NumPad1)) y = 1;
            if ((x.Key == ConsoleKey.D2) || (x.Key == ConsoleKey.NumPad2)) y = 2;
            if ((x.Key == ConsoleKey.D3) || (x.Key == ConsoleKey.NumPad3)) y = 3;
            if ((x.Key == ConsoleKey.D4) || (x.Key == ConsoleKey.NumPad4)) y = 4;
            Console.Clear();
            
            switch (y)
            {
                case 1: //Плейлист
                    nm = 1;
                    if (songs[0].rate != 0)
                        foreach (Song s in songs)
                        {
                            s.Info(); //Информация о песне
                            nm++;
                        }
                    else
                    {
                        Console.WriteLine("Песни отсуствуют в плейлисте");
                    }
                    Console.ReadKey();
                    break;
                case 2: // Добавление
                    n = 0;
                    for (int i = 0; i < 99; i++)
                        if (songs[i].rate != 0)
                            n++;
                    songs[n].NewSong();
                    break;
                case 3: //Удаление песни
                    if (songs[0].rate == 0)
                        Console.WriteLine("Песен в базе вообще нет");
                    else
                    {
                        Console.WriteLine("Введите номер песни, которую хотите удалить"); //замутить выход
                        try
                        {
                            int del = int.Parse(Console.ReadLine());
                            for (int i = del; i < 99; i++)
                                songs[i - 1] = songs[i];
                            n--;
                            Console.WriteLine("Песня успешно удалена");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("ОШИБКА #322: Неверное значение!");
                        }
                    }
                    Console.ReadKey();
                    break;
                case 4: //Топ 10
                    if (songs[0].rate == 0)
                        Console.WriteLine("Песен в базе вообще нет");
                    else
                    {

                        Console.WriteLine("~Топ 10 песен~");
                        Song[] songtop = (Song[])songs.Clone();
                        for (int i = 0; i <= n; i++)
                            for (int j = 0; j <= n; j++)
                                if (songtop[i].rate > songtop[j].rate)
                                {
                                    Song i1;
                                    i1 = songtop[j];
                                    songtop[j] = songtop[i];
                                    songtop[i] = i1;
                                }
                        nm = 1;
                        for (int i = 0; i < 99; i++)
                            if (songtop[i].rate != 0)
                            {
                                songtop[i].Info();
                                nm++;
                            }
                            
                    }
                        Console.ReadKey();
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
        public void Info() //Инфа о песне
        {
            if (rate != 0)
            {
                Console.Write(Program.nm + ". ");
                Console.WriteLine("{1} - {0} [{2}] ({3}) \r\nРейтинг: {4}/10", name, group, longtime, gogod, rate);
            }
        }
        public void NewSong() //Добавить песню
        {
            try
            { 
            Console.WriteLine("~Создание новой песни~\r\nВведите название песни");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("~Создание новой песни~\r\nНазвание: {0}\r\nВведите название группы", name);
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
            }
            catch (Exception e)
            {
                name = null;
                group = null;
                longtime = null;
                gogod = 0;
                rate = 0;
        Console.WriteLine("ОШИБКА #322: Неверное значение!");
            }
            Console.ReadKey();
        }
    }
}
