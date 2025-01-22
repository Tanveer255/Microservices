using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact;
public class Phone
{
    public int Id { get; set; }
    public string PhoneNo { get; set; }
    public string PhoneType { get; set; }
    public Guid ContactId { get; set; }
    public string PhoneExt { get; set; }
}
