using Tyuiu.PiskulinIY.Sprint1.Task6.V3.Lib;
namespace Tyuiu.PiskulinIY.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string words = "��� ��� �����";
            string res = ds.LastLetterWord(words);
            Assert.AreEqual("���", res);



        }
    }
}