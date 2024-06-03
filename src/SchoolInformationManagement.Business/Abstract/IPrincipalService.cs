using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Abstract;

public interface IPrincipalService
{
    public List<Principal> GetList();
    public bool Add(Principal principal);
    public bool Delete(int principalId);
    public bool Update(Principal principal);
    public Principal getPrincipal(string userName, string password);
}
