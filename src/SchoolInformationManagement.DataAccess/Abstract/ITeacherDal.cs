using SchoolInformationManagement.Core.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.DataAccess.Abstract;

public interface ITeacherDal : IEntityRepository<Teacher>
{
}
