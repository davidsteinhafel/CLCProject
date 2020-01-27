using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T>
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
        //public void IncreasedCapacity()
        //{
        //    T[] tempCopy = items;
        //    Capacity = Capacity * 2;

        //    items = new T[Capacity];

        //    for (int i = 0; i < count; i++)
        //    {

        //        items[i] = tempCopy[i];
        //    }
        //}
        public void Remove(T item)
        {
            T[] tempCopy = items;
            int j = 0;


            int countBefore = count;
            for (int i = 0; i < countBefore; i++)
            {
                if (Compare(item, items[i]) && count == countBefore)
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
    }
}
