using Tyuiu.BozhukovVP.Sprint4.Task3.V27.Lib;
namespace Tyuiu.BozhukovVP.Sprint4.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Божуков Владимир Павлович | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы (статический ввод)                                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Божуков Владимир Павлович | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статичес*");
            Console.WriteLine("*скими значениями в диапазоне от 3 до 7. Подсчитайте количество четных эле*");
            Console.WriteLine("*ементов во всем массиве.                                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5] { { 4, 3, 5, 5, 3 }, { 6, 7, 4, 4, 3 }, { 3, 3, 7, 3, 6 }, { 3, 4, 3, 7, 7 }, { 3, 5, 6, 3, 6 } };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Элемент массива [{i},{j}]: {array[i, j]}");
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine($"произведение нечетных элементов: {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
