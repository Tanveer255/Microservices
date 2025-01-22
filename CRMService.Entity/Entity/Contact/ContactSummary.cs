using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact;
public class ContactSummary : _Base
{
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    public string Town { get; set; }
    public string City { get; set; }
    public string PersonName { get; set; }
    public string CompanyName { get; set; }
    public string SageOneId { get; set; }
    public string XeroId { get; set; }
    public string FreeAgentId { get; set; }
    public string CreditRating { get; set; }
    public string UpdatedBy { get; set; }
    public int TotalRecords { get; set; }
    public string ContactType { get; set; }
    public string Status { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string PostalCode { get; set; }
    public string PhoneNo { get; set; }
    public string Email { get; set; }
    public string Web { get; set; }
    public int CreatedRecords { get; set; }
    public int ActiveRecords { get; set; }
    public int DeletedRecords { get; set; }
    public int SuspendedRecords { get; set; }
    public int InActiveRecords { get; set; }
    public int TotalPersons { get; set; }
    public int TotalOrganisations { get; set; }
    public string OrganisationId { get; set; }
    public string FilterType { get; set; }
    public bool Main { get; set; }
    public string Name { get; set; }
    public string BioNote { get; set; }
    public string ContactSource { get; set; }
    public string IndustrialGroupClass { get; set; }
    public int TotalLogisticFirm { get; set; }
    public int TotalSupplier { get; set; }
    public int TotalPhone { get; set; }
    public int TotalEmail { get; set; }
    public int TotalPost { get; set; }
    public int TotalEmailPhone { get; set; }
    public int TotalEmailPhonePost { get; set; }
    public int TotalUK { get; set; }
    public int TotalUS { get; set; }
    public int TotalBRICS { get; set; }
    public int TotalRest { get; set; }
    public int TotalEU { get; set; }
    public string State { get; set; }
    public string Title { get; set; }
    public string XeroShortCode { get; set; }
    public string PhoneExt { get; set; }
    public string AuthorityToBuy { get; set; }
    public string MaritalStatus { get; set; }
    public string MarketingMethod { get; set; }
    public string GiveDiscounts { get; set; }
    public string ContactEvery { get; set; }
    public float PaymentTerms { get; set; }
    public float ExpectedDiscount { get; set; }
    public float ExpectedCommission { get; set; }
    public float AgePersonOrBusiness { get; set; }
    public float AnnualTurnover { get; set; }
    public float NoOfPeople { get; set; }
    public float UnsetteledInvoiceCount { get; set; }
    public string MarketingFrom { get; set; }
    public string OpenIn { get; set; }
    public string ClosedAfter { get; set; }
    public string Period { get; set; }
    public string QuickBookId { get; set; }
    public string PreferredTradeCurrency { get; set; }
    public int Funnel { get; set; }
    public string CustomerAccNo { get; set; }
    public string VatNo { get; set; }
    public string EdgeTenantId { get; set; }
    public string EdgeCompanyName { get; set; }
    public string EoriNumber { get; set; }
    public string CarrierAccountNumber { get; set; }
    public string ShopifyId { get; set; }
    public string OwingCcy { get; set; }
    public string RpsStatus { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime RpsUpdatedDate { get; set; }
    public string NotifyBirthday { get; set; }
    public string WooCommerceId { get; set; }
    public float MaxCreditLimit { get; set; }
    public string CreditCurrency { get; set; }
    public int MinExpiryDays { get; set; }
    public decimal NormalLeadTime { get; set; }
    public decimal ActualLeadTime { get; set; }
    public int DueTimeTill { get; set; }
    public string PaymentTermsvalue { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentMethodValue { get; set; }
    public string QuickBookSupplierId { get; set; }
    public string FaireId { get; set; }
}
