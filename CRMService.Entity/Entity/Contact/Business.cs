using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact;
public  class Business :_Base
{
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public string FirstOwner { get; set; }
    public string AnnualTurnOver { get; set; }
    public string GroupClassification { get; set; }
    public int NoOfPeople { get; set; }
    public string Division { get; set; }
}
