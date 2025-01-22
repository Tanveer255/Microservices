using ProductService.Entity.Entity.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Entity.Entity.Warehouse;
public class Warehouse : _Base
{
    public string Name { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Town { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string PostCode { get; set; }
    public string Status { get; set; }
    public string Sections { get; set; }
    public string Aisles { get; set; }
    public string Racks { get; set; }
    public string Shelves { get; set; }
    public string Positions { get; set; }
    public string AveragePickupTime { get; set; }
    public string AverageDropofTime { get; set; }
    public string ParkingForWaiting { get; set; }
    public string OpeningTime { get; set; }
    public string ClosingTime { get; set; }
    public string DaysOpen { get; set; }
    public string VehicleSize { get; set; }
    public string Purposes { get; set; }
    public string ProcessUser { get; set; }
    public string State { get; set; }
    public string Bays { get; set; }
    public string PlaceType { get; set; }
}
