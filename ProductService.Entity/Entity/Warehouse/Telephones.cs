using ProductService.Entity.Entity.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Entity.Entity.Warehouse;
public class Telephones : _Base
{
    public string ContactNumber { get; set; }
    public string Extension { get; set; }
    public string Type { get; set; }
    public Guid WarehouseSaveId { get; set; }
}
