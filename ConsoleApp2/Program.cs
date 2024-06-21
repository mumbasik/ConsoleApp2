using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //N1
            double F = 0;
            Console.WriteLine("Celsius: ");
            int C = Convert.ToInt32(Console.ReadLine());

            F = (9.0 / 5.0) * C + 32;

            Console.WriteLine($"Result:  {F} ");
            //N2
            double MathPI = 3.14159;
            Console.WriteLine("Radius: ");
            float radius = float.Parse(Console.ReadLine());
            double size = (4.0 / 3.0) * MathPI * radius * radius * radius;
            Console.WriteLine($"Result:  {size} ");
            //N3
            Console.WriteLine("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Discount: ");
            int discount = Convert.ToInt32(Console.ReadLine());
            double summa = 0;

            summa = (price * count) * (1 - (discount / 100.0));
            Console.WriteLine($"Result:  {summa} ");
            //N4
            float PI = 3.14f;
            Console.WriteLine("Circle: ");
            float circle = float.Parse(Console.ReadLine());
            float circlerad = circle / (2.0f * PI);
            float x = PI * circlerad * circlerad;
            Console.WriteLine($"Result:  {x} ");
            ////N5
            Console.WriteLine("4xNumber: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = number / 1000;
            int y  = number % 10;
            int a = (number / 10) % 100;
            int res = y * 1000 + a * 10 + i;
            Console.WriteLine($"Result: {res}");
            //N6
            Console.WriteLine("Days: ");
            int data = Convert.ToInt32(Console.ReadLine());
            int day = data % 7;
            int week = data / 7;
            Console.WriteLine($"Result: weeks: {week}, days: {day}");
            //N7
            Console.WriteLine("Children: ");
            int child = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Apples: ");
            int apples = Convert.ToInt32(Console.ReadLine());
            int countofchild = apples / child;
            int countofapples = apples % child;
            Console.WriteLine($"Result: children {countofchild} = {countofapples}");
        }
    }
}
