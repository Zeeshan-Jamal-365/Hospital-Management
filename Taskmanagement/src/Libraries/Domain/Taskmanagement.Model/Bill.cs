using Taskmanagement.Shared.Common;

namespace Taskmanagement.Model;
public class Bill : BaseEntity, IEntity
{
  
    public string PatName { get; set; }
    public string DrName { get; set; }
    public DateTimeOffset DateTime { get; set; }
    public string Amount { get; set; }
    public int PatId { get; set; }
    public Patient? Patient { get; set; }
}

