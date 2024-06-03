using SchoolInformationManagement.Core.DataAccess.Abstract;
using SchoolInformationManagement.Core.Entities.Dto;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.DataAccess.Abstract;

public interface ISchoolEntryExitDal : IEntityRepository<SchoolEntryExit>
{
    public List<SchoolEntryExitDto> GetSchoolEntryExit();
}
