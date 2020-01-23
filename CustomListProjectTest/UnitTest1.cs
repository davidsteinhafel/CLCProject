using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;
namespace CustomListProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckZeroIndexAdd()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 2;

            //Act
            myList.Add(value);
            //Assert
            Assert.AreEqual(value, myList[0]);
        }
        [TestMethod]
        public void CheckCountAfterAdd()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int expectedResult = 1;

            myList.Add(value);

            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void CheckCountAfterRemove()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int secondValue = 10;

            myList.Add(value);
            myList.Add(secondValue);

            Assert.AreEqual(secondValue, myList[1]);
        }

        [TestMethod]
        public void CheckCapacityAfterAdd()
        {
            CustomList<int> myList = new CustomList<int>();
            int expectedValue = 4;

            myList.Add(12);

            Assert.AreEqual(expectedValue, myList.Capacity);

        }
        [TestMethod]
        public void CheckCapacityAfterAddingMultiple()
        {
            CustomList<int> myList = new CustomList<int>();
            int expectedValue = 8;

            myList.Add(2);
            myList.Add(4);
            myList.Add(6);
            myList.Add(8);
            myList.Add(10);

            Assert.AreEqual(expectedValue, myList.Capacity);
        }
        [TestMethod]
        public void CheckCountAfterAddingMultiple()
        {
            CustomList<int> myList = new CustomList<int>();
            int expectedValue = 8;

            myList.Add(2);
            myList.Add(4);
            myList.Add(6);
            myList.Add(8);
            myList.Add(10);

            Assert.AreEqual(expectedValue, myList.Capacity);
        }
        [TestMethod]
        public void CheckZeroIndexAfterAddingMultiples()
        {
            CustomList<int> myList = new CustomList<int>();
            int expectedValue = 2;

            myList.Add(2);
            myList.Add(4);
            myList.Add(6);
            myList.Add(8);
            myList.Add(10);

            Assert.AreEqual(expectedValue, myList[0]);

        }
    }
}
