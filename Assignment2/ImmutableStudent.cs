

using System.Text;

public record ImmutableStudent{
    public int id {get; init;}
    public String GivenName { get; init; } = null!;
    public String SurName { get; init; } =null!;
    public Enum Status {get;} = null!;
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public DateTime GraduationDate { get; init; }

    

}