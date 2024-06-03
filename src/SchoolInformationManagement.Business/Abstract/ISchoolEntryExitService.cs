using SchoolInformationManagement.Core.Entities.Dto;

namespace SchoolInformationManagement.Business.Abstract;

public interface ISchoolEntryExitService
{
    public List<SchoolEntryExitDto> GetSchoolEntryExit();
}