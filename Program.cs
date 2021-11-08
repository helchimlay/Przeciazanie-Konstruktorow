using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Prostokat
    {

        public Prostokat()
        {
            Console.WriteLine("Nie podales zadnych parametrow lub sa one niepoprawne!");
        }
        public Prostokat(string a)
        {
            Console.WriteLine("Podales tylko jeden parametr!");
        }
        public Prostokat(string a,string b)
        {
            Console.WriteLine("Pole prostokata: "+int.Parse(a)*int.Parse(b));
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            PoleProstokata();
            Console.ReadKey();
        }




        private static void PoleProstokata()
        {
            string a, b;
            a = SettingA();
            b = SettingB();
            WalidacjaDanych(a, b);
        }

        private static string SettingB()
        {
            string b;
            Console.WriteLine("Podaj b");
            b = Console.ReadLine();
            return b;
        }

        private static string SettingA()
        {
            string a;
            Console.WriteLine("Podaj a");
            a = Console.ReadLine();
            return a;
        }

        private static void WalidacjaDanych(string a, string b)
        {
            if (int.TryParse(a, out _) && int.TryParse(b, out _))
            {
                Prostokat prostokat1 = new Prostokat(a, b);
            }
            else if ((!int.TryParse(a, out _) && int.TryParse(b, out _)) || (int.TryParse(a, out _) && !int.TryParse(b, out _)))
            {
                Prostokat prostokat2 = new Prostokat(a);
            }
            else if (!int.TryParse(a, out _) && !int.TryParse(b, out _))
            {
                Prostokat prostokat = new Prostokat();
            }
        }
    }
}
