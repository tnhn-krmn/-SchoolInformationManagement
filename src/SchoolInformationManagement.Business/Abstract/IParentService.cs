using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Abstract;

public interface IParentService
{
    public List<Parent> GetList();
    public bool Add(Parent parent);
    public bool Delete(Parent parent);
    public bool Update(Parent parent);
}
