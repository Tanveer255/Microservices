using AuthService.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.DAL.Interface
{
    /// <summary>
    /// Unit Of Work interface.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gets context property.
        /// </summary>
        public AuthServiceDbContext Context { get; }

        /// <summary>
        /// Commit.
        /// </summary>
        public void Commit();
    }
}
