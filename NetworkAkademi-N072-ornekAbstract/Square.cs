using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N072_ornekAbstract
{
    public class Square : Shape
    {
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                Console.WriteLine("Karenin bir kenarı: ");
                value = Convert.ToInt32(Console.ReadLine());
                _side = value;
            }
        }
        public void square()
        {

        }
        public override void CalculateArea()
        {
            int sonuc = _side * _side;
            Console.WriteLine("Karenin alanı: "+sonuc);
        }

        public override void CalculatePerimeter()
        {
            int sonuc = 4 * _side;
            Console.WriteLine("Karenin çevresi: "+sonuc);
        }
     
    }
}
