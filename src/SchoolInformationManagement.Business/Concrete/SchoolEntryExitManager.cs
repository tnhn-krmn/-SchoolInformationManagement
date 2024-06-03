using SchoolInformationManagement.Business.Abstract;
using SchoolInformationManagement.Core.Entities.Dto;
using SchoolInformationManagement.DataAccess.Abstract;

namespace SchoolInformationManagement.Business.Concrete;

public class SchoolEntryExitManager : ISchoolEntryExitService
{
    private readonly ISchoolEntryExitDal _schoolEntryExitDal;

    public SchoolEntryExitManager(ISchoolEntryExitDal schoolEntryExitDal)
    {
        _schoolEntryExitDal = schoolEntryExitDal;
    }

    public List<SchoolEntryExitDto> GetSchoolEntryExit()
    {
        var schoolEntryExit = _schoolEntryExitDal.GetSchoolEntryExit();
        if (schoolEntryExit != null)
        {
            return schoolEntryExit;
        }
        return null!;
    }
}
