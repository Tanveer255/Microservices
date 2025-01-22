using ProductService.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.DAL.Interface
{
    /// <summary>
    /// Unit Of Work interface.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gets context property.
        /// </summary>
        public ProductServiceDbContext Context { get; }

        /// <summary>
        /// Commit.
        /// </summary>
        public void Commit();
    }
}
