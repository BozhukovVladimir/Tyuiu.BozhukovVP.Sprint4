using Tyuiu.BozhukovVP.Sprint4.Task6.V29.Lib;
namespace Tyuiu.BozhukovVP.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = ["Âåñíà", "Ëåòî", "Îñåíü", "Çèìà"];
            int wail = 2;
            int res = ds.Calculate(array);
            Assert.AreEqual(wail, res);
        }
    }
}