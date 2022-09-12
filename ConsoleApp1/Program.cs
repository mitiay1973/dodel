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

            };
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
        public override decimal Area()
        {
            if(figura == "треугольник")
            {
                plosha = x * y;
            }
            return (decimal)plosha;
        }

        public override decimal Perimeter()
        {
            if (figura == "треугольник")
            {
                perim = (x + y) * 2;
            }
            return (decimal)perim;
        }

        public override void PrintFigure()
        {
            if (figura == "треугольник")
            {
                Console.WriteLine($"Прямоугольник: Периметр = {perim}, Площадь = {plosha}");
            }
        }
    }
    public class Circle : Figuri
    {
        public double perim;
        public double plosha;
        public override decimal Area()
        {
            if (figura == "круг")
            {
                plosha = x * y;
            }
            return (decimal)plosha;
        }

        public override decimal Perimeter()
        {
            if (figura == "круг")
            {
                perim = (x + y) * 2;
            }
            return (decimal)perim;
        }
        public override void PrintFigure()
        {
            if (figura == "круг")
            {
                Console.WriteLine($"Круг: Периметр = {perim}, Площадь = {plosha}");
            }
        }
    }
    public class Triangle : Figuri
    {
        public double perim;
        public double plosha;
        public override decimal Area()
        {
            if (figura == "треугольник")
            {
                plosha = x * y;
            }
            return (decimal)plosha;
        }

        public override decimal Perimeter()
        {
            if (figura == "треугольник")
            {
                perim = (x + y) * 2;
            }
            return (decimal)perim;
        }
        public override void PrintFigure()
        {
            if (figura == "треугольник")
            {
                Console.WriteLine($"Треугольник: Периметр = {perim}, Площадь = {plosha}");
            }
        }
    }
}