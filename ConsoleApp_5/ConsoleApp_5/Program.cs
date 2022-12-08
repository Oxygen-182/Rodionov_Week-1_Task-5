using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_5
{
    internal class Program
    {
        static double f(double x)
        {
            return Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());

                if (a > b)
                {
                    Console.Write("Параметр a не может быть больше b");
                    return;
                }

                if (h <= 0)
                {
                    Console.Write("Параметр h не может быть меньше или равен нулю");
                    return;
                }

                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}
