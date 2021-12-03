using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N072_ornekAbstract
{
    public abstract class Shape
    {
        private int _area;
        public int area 
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }
        }

        private string _color;
        public string color 
        {
            get
            {
                return _color;
            } 
            set
            {
                _color = value;
            }
        }

        private int _perimeter;
        public int perimeter 
        {
            get
            {
                return _perimeter;
            }
            set
            {
                _perimeter = value;
            }
        }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();


    }
}
