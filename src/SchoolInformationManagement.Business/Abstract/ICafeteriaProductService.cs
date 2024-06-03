using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Abstract;

public interface ICafeteriaProductService
{
    public List<CafeteriaProduct> GetList();
    public bool Add(CafeteriaProduct cafeteriaProduct);
    public bool Delete(CafeteriaProduct cafeteriaProduct);
    public bool Update(CafeteriaProduct cafeteriaProduct);
}
