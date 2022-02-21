using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Consol_Calisma
{
    class Menu
    {
        int sec, x, y;
        public Menu(int sut, int sat)
        {
            sec = 1; x = sut; y = sat;

        }
        public int secenek
        {
            get { belirle(); return sec; }
        }
        void belirle()
        {   Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();            
            ConsoleKeyInfo tus;
            Console.CursorVisible = false;
                                      
            do
            {                
                Console.SetCursorPosition(x + 2, y);
                Console.Write("İŞLEMLER");
                Console.SetCursorPosition(x + 2, y + 1);
                Console.Write("---------------");
                Console.SetCursorPosition(x + 2, y + 2);
                Console.Write("Kayıt Girişi");
                Console.SetCursorPosition(x +2, y + 3);
                Console.Write("Kayıt Listeleme");
                Console.SetCursorPosition(x + 2, y + 4);
                Console.Write("Kayıt Arama");
                Console.SetCursorPosition(x + 2, y + 5);
                Console.Write("Kayıt Güncelleme");
                Console.SetCursorPosition(x + 2, y + 6);
                Console.Write("Kayıt Silme");
                Console.SetCursorPosition(x + 2, y + 7);
                Console.Write("Çıkış");
                Console.SetCursorPosition(x,y+sec+1);
                Console.Write("->");
                tus = Console.ReadKey();
                if (tus.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(x,y+sec+1);
                    Console.Write("  ");
                    sec--;
                    if (sec < 1) sec = 6;                    
                    Console.SetCursorPosition(x,y+sec+1);
                    Console.Write("->");                    
                }
                if (tus.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(x, y + sec + 1);
                    Console.Write("  ");
                    sec++;
                    if (sec > 6) sec = 1;
                    Console.SetCursorPosition(x, y + sec + 1);
                    Console.Write("->");
                }
                Console.WriteLine(sec);
                

            } while (tus.Key != ConsoleKey.Enter);
            Console.ReadLine();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu(30,5);

            int s;
            s = menu.secenek;
            

        }
    }
}
