using Tyuiu.BozhukovVP.Sprint4.Task1.V18.Lib;
namespace Tyuiu.BozhukovVP.Sprint4.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Божуков В. П. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Оператор цикла continue/break                                     *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Божуков Владимир Павлович | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов с клавиатуры:{7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7} *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int z;
            Console.Write("Введите количество элементвов массива: ");
            z = Convert.ToInt32(Console.ReadLine());

            int[] n = new int[z];

            for (int i = 0; i <= z - 1; i++)
            {
                Console.Write("Введите значение " + i + " элемент массива: ");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= z - 1; i++)

            {
                Console.Write(n[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n);
            Console.WriteLine("Сумма нечетных чисел в массиве = " + res);

            Console.ReadKey();
        }
    }
}
