using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 1");
                        Console.WriteLine("Ввести с клавиатуры номер трамвайного билета (6-значное число) ");
                        Console.WriteLine("и проверить является ли данный билет счастливым (если на билете ");
                        Console.WriteLine("напечатано шестизначное число, и сумма первых трёх цифр равна ");
                        Console.WriteLine("сумме последних трёх, то этот билет считается счастливым). ");
                        Console.WriteLine("\n");
                        Console.Write("Укажите 6-значное число ==> ");
                        int number = int.Parse(Console.ReadLine());
                        string data = number.ToString();
                        if (data.Length == 6)
                        {
                            int first = data[0] - '0' + data[1] - '0' + data[2] - '0';
                            int second = data[3] - '0' + data[4] - '0' + data[5] - '0';
                            if (first == second)
                                Console.WriteLine($"{number} счастливое!");
                            else
                                Console.WriteLine($"{number} не счастливое :(");
                        }
                        else
                            Console.WriteLine("Введено не 6-значное число!");
                    }
                    break;
                case '2':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 2");
                        Console.WriteLine("Дано целое число N (> 0), найти число, полученное при ");
                        Console.WriteLine("прочтении числа N справа налево. Например, если было введено число ");
                        Console.WriteLine("345, то программа должна вывести число 543.");
                        Console.WriteLine("\n");
                        Int32 x, n;
                        Console.WriteLine("Введите число х ==> ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write(x);
                        Console.Write(x % 100 / 10);
                        n = 0;
                        while (n < 10)
                        {
                            n = x / 10;
                            Console.Write(n);
                        }
                        break;
                    }
            }
        }
    }
}
