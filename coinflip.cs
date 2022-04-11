using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace coinflip

{
    internal class Program

    {
        static void Main(string[] args)

        {
            Random coin = new Random();
            int flip = coin.Next(0, 2);

            Console.WriteLine((flip == 0) ? "heads" : "tails");

            Console.ReadKey();

        }

    }

}