using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassInheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Test(10);
        }
        public static void Test(int countTest)
        {
            int choiceRandomClass;
            Random rnd = new Random();
            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < countTest; i++)
            {
                choiceRandomClass = rnd.Next(3);
                if (choiceRandomClass == 0)
                {
                    shapes.Add(new Circle(rnd.Next(3, 20)));
                } else if (choiceRandomClass == 1)
                {
                    shapes.Add(new Rectangle(rnd.Next(1, 30), rnd.Next(1, 20)));
                }
                else
                {
                    shapes.Add(new Square(rnd.Next(1, 50)));
                }

            }
            foreach (var item in shapes)
            {
                item.Print();
            }
        }
    }
}
