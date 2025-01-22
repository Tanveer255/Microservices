using ProductService.Entity.Entity.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Entity.Entity.Warehouse;
public class WarehouseSummary : _Base
{
    public string Name { get; set; }
    public string PrimaryAddress { get; set; }
    public string Country { get; set; }
    public string PhoneNumber { get; set; }
    public string Purpose { get; set; }
    public string Status { get; set; }
    public string ProcessUser { get; set; }
    public Guid WarehouseId { get; set; }
    public string City { get; set; }
    public string TotalSections { get; set; }
    public string TotalAisles { get; set; }
    public string TotalRacks { get; set; }
    public string TotalShelves { get; set; }
    public string TotalPositions { get; set; }
    public string TotalBays { get; set; }
    public string PlaceType { get; set; }
}
