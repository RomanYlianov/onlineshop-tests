using ExecityEntityFramework;

namespace TestOnlineShop
{
    public class UnitTest
    {
        [Test]
        public void TestEntityFrameworkCore()
        {

            bool flag = TestEntityFrameworkConnection.TestConnection();

            Assert.True(flag);
        }
    }
  
}