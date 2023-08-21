using Taskmanagement.Shared.Common;

namespace Taskmanagement.Model;
public class PatientDiagnosis : BaseEntity, IEntity
{


    public string DiagDetails { get; set; }
    public string Remark { get; set; }
    public DateTimeOffset DiagDate { get; set; }
    public string Other { get; set; }
    public int Patid { get; set; }
    public Patient? Patient { get; set; }

}
