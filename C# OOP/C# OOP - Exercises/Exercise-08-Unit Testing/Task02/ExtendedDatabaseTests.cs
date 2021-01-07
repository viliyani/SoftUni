using NUnit.Framework;
using System;

namespace UnitTesting
{
    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Person person;
        private ExtendedDatabase database;
        private readonly Person[] initialData = new Person[]
        {
            new Person(1, "Pesho"),
            new Person(2, "Gosho")
        };

        [SetUp]
        public void Setup()
        {
            this.person = new Person(1, "Ivan");

            Person[] personsData = new Person[]
            {
                new Person(1, "Ivan1"),
                new Person(2, "Ivan2"),
                new Person(3, "Ivan3"),
                new Person(4, "Ivan4"),
                new Person(5, "Ivan5"),
                new Person(6, "Ivan6"),
                new Person(7, "Ivan7"),
                new Person(8, "Ivan8"),
                new Person(9, "Ivan9"),
                new Person(10, "Ivan10"),
                new Person(11, "Ivan11"),
                new Person(12, "Ivan12"),
                new Person(13, "Ivan13"),
                new Person(14, "Ivan14"),
                new Person(15, "Ivan15"),
            };

            this.database = new ExtendedDatabase(personsData);
        }

        [Test]
        public void ConstructorOfPersonShouldWorkCorrectly()
        {
            long expectedID = (long)1;
            string expectedUserName = "Ivan";

            long actualID = this.person.Id;
            string actualUSer = this.person.UserName;

            Assert.That(actualUSer, Is.EqualTo(expectedUserName));
            Assert.That(actualID, Is.EqualTo(expectedID));
        }

        [Test]
        public void AddShouldThrowExceptionWhenUserNameExists()
        {
            Person personToAdd = new Person(222, "Ivan1");
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(personToAdd);
            }, "There is already user with this username!");
        }

        [Test]
        public void AddShouldThrowExceptionWhenIDExists()
        {
            Person personToAdd1 = new Person(2, "Peter");
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(personToAdd1);
            }, "There is already user with this Id!");
        }

        [Test]
        public void RemoveShouldDecreaseCount()
        {
            int expectedCount = 14;
            this.database.Remove();

            int actualCount = this.database.Count;

            Assert.That(actualCount, Is.EqualTo(expectedCount));
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenCountZero()
        {
            ExtendedDatabase data = new ExtendedDatabase(initialData);

            data.Remove();
            data.Remove();

            Assert.Throws<InvalidOperationException>(() =>
            {
                data.Remove();
            });
        }

        [Test]
        public void FindByNameShouldWorkCorrectly()
        {
            Person expectedPerson = new Person(1, "Ivan1");
            string searchedName = "Ivan1";

            Assert.That(this.database.FindByUsername(searchedName).UserName, Is.EqualTo(expectedPerson.UserName));
        }

        [Test]
        public void FindByUserNameShouldThrowExcWhenNameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.database.FindByUsername("");
            }, "Username parameter is null!");
        }

        [Test]
        public void FindByNameShouldThrowExcWhenNameDontExists()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.FindByUsername("Aleksandra");
            }, "No user is present by this username!");
        }

        [Test]
        public void FindByIDShouldWorkCorrectly()
        {
            Person expectedPerson = new Person(1, "Ivan1");
            long searchedID = (long)1;

            Assert.That(this.database.FindById(searchedID).Id, Is.EqualTo(expectedPerson.Id));
        }

        [Test]
        public void FindByIDShouldThrowExcWhenIDBelowZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                this.database.FindById(-10);
            }, "Id should be a positive number!");
        }

        [Test]
        public void FindByIDShouldThrowExcWhenUnExistingID()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.FindById(100);
            }, "No user is present by this ID!");
        }
    }
}
