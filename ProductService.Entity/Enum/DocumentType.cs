using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Entity.Enum
{
    public enum DocumentType
    {
        PurchaseOrder,
        None
    }

    public enum LinkType
    {
        Sale,
        Order,
        Document,
        Unknown
    }
}
