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
        public T this[int index] 
        { 
            get 
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return items[index];
                }
                     
            } 
            set 
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                items[index] = value; 
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

        }

    }
}
