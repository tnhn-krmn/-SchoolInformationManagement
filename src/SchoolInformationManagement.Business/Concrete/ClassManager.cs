using SchoolInformationManagement.Business.Abstract;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;


namespace SchoolInformationManagement.Business.Concrete;

public class ClassManager : IClassService
{
    private readonly IClassDal _classDal;

    public ClassManager(IClassDal classDal)
    {
        _classDal = classDal;
    }

    public bool Add(Class clas)
    {
        var clss = _classDal.Add(clas);
        if (clss != false)
        {
            return true;
        }
        return false;
    }

    public bool Delete(Class clas)
    {
        throw new NotImplementedException();
    }

    public List<Class> GetList()
    {
        var getList = _classDal.GetList();
        if (getList != null)
        {
            return getList;
        }
        return null!;
    }

    public bool Update(Class clas)
    {
        throw new NotImplementedException();
    }
}
