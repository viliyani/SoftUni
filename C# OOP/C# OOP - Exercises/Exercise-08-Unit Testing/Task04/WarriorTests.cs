using NUnit.Framework;
using System;

namespace UnitTesting
{
    [TestFixture]
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            string expectedName = "Pesho";
            int expectedDmg = 50;
            int expectedHP = 100;

            Warrior warrior = new Warrior(expectedName, expectedDmg, expectedHP);

            string actualName = warrior.Name;
            int actualDmg = warrior.Damage;
            int actualHP = warrior.HP;

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedDmg, actualDmg);
            Assert.AreEqual(expectedHP, actualHP);
        }

        [Test]
        public void TestWithLikeNullName()
        {
            string name = null;
            int dmg = 50;
            int hp = 100;

            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        public void TestWithLikeEmptyName()
        {
            string name = String.Empty;
            int dmg = 50;
            int hp = 100;

            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        public void TestWithLikeZeroDamage()
        {
            string name = "Pesho";
            int dmg = 0;
            int hp = 100;

            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        public void TestWithLikeNegativeDamage()
        {
            string name = "Gosho";
            int dmg = -10;
            int hp = 50;

            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        public void TestWithLikeNegativeHp()
        {
            string name = "Pesho";
            int dmg = 10;
            int hp = -10;

            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [Test]
        [TestCase(30)]
        [TestCase(20)]
        public void AttackShouldThrowExceptionWhenHpLowerThen31(int hp)
        {
            Warrior myWarrior = new Warrior("Stiv", 20, hp);
            Warrior enemy = new Warrior("Peter", 20, 40);

            Assert.Throws<InvalidOperationException>(() =>
            {
                myWarrior.Attack(enemy);
            });
        }

        [Test]
        public void AttackShouldThrowExceptionHpLowerThenEnemysDamage()
        {
            Warrior myWarrior = new Warrior("Stiv", 100, 90);
            Warrior enemy = new Warrior("Peter", 100, 100);

            Assert.Throws<InvalidOperationException>(() =>
            {
                myWarrior.Attack(enemy);
            });
        }

        [Test]
        public void AttackShouldDecreaseHp()
        {
            Warrior myWarrior = new Warrior("Stiv", 60, 100);
            Warrior enemy = new Warrior("Peter", 50, 100);
            int expectedHp = myWarrior.HP - enemy.Damage;
            int expectedEnemyHp = enemy.HP - myWarrior.Damage;

            myWarrior.Attack(enemy);

            Assert.That(myWarrior.HP, Is.EqualTo(expectedHp));
            Assert.That(enemy.HP, Is.EqualTo(expectedEnemyHp));
        }

        [Test]
        public void AttackShouldSetEnemysHpZeroWhenDamageBiggerThenEnemysHp()
        {
            Warrior myWarrior = new Warrior("Stiv", 100, 100);
            Warrior enemy = new Warrior("Peter", 40, 90);
            int expectedWarriorHp = myWarrior.HP - enemy.Damage;
            int expectedEnemyHp = 0;

            myWarrior.Attack(enemy);

            Assert.That(myWarrior.HP, Is.EqualTo(expectedWarriorHp));
            Assert.That(enemy.HP, Is.EqualTo(expectedEnemyHp));
        }
    }
}
