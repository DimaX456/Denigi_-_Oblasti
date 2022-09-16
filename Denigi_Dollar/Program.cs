using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denigi_Dollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите количество долларов, для того, чтобы перевести доллар в рубли: ");
                var dollarInput = Console.ReadLine();
                int.TryParse(dollarInput, out int dollarOutput);
                var result = dollarOutput * 60;
                var proc = 0.37;
                Console.WriteLine($"Вывод: {result:#,###} рублей.");
                if 
                (dollarOutput < 500) 
                Console.WriteLine($"Было взято {8} рублей, вывод: {(result - 8):#,###} рублей.");
                else 
                Console.WriteLine($"Было взято {proc}%, вывод: {(result - (result * proc / 100)):#,###} рублей.");
                Console.ReadLine();
            }
        }
    }
}
