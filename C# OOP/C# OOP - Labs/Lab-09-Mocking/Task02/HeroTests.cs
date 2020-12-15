using FakeAxeAndDummy.Contracts;
using FakeAxeAndDummy.Fakes;
using NUnit.Framework;

namespace FakeAxeAndDummy
{
    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void GivenHero_WhenAttackedTargetDies_ThenHeroReceivesExperience()
        {
            IAttackable fakeTarget = new IAttackableFake();
            IWeapon fakeWeapon = new IWeaponFake();
            Hero hero = new Hero("Hero", fakeWeapon);

            hero.Attack(fakeTarget);

            Assert.AreEqual(20, hero.Experience);
        }


    }
}
