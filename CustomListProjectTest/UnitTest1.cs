﻿using System;
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
        public void CheckIndexAfterRemoveWithMultiple()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int value1 = 4;
            int value2 = 6;
            int expectedValue = 6;

            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(value1);

            Assert.AreEqual(expectedValue, myList[1]);
        }
        [TestMethod]
        public void CheckIfItemRemovedSuccesfully()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expectedValue = 0;

            myList.Add(value);
            myList.Remove(value);

            Assert.AreEqual(expectedValue, myList.Count);
        }
        [TestMethod]
        public void CheckIfDuplicateRemoved()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 2;
            int value1 = 3;
            int value2 = 3;
            int expectedValue = 3;

            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(value1);

            Assert.AreEqual(expectedValue, myList[1]);  
        }
        public void CheckZeroIndexWhenMutliplesRemoved()
        {
            CustomList<int> myList = new CustomList<int>();
            int expectedValue = 4;
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Remove(1);
            myList.Remove(2);
            myList.Remove(3);

            Assert.AreEqual(expectedValue, myList[0]);
        }
        public void CheckCountWhenMultiplesRemoved()
        {
            CustomList<int> myList = new CustomList<int>();
            int expectedValue = 1;
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Remove(1);
            myList.Remove(2);
            myList.Remove(3);

            Assert.AreEqual(expectedValue, myList.Count);
        }
    }
}
