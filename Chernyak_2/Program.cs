using System;

namespace Chernyak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнила Черняк Оксана Александровна, АЭМ-111");
            Console.Write("Введите A: ");
            var line = Console.ReadLine();
            double a;

            //проверка правильности ввода
            while (!double.TryParse(line, out a))
            {
                Console.WriteLine("Ввод не удалось распознать");
                Console.Write("Введите A: ");
                line = Console.ReadLine();
            }

            double b;
            if (a < 5)
            {
                b = a;
            }
            else if (a > 5)
            {
                b = a * Math.Cos(a);
            }
            else
            {
                b = a * a;
            }

            double c;
            if (b > a)
            {
                c = b * b;
            }
            else if (b < a)
            {
                c = b * b - Math.Tan(b);
            }
            else
            {
                c = b * b + Math.Sin(b);
            }

            double m = (a * a - b) / (c - a) + Math.Tan(b);
            Console.WriteLine("M: {0:0.000}", m);//вывод с точностью 3 знака
            Console.ReadKey();//ожидание любой клавиши
        }
    }
}