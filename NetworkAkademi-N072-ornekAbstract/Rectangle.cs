using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N072_ornekAbstract
{
    public class Rectangle : Shape
    {
       
        private int _height;
        public int height 
        {
            get
            {
                return _height;
            }
            set
            {
                Console.WriteLine("Dikdörtgenin uzun kenarı: ");
                value = Convert.ToInt32(Console.ReadLine());
                _height = value;
            }
        }

        private int _width;
        public int Witdth 
        {
            get
            {
                return _width;
            }
            set
            {
                Console.WriteLine("Dikdörtgenin kısa kenarı: ");
                value = Convert.ToInt32(Console.ReadLine());
                _width = value;
            } 
        }
        public override void CalculateArea()
        {
            int sonuc = _height * _width;
            Console.WriteLine("Dikdörtgenin alanı: " + sonuc);

        }

        public override void CalculatePerimeter()
        {
            int sonuc = 2 * (_height + _width);
            Console.WriteLine("Dikdörtgenin çevresi: " + sonuc);
        }

        public void rectangle()
        {
            
        }

    }
}
