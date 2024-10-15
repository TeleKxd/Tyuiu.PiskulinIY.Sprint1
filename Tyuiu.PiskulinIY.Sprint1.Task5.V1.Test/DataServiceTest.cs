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
            double x2 = 2;
            double y1 = 5;
            double y2 = 1;

            double res = ds.DistanceBetweenDots(x1, x2, y1, y2);

            int result = Convert.ToInt32(res);

            int wait = 5;

            Assert.AreEqual(wait, result);

        }
    }
}