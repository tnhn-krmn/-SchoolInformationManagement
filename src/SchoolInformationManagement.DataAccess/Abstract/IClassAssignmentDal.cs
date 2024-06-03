
using SchoolInformationManagement.Core.DataAccess.Abstract;
using SchoolInformationManagement.Core.Entities.Dto;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.DataAccess.Abstract;

public interface IClassAssignmentDal : IEntityRepository<ClassAssignment>
{
    public List<ClassAssignmentDto> GetClassAssignments();
    public ClassAssignmentDto GetClassAssignmentId(int? GetByIdClassAssignments);
}
