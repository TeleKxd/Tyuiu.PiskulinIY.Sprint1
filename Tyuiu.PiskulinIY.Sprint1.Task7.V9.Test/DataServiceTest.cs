using Tyuiu.PiskulinIY.Sprint1.Task7.V9.Lib;
namespace Tyuiu.PiskulinIY.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;
            double wait = 1.975;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}