using System;
using System.Dynamic;

namespace lesson1_19._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, press any key to continue");
            Console.ReadKey();
            
            Console.WriteLine();
            double a = 16.80, b = 12.40, geoavg = Math.Round (Math.Sqrt(a * b), 2);
            Console.WriteLine("Задача 1: Даны два неотрицательных числа a и b. Найти их среднее геометрическое.");
            Console.WriteLine($"a = {a}, b = {b}, Результат: {geoavg}");
            Console.ReadKey();

            Console.WriteLine();
            double a2 = 1.40, b2 = -5.50, c2 = 0.60, AC = Math.Round(Math.Abs(a2 - c2), 2), BC = Math.Round(Math.Abs(b2 - c2), 2);
            double sum2 = Math.Round(AC + BC, 2); ;
            Console.WriteLine("Задача 2: Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их сумму.");
            Console.WriteLine($"A = {a2}, B = {b2}, C = {c2}, AC = {AC}, BC = {BC}, сумма AC + BC = {sum2}");
            Console.ReadKey();

            Console.WriteLine();
            double x1 = -6.20, x2 = 2.10, y1 = 5.20, y2 = 9.80;
            double dist = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
            Console.WriteLine("Задача 3: Найти расстояние между двумя точками с заданными координатами (x1,y1) и (x2, y2) на плоскости.");
            Console.WriteLine($"Расстояние между ({x1}, {y1}) и ({x2}, {y2}) равняется {dist}");
            Console.ReadKey();

            Console.WriteLine();
            int x = 41;
            Console.WriteLine("Задача 4: Дано двузначное число. Вывести число, полученное при перестановке цифр исходного числа.");
            Console.WriteLine($"Число: {x}, Результат: {x % 10}{x / 10}");
            Console.ReadKey();

            Console.WriteLine();
            int sec = 10985, min = sec / 60;
            Console.WriteLine("Задача 5: С начала суток прошло N секунд. Найти количество полных минут, прошедших с начала суток.");
            Console.WriteLine($"N = {sec}, Результат: {min}");
            Console.ReadKey();

            Console.WriteLine();
            int K = 202;
            Console.WriteLine("Задача 6: Дни недели пронумерованы следующим образом: 0 — воскресенье, ..., 6 — суббота. Дано целое число K, лежащее в диапазоне 1–365. Определить номер дня недели для K - го дня года, если известно, что в этом году 1 января было понедельником.");
            Console.WriteLine($"K = {K}, Номер дня недели: {K % 7}");
            Console.ReadKey();
        }
    }
}
