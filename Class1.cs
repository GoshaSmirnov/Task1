using System;

namespace Task1
{
    public static class Class1
    {
        public static double triangleSquare(double ab, double bc, double ac)
        {
            if (ab < 0 || bc < 0 || ac < 0)
            {
                throw new ArgumentException($"Ошибка: Сторона не может быть меньше 0\n Не надо ломать мою программу(");
            }
            if (ab > (bc + ac) || bc > (ab + ac) || ac > (bc + ab))
            {
                throw new ArgumentException($"Ошибка: Сторона не может быть больше суммы других сторон\n p.s Я сам не знал");
            }
            double p = (ab + bc + ac) / 2;
            double Square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            return Square;
        }

        public static double circleSquare(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Тревога: радиус круга не должен быть отрицательным...");
            }
            double Square = Math.PI * radius;
            return Square;
        }
    }
}
