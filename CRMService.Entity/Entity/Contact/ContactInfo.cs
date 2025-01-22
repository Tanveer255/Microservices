using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact;
public class ContactInfo :_Base
{
    public string UserId { get; set; }
    public string ContactSource { get; set; }
    public string UserName { get; set; }
    public string Status { get; set; }
    public string Image { get; set; }
    public string CreditRating { get; set; }
    public bool IsClient { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public string Name { get; set; }
    public string Discriminator { get; set; }
    public string XeroShortCode { get; set; }
    public string PreferredTradeCurrency { get; set; }
    public string Grade { get; set; }
    public string EdgeTenantId { get; set; }
    public string EdgeCompanyName { get; set; }
    public string ContactSignature { get; set; }
    public string RpsStatus { get; set; }
    public DateTime RpsUpdatedDate { get; set; }
    public string WooCommerceId { get; set; }
    public float MaxCreditLimit { get; set; }
    public string CreditCurrency { get; set; }
    public int MinExpiryDays { get; set; }
    public int DueTimeTill { get; set; }
    public DateTime KnownSince { get; set; }
    public DateTime LastActivity { get; set; }
    public string Categories { get; set; }
}
