using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Entity.Entity.Product;
public class Product : _Base
{
    public string? ImageSaveId { get; set; }
    public string? Status { get; set; }
    public string? ProductId { get; set; }
    public string? ProductName { get; set; }
    public string? ProductDescription { get; set; }
    public string? BarCode { get; set; }
    public string? Country { get; set; }
    public string? BatchNumber { get; set; }
    public string? Perishable { get; set; }
    public DateTime UseBy { get; set; }
    public string? UpdatedUserId { get; set; }
    public DateTime UpdatedTimestamp { get; set; }
    public string? ProductType { get; set; }
    public string? ProcessTimeSpent { get; set; }
    public string? ProcessSkillLevel { get; set; }
    public float LaborUnitCost { get; set; }
    public string? TariffAnalysisMethod { get; set; }
    public Guid XeroSaveId { get; set; }
    public string? GroupProductSaveId { get; set; }
    public string? ProductCategory { get; set; }
    public int NoOfPiece { get; set; }
    public float Weight { get; set; }
    public string? UnitOfMeasure { get; set; }
    public float Amount { get; set; }
    public string? Ccy { get; set; }
    public string? Discriminator { get; set; }
    public Guid? SingleProduct_SaveId { get; set; }
    public int? BOMVersion { get; set; }
    public Guid? GroupVersionId { get; set; }
    public float IndirectLaborCostPercentage { get; set; }
    public float OverheadsValue { get; set; }
    public float TotalOverheads { get; set; }
    public string? OverheadsType { get; set; }
    public float StockQuantityAvailable { get; set; }
    public float StockQuantityReserved { get; set; }
    public string? ReasonForAssembly { get; set; }
    public string? AssemblyComponentStockTreatment { get; set; }
    public Guid? GenerateAssemblyProduct_SaveId { get; set; }
    public int ProductStatus { get; set; }
    public Guid BomProductSaveId { get; set; }
    public string? FreeAgentSaveId { get; set; }
    public string? PerpetualValue { get; set; }
    public string? QuickBookSaveId { get; set; }
    public string? ObtainedBy { get; set; }
    public string? BomTotalMaterialCost { get; set; }
    public string? ShopifySaveId { get; set; }
    public string? OnECommerce { get; set; }
    public string? QtyListed { get; set; }
    public string? Variants { get; set; }
    public DateTime LastOrdered { get; set; }
    public int NumberOfOrders { get; set; }
    public string? VariantId { get; set; }
    public string? Source { get; set; }
    public string? BrandMessage { get; set; }
    public string? CareInstructions { get; set; }
    public string? Benefits { get; set; }
    public string? SafetyInstructions { get; set; }
    public string? TermsConditions { get; set; }
    public bool IsProductSellable { get; set; }
    public Guid? PackagingSaveId { get; set; }
    public float PackNeedQty { get; set; }
    public string? BrandManufacture { get; set; }
    public float StockUnitPrice { get; set; }
    public float StockSellPrice { get; set; }
    public string? StockCcy { get; set; }
    public float StockReOrderTrigger { get; set; }
    public string? StockPackageKind { get; set; }
    public string? Image2SaveId { get; set; }
    public string? Image3SaveId { get; set; }
    public string? Color { get; set; }
    public bool IsVariant { get; set; }
    public bool HasVariant { get; set; }
    public int VariantsCount { get; set; }
    public Guid? VariantSaveId { get; set; }
    public float QtyOnOrder { get; set; }
    public string? LaborRate { get; set; }
    public string? WooCommerceId { get; set; }
    public DateTime? WooCommerceLastOrdered { get; set; }
    public string? WooCommerceQtyListed { get; set; }
    public string? SageOneSaveId { get; set; }
    public float StockQuantityQuarantine { get; set; }
    public float StockQuantityRejected { get; set; }
    public float StockQuantityExpired { get; set; }
    public bool IsParant { get; set; }
    public string? Grade { get; set; }
    public bool IsAdjustInAccPkg { get; set; }
    public float WorkInProgressQuantity { get; set; }
    public string? FaireId { get; set; }
}
