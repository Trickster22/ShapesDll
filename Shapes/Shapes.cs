using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    public static class Circle
    {
        public static double Area(double R)
        {
            if (R > 0)
                return 3.14 * R * R;
            else
                return 0;
        }
        
    }
    public static class Triangle
    {
        public static double Area(double A, double B, double C)
        {
            if ((A + B > C) && (A + C > B) && (C + B > A))
            {
                if ((A > 0) && (B > 0) && (C > 0))
                {
                    double p = (A + B + C) / 2;
                    return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                }
                else
                    return 0;
            }
            else
                return 0;

        }
        public static void IsRightTriangle(double A, double B, double C)
        {
            if((C>B)&&(C>A))
            {
                if (C*C==A*A+B*B)
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник не прямоугольный");
            }
            if ((C < B) && (B > A))
            {
                if (B * B == A * A + C * C)
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник не прямоугольный");
            }
            if ((A > B) && (C < A))
            {
                if (A * A == C * C + B * B)
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник не прямоугольный");
            }

        }
    }

}
