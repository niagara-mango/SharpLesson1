using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLesson1
{
    class ClassTasks
    {
        //1
        public void Task1()
        {
            //Задание 1
            // Ввести с консоли 2 числа. Вывести их сумму на консоль
            float a, b;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // устанавливаем цвет
                Console.WriteLine("\nЗадание 1.\nВвести с консоли 2 числа. Вывести их сумму на консоль.");

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan; // устанавливаем цвет
                    Console.Write("\nВведите число 1: ");
                    Console.ResetColor();

                    string line = Console.ReadLine();

                    if (line.Contains('.'))
                        line = line.Replace(".", ",");

                    a = float.Parse(line);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНадо ввести число!!! " + e.Message.ToString());
                    continue;
                }

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("\nВведите число 2: ");
                    Console.ResetColor();

                    string line = Console.ReadLine();

                    if (line.Contains('.'))
                        line = line.Replace(".", ",");

                    b = float.Parse(line);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНадо ввести число!!! " + e.Message.ToString());
                    continue;
                }

                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\n\rРезультат: {a.ToString()} + {b.ToString()} = {(a + b).ToString()}");
                    Console.ResetColor();
                    break;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Невозможно вычислить сумму!!! " + e.Message.ToString());
                    continue;
                }
            }
        }
        //2
        public void Task2()
        {
            // Задание 2
            //Ввести с консоли 2 числа: n и i. Вывести значение i-ого бита числа n
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // устанавливаем цвет
                Console.WriteLine("\n\rЗадание 2.\nВвести с консоли 2 числа: n и i. Вывести значение i-ого бита числа n.");

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan; // устанавливаем цвет
                    Console.WriteLine();
                    Console.Write("Введите число n: ");
                    Console.ResetColor();

                    string line = Console.ReadLine();

                    if (line.Contains('.'))
                        line = line.Replace(".", ",");

                    float b = float.Parse(line);
                    Int64 n = Convert.ToInt64(b);

                    string binary = Convert.ToString(n, 2); //строковое представление

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n{0} в двоичном предствелнии {1}", n.ToString(), binary);

                    Console.ForegroundColor = ConsoleColor.DarkCyan; // устанавливаем цвет
                    Console.Write("\nВведите число i (от 1 до {0}): ", binary.Length.ToString());
                    Console.ResetColor();

                    line = Console.ReadLine();

                    if (line.Contains('.'))
                        line = line.Replace(".", ",");

                    int i = int.Parse(line);

                    if (i > binary.Length)
                    {
                        Console.WriteLine("Вы ввели слишком большое число. Так что вот вам старшый бит");
                        i = binary.Length - 1;
                    }
                    else
                        i--;

                    var res = (n >> i) & 1u;// сдвигаем вправо на нучное количество разрядов и логически умножаем на 1

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nРезультат: {0}-й бит равен {1}",(i+1).ToString(),res.ToString());

                    break;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Что-то пошло не так!!! " + e.Message.ToString());
                    continue;
                }
            }

        }
        //3
        public void Task3()
        {
            //Задание 3
            //Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\rЗадание 3.\nВвести с консоли число. Обнулить последний бит этого числа. Вывести на консоль.");

                    Console.ForegroundColor = ConsoleColor.DarkCyan; // устанавливаем цвет
                    Console.WriteLine();
                    Console.Write("Введите число: ");
                    Console.ResetColor();

                    string line = Console.ReadLine();

                    if (line.Contains('.'))
                        line = line.Replace(".", ",");

                    float b = float.Parse(line);
                    Int64 n = Convert.ToInt64(b);

                    string binary = Convert.ToString(n, 2); //строковое представление

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n{0} в двоичном предствелнии {1}", n.ToString(), binary);

                    var res = (n >> 1) << 1;// сначала сдвинев вправо, затем обратно влево. получим 0 последним битом

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nРезультат: {0}", res.ToString());

                    break;

                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Что-то пошло не так!!! " + e.Message.ToString());
                    continue;
                }
            }
        }
    }
}
