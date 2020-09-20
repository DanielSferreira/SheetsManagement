using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManageSheets.Helpers;
namespace SheetsManagement
{
    [TestClass]
    public class UnitTest1
    {
        private Sum s = new Sum();
        [TestMethod]
        public void TestMethod1()
        {
            int[] i = new int[]{
                1,1
            };
            int result = s.sum(i);
            int except = 2;

            Assert.AreEquals(except, result);
        }
    }
}
