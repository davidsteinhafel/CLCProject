using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T> : IEnumerable
    {
        int count;
        T[] items;
        public int Count { get { return count; } }
        public int Capacity { get; set; }
        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return items[i];
                }

            }
            set
            {
                if (i < 0 || i >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                items[i] = value;
            }
        }

        public CustomList()
        {
            Capacity = 4;
            items = new T[Capacity];
            count = 0;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {

                yield return items[i];

            }
        }
        public void Add(T item)
        {
            if (Count == Capacity)
            {
                T[] tempCopy = new T[Count];
                Capacity = Capacity * 2;

                for (int i = 0; i < count; i++)
                {
                    tempCopy[i] = items[i];
                }
                items = new T[Capacity];
                for (int i = 0; i < count; i++)
                {
                    items[i] = tempCopy[i];
                }
            }
            items[Count] = item;
            count++;
        }
        public void Remove(T item)
        {
            T[] tempCopy = items;
            int j = 0;


            int countBefore = count;
            for (int i = 0; i < countBefore; i++)
            {
                if (item.Equals( items[i]) && count == countBefore)
                {
                    i++;
                    count--;
                }
                tempCopy[j] = items[i];
                j++;
            }
            items = tempCopy;
        }
        public bool Compare(T firstValue, T secondValue)
        {
            if (firstValue.Equals(secondValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i]);
            }
            return sb.ToString();
        }
        public static CustomList<T> operator +(CustomList<T> myList, CustomList<T> otherList)
        {
            CustomList<T> returnedList = new CustomList<T>();
            for (int i = 0; i < myList.Count; i++)
            {

                returnedList.Add(myList.items[i]);

            }
            for (int j = 0; j < otherList.Count; j++)
            {
                returnedList.Add(otherList.items[j]);
            }
            return returnedList;
        }
        public static CustomList<T> operator -(CustomList<T> myList, CustomList<T> otherList)
        {
            CustomList<T> returnedList = new CustomList<T>();

            for(int i = 0; i < myList.Count; i++)
            {
                // 1223
                // 324
                if (!otherList.Contains(myList[i]))
                {
                    returnedList.Add(myList[i]);
                    // 1
                }
                
            }
            return returnedList;
            //if(myList.Count > otherList.Count)
            //{
            //    for (int i = 0; i < myList.Count; i++)
            //    {
            //        if (!otherList.Contains(myList.items[i]) || !myList.Contains(otherList.items[i]))
            //        {
            //            returnedList.Add(myList.items[i]);
            //            returnedList.Add(otherList.items[i]);
            //        }
            //    }
            //}
            //if(myList.Count <= otherList.Count)
            //{
            //    for (int i = 0; i < otherList.Count; i++)
            //    {
            //        if (!myList.Contains(otherList.items[i]) || !otherList.Contains(myList.items[i]))
            //        {
            //            returnedList.Add(myList.items[i]);
            //            returnedList.Add(otherList.items[i]);
            //        }
            //    }
            //}

            return returnedList;
        }
        public bool Contains(T item)
        {
            bool hasFound = false;
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(items[i]))
                {
                    hasFound = true;
                }
            }
            return hasFound;
        }
    }
}
