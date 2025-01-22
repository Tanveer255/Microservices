using ProductService.Entity.Entity.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Entity.Entity.Warehouse;
public class Location : _Base
{
    public string WarehouseId { get; set; }
    public string Warehouse { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Status { get; set; }
    public bool IsMainLocation { get; set; }
    public string ShelfPosition { get; set; }
    public Guid ProductSaveId { get; set; }
    public string SectionZone { get; set; }
    public string Aisle { get; set; }
    public string Rack { get; set; }
    public string Position { get; set; }
    public string Purpose { get; set; }
    public string BayNo { get; set; }
    public float AvailableQty { get; set; }
    public float ReserveQty { get; set; }
    public Guid VehicleId { get; set; }
    public float QuarantineStockQty { get; set; }
    public float RejectedStockQty { get; set; }
    public float ExpiredStockQty { get; set; }
}
