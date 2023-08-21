using Taskmanagement.Shared.Common;

namespace Taskmanagement.Model;
public class Staff : BaseEntity, IEntity
{
   
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string Cell { get; set; }
    public int DoctId { get; set; }
    public Doctor? Doctor { get; set; }
}
