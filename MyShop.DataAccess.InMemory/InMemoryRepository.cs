using MyShop.Core.Contracts;
using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.InMemory
{
    public class InMemoryRepository<E> : IRepository<E> where E : BaseEntity
    {
        ObjectCache cache = MemoryCache.Default;
        List<E> items;
        string className;

        public InMemoryRepository()
        {
            className = typeof(E).Name;
            items = cache[className] as List<E>;
            if (items == null)
            {
                items = new List<E>();
            }
        }
        public void Commit()
        {
            cache[className] = items;
        }


        public void Insert(E e)
        {
            items.Add(e);
        }

        public void Update(E e)
        {
            E eToUpdate = items.Find(i => i.Id == e.Id);

            if (eToUpdate != null)
            {
                eToUpdate = e;
            }
            else
            {
                throw new Exception(className + "Not found");
            }
        }

        public E Find(string Id)
        {
            E e = items.Find(i => i.Id == Id);
            if (e != null)
            {
                return e;
            }
            else
            {
                throw new Exception(className + "Not found");
            }
        }

        public IQueryable<E> Collection()
        {
            return items.AsQueryable();
        }

        public void Delete(string Id)
        {
            E eToDelete = items.Find(i => i.Id == Id);

            if (eToDelete != null)
            {
                items.Remove(eToDelete);
            }
            else
            {
                throw new Exception(className + "Not found");
            }
        }
    }

}
