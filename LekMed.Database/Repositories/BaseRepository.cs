using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LekMed.Database
{
    public abstract class BaseRepository<Entity> where Entity : class
    {
        protected LekMedDbContext _dbContext { get; }
        protected abstract DbSet<Entity> _dbSet { get; }

        protected BaseRepository(LekMedDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Entity> GetAll()
        {
            List<Entity> items = new List<Entity>();

            foreach(var item in _dbSet)
            {
                items.Add(item);
            }

            return items;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
