using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N072_ornekAbstract
{
    
    public class Circle : Shape
    {
        private int _radius;
        public int radius
        {
            get
            {
                return _radius;
            }
            set
            {
                Console.WriteLine("Dairenin yarı çapını giriniz: ");
                value = Convert.ToInt32(Console.ReadLine());
                _radius = value;
            }
        }

        public void circle()
        {
            
        }
        public override void CalculateArea()
        {
            int sonuc = _radius*_radius * 3;
            Console.WriteLine("Dairenin alanı: "+sonuc);
        }

        public override void CalculatePerimeter()
        {
            int sonuc = 2 * 3 * _radius;
            Console.WriteLine("Dairenin çevresi: "+sonuc);
        }

       

        

    }
}
