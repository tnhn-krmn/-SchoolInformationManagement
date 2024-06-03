using SchoolInformationManagement.Business.Abstract;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInformationManagement.Business.Concrete;

public class StudentManager : IStudentService
{
    private readonly IStudentDal _studentDal;

    public StudentManager(IStudentDal studentDal)
    {
        _studentDal = studentDal;
    }

    public bool Add(Student student)
    {
        var studentAdd = _studentDal.Add(student);
        if (studentAdd != false)
        {
            return true;
        }
        return false;
    }

    public bool Delete(int studentId)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetList()
    {
        var getStudents = _studentDal.GetList();
        if (getStudents != null)
        {
            return getStudents;
        }
        return null!;
    }

    public bool Update(Student student)
    {
        throw new NotImplementedException();
    }
}
