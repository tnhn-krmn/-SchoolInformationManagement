using SchoolInformationManagement.Core.DataAccess.Concrete;
using SchoolInformationManagement.Core.Entities.Dto;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.DataAccess.Concrete;

public class SchoolEntryExitDal : EfRepository<SchoolEntryExit, Context>, ISchoolEntryExitDal
{
    public List<SchoolEntryExitDto> GetSchoolEntryExit()
    {
        using(var context = new Context())
        {
            var studentEntryExits = from student in context.Students
                                    join entryExit in context.SchoolEntryExits on student.Id equals entryExit.StudentId
                                    select new SchoolEntryExitDto
                                    {
                                        Id = entryExit.Id,
                                        StudentName = student.FirstName,
                                        StudentLastName = student.LastName,
                                        EntryDate = entryExit.EntryDate,
                                        ExitDate = entryExit.ExitDate
                                    };


            return studentEntryExits.ToList();
        }
    }
}
