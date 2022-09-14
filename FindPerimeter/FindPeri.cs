using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// WAP accept length and breadth of rectangle and find perimeter  
namespace FindPerimeter
{
    internal class FindPeri
    {
        static void Main(string[] args)
        {
            float length, breadth, perimeter;

            Console.Write("Enter the length of the rectangle:");
            length = float.Parse(Console.ReadLine());

            Console.Write("Enter the breadth of the rectangle:");
            breadth = float.Parse(Console.ReadLine());

            perimeter = 2 * (length + breadth);
            Console.WriteLine("Perimeter of Rectangle is:" + perimeter);
        }
    }
}
