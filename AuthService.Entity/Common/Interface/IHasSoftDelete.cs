using System;
using System.Collections.Generic;
using System.Text;

namespace AuthService.Entity.Common.Interface
{
    public interface IHasSoftDelete
    {
        public bool IsDeleted { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
