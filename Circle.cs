using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassInheritance
{
    internal class Circle: Shape
    {
        private double radius;
        private const double  PI = 3.1415;
        public Circle(double radius)
        {
            this.radius = radius;
            nameShape = "Круг";
        }
        public override double Area()
        {
            return Math.Pow(radius, 2);
        }
        public override string Draw()
        {
            drawString = "Рисуем круг!";
            return drawString;
        }
        public override string Fill(ColorEnum color=ColorEnum.yellow)
        {
            return color.ToString();
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Форма: \t\t\t {Draw()} \nПлощадь:\t\t {Area()} \nДействие:\t\t {Draw()}\nЗаполнение цветом:\t {Fill()}");
        }
    }
}
