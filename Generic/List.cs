using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class List
    {
        public class CustomList<T>
        {
            private T[] items;
            private int capacity;
            private int count;

            public CustomList()
            {
                capacity = 4; 
                items = new T[capacity];
                count = 0; 
            }

            public int Capacity
            {
                get { return capacity; }
            }

            public int Count
            {
                get { return count; }
            }

            public void Add(T item)
            {
                if (count == capacity)
                {
                    capacity *= 2;
                    T[] newItems = new T[capacity];
                    Array.Copy(items, newItems, count);
                    items = newItems;
                }

                items[count] = item;
                count++;
            }

            public void Clear()
            {
                Array.Clear(items, 0, count);
                count = 0;
            }

            public bool Exist(T item)
            {
                return Array.IndexOf(items, item) != -1;
            }

            public void Remove(T item)
            {
                int index = Array.IndexOf(items, item);
                if (index != -1)
                {
                    Array.Copy(items, index + 1, items, index, count - index - 1);
                    items[count - 1] = default(T); 
                    count--;
                }
            }

            public void Reverse()
            {
                Array.Reverse(items, 0, count);
            }

            public int IndexOf(T item)
            {
                return Array.IndexOf(items, item);
            }

            public int LastIndexOf(T item)
            {
                return Array.LastIndexOf(items, item);
            }
        }
    }
}
