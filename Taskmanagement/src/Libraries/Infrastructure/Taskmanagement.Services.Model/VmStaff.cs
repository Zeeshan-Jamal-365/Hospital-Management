using Taskmanagement.Shared.Common;

namespace Taskmanagement.Services.Model;
public class VmStaff : IVm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Dept { get; set; }

    public string Gender { get; set; }
    public string Address { get; set; }
    public string Cell { get; set; }

    public int DrId { get; set; }
}
