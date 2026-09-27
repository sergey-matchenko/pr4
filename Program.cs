//**********************************************************
//* Практическая работа N4                                 *
//* Выполнил:Матченко M.C., группа 2-ИСП-оКФ               *
//* Вариант 4                                              *
//* Задание: составить программу работы линейного алгоритма*
//**********************************************************
using System;
namespace PR_4
{
    internal class Program
    {
        static void Main(string[] args) // точка входа в программу 
        {
            Console.Title = "Практическая работа №4"; // заголовок консоли
            double x, z, y; // объявление переменных(вещественные)
            double v1, v2, v3, v4, v5, v6, v7;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите x = "); // ввод исходных данных
            x = Convert.ToDouble(Console.ReadLine()); // явное присвоение к типу double
            Console.Write("Введите z = "); // ввод исходных данных
            z = Convert.ToDouble(Console.ReadLine()); // явное присвоение к типу double
            //расчет значения выражения
            v1 = Math.Tan(x - Math.PI / 2); // тангенс разности
            v2 = Math.Cos(1.5 * Math.PI + z); //косинус суммы
            v3 = Math.Pow(Math.Sin(7.0 / 2.0 * Math.PI - x * z), 3); //синус разности, возведённый в куб
            v4 = v1 * v2 - v3; // числитель
            v5 = Math.Cos(x - Math.PI * z / 2); //первый множитель знаменателя
            v6 = Math.Tan(1.5 * Math.PI + x); //второй множитель знаменателя
            v7 = v5 * v6; // знаменатель
            y = v4 / v7; // нахождение функции 
            Console.WriteLine("\nРезультат расчета:"); // вывод  на терминал
            Console.WriteLine("y={0:#.###}", y); // результат
            Console.ReadKey(); // остановка программы, ожидание нажатия на клавишу
        }
    }
}
