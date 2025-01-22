using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Entity.Entity.Product;
[Table("DataFile")]
public class DataFile : _Base
{
    public string SpecificationType { get; set; }
    public string FileName { get; set; }
    public string DocType { get; set; }
    public string WhenAttached { get; set; }
    public string NoOfPages { get; set; }
    public string FileData { get; set; }
    public Guid ProductSaveId { get; set; }
    public string FilePath { get; set; }
}
