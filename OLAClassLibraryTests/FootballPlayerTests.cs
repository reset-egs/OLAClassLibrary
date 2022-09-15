using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLAClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OLAClassLibrary.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        internal FootballPlayer player = new FootballPlayer() { Id = 1, Name = "Szymon", Age = 23, ShirtNumber = 69 };

        [TestMethod()]
        public void ValidateNameTest()
        {
            player.ValidateName();

            FootballPlayer shortName = new FootballPlayer() { Id = 2, Name = "S", Age = 15, ShirtNumber = 70 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shortName.ValidateName());

            FootballPlayer nullName = new FootballPlayer() { Id = 3, Name = null, Age = 15, ShirtNumber = 70 };
            Assert.ThrowsException<ArgumentNullException>(() => nullName.ValidateName());

            FootballPlayer borderName = new FootballPlayer() { Id = 4, Name = "Sz", Age = 15, ShirtNumber = 70 };
            borderName.ValidateName();
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            player.ValidateAge();

            FootballPlayer negativeAge = new FootballPlayer() { Id = 5, Name = "Szymon", Age = -1, ShirtNumber = 25 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => negativeAge.ValidateAge());

            FootballPlayer borderAge = new FootballPlayer() { Id = 6, Name = "Szymon", Age = 1, ShirtNumber = 30 };
            borderAge.ValidateAge();
        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            player.ValidateShirtNumber();

            FootballPlayer negativeShirtNumber = new FootballPlayer() { Id = 7, Name = "Szymon", Age = 20, ShirtNumber = -1 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => negativeShirtNumber.ValidateShirtNumber());

            FootballPlayer lowerBorderShirtNumber = new FootballPlayer() { Id = 8, Name = "Szymon", Age = 20, ShirtNumber = 1 };
            lowerBorderShirtNumber.ValidateShirtNumber();

            FootballPlayer higherBorderShirtNumber = new FootballPlayer() { Id = 9, Name = "Szymon", Age = 20, ShirtNumber = 99 };
            higherBorderShirtNumber.ValidateShirtNumber();

            FootballPlayer overLimitShirtNumber = new FootballPlayer() { Id = 10, Name = "Szymon", Age = 20, ShirtNumber = 100 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => overLimitShirtNumber.ValidateShirtNumber());
        }
    }
}