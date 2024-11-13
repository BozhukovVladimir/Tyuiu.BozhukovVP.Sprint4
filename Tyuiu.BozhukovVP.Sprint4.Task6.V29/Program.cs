using Tyuiu.BozhukovVP.Sprint4.Task6.V29.Lib;
namespace Tyuiu.BozhukovVP.Sprint4.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил Божуков В. П. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Божуков Владимир Павлович   | ИБКСб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных                                             *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов,                 *");
            Console.WriteLine("* длина которых больше 4.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Найти слова, содержащие больше 4 букв, в массиве:");
            Console.WriteLine("\"Весна\", \"Лето\", \"Осень\", \"Зима\"");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] array = ["Весна", "Лето", "Осень", "Зима"];
            int z = ds.Calculate(array);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
