using Taskmanagement.Shared.Common;

namespace Taskmanagement.Model;
public class Doctor : BaseEntity, IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string Designation { get; set; }
    public ICollection<Patient> Patients { get; set; }  = new HashSet<Patient>();
    


}
