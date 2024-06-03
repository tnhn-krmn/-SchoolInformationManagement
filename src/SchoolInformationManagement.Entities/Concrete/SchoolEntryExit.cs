
using SchoolInformationManagement.Core.Entities;
namespace SchoolInformationManagement.Entities.Concrete;

public class SchoolEntryExit : IEntity
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime ExitDate { get; set; }
}
