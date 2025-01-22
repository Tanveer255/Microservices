using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact.Contact;
public class Email :_Base
{
    public int Id { get; set; }
    public string ContactEmail { get; set; }
    public string EmailType { get; set; }
    public Guid ContactId { get; set; }
}
