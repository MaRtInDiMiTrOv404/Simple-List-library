using System;
using System.Collections.Generic;

namespace SimpleListLibrary
{
    public class SimpleList
    {
        private List<int> _list;

        public SimpleList()
        {
            _list = new List<int>();
        }

        public void Add(int item)
        {
            _list.Add(item);
        }

        public int Get(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return _list[index];
        }

        public int Min()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }

            return _list.Min();
        }

        public int Max()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }

            return _list.Max();
        }

        public void Sort()
        {
            _list.Sort();
        }
    }
}
