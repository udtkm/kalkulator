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
                int menuOpt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("4. Wyjście");
                Console.WriteLine("1.ADD");
                if (menuOpt == 0)
                {
                    break;
                }
                Console.WriteLine("2.DIFF");
             
            }
        }
    }
}
