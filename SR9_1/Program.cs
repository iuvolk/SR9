using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                Console.Write("Введите целое число. X = ");
                double x = Convert.ToDouble(Console.ReadLine());

                try
                {
                    Console.Write("Введите целое число. Y = ");
                    double y = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите код операции:\n \t 1 - сложение \n \t 2 - вычитание \n \t 3 - произведение \n \t 4 - частное \nВаш выбор: ");

                    int z = Convert.ToInt32(Console.ReadLine());

                    if (z == 1)
                    {
                        Console.WriteLine("Результат: {0}", x + y);
                    }
                    else if (z == 2)
                    {
                        Console.WriteLine("Результат: {0}", x - y);
                    }
                    else if (z == 3)
                    {
                        Console.WriteLine("Результат: {0}", x * y);
                    }
                    else if (z == 4)
                    {
                        Console.WriteLine("Результат: {0}", x / y);
                    }
                    else Console.WriteLine("Нет операции с указанным номером");


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
