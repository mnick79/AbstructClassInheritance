using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassInheritance
{
   public abstract class Shape
    {
        protected string nameShape, areastring, drawString, fillString;
        public abstract double Area();
        public abstract string Draw();
        public virtual string Fill(ColorEnum colorEnum = ColorEnum.black)
        {
            return $"Наполнение формы {colorEnum}";
        }
        public virtual void Print() 
        {
            Console.WriteLine();    
        }
    }

}
