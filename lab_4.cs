using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество членов последовательности:");
            Int32 n = Int32.Parse(Console.ReadLine());

            double z = 0.0;

            double x2 = Math.Pow(x, 2);
            double y4 = Math.Pow(y, 4);
            double x6 = Math.Pow(x, 6);
            double y8 = Math.Pow(y, 8);

            double sum1 = 0.0;

            for(int i = 1; i < n; i++) { 
                sum1 += Math.Pow(-1,i+1) * Math.Pow(x, 2 * i) / (2 * i * (2 * i + 1) * (2 * i + 2));
            }
            double sum2 = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum2 += Math.Pow(-1, i) * Math.Pow(y, 2 * i + 2) / ((2 * i + 2) * (2 * i + 3) * (2 * i + 4));
            }
            z = x2 / 3 - y4 / 15 + x6 / 35 - y8 / 63 + sum1 - sum2;

            Console.WriteLine("Z = " + z);
            Console.ReadKey();
        }
    }
}
