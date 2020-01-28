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
            myList.Remove(value);
            myList.Remove(value1);

            Assert.AreEqual(expectedValue, myList[0]);
        }
        [TestMethod]
        public void CheckIndexAfterRemoveWithMultipleNonRemoveDup()
        {
            CustomList<int> myList = new CustomList<int>();

            int expectedValue = 4;

            myList.Add(2);
            myList.Add(4);
            myList.Add(6);
            myList.Add(4);
            myList.Remove(2);
            myList.Remove(4);

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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void StringifyInteger()
        {
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.ToString();
            string expectedValue = "1";

            Assert.AreEqual(expectedValue, myList.ToString());
        }
        [TestMethod]
        public void StringifyMultipleIntegers()
        {
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.ToString();
            string expectedValue = "1234";

            Assert.AreEqual(expectedValue, myList.ToString());
        }
        [TestMethod]
        public void StringifyStringList()
        {
            CustomList<string> myList = new CustomList<string>();
            myList.Add("david");
            myList.Add("charlie");
            myList.Add("matt");
            myList.Add("nevin");

            myList.ToString();
            string expectedValue = "davidcharliemattnevin";

            Assert.AreEqual(expectedValue, myList.ToString());
        }
        [TestMethod]
        public void AddingTwoLists()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> otherList = new CustomList<int>();
            myList.Add(1);
            otherList.Add(2);
            CustomList<int> actualValue = myList + otherList;


            Assert.AreEqual("12", actualValue.ToString());
        }
        [TestMethod]
        public void AddingTwoDifferentSizeLists()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> otherList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            otherList.Add(4);
            otherList.Add(4);
            CustomList<int> actualValue = myList + otherList;

            Assert.AreEqual("12344", actualValue.ToString());
        }
        [TestMethod]
        public void SubstractingTwoDifferentLists()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> otherList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            otherList.Add(1);
            otherList.Add(3);
            CustomList<int> actualValue = myList - otherList;

            Assert.AreEqual("2", actualValue.ToString());
        }
        [TestMethod]
        public void SubtractingStringLists()
        {
            CustomList<string> myList = new CustomList<string>();
            CustomList<string> otherList = new CustomList<string>();
            myList.Add("david");
            myList.Add("david");
            myList.Add("lucas");
            otherList.Add("david");
            otherList.Add("jimmy");
            CustomList<string> actualValue = myList - otherList;
            Assert.AreEqual("lucas", actualValue.ToString());
        }
        [TestMethod]
        public void SubtractingStringListsWithNoSharedItems()
        {
            CustomList<string> myList = new CustomList<string>();
            CustomList<string> otherList = new CustomList<string>();
            myList.Add("david");
            myList.Add("john");
            myList.Add("lucas");
            otherList.Add("kelsey");
            otherList.Add("jimmy");
            CustomList<string> actualValue = myList - otherList;
            Assert.AreEqual("davidjohnlucas", actualValue.ToString());
        }
        [TestMethod]
        public void SubtractingIntegerListsWithIdenticalItems()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> otherList = new CustomList<int>();
            myList.Add(1);
            myList.Add(1);
            otherList.Add(1);
            otherList.Add(1);
            CustomList<int> actualValue = myList - otherList;

            Assert.AreEqual(0, actualValue.Count);
        }
        [TestMethod]
        public void ZipTwoIntLists()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> otherList = new CustomList<int>();
            myList.Add(1);
            myList.Add(3);
            myList.Add(5);
            otherList.Add(2);
            otherList.Add(4);
            otherList.Add(6);

            CustomList<int> actualValue = myList + otherList;
            Assert.AreEqual("123456", actualValue.ToString());
        }
        [TestMethod]
        public void ZipTwoStringLists()
        {
            CustomList<string> myList = new CustomList<string>();
            CustomList<string> otherList = new CustomList<string>();
            myList.Add("david");
            myList.Add("jimmy");
            myList.Add("lucas");
            otherList.Add("kelsey");
            otherList.Add("katie");
            otherList.Add("jennifer");
            CustomList<string> actualValue = myList + otherList;
            Assert.AreEqual("davidkelseyjimmykatielucasjennifer", actualValue.ToString());
        }
        [TestMethod]
        public void ZipTwoDifferentSizeLists()
        {
            CustomList<string> myList = new CustomList<string>();
            CustomList<string> otherList = new CustomList<string>();
            myList.Add("david");
            myList.Add("jimmy");
            myList.Add("lucas");
            myList.Add("donald");
            otherList.Add("kelsey");
            otherList.Add("katie");
            CustomList<string> actualValue = myList + otherList;
            Assert.AreEqual("davidkelseyjimmykatielucasdonald", actualValue.ToString());
        }
    }
}
