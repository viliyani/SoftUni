using Chainblock.Contracts;
using NUnit.Framework;

namespace Chainblock.Tests
{
    [TestFixture]
    public class ChainblockTests
    {

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            int expectedInitialCount = 0;

            IChainblock chainblock = new Core.Chainblock();

            Assert.AreEqual(expectedInitialCount, chainblock.Count);
        }
        

    }
}
