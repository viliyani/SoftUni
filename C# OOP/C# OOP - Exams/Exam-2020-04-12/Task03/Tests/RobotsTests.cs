using NUnit.Framework;
using System;

namespace Robots.Tests
{
    [TestFixture]
    public class RobotsTests
    {
        private Robot robot;
        private Robot secondRobot;
        private RobotManager robotManager;

        [SetUp]
        public void SetUp()
        {
            robot = new Robot("Robot 1", 50);
            secondRobot = new Robot("Robot 2", 40);
        }

        [Test]
        public void ConstructorShouldWorksCorrectly()
        {
            robotManager = new RobotManager(2);

            // Assert
            Assert.AreEqual(0, robotManager.Count);
            Assert.AreEqual(2, robotManager.Capacity);
        }

        [Test]
        public void InvalidCapacityShouldThrowExceptionWhenNegative()
        {
            Assert.That(() =>
            {
                var robotManager = new RobotManager(-5);
            }, Throws.ArgumentException);
        }

        [Test]
        public void AddRobotWithExistingNameShouldThrowException()
        {
            robotManager = new RobotManager(5);
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Add(robot);
            });
        }

        [Test]
        public void AddShouldThrowExceptionWhenReachesCapacity()
        {
            robotManager = new RobotManager(1);
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Add(robot);
            });
        }

        [Test]
        public void AddShouldIncreaseCount()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(secondRobot);

            Assert.That(robotManager.Count, Is.EqualTo(2));
        }

        [Test]
        public void RemoveShouldWorkCorrectly()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(secondRobot);

            robotManager.Remove(secondRobot.Name);

            Assert.That(robotManager.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveShouldThrowExceptionWithNonexistingRobotName()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(secondRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Remove("Opa");
            });
        }

        [Test]
        public void WorkShouldThrowExceptionWithNonexistingRobotName()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(secondRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Work("Opa", "clean", 20);
            });
        }

        [Test]
        public void WorkShouldThrowExceptionWhenNotEnoughBattery()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(secondRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Work("Opa", "clean", 30);
            });
        }

        [Test]
        public void WorkShouldDecreaseBattery()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(secondRobot);

            robotManager.Work(secondRobot.Name, "clean", 10);

            Assert.That(secondRobot.Battery, Is.EqualTo(30));
        }

        [Test]
        public void ChargeShouldThrowExceptionWhenNonexistingRobotName()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(secondRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Charge("Opa");
            });
        }

        [Test]
        public void ChargeShouldSetRoboBatteryToMax()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(secondRobot);

            robotManager.Work(secondRobot.Name, "clean", 10);

            robotManager.Charge(secondRobot.Name);

            Assert.That(robot.Battery, Is.EqualTo(robot.MaximumBattery));

        }
    }
}
