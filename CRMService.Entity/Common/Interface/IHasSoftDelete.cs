using System;
using System.Collections.Generic;
using System.Text;

namespace CRMService.Entity.Common.Interface
{
    public interface IHasSoftDelete
    {
        public bool IsDeleted { get; set; }
        DateTime UpdatedTimeStamp { get; set; }
    }
}
