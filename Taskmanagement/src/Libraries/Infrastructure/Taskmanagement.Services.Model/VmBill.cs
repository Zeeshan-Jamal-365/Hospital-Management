using Taskmanagement.Shared.Common;

namespace Taskmanagement.Services.Model;
public class VmBill : IVm
{
    public int Id { get; set; }
    public string PatName { get; set; }
    public string DrName { get; set; }
    public DateTimeOffset DateTime { get; set; }
    public string Amount { get; set; }
    public int PatId { get; set; }
}
