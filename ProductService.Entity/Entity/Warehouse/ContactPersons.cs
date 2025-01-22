
using ProductService.Entity.Entity.Product;

namespace ProductService.Entity.Entity.Warehouse;
public class ContactPersons : _Base
{
    public string FullName { get; set; }
    public string Type { get; set; }
    public Guid WarehouseId { get; set; }
}
