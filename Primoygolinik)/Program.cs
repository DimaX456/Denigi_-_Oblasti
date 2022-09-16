using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primoygolinik_
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.Write("Введите длину для прямоугольника: ");
            var WidthOutput = Console.ReadLine();
            Console.Write("Введите высоту для прямоугольника: ");
            var HeightOutput = Console.ReadLine();
            if (int.TryParse(WidthOutput, out int Width) && int.TryParse(HeightOutput, out int Height))
            {
                var x = (Console.WindowWidth - Width) / 2;
                var y = (Console.WindowHeight - Height) / 2;
                Console.SetCursorPosition(x, y);

                for (int i = 0; i <= Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write("#");
                    }
                    Console.SetCursorPosition(x, y++);
                }
                Console.ReadLine();
            }
        }
    }
}
