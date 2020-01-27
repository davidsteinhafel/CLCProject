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
                IncreasedCapacity();
            }
            items[Count] = item;
            count++;
        }
        public void IncreasedCapacity()
        {
            T[] tempCopy = items;
            Capacity = Capacity * 2;
            items = new T[Capacity];
            for (int i = 0; i < count; i++)
            {

                items[i] = tempCopy[i];
            }
        }
        public void Remove(T item)
        {
            T[] tempCopy = items;
            items = new T[Capacity];
            int j;
            j = 0;

            for (int i = 0; i < count; i++)
            {

                if (Compare(item, items[i]))
                {
                    i++;
                    
                }
                tempCopy[j] = items[i];
                j++;
                if (i < count)
                {
                    items[i] = tempCopy[j];
                }
                --count;
            }

            //    for (int i = 0; i < count; i++)
            //    {

            //        if (Compare(item, items[i]))
            //        {
            //            int dontCopy = i;
            //            counter++;
            //        }
            //        else
            //        {
            //            for (i = 0; i < count - 1; i++)
            //            {
            //                tempArray[Capacity] = items[i];
            //            }

            //        }
            //        items[i] = tempArray[i];
            //        count++;

            //    }

            //    count--;
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

    }
}
