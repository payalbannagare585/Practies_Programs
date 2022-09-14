using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//write a program Accept Radius of  a Circle.Display area of a circle 
namespace AreaOfCircle
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            int r;
            double Area;
            Console.WriteLine("Enter the radius:");
            r = Convert.ToInt32(Console.ReadLine());
            Area = (3.14) * r * r;
            Console.WriteLine("The Area of circle =" + Area);
            Console.ReadLine();

        }
    }
}
