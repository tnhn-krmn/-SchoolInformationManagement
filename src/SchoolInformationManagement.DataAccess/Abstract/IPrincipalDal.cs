using SchoolInformationManagement.Core.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.DataAccess.Abstract;

public interface IPrincipalDal : IEntityRepository<Principal>
{
    public Principal getPrincipal(string userName, string password);
}
