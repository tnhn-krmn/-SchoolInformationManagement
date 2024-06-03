
using SchoolInformationManagement.Core.Entities;

namespace SchoolInformationManagement.Entities.Concrete;

public class Class : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
