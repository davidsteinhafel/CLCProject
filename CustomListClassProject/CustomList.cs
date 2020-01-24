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
                return items[index]; 
            } 
            set 
            { 
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

    }
}
