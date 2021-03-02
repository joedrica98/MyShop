using MyShop.Core.Models;
using System.Linq;

namespace MyShop.Core.Contracts
{
    public interface IRepository<E> where E : BaseEntity
    {
        IQueryable<E> Collection();
        void Commit();
        void Delete(string Id);
        E Find(string Id);
        void Insert(E e);
        void Update(E e);
    }
}