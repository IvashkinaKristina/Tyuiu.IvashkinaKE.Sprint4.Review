using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.IvashkinaKE.Sprint4.TaskReview.V11.Lib;

namespace Tyuiu.IvashkinaKE.Sprint4.TaskReview.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int rows = 4;
                int columns = 2;
                int[,] mtrx = new int[rows, columns];

                string str = "56789012";

                DataService ds = new DataService();
                Console.Title = "Спринт #4-Review | Выполнила: Ивашкина К.Э. | АСОиУб-23-1";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #4-Review                                                        *");
                Console.WriteLine("* Вариант #11                                                             *");
                Console.WriteLine("* Выполнила: Ивашкина Кристина Эдуардовна | АСОиУб-23-1                   *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Дана строка из одноразрядных цифр ['56789012'].                         *");
                Console.WriteLine("* Преобразуйте ее в матрицу 4 на 2 и подсчитайте количество четных чисел. *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                int index = 0;

                Console.WriteLine("\nМассив:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{str[index]} \t");
                        index++;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                int res = ds.Calculate(rows, columns, str);

                Console.WriteLine("Количество нечётных элементов = " + res);
                Console.ReadKey();

            }
        }
    }
}
