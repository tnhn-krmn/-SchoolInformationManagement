
using SchoolInformationManagement.Core.Entities;

namespace SchoolInformationManagement.Entities.Concrete;

public class CafeteriaProduct : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
