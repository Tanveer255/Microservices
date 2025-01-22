using CRMService.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.DAL.Interface
{
    /// <summary>
    /// Unit Of Work interface.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gets context property.
        /// </summary>
        public CRMServiceDbContext Context { get; }

        /// <summary>
        /// Commit.
        /// </summary>
        public void Commit();
    }
}
