using SchoolInformationManagement.Business.Abstract;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Concrete;

public class ParentManager : IParentService
{
    private readonly IParentDal _parentDal;

    public ParentManager(IParentDal parentDal)
    {
        _parentDal = parentDal;
    }

    public bool Add(Parent parent)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Parent parent)
    {
        throw new NotImplementedException();
    }

    public List<Parent> GetList()
    {
        var parents = _parentDal.GetList();
        if (parents != null)
        {
            return parents;
        }
        return null!;
    }

    public bool Update(Parent parent)
    {
        throw new NotImplementedException();
    }
}
