using SchoolInformationManagement.Core.Entities;
using System.Linq.Expressions;

namespace SchoolInformationManagement.Core.DataAccess.Abstract;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    public T GetById(int id);
    List<T> GetList(Expression<Func<T, bool>> filter = null);

    bool Add(T Entity);
    void Update(T Entity);
    bool Delete(T Entity);
}