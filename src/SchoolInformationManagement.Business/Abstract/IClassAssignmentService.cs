using SchoolInformationManagement.Core.Entities.Dto;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Abstract;

public interface IClassAssignmentService
{
    public List<ClassAssignmentDto> GetClassAssignments();
    public ClassAssignmentDto GetByIdClassAssignment();
    public ClassAssignmentDto GetById(int classAssignment);
    public bool Add(ClassAssignment classAssignment);
    public bool Delete(ClassAssignment classAssignment);
    public bool Update(ClassAssignment classAssignment);
}
