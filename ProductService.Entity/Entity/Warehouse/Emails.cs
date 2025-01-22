using ProductService.Entity.Entity.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Entity.Entity.Warehouse;
public class Emails : _Base
{
    public string FullName { get; set; }
    public string Type { get; set; }
    public Guid WarehouseId { get; set; }
}
