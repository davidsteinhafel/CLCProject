using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T>
    {
        T[] items;
        public int Count { get; }
        public int Capacity { get; set; }
        public int Contain { get; }
        public CustomList()
        {
            Capacity = 4;
            items = new T[0];
            Count = 0;
            
                        
        }
        public void Add(T item)
        {
           if(new item)
        }
    }
}
