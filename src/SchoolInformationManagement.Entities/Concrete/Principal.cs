using SchoolInformationManagement.Core.Entities;

namespace SchoolInformationManagement.Entities.Concrete;

public class Principal : IEntity
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
