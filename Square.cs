using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassInheritance
{
    public class Square: Rectangle
    {
        private double side;
        public Square(double side): base(side, side)
        {
            this.side = side;
            nameShape = "Квадрат";
        }
        
    }
}
