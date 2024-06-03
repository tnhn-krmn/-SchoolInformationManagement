using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.Business.Abstract;

public interface IStudentService
{
    public List<Student> GetList();
    public bool Add(Student student);
    public bool Delete(int studentId);
    public bool Update(Student student);
}
