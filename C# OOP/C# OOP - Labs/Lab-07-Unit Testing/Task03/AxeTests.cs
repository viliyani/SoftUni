using NUnit.Framework;

namespace Skeleton
{
    [TestFixture]
    public class AxeTests
    {
        private const string AXE_DURABILITY_RESULT_FAILED_MSG = "Axe durability doesn't change after attack.";

        private const string AXE_BROKEN_MSG = "Axe is broken.";

        private const int ATTACKS_POINTS = 10;

        private Dummy dummy;

        [SetUp]
        public void SetDummy()
        {
            this.dummy = new Dummy(ATTACKS_POINTS, 10);
        }

        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(ATTACKS_POINTS, 10);

            // Act
            axe.Attack(this.dummy);

            // Assert
            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), AXE_DURABILITY_RESULT_FAILED_MSG);
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            Axe axe = new Axe(ATTACKS_POINTS, 0);

            Assert.That(() => axe.Attack(dummy),
              Throws.InvalidOperationException
                .With.Message.EqualTo(AXE_BROKEN_MSG));
        }
    }
}
