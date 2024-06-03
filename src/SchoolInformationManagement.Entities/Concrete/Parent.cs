
using SchoolInformationManagement.Core.Entities;

namespace SchoolInformationManagement.Entities.Concrete;

public class Parent : IEntity
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int StudentId { get; set; }
    public string CreditCardInfo { get; set; }
}
