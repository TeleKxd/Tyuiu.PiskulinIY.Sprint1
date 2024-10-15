using Tyuiu.PiskulinIY.Sprint1.Task5.V1.Lib;
namespace Tyuiu.PiskulinIY.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            DataService ds = new DataService();
            double x1 = 5;
            double y1 = 5;
            double x2 = 2;
            double y2 = 1;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(5, res);

        }
    }
}