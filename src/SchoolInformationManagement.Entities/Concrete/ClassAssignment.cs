using SchoolInformationManagement.Core.Entities;

namespace SchoolInformationManagement.Entities.Concrete;

public class ClassAssignment : IEntity
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int ClassId { get; set; }
    public int TeacherId { get; set; }
}
