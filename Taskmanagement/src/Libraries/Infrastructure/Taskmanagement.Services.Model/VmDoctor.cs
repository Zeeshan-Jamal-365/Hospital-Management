using Taskmanagement.Shared.Common;

namespace Taskmanagement.Services.Model;
public class VmDoctor : IVm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string Designation { get; set; }
}
