using SchoolInformationManagement.Entities.Concrete;


namespace SchoolInformationManagement.Business.Abstract;

public interface ITeacherService
{
    public List<Teacher> GetList();
    public Teacher GetById(int teacherId);
    public bool Add(Teacher teacher);
    public bool Delete(int teacherId);
    public bool Update(Teacher teacher);
}
