using Tyuiu.BozhukovVP.Sprint4.Task2.V22.Lib;
namespace Tyuiu.BozhukovVP.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4, 5, 6, 6, 5, 4, 3, 2, 1, 2 };
            int res = ds.Calculate(array);
            int wait = 225;
            Assert.AreEqual(wait, res);
        }
    }
}