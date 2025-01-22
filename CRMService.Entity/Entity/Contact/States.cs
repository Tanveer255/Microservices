using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact;
public class States : _Base
{
    public string ContactStatus { get; set; }
    public string Action { get; set; }
    public string ProcessUser { get; set; }
    public string Comments { get; set; }
    public Guid ContactSaveId { get; set; }
}
