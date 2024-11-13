using Tyuiu.BozhukovVP.Sprint4.Task3.V27.Lib;
namespace Tyuiu.BozhukovVP.Sprint4.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 2, 4, 5, 6, 7 }, { 1, 4, 5, 2, 5 }, { 1, 6, 7, 3, 5 }, { 8, 1, 4, 7, 8 }, { 6, 3, 1, 2, 5 } };
            Assert.AreEqual(11, ds.Calculate(array));
        }
    }
}