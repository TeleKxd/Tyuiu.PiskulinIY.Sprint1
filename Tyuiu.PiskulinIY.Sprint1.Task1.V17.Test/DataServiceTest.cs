using Tyuiu.PiskulinIY.Sprint1.Task1.V17.Lib;
namespace Tyuiu.PiskulinIY.Sprint1.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Double x = 1.0;
            Double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(8, res);
        }
    }
}