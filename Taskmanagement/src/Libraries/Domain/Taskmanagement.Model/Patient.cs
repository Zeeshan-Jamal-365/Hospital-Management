using Taskmanagement.Shared.Common;

namespace Taskmanagement.Model;
public class Patient : BaseEntity, IEntity
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public int DrId { get; set; }
    public Doctor Doctor { get; set; }  

    public ICollection<Bill> Bill { get; set; }=new HashSet<Bill>();
    public ICollection<PatientDiagnosis> PatientDiagnosis { get; set; } = new HashSet<PatientDiagnosis>();

}
