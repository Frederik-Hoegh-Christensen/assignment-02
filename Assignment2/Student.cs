public class Student {
    public int id {get; init;}
    public string? givenName;
    public string? surName;
    public Status status {get;}
    public DateTime startDate;
    public DateTime endDate;
    public DateTime graduationDate;

    public override string ToString(){
        return id + ", " + givenName + " " + surName + ", StartDate: " + startDate;
    }

}

public enum Status {
    New,
    Active,
    Dropout,
    Graduated
}

public record ImmutableStudent(int Id, string GivenName, string SurName, Status Status, DateTime StartDate, DateTime EndDate, DateTime GraduationDate);

