using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductService.Entity.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountCode",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTimeStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XeroSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountCode", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "AdvanceSearch",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SearchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SearchType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perishable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReorderLevel = table.Column<int>(type: "int", nullable: true),
                    ReorderQty = table.Column<int>(type: "int", nullable: true),
                    GeneralItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemOperator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemValue = table.Column<float>(type: "real", nullable: true),
                    CommCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hazard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularityControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportLicence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvanceSearch", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "AlternativeCurrency",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: true),
                    SellPrice = table.Column<float>(type: "real", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlternativeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlternativeCurrency", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Batchs",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOMVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinishProductTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyAvailable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyReserved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockImpact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActionState = table.Column<int>(type: "int", nullable: false),
                    ExpectedStartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseBuildIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsWIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WIPStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackProgress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyCompleted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseFinished = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseAisle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseShelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseRack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCancelled = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForCancellation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReinstate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompleteQtyTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancellationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActualStartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedFinishDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActualFinishDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsStarted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseBuildInSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseFinishedSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseBay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgressStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyQuarantine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyRejected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyExpired = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectJNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommercialInvoiceSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImpactBOMProductIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batchs", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "BillOfMaterial",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: true),
                    SellPrice = table.Column<float>(type: "real", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlternativeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillOfMaterial", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "BomComposition",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: true),
                    SellPrice = table.Column<float>(type: "real", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlternativeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternativeSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BomComposition", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "BOMVersionHistory",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionNo = table.Column<int>(type: "int", nullable: false),
                    ProcessUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BOMProduct_SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SingleProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOMVersionHistory", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "ClassificationForBoMs",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularityControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SicGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SicClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrigion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportLicence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportControlRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportLicenceCountries = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificationForBoMs", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularityControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SicGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SicClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOrigion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportLicence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportControlRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportLicenceCountries = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcedureCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomProcedureCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSubCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductItemType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductListOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsListed = table.Column<bool>(type: "bit", nullable: false),
                    HtsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomDuty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesTax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportCountries = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferentialTreatment = table.Column<bool>(type: "bit", nullable: false),
                    IsControlsSubstances = table.Column<bool>(type: "bit", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "CompletedPart",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCompleted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartCompleted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedPart", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "ContactPersons",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPersons", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "DataFile",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecificationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhenAttached = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfPages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataFile", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentOnOrderQtyTag",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnOrderQty = table.Column<double>(type: "float", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeliveryDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentOnOrderQtyTag", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentReservedQtyTag",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservedQty = table.Column<double>(type: "float", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warehouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelfPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aisle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnOrderQty = table.Column<double>(type: "float", nullable: false),
                    DeliveryDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentReservedQtyTag", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catagory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicalSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRate",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManuallyExchangeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsAllDay = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRate", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "GenerateAssemblyProduct",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockQuantityAvailable = table.Column<int>(type: "int", nullable: false),
                    StockQuantityReserved = table.Column<int>(type: "int", nullable: false),
                    ReasonForAssembly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssemblyComponentStockTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerateAssemblyProduct", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "HazardGoodsClassification",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryHazardClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmsFireNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubsidiaryHazardClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmsSpillageNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MfagCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackaginGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueOfSpecialServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitOfSpecialServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAccessable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HazardShippingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackingInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LtdQtyMax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassengerAirPackingInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassengerAirMax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoAirPackingInstrution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoAirMax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialProvision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardGoodsClassification", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Changes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "ImpactedComponents",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BatchSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BOMSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aisle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickedAvlQty = table.Column<double>(type: "float", nullable: false),
                    PickedResQty = table.Column<double>(type: "float", nullable: false),
                    IsPicked = table.Column<bool>(type: "bit", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImpactType = table.Column<int>(type: "int", nullable: false),
                    PickedQty = table.Column<double>(type: "float", nullable: false),
                    BatchTrackigSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImpactedComponents", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockIn = table.Column<float>(type: "real", nullable: false),
                    StockOut = table.Column<float>(type: "real", nullable: false),
                    StockBalance = table.Column<float>(type: "real", nullable: false),
                    UpdatedTimestamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalReserved = table.Column<float>(type: "real", nullable: false),
                    ReasonForStockOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhoAdjustedStock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdjustedStockLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeductFromAssembly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForStockIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForStockReturned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrevReservedQuantity = table.Column<float>(type: "real", nullable: false),
                    ReservQtyVeriation = table.Column<float>(type: "real", nullable: false),
                    PrevAvailableQuantity = table.Column<float>(type: "real", nullable: false),
                    AvailableQtyVeriation = table.Column<float>(type: "real", nullable: false),
                    WarehouseSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseBays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReinstated = table.Column<bool>(type: "bit", nullable: false),
                    UpdateTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleSections = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalQuarantine = table.Column<float>(type: "real", nullable: false),
                    TotalRejected = table.Column<float>(type: "real", nullable: false),
                    TotalExpired = table.Column<float>(type: "real", nullable: false),
                    TotalworkInProgressQuantity = table.Column<float>(type: "real", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WarehouseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warehouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMainLocation = table.Column<bool>(type: "bit", nullable: false),
                    ShelfPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aisle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BayNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableQty = table.Column<float>(type: "real", nullable: false),
                    ReserveQty = table.Column<float>(type: "real", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuarantineStockQty = table.Column<float>(type: "real", nullable: false),
                    RejectedStockQty = table.Column<float>(type: "real", nullable: false),
                    ExpiredStockQty = table.Column<float>(type: "real", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturingCompletedDetail",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BatchSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectJNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeOrBuyerSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseDocumentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleDocumentSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleDocumentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchIdOrWorkOrderNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManufacturingSerialBatchSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturingCompletedDetail", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderQty = table.Column<float>(type: "real", nullable: false),
                    ReceivedQty = table.Column<float>(type: "real", nullable: false),
                    OrderSentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderAmount = table.Column<float>(type: "real", nullable: false),
                    Ccy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuoteCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "PackageSize",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SKUNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarcodeX64 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QRCodeX64 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QRCodeURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageSize", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "PackagingDetails",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackagingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimarySizeQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PPUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryLength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryWidth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryCubicVolume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryGrossWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryNetWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PPInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPrimnaryMaterialAddedToBoM = table.Column<bool>(type: "bit", nullable: false),
                    IsSecondaryPackagingSameAsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    UnitsInPack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSecondarySizingSameAsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    SecondarySizeQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryLength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryWidth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryCubicVolume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryGrossWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryNetWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTransportPackagingSameAsSecondary = table.Column<bool>(type: "bit", nullable: false),
                    TPInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PalletQtyUnits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PalletQtyPacks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PalletStackHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PalletWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container20Qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container40Qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container40HQQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container45HQQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxStackHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreightClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NMFC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingDetails", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "PackagingProducts",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackagingSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackNeedQty = table.Column<float>(type: "real", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingProducts", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
                    Ccy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxRate = table.Column<float>(type: "real", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CostTax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellTax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostSaleAccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellSaleAccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalPrice = table.Column<float>(type: "real", nullable: false),
                    PrevUnitPrice = table.Column<float>(type: "real", nullable: false),
                    PrevSellPrice = table.Column<float>(type: "real", nullable: false),
                    UnitPriceVeriation = table.Column<float>(type: "real", nullable: false),
                    SellPriceVeriation = table.Column<float>(type: "real", nullable: false),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceUpdatedFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopifySellPrice = table.Column<float>(type: "real", nullable: false),
                    AmazonSellPrice = table.Column<float>(type: "real", nullable: false),
                    EtsySellPrice = table.Column<float>(type: "real", nullable: false),
                    AliBabaSellPrice = table.Column<float>(type: "real", nullable: false),
                    EbaySellPrice = table.Column<float>(type: "real", nullable: false),
                    WooCommerceSellPrice = table.Column<float>(type: "real", nullable: false),
                    RecommendedRetailPrice = table.Column<float>(type: "real", nullable: false),
                    ListPrice = table.Column<float>(type: "real", nullable: false),
                    CostPriceDefaultCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellPriceDefaultCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaireSellPrice = table.Column<float>(type: "real", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perishable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessTimeSpent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessSkillLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LaborUnitCost = table.Column<float>(type: "real", nullable: false),
                    TariffAnalysisMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XeroSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupProductSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfPiece = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Ccy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SingleProduct_SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BOMVersion = table.Column<int>(type: "int", nullable: true),
                    GroupVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IndirectLaborCostPercentage = table.Column<float>(type: "real", nullable: false),
                    OverheadsValue = table.Column<float>(type: "real", nullable: false),
                    TotalOverheads = table.Column<float>(type: "real", nullable: false),
                    OverheadsType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockQuantityAvailable = table.Column<float>(type: "real", nullable: false),
                    StockQuantityReserved = table.Column<float>(type: "real", nullable: false),
                    ReasonForAssembly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssemblyComponentStockTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenerateAssemblyProduct_SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductStatus = table.Column<int>(type: "int", nullable: false),
                    BomProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FreeAgentSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerpetualValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuickBookSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObtainedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BomTotalMaterialCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopifySaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnECommerce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyListed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Variants = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastOrdered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfOrders = table.Column<int>(type: "int", nullable: false),
                    VariantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CareInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SafetyInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermsConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsProductSellable = table.Column<bool>(type: "bit", nullable: false),
                    PackagingSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PackNeedQty = table.Column<float>(type: "real", nullable: false),
                    BrandManufacture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockUnitPrice = table.Column<float>(type: "real", nullable: false),
                    StockSellPrice = table.Column<float>(type: "real", nullable: false),
                    StockCcy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockReOrderTrigger = table.Column<float>(type: "real", nullable: false),
                    StockPackageKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2SaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3SaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVariant = table.Column<bool>(type: "bit", nullable: false),
                    HasVariant = table.Column<bool>(type: "bit", nullable: false),
                    VariantsCount = table.Column<int>(type: "int", nullable: false),
                    VariantSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QtyOnOrder = table.Column<float>(type: "real", nullable: false),
                    LaborRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WooCommerceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WooCommerceLastOrdered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WooCommerceQtyListed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SageOneSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockQuantityQuarantine = table.Column<float>(type: "real", nullable: false),
                    StockQuantityRejected = table.Column<float>(type: "real", nullable: false),
                    StockQuantityExpired = table.Column<float>(type: "real", nullable: false),
                    IsParant = table.Column<bool>(type: "bit", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdjustInAccPkg = table.Column<bool>(type: "bit", nullable: false),
                    WorkInProgressQuantity = table.Column<float>(type: "real", nullable: false),
                    FaireId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "ProductLabel",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SKUNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarcodeX64 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QRCodeX64 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QRCodeURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLabel", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "ProductSummary",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sellable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perishable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockQuantity = table.Column<float>(type: "real", nullable: false),
                    QtyOrdered = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfPackages = table.Column<int>(type: "int", nullable: false),
                    GrossWeight = table.Column<float>(type: "real", nullable: false),
                    NetWeight = table.Column<float>(type: "real", nullable: false),
                    CubicVolume = table.Column<float>(type: "real", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOMCount = table.Column<int>(type: "int", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HazardClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PkgGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxRate = table.Column<float>(type: "real", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrefTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hazard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularityControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportLicence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReorderTrigger = table.Column<float>(type: "real", nullable: false),
                    ReorderQty = table.Column<float>(type: "real", nullable: false),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupProductSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProccessTimeSpent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProccessSkillLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Depth = table.Column<float>(type: "real", nullable: false),
                    SizeQuantity = table.Column<float>(type: "real", nullable: false),
                    LaborUnitCost = table.Column<float>(type: "real", nullable: false),
                    XeroSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginalPrice = table.Column<float>(type: "real", nullable: false),
                    CompositionNo = table.Column<int>(type: "int", nullable: false),
                    BOMVersion = table.Column<int>(type: "int", nullable: false),
                    ReservedStockQty = table.Column<float>(type: "real", nullable: false),
                    GroupVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueOfSpecialServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitOfSpecialServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAccessable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HazardShippingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackingInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LtdQtyMax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassengerAirPackingInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassengerAirMax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoAirPackingInstrution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoAirMax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialProvision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackingGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubsidiaryHazardClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreeAgentSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomProcedureCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuickBookSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemCount = table.Column<int>(type: "int", nullable: false),
                    Misc1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Misc2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObtainedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerpetualValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Misc3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Misc4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Misc5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopifySaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyListed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnECommerce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Variants = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopifySellPrice = table.Column<float>(type: "real", nullable: false),
                    AmazonSellPrice = table.Column<float>(type: "real", nullable: false),
                    EtsySellPrice = table.Column<float>(type: "real", nullable: false),
                    AliBabaSellPrice = table.Column<float>(type: "real", nullable: false),
                    EbaySellPrice = table.Column<float>(type: "real", nullable: false),
                    WooCommerceSellPrice = table.Column<float>(type: "real", nullable: false),
                    LastOrdered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfOrders = table.Column<int>(type: "int", nullable: false),
                    RecommendedRetailPrice = table.Column<float>(type: "real", nullable: false),
                    VariantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsProductSellable = table.Column<bool>(type: "bit", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVariant = table.Column<bool>(type: "bit", nullable: false),
                    HasVariant = table.Column<bool>(type: "bit", nullable: false),
                    VariantsCount = table.Column<int>(type: "int", nullable: false),
                    LaborRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WooCommerceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WooCommerceLastOrdered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WooCommerceQtyListed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListPrice = table.Column<float>(type: "real", nullable: false),
                    SkuNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SageOneSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsControlsSubstances = table.Column<bool>(type: "bit", nullable: false),
                    SerialNoTracking = table.Column<bool>(type: "bit", nullable: false),
                    BatchTracking = table.Column<bool>(type: "bit", nullable: false),
                    PerishableTracking = table.Column<bool>(type: "bit", nullable: false),
                    QuarantineStockQty = table.Column<float>(type: "real", nullable: false),
                    RejectedStockQty = table.Column<float>(type: "real", nullable: false),
                    ExpiredStockQty = table.Column<float>(type: "real", nullable: false),
                    IsParant = table.Column<bool>(type: "bit", nullable: false),
                    CostPrice = table.Column<float>(type: "real", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostPriceDefaultCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellPriceDefaultCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkInProgressQuantity = table.Column<float>(type: "real", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSummary", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "ReOrderSetting",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReorderQty = table.Column<float>(type: "real", nullable: false),
                    QtyToReorder = table.Column<float>(type: "real", nullable: false),
                    QtyOnReorder = table.Column<float>(type: "real", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReOrderSetting", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Reporting",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleOrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductAction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentSaveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuotedQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoicedQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidTillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StockDeducted = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableQuantity = table.Column<float>(type: "real", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporting", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "ReservedStockOrders",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Consignee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETADelivery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservedQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveredQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BatchSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsigneeSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedStockOrders", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "RFQuote",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredQty = table.Column<float>(type: "real", nullable: false),
                    QuotedQty = table.Column<float>(type: "real", nullable: false),
                    RFQSentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuoteAmount = table.Column<float>(type: "real", nullable: false),
                    Ccy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOrderPlaced = table.Column<bool>(type: "bit", nullable: false),
                    QuoteCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RFQAdditionalMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RFQuote", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsShowGraph = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMainSupplier = table.Column<bool>(type: "bit", nullable: false),
                    SupplierType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EdgeTenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EdgeCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedTimeOfArrival = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActualTimeOfArrival = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreferredTradeCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaxRate = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxRateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanApplyToRevenue = table.Column<bool>(type: "bit", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Tracking",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SerialTracking = table.Column<bool>(type: "bit", nullable: false),
                    BatchTracking = table.Column<bool>(type: "bit", nullable: false),
                    PerishableTracking = table.Column<bool>(type: "bit", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracking", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "TrackingDetail",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostPrice = table.Column<float>(type: "real", nullable: false),
                    Misc1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Misc2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellPrice = table.Column<float>(type: "real", nullable: false),
                    CostCcy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellCcy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDocumentSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseDocumentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleDocumentSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleDocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleDocumentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchViewAvlQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchViewResQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchViewQAQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchViewRejQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BatchViewExpQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReInStated = table.Column<bool>(type: "bit", nullable: false),
                    ManufacturingBatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PickedResQty = table.Column<float>(type: "real", nullable: false),
                    PickedAvlQty = table.Column<float>(type: "real", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackingDetail", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrossWeightClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Refrigerated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearReg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextServiceDue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoadTaxDue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceDue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryLoadUnload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxPayLoadKg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxPayLoadLb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSections = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfSections = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRoofLoad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTakePallet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxPalletSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxPalletNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "VehiclePickedLists",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReserveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReserveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickedAvailableQty = table.Column<float>(type: "real", nullable: false),
                    PickedReserveQty = table.Column<float>(type: "real", nullable: false),
                    IsPicked = table.Column<bool>(type: "bit", nullable: false),
                    PickedWarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PickedVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShelfPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aisle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovedWarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovedVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovedBayNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePickedLists", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleStockLists",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinAvailable = table.Column<float>(type: "real", nullable: false),
                    MinReserve = table.Column<float>(type: "real", nullable: false),
                    CurrentAvailable = table.Column<float>(type: "real", nullable: false),
                    CurrentReserve = table.Column<float>(type: "real", nullable: false),
                    UnitPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleSaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleStockLists", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sections = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aisles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Racks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shelves = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Positions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AveragePickupTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageDropofTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkingForWaiting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaysOpen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purposes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.SaveId);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseSummary",
                columns: table => new
                {
                    SaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSections = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAisles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalRacks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalShelves = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPositions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalBays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseSummary", x => x.SaveId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountCode");

            migrationBuilder.DropTable(
                name: "AdvanceSearch");

            migrationBuilder.DropTable(
                name: "AlternativeCurrency");

            migrationBuilder.DropTable(
                name: "Batchs");

            migrationBuilder.DropTable(
                name: "BillOfMaterial");

            migrationBuilder.DropTable(
                name: "BomComposition");

            migrationBuilder.DropTable(
                name: "BOMVersionHistory");

            migrationBuilder.DropTable(
                name: "ClassificationForBoMs");

            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropTable(
                name: "CompletedPart");

            migrationBuilder.DropTable(
                name: "ContactPersons");

            migrationBuilder.DropTable(
                name: "DataFile");

            migrationBuilder.DropTable(
                name: "DocumentOnOrderQtyTag");

            migrationBuilder.DropTable(
                name: "DocumentReservedQtyTag");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "ExchangeRate");

            migrationBuilder.DropTable(
                name: "GenerateAssemblyProduct");

            migrationBuilder.DropTable(
                name: "HazardGoodsClassification");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "ImpactedComponents");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "ManufacturingCompletedDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PackageSize");

            migrationBuilder.DropTable(
                name: "PackagingDetails");

            migrationBuilder.DropTable(
                name: "PackagingProducts");

            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductLabel");

            migrationBuilder.DropTable(
                name: "ProductSummary");

            migrationBuilder.DropTable(
                name: "ReOrderSetting");

            migrationBuilder.DropTable(
                name: "Reporting");

            migrationBuilder.DropTable(
                name: "ReservedStockOrders");

            migrationBuilder.DropTable(
                name: "RFQuote");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Tracking");

            migrationBuilder.DropTable(
                name: "TrackingDetail");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "VehiclePickedLists");

            migrationBuilder.DropTable(
                name: "VehicleStockLists");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "WarehouseSummary");
        }
    }
}
