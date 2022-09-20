

using System.Text;

public record ImmutableStudent{
    public int id {get; init;}
    public String GivenName { get; init; } = null!;
    public String SurName { get; init; } =null!;
    public Enum Status {get;} = null!;
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public DateTime GraduationDate { get; init; }


     public enum StatusEnum
{
    New,
    Active,
    Dropout,
    Graduated,
}
    public Enum getStatus (DateTime now, Student s){
        if (now < this.StartDate)
        {
            return StatusEnum.New;

        } else if(this.StartDate < now){
        
            if(now < this.EndDate){
                return StatusEnum.Active;
            } else if(this.EndDate < now && this.EndDate < this.GraduationDate){
                return StatusEnum.Dropout;
            } 
            
        }
        return StatusEnum.Graduated;
    }

}