using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_10
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Point a = new Point(0.0, 1.0);
            Point b = new Point(0.0, 2.0);
            var dis = Distance(a, b);

         
            Console.WriteLine("Distance: {0:N}", dis);

            Console.ReadLine();

        }

        public static double Distance(Point p1, Point p2)

        {           
            return (Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
            
        }
    }
}
