using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact;
public class History : _Base
{
    public string User { get; set; }
    public string Changes { get; set; }
    public string Comment { get; set; }
    public string IpAddress { get; set; }
    public string ContactType { get; set; }
    public Guid ContactSaveId { get; set; }
}
