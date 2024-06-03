using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Abstract;

public interface IClassService
{
    public List<Class> GetList();
    public bool Add(Class clas);
    public bool Delete(Class clas);
    public bool Update(Class clas);
}
