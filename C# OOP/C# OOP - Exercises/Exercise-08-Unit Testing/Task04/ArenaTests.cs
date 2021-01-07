using NUnit.Framework;
using System;

namespace UnitTesting
{
    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        private Warrior attacker;
        private Warrior deffender;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
            this.attacker = new Warrior("Pesho", 10, 80);
            this.deffender = new Warrior("Peter", 5, 50);
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Assert.IsNotNull(this.arena.Warriors);
        }

        [Test]
        public void CountShouldWorkCorrectly()
        {
            int expectedCount = 0;

            Assert.That(this.arena.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void EnrollShouldWorkCorrectlyWhenEnrollNewUniqueWarrior()
        {
            Warrior warriorToEnroll = new Warrior("Peter", 100, 100);
            int expectedCount = 1;

            this.arena.Enroll(warriorToEnroll);

            Assert.That(this.arena.Count, Is.EqualTo(expectedCount));
            Assert.That(this.arena.Warriors, Has.Member(warriorToEnroll));
        }

        [Test]
        public void EnrollShouldThrowExceptionAddingAnExistingWarrior()
        {
            Warrior warriorToEnroll = new Warrior("Peter", 100, 100);

            this.arena.Enroll(warriorToEnroll);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Enroll(warriorToEnroll);
            });
        }

        [Test]
        public void EnrollShouldThrowExceptionWhenTwoWarriorsHaveSameName()
        {
            Warrior warriorToEnroll = new Warrior("Peter", 100, 100);
            Warrior another = new Warrior("Peter", 80, 80);

            this.arena.Enroll(warriorToEnroll);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Enroll(another);
            });
        }

        [Test]
        public void FightShouldThrowExceptionWhenMissingAttacker()
        {
            this.arena.Enroll(this.deffender);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight(this.attacker.Name, this.deffender.Name);
            });
        }

        [Test]
        public void FightShouldThrowExceptionWhenMissingDeffender()
        {
            this.arena.Enroll(this.attacker);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight(this.attacker.Name, this.deffender.Name);
            });
        }

        [Test]
        public void FightShouldThrowExceptionWhenMissingTheTwoWarriors()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight(this.attacker.Name, this.deffender.Name);
            });
        }

        [Test]
        public void FightShouldWorkWithCorrectsParameters()
        {
            int expectedAttackerHp = this.attacker.HP - this.deffender.Damage;
            int expectedDeffenderHp = this.deffender.HP - this.attacker.Damage;

            this.arena.Enroll(this.attacker);
            this.arena.Enroll(this.deffender);

            this.arena.Fight(this.attacker.Name, this.deffender.Name);

            Assert.That(this.attacker.HP, Is.EqualTo(expectedAttackerHp));
            Assert.That(this.deffender.HP, Is.EqualTo(expectedDeffenderHp));
        }

    }
}
