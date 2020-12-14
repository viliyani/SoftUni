using NUnit.Framework;

namespace Skeleton
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLoosesHealthAfterAttack()
        {
            Dummy dummy = new Dummy(100, 50);

            dummy.TakeAttack(20);

            Assert.That(dummy.Health, Is.EqualTo(80), "Dummy Health is not loosing after take attack.");
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(0, 50);

            Assert.That(() => dummy.TakeAttack(20),
              Throws.InvalidOperationException
                .With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyShouldGiveXP()
        {
            Dummy dummy = new Dummy(0, 50);

            var experience = dummy.GiveExperience();

            Assert.That(experience, Is.EqualTo(50), "Dead dummies give experience.");
        }

        [Test]
        public void AliveDummyShouldntGiveXP()
        {
            Dummy dummy = new Dummy(100, 50);

            Assert.That(() =>
                dummy.GiveExperience(),
                Throws.InvalidOperationException.
                With.Message.EqualTo("Target is not dead."));
        }
    }
}
