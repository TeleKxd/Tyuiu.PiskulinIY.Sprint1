using Tyuiu.PiskulinIY.Sprint1.Task4.V23.Lib;
namespace Tyuiu.PiskulinIY.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 5;
            double wait = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
         
        }
    }
}