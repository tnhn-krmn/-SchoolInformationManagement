using Microsoft.EntityFrameworkCore;
using SchoolInformationManagement.Core.DataAccess.Abstract;
using SchoolInformationManagement.Core.Entities;
using System.Linq.Expressions;

namespace SchoolInformationManagement.Core.DataAccess.Concrete;

public class EfRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
{
    public bool Add(TEntity entity)
    {
        using (var context = new TContext())
        {
            var addEntity = context.Entry(entity);
            addEntity.State = EntityState.Added;
            if (addEntity.State == EntityState.Added)
            {
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }

    public TEntity GetById(int id)
    {
        using (var context = new TContext())
        {
            // Id'ye göre varlığı al
            return context.Set<TEntity>().Find(id);
        }
    }

    public bool Delete(TEntity entity)
    {
        using (var context = new TContext())
        {
            var deleteEntity = context.Entry(entity);
            deleteEntity.State = EntityState.Deleted;
            if (deleteEntity.State == EntityState.Deleted)
            {
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter = null!)
    {
        using (var context = new TContext())
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
    }

    public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
    {
        using (var context = new TContext())
        {
            return filter == null ?
             context.Set<TEntity>().ToList()
            : context.Set<TEntity>().Where(filter).ToList();
        }
    }

    public void Update(TEntity entity)
    {
        using (var context = new TContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}