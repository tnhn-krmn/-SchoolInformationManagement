using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Abstract;

public interface ICafeteriaPurchaseService
{
    public List<CafeteriaPurchase> GetList();
    public bool Add(CafeteriaPurchase cafeteriaPurchase);
    public bool Delete(CafeteriaPurchase cafeteriaPurchase);
    public bool Update(CafeteriaPurchase cafeteriaPurchase);
}
