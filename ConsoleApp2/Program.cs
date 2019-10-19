using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0. Wyjście");
                Console.WriteLine("1.Dodawanie");
                Console.WriteLine("2.Odejmowanie");
                int menuOpt = Convert.ToInt32(Console.ReadLine());
                if (menuOpt == 0)
                {
                    break;
                }
            }
        }
    }
}
