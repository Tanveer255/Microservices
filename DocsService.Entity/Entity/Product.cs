using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DocsService.Entity.Entity;

[Serializable]
[Table("Product")]
[DataContract(IsReference = true)]
public class Product
{
    [Key]
    [DataMember]
    public Guid SaveId { get; set; }

    [DataMember]
    [StringLength(50)]
    public string TenantId { get; set; }

    [DataMember]
    [StringLength(100)]
    public string ProductName { get; set; }

    [DataMember]
    [StringLength(2500)]
    public string ProductDescription { get; set; }

    [DataMember]
    [StringLength(50)]
    public string BarCode { get; set; }

    [DataMember]
    public DateTime UseBy { get; set; }

    [DataMember]
    public DateTime LastOrdered { get; set; }

    [DataMember]
    public double StockQuantityAvailable { get; set; }

    [DataMember]
    public double StockUnitPrice { get; set; }

    [DataMember]
    public double StockSellPrice { get; set; }

    [DataMember]
    public string StockCcy { get; set; }

    [DataMember]
    public string OnECommerce { get; set; }

    [DataMember]
    public string QtyListed { get; set; }

    [DataMember]
    public string Status { get; set; } = "New";

    [DataMember]
    public ProductStatus ProductStatus { get; set; }

    // Constructor
    public Product()
    {
        // Initialize any collections or defaults if needed
    }
}

public enum ProductStatus
{
    New,
    Active,
    Inactive,
    Discontinued
}
