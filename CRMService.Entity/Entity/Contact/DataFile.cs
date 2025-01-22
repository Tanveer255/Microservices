using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMService.Entity.Entity.Contact.Contact;
public class DataFile : _Base
{
    public Guid ContactFileId { get; set; }
    public string SpecificationType { get; set; }
    public string FileName { get; set; }
    public string DocType { get; set; }
    public string WhenAttached { get; set; }
    public string ValidTillDateTime { get; set; }
    public string NoOfPages { get; set; }
    public string FileData { get; set; }
    public string FilePath { get; set; }
    public string Comments { get; set; }
    public Guid ContactSaveId { get; set; }
}
