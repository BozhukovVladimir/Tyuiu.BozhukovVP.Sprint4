using Tyuiu.BozhukovVP.Sprint4.Task1.V18.Lib;
namespace Tyuiu.BozhukovVP.Sprint4.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
             DataService ds  = new DataService();
            int[] i = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };
            int res = ds.Calculate(i);
            int walie = 79;
            Assert.AreEqual(walie, res);
        }
    }
}