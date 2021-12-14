using System;

namespace dz2_viriasov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = double.Parse(Console.ReadLine());
            PrintAllValues(r);

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите x");
                    String user_input = Console.ReadLine();
                    if (user_input == "")
                    {
                        break;
                    }
                    double x = double.Parse(user_input);
                    WhatIsFunction(x, r);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Введён некорректный x");
                }
            }
        }

        static double GetYfromFirstSegment(double x, double R)
        {
            double y = Math.Round(2 - Math.Sqrt(R*R - ((double)x+7)* ((double)x + 7)), 2);
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }


        static double GetYFromSecondSegment(double x)
        {
            double y = 2;
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static double GetYFromThirdSegment(double x)
        {
            double y = (double)x * (-0.5);
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static double GetYFromFourthSegment(double x, double R)
        {
            double y = Math.Round(Math.Sqrt((R * R - ((double)x - Math.PI / 2 ) * (double)x - Math.PI / 2) - 1), 2);
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static double GetYfromFivethSegment(double x) {
            double y = 0.5 * (double)x;
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static void WhatIsFunction(double x, double r)
        {
            if ((double)-9 <= x && x < (double)-5)
            {
                GetYfromFirstSegment(x, r);
            };
            if ((double)-5 <= x && x <= (double)-4)
            {

                GetYFromSecondSegment(x);
            };
            if ((double)-4 < x && x <= (double)0)
            {
                GetYFromThirdSegment(x);
            };
            if ((double)0 < x && x <= (double)Math.PI)
            {
                GetYFromFourthSegment(x, r);
            };
            if ((double)Math.PI < x && x <= 5) {
                GetYfromFivethSegment(x);
            }
            if (x > (double)5 || x < (double)-9)
            {
                Console.WriteLine("x должен принадлежать отрезку [-6.5, 3]");
            }
        }

        static void PrintAllValues(double r)
        {
            for (double x = -9; x <= 5; x += (double)0.2)
            {
                WhatIsFunction(Math.Round(x, 2), r);
            }

        }
    }
}
