using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfacesELinq
{
    public class CustomCollection1 : ICollection<Item>
    {
        private List<Item> Items { get; set; } = new List<Item>();

        int ICollection<Item>.Count => throw new NotImplementedException();

        bool ICollection<Item>.IsReadOnly => throw new NotImplementedException();

        public int Count ;        

        public bool IsReadOnly ;        

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Clear()
        {
            Items.Clear();
        }

        public bool Contains(Item item)
        {
            return Items.Contains(item);
        }

        public void CopyTo(Item[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Item> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Item item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class CustomCollection2 : ICollection<Item>
    {
        private Item _Item {get;set;}

        int ICollection<Item>.Count => throw new NotImplementedException();

        bool ICollection<Item>.IsReadOnly => throw new NotImplementedException();

        public int Count ;

        public bool IsReadOnly ;

        public void Add(Item item)
        {
            _Item = item;
        }

        public void Clear()
        {
            _Item.Descricao = "";
        }

        public bool Contains(Item item)
        {
            return _Item.Descricao == item.Descricao;
        }

        public void CopyTo(Item[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Item> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Item item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
