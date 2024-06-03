using SchoolInformationManagement.Business.Abstract;
using SchoolInformationManagement.Core.Entities.Dto;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Concrete;

public class ClassAssignmentManager : IClassAssignmentService
{
    private readonly IClassAssignmentDal _classAssignmentDal;

    public ClassAssignmentManager(IClassAssignmentDal classAssignmentDal)
    {
        _classAssignmentDal = classAssignmentDal;
    }

    public bool Add(ClassAssignment classAssignment)
    {
        var assignment = _classAssignmentDal.Add(classAssignment);
        if (assignment != false)
        {
            return assignment;
        }
        return false;
    }

    public bool Delete(ClassAssignment classAssignment)
    {
        throw new NotImplementedException();
    }

    public ClassAssignmentDto GetById(int classAssignment)
    {
        var classAssignmentId = _classAssignmentDal.GetById(classAssignment);
        var classAssignmenDto = _classAssignmentDal.GetClassAssignmentId(classAssignmentId.Id);
        if (classAssignmenDto != null)
        {
            return classAssignmenDto;
        }
        return null!;
    }

    public ClassAssignmentDto GetByIdClassAssignment()
    {
        throw new NotImplementedException();
    }

    public List<ClassAssignmentDto> GetClassAssignments()
    {
        var classAssignments = _classAssignmentDal.GetClassAssignments();
        if (classAssignments != null)
        {
            return classAssignments;
        }
        return null!;
    }

    public bool Update(ClassAssignment classAssignment)
    {
        throw new NotImplementedException();
    }
}
