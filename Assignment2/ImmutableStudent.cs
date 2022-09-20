

using System.Text;

public record ImmutableStudent{
    public int id {get; init;}
    public String GivenName { get; set; } = null!;
    public String SurName { get; set; } =null!;
    public Enum Status {get;} = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    

}