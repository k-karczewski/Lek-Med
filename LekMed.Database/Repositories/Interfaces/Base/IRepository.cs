namespace LekMed.Database
{
    public interface IRepository<Entity> where Entity : BaseEntity
    {
        bool AddNew(Entity entity);
        bool Delete(int id);
    }
}
