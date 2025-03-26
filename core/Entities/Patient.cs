namespace Library.Core.Entities;


public class Patient : IEntity
{
    public Id Id { get; set; } = null!;

    public string Name { get; set; } = null!;
    public DateTime DateB { get; set; }= null!;
    public ICollection<Genderar> Gender { get; set; }= null!;
    public  string PhoneNumber { get; set; } = null!;
    public string InsuranceNumber { get; set; } = null!;

}