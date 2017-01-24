using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var aria = Math.Abs((x1 - x2) * (y1 - y2));
            var perimeter = (Math.Abs(x1 - x2) + Math.Abs(y1 - y2)) * 2;
            Console.WriteLine(aria);
            Console.WriteLine(perimeter);
        }
    }
}
