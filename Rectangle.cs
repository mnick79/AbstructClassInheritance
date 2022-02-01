using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassInheritance
{
   public class Rectangle: Shape
    {
        private double sideVert, sideHorz;
        public Rectangle(double sideVert, double sideHorz)
        {
            this.sideVert = sideVert;
            this.sideHorz = sideHorz;
            this.nameShape = "Прямоугольник";
        }
        public override double Area()
        {
            areastring = (sideVert * sideHorz).ToString();
            return sideHorz * sideVert;
        }
        public override string Draw()
        {
            drawString = $"Рисование {nameShape}а";
            return drawString;
        }
        public override string Fill(ColorEnum colorEnum = ColorEnum.black)
        {
            return $"Наполнение формы {colorEnum}";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Форма: \t\t\t {Draw()} \nПлощадь:\t\t {Area()} \nДействие:\t\t {Draw()}\nЗаполнение цветом:\t {Fill()}");
        }
    }
}
