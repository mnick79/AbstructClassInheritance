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
            Shape shape1 = new Circle(4);
            shape1.Print();
            Test(10);
        }
        public static void Test(int countTest)
        {
            List<Shape> dataTest = new List<Shape>();
            for (int i = 0; i < countTest; i++)
            {
                dataTest.Add(new Circle(i));
            }
            foreach (var item in dataTest)
            {
                item.Print();
            }
        }
    }
}
