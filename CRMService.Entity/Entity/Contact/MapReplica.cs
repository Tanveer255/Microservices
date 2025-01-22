using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact;
public class MapReplica : _Base
{
    public int Id { get; set; }
    public Guid IndividualSaveId { get; set; }
    public Guid OrganisationSaveId { get; set; }
    public string RoleType { get; set; }
    public int AddressId { get; set; }
}
