using Microsoft.EntityFrameworkCore;
using SchoolInformationManagement.Core.DataAccess.Concrete;
using SchoolInformationManagement.Core.Entities.Dto;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.DataAccess.Concrete;

public class ClassAssignmentDal : EfRepository<ClassAssignment, Context>, IClassAssignmentDal
{
    public List<ClassAssignmentDto> GetClassAssignments()
    {
        using(var context  = new Context())
        {
            var result = from classAssignment in context.ClassAssignments
                         join teacher in context.Teachers on classAssignment.TeacherId equals teacher.Id
                         join clas in context.Classes on classAssignment.ClassId equals clas.Id
                         join student in context.Students on classAssignment.StudentId equals student.Id
                         select new ClassAssignmentDto
                         {
                             Id = classAssignment.Id,
                             ClassName = clas.Name,
                             TeacherName = teacher.FirstName + " " + teacher.LastName,
                             StudentName = student.FirstName + " " + student.LastName,
                         };

            return result.ToList();
        }
    }
    public ClassAssignmentDto GetClassAssignmentId(int? GetByIdClassAssignments)
    {
        using (var context = new Context())
        {
            var result = from classAssignment in context.ClassAssignments
                         join teacher in context.Teachers on classAssignment.TeacherId equals teacher.Id
                         join clas in context.Classes on classAssignment.ClassId equals clas.Id
                         join student in context.Students on classAssignment.StudentId equals student.Id
                         where classAssignment.ClassId == GetByIdClassAssignments
                         select new ClassAssignmentDto
                         {
                             Id = classAssignment.Id,
                             ClassName = clas.Name,
                             TeacherName = teacher.FirstName + " " + teacher.LastName,
                             StudentName = student.FirstName + " " + student.LastName,
                         };

            return result.FirstOrDefault();
        }
    }
}
