//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace задания_разработка_п_м.lessons
//{
//    internal class Overload
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"Площадь квадрата: {Figure.Area(5)}");
//            Console.WriteLine($"Периметр квадрата: {Figure.Perimeter(5)}");
//            Console.WriteLine($"Площадь прямоугольника: {Figure.Area(3, 4)}");
//            Console.WriteLine($"Периметр прямоугольника: {Figure.Perimeter(3, 4)}");
//            Console.WriteLine($"Площадь треугольника: {Figure.Area(3, 4, 5)}");
//            Console.WriteLine($"Периметр треугольника: {Figure.Perimeter(3, 4, 5)}");
//            Console.WriteLine($"Площадь круга: {Figure.Area(3)}");
//            Console.WriteLine($"Периметр круга: {Figure.Perimeter(3)}");
//        }
//    }
//    
//    public static class Figure
//    {
//        //квадрат
//        public static int Area(int a)
//        {
//            return a * a;
//        }
//        public static int Perimeter(int a)
//        {
//            return 4 * a;
//        }
//        //прямоугольник
//        public static int Area(int a, int b)
//        {
//            return a * b;
//        }
//        public static int Perimeter(int a, int b)
//        {
//            return 2 * (a + b);
//        }
//        //треугольник
//        public static double Area(double a, double b, double c)
//        {
//            double p = (a + b + c) / 2;
//            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
//        }
//        public static double Perimeter(double a, double b, double c)
//        {
//            return a + b + c;
//        }
//        //круг
//        public static double Area(double r)
//        {
//            return Math.PI * r * r;
//        }
//        public static double Perimeter(double r)
//        {
//            return 2 * Math.PI * r;
//        }
//        public static double Area(List<(double x, double y)> points)
//        {
//            double area = 0;
//            int n = points.Count;
//            for (int i = 0; i < n; i++)
//            {
//                int j = (i + 1) % n;
//                area += points[i].x * points[j].y;
//                area -= points[j].x * points[i].y;
//            }
//            return Math.Abs(area) / 2.0;
//        }
//        public static double Perimeter(List<(double x, double y)> points)
//        {
//            double perimeter = 0;
//            int n = points.Count;
//            for (int i = 0; i < n; i++)
//            {
//                int j = (i + 1) % n;
//                double dx = points[j].x - points[i].x;
//                double dy = points[j].y - points[i].y;
//                perimeter += Math.Sqrt(dx * dx + dy * dy);
//            }
//            return perimeter;
//        }
//    }
//}
