using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricMarioPonavljanje4
{
    
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Unesi cijenu proizvoda: ");
            string itemPrice = Console.ReadLine();
            Console.Write("Unesi PDV (u postotku): ");
            string taxRate = Console.ReadLine();

           

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}