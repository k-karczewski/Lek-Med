using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LekMed.Database
{
    public abstract class BaseRepository<Entity> where Entity : BaseEntity
    {
        protected LekMedDbContext _dbContext { get; }
        protected abstract DbSet<Entity> _dbSet { get; }

        protected BaseRepository(LekMedDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddNew(Entity entity)
        {
            _dbSet.Add(entity);

            return SaveChanges();
        }

        public bool Delete(int id)
        {
            var foundEntity = _dbSet.FirstOrDefault(x => x.Id == id);

            if (foundEntity != null)
            {
                _dbSet.Remove(foundEntity);
                return SaveChanges();
            }

            return false;
        }

        public bool SaveChanges()
        {
            return _dbContext.SaveChanges() > 0 ? true : false;
        }
    }
}
