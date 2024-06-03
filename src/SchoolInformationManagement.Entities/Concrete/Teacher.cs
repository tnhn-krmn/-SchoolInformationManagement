
using SchoolInformationManagement.Core.Entities;

namespace SchoolInformationManagement.Entities.Concrete;
public class Teacher : IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Branch { get; set; }
}
