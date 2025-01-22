using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductService.Entity.Enum
{
    public enum ProductStatus
    {
        Draft,
        Created,
        InStock,
        Suspended,
        OutOfStock,
        ReorderMe,
        Deleted,
        CreatedReOrdered,
        CreatedOnOrder,
        InStockOnOrder,
        SuspendedReOrdered,
        SuspendedOnOrder,
        OutOfStockReOrdered,
        OutOfStockOnOrder,
        Unknown,
        New,
        OnOrder,
        ATACarnet
    }


}
