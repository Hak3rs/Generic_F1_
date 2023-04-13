using Generic_F1.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_F1.Repository
{
    public class ListRepo<TLRepo> : IRepo<TLRepo> where TLRepo : class, IPerson, new()
    {
        protected readonly List<TLRepo> _items = new List<TLRepo>();
        public IEnumerable<TLRepo> GetAll()
        {
            return _items.ToList();
        }
        public TLRepo CreateNewItem()
        {
            return new TLRepo();
        }

        public void Add(TLRepo item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Save()
        {
            //foreach (var emp in _items)
            //{
            //    Console.WriteLine(emp);
            //}
        }

        public void Remove(TLRepo item)
        {
            _items.Remove(item);
        }

        public TLRepo GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
    }
}
