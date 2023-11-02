using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme4Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.
            //Console.Write("Введите x первой точки ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите y первой точки ");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите x второй точки ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Введите y второй точки ");
            //double y2 = double.Parse(Console.ReadLine());
            //Console.Write("Введите x третьей точки ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Введите y третьей точки ");
            //double y3 = double.Parse(Console.ReadLine());
            //double P = 0;
            //double dlina1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //double dlina2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            //double dlina3 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            //P += dlina1;
            //P += dlina2;
            //P += dlina3;
            //double p = P / 2;  
            //double S = Math.Sqrt(p * (p - dlina1) * (p - dlina2) * (p - dlina3));  
            //Console.Write($"Периметр треугольника = {P}\nПлощадь треугольника = {S}");
            //Console.ReadKey();

            //Задача 2. Стоимость поездки на автомобиле (ввод: s – расстояние, b – расход бензина на 100 км, c - цена бензина за 1 литр).
            //Console.Write("Введите расстояние ");                 
            //double s = double.Parse(Console.ReadLine());
            //Console.Write("Введите расход бензина на 100 км ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Введите цену бензина за 1 литр ");
            //double c = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Стоимость поездки - {s / 100 * b * c} рублей");
            //Console.ReadKey();

            //Задача 3.Известна цена 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
            Console.Write("Введите цену за 1 кг конфет = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите цену за 1 кг печенья = ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите цену за 1 кг яблок = ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Введите x кг конфет = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите y кг печенья = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите z кг яблок = ");
            double z1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nСтоимость всей покупки - {(x * x1) + (y * y1) + (z * z1)} рублей");
            Console.ReadKey();




        }
}
}
