

using SchoolInformationManagement.Core.Entities;

namespace SchoolInformationManagement.Entities.Concrete;

public class CafeteriaPurchase : IEntity
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public string ProductName { get; set; }
    public int ProductQuantity { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime PurchaseDate { get; set; }
}
