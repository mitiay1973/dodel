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

            Figuri[] figuri = new Figuri[]
            {
                new Triangle (5,2,5),
                new Circle(8),
                new Rectangle(5,6)
            };
            for(int i= 0; i < figuri.Length; i++)
            {
                figuri[i].Perimeter();
                figuri[i].Area();
                figuri[i].PrintFigure();
            }
            Console.ReadKey();
        }
    }
    public abstract class Figuri
    {
        public string figura;
        public double x;
        public double y;
        public double z;
        public double r;

        public abstract decimal Area();
        public abstract decimal Perimeter();
        public abstract void PrintFigure();
      
    }
      
    public class Rectangle : Figuri
    {
        public double perim;
        public double plosha;
        public Rectangle(double a, double b)
        {
            x = a;
            y = b;
        }
        public override decimal Area()
        {
                plosha = x * y;
            return (decimal)plosha;
        }

        public override decimal Perimeter()
        {
                perim = (x + y) * 2;
            return (decimal)perim;
        }

        public override void PrintFigure()
        {
                Console.WriteLine($"Прямоугольник: Периметр = {perim}, Площадь = {plosha}");
        }
    }
    public class Circle : Figuri
    {
        public double perim;
        public double plosha;

        public Circle(double rr)
        {
            r = rr;
        }
        public override decimal Area()
        {
                plosha = Math.PI * Math.Pow(r,2);
            return (decimal)plosha;
        }

        public override decimal Perimeter()
        {
                perim = 2* Math.PI*r;
            return (decimal)perim;
        }
        public override void PrintFigure()
        {
                Console.WriteLine($"Круг: Периметр = {perim}, Площадь = {plosha}");
        }
    }
    public class Triangle : Figuri
    {
        public double perim;
        public double plosha;

    public Triangle(double a, double b, double c)
    {
            x = a;
            y = b;
            z = c;
    }


    public override decimal Area()
        {
            plosha = Math.Sqrt(perim*(perim-x)* (perim - y)* (perim - z));
            return (decimal)plosha;
        }

        public override decimal Perimeter()
        {

            perim = x + y + z;
            return (decimal)perim;
        }
        public override void PrintFigure()
        {
                Console.WriteLine($"Треугольник: Периметр = {perim}, Площадь = {plosha}");
        }
    }
}