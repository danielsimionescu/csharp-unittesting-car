using System;
using CarLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CarLibrary.Car;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        Car car;
        Owner owner;

        const int minDoors = 2;
        const int maxDoors = 5;
        const int minWheels = 3;
        const int maxWheels = 4;
        
        string make;
        string regNo;
        Colors color;

        [TestInitialize]
        public void Initialize()
        {
            regNo = "1234567";
            make = "Hyundai";
            color = Colors.White;
            car = new Car();
        }

        [TestMethod]
        public void TestCreateCar()
        {
            // arrange

            // act
            car = new Car(regNo, make, minDoors, color);

            // assert
            Assert.AreEqual(regNo, car.RegistrationNo);
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(minDoors, car.Doors);
            Assert.AreEqual(color, car.Color);
        }

        [TestMethod]
        public void TestMinDoors()
        {
            // arrange

            // act
            car.Doors = minDoors;

            // assert
            Assert.AreEqual(minDoors, car.Doors);
        }

        [TestMethod]
        public void TestMaxDoors()
        {
            // arrange

            // act
            car.Doors = maxDoors;

            // assert
            Assert.AreEqual(maxDoors, car.Doors);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestLessThanMinDoors()
        {
            // arrange

            // act
            car.Doors = minDoors - 1;

            // assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMoreThanMaxDoors()
        {
            // arrange

            // act
            car.Doors = maxDoors + 1;

            // assert
        }

        [TestMethod]
        public void TestManufacturer()
        {
            // arrange
            make = "BMW";

            // act
            car.Make = make;

            // assert
            Assert.AreEqual(make, car.Make);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEmptyManufacturer()
        {
            // arrange
            make = string.Empty;

            // act
            car.Make = make;

            // assert
        }

        [TestMethod]
        public void TestRegistrationNo()
        {
            // arrange
            regNo = "1234567";

            // act
            car.RegistrationNo = regNo;

            // assert
            Assert.AreEqual(regNo, car.RegistrationNo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestShortRegistrationNo()
        {
            // arrange
            regNo = "123";

            // act
            car.RegistrationNo = regNo;

            // assert
        }

        [TestMethod]
        public void TestColor()
        {
            // arrange
            color = Colors.Black;

            // act
            car.Color = color;

            // assert
            Assert.AreEqual(color, car.Color);
        }

        [TestMethod]
        public void TestOwner()
        {
            // arrange
            owner = new Owner("Blue Gardens", "Matthew", "12345678");

            // act
            car.Owner = owner;

            // assert
            Assert.AreEqual(owner, car.Owner);
        }
    }
}
