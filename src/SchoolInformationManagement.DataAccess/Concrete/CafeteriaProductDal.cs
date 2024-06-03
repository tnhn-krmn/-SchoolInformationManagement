using SchoolInformationManagement.Core.DataAccess.Concrete;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.DataAccess.Concrete;

public class CafeteriaProductDal : EfRepository<CafeteriaProduct, Context>, ICafeteriaProductDal
{
}
