using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N072_ornekAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.height = 0;
            r1.Witdth = 0;
            r1.CalculateArea();
            r1.CalculatePerimeter();
            Console.WriteLine("*****************************");
            Circle c1 = new Circle();
            c1.radius = 0;
            c1.CalculateArea();
            c1.CalculatePerimeter();
            Console.WriteLine("*****************************");

            Square s1 = new Square();
            s1.Side = 0;
            s1.CalculateArea();
            s1.CalculatePerimeter();

            Console.ReadKey();
        }
    }
}
