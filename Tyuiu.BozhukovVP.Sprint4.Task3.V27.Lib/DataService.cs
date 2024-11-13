using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BozhukovVP.Sprint4.Task3.V27.Lib
{
    public class DataService : ISprint4Task3V27
    {
        public int Calculate(int[,] array)
        {
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] % 2 == 0) res++;
                }
            }
            return res;
        }
    }
}
