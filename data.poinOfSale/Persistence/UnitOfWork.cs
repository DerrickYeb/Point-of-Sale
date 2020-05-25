using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace data.poinOfSale.Persistence
{
    public class UnitOfWork
    {
        private readonly DbContext _ctx;
        public UnitOfWork(DbContext dbContext)
        {
            _ctx = dbContext;
        }

        public T GetRepository<T>() where T: class
        {
            return Activator.CreateInstance(typeof(T), _ctx) as T;
        }
        public async Task<int> Commit() => await _ctx.SaveChangesAsync();
    }
}
