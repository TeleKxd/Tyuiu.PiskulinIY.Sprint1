using Tyuiu.PiskulinIY.Sprint1.Task2.V20.Lib;
namespace Tyuiu.PiskulinIY.Sprint1.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            var res = ds.CalculateSquaresSumm(x, y);
            Assert.AreEqual(13, res);
        }
    }
}