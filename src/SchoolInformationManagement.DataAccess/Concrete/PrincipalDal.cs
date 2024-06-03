using SchoolInformationManagement.Core.DataAccess.Concrete;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.DataAccess.Concrete;

public class PrincipalDal : EfRepository<Principal, Context>, IPrincipalDal
{
    public Principal getPrincipal(string userName, string password)
    {
        using(var context = new Context())
        {
            var principal = context.Principals
                               .FirstOrDefault(p => p.Email == userName && p.Password == password);


            return principal!;
        }
    }
}
