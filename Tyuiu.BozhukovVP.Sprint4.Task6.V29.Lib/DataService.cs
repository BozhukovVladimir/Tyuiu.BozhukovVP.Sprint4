using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BozhukovVP.Sprint4.Task6.V29.Lib
{
    public class DataService : ISprint4Task6V29
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(x => x.Length > 4);
            return count;
        }
    }
}
