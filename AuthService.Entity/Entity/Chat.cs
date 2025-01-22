using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthService.Entity.Entity;
/// <summary>
/// edge_auth_db.edge_chat_table;
/// </summary>
[Table("Chat")]
public class Chat : _Base
{
    //public string SaveId { get; set; }
    public string TenantId { get; set; }
    public string UserId { get; set; }
    public string UserMessage { get; set; }
    public string UserName { get; set; }
    //public DateTime? UpdatedTimeStamp { get; set; }
    public bool? IsRead { get; set; }
    //public DateTime? CreatedTimeStamp { get; set; }
    public string ChatType { get; set; }
    public int? ChamberChatId { get; set; }
    public int? ChamberId { get; set; }
}

