using SchoolInformationManagement.Business.Abstract;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Concrete;

public class PrincipalManager : IPrincipalService
{
    private readonly IPrincipalDal _principalDal;

    public PrincipalManager(IPrincipalDal principalDal)
    {
        _principalDal = principalDal;
    }

    public bool Add(Principal principal)
    {
        var principalEntity = _principalDal.Add(principal);
        if (principalEntity != false)
        {
            return true;
        }
        return false;
    }

    public bool Delete(int principalId)
    {
        var principal = _principalDal.Delete(new Principal { Id = principalId });
        if (principal != false)
        {
            return true;
        }
        return false;
    }

    public List<Principal> GetList()
    {
        var principalGet = _principalDal.GetList();
        if (principalGet != null)
        {
            return principalGet;
        }
        return null!;
    }

    public Principal getPrincipal(string userName, string password)
    {
        var IsPrincipal = _principalDal.getPrincipal(userName, password);
        if (IsPrincipal != null)
        {
            return IsPrincipal;
        }
        return null!;
    }

    public bool Update(Principal principal)
    {
        throw new NotImplementedException();
    }
}
