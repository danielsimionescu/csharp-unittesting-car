using CarLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTests
{
    [TestClass]
    public class OwnerTests
    {
        Owner onwer;

        string address;
        string name;
        string phone;

        [TestInitialize]
        public void Initialize()
        {
            onwer = new Owner();
            address = null;
            name = null;
            phone = null;
        }

        [TestMethod]
        public void TestCreateOnwer()
        {
            // arrange
            var owner = new Owner("Eriksvej", "Mathew", "12345678");

            // act
            onwer = owner;

            // assert
            Assert.AreEqual(owner, onwer);
        }

        [TestMethod]
        public void TestAddress()
        {
            // arrange
            address = "Eriksvej";

            // act
            onwer.Address = address;

            // assert
            Assert.AreEqual(address, onwer.Address);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestOutOfRangeAddress()
        {
            // arrange
            address = "42";

            // act
            onwer.Address = address;

            // assert
            Assert.AreNotEqual(address, onwer.Address);
        }

        [TestMethod]
        public void TestName()
        {
            // arrange
            name = "Matthew";

            // act
            onwer.Name = name;

            // assert
            Assert.AreEqual(name, onwer.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestShortName()
        {
            // arrange
            name = "Ma";

            // act
            onwer.Name = name;

            // assert
            Assert.AreNotEqual(name, onwer.Name);
        }

        [TestMethod]
        public void TestPhone()
        {
            // arrange
            phone = "12345678";

            // act
            onwer.Phone = phone;

            // assert
            Assert.AreEqual(phone, onwer.Phone);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDifferentPhone()
        {
            // arrange
            phone = "1234567";

            // act
            onwer.Phone = phone;

            // assert
            Assert.AreNotEqual(phone, onwer.Phone);
        }
    }
}
