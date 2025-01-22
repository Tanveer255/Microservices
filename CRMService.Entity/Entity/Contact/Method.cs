using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact;
public class Method :_Base
{
    public Guid ContactMethodId { get; set; }
    public string LinkedIn { get; set; }
    public string Twitter { get; set; }
    public string FaceBook { get; set; }
}
