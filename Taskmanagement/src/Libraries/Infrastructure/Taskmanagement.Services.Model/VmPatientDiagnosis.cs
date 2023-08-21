using Taskmanagement.Shared.Common;

namespace Taskmanagement.Services.Model;
public class VmPatientDiagnosis : IVm
{
    public int Id { get; set; }

    public string DiagDetails { get; set; }
    public string Remark { get; set; }
    public DateTimeOffset DiagDate { get; set; }
    public string Other { get; set; }
    public int Patid { get; set; }
}
