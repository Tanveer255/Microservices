using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthService.Entity.Entity;
/// <summary>
/// edge_auth_db.user
/// </summary>
[Table("User")]
public class User : _Base
{
    public string UserId { get; set; }
    public string TenantId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    //public DateTime CreatedTimestamp { get; set; } = DateTime.UtcNow;
    public string PhoneNumber { get; set; }
    public string Status { get; set; }
    public string UserType { get; set; }
    //public DateTime UpdatedTimestamp { get; set; } = DateTime.UtcNow;
    public string EmployeeId { get; set; }
    public string JobTitle { get; set; }
    public string JobRole { get; set; }
    public bool IsNewSignup { get; set; } = true;
    public string MembershipId { get; set; }
    public string MembershipName { get; set; }
    public string MembershipEmail { get; set; }
    public string ChamberEmail { get; set; }
    public bool IsAllowChamber { get; set; } = false;
    public bool IsLeaveChamber { get; set; } = false;
    public bool IsSelfLoginEnable { get; set; } = false;
    public bool IsAllowInform { get; set; } = false;
    public bool IsNotAllowInform { get; set; } = false;
    public string CustomerId { get; set; }
    public string SubscriptionId { get; set; }
    public string PaymentId { get; set; }
    public string PlanDescription { get; set; }
    public DateTime? SubscriptionStartDate { get; set; }
    public DateTime? SubscriptionEndDate { get; set; }
    public bool? IsAllowFollowUp { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string SubscriptionPeriod { get; set; }
    public double? PaymentAmount { get; set; }
    public string PaymentCurrency { get; set; }
    public string PaymentStatus { get; set; }
    public bool IsSuperUser { get; set; } = false;
}

