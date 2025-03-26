namespace Library.Core.Entities;

public class Appointment : IEntity 
{
    public Id Id { get; set; } = null!;

    public virtual ICollection<Patient> Patient { get; set; } = [];
    public DateTime AppointmentDate { get; set; } = null!;
    public Guid DoctorId { get; set; } = null!;
    public int ClinicalRecords { get; set; } = null!;
    public Guid QueueStatusID { get; set; } = null!;

}