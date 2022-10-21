using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int error;
            do
            {
                try
                {
                    double[] triangle = new double[3];
                    Console.WriteLine("Введите длины сторон треугольника (через enter)");
                    for (int i = 0; i < 3; i++)
                    {
                        triangle[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    double circle = 0;
                    Console.WriteLine("\nВведите радиус круга");
                    circle = Convert.ToDouble(Console.ReadLine());
                    double[] rectangle = new double[2];
                    Console.WriteLine("\nВведите длины сторон прямоугольника (через enter)");
                    for (int i = 0; i < 2; i++)
                    {
                        rectangle[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    Figure[] figure = new Figure[]
                    {
                    new Triangle (triangle[0],triangle[1],triangle[2]),
                    new Circle(circle),
                    new Rectangle(rectangle[0],rectangle[1])
                    };

                    for (int i = 0; i < figure.Length; i++)
                    {
                        figure[i].Perimeter();
                        figure[i].Area();
                        figure[i].PrintFigure();
                    }
                    error = 0;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Входная строка имет неверный формат, перезапуск программы\n");
                    error = 1;
                }
            }
            while (error != 0);
            Console.ReadKey();
        }
    }
    public abstract class Figure
    {
        public double x;
        public double y;
        public double z;
        public double r;

        public abstract decimal Area();
        public abstract decimal Perimeter();
        public abstract void PrintFigure();
      
    }
      
    public class Rectangle : Figure
    {
        public double perimeter;
        public double area;
        public Rectangle(double a, double b)
        {
            x = a;
            y = b;
        }
        public override decimal Area()
        {
            area = x * y;
            return (decimal)area;
        }

        public override decimal Perimeter()
        {
            perimeter = (x + y) * 2;
            return (decimal)perimeter;
        }

        public override void PrintFigure()
        {
            Console.WriteLine($"Прямоугольник: Периметр = {perimeter}, Площадь = {area}");
        }
    }
    public class Circle : Figure
    {
        public double perimeter;
        public double area;

        public Circle(double rr)
        {
            r = rr;
        }
        public override decimal Area()
        {
            area = Math.PI * Math.Pow(r,2);
            return (decimal)area;
        }

        public override decimal Perimeter()
        {
            perimeter = 2* Math.PI*r;
            return (decimal)perimeter;
        }
        public override void PrintFigure()
        {
                Console.WriteLine($"Круг: Периметр = {perimeter}, Площадь = {area}");
        }
    }
    public class Triangle : Figure
    {
        public double perimeter;
        public double area;

        public Triangle(double a, double b, double c)
        {
            x = a;
            y = b;
            z = c;
        }


        public override decimal Area()
        {
            area = Math.Sqrt(perimeter * (perimeter - x)* (perimeter - y)* (perimeter - z));
            return (decimal)area;
        }

        public override decimal Perimeter()
        {
            perimeter = x + y + z;
            return (decimal)perimeter;
        }
        public override void PrintFigure()
        {
            Console.WriteLine($"\nТреугольник: Периметр = {perimeter}, Площадь = {area}");
        }
    }
}