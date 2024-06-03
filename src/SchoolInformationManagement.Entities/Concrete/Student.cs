using SchoolInformationManagement.Core.Entities;

namespace SchoolInformationManagement.Entities.Concrete;

public class Student : IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public int ParentId { get; set; }
    public string BloodGroup { get; set; }
    public byte[] Photo { get; set; }
}
