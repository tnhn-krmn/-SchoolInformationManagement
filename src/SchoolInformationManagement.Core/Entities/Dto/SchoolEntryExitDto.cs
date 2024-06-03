namespace SchoolInformationManagement.Core.Entities.Dto;

public class SchoolEntryExitDto
{
    public int Id { get; set; }
    public string StudentName { get; set; }
    public string StudentLastName { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime ExitDate { get; set; }
}
