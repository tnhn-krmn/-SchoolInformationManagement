using SchoolInformationManagement.Business.Abstract;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;


namespace SchoolInformationManagement.Business.Concrete;

public class TeacherManager : ITeacherService
{
    private readonly ITeacherDal _teacherDal;

    public TeacherManager(ITeacherDal teacherDal)
    {
        _teacherDal = teacherDal;
    }

    public bool Add(Teacher teacher)
    {
        var teacherEntity = _teacherDal.Add(teacher);
        if (teacherEntity != true)
        {
            return false;
        }
        return true;
    }

    public bool Delete(int teacherId)
    {
        var teacher = _teacherDal.Delete(new Teacher { Id = teacherId });
        if (teacher != false)
        {
            return true;
        }
        return false;
    }

    public List<Teacher> GetList()
    {
        var teachers = _teacherDal.GetList();
        if (teachers != null)
        {
            return teachers;
        }
        return null!;
    }

    public Teacher GetById(int teacherId)
    {
        var teachers = _teacherDal.GetById(teacherId);
        if (teachers != null)
        {
            return teachers;
        }
        return null!;
    }

    public bool Update(Teacher teacher)
    {
        return false;
    }
}
