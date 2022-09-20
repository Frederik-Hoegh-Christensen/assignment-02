using System.ComponentModel.Design;
using System.Text;

namespace Student;

public class Student{

    
    
    public int id {get; init;}
    public String GivenName { get; set; } = null!;
    public String SurName { get; set; } =null!;
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }
    public Enum Status { get => getStatus(); }

    public Enum getStatus (){
        if (DateTime.Today < this.StartDate)
        {
            return StatusEnum.New;

        } else if(this.StartDate < DateTime.Today){
        
            if(DateTime.Today < this.EndDate){
                return StatusEnum.Active;
            } else if(this.EndDate < DateTime.Today && this.EndDate < this.GraduationDate){
                return StatusEnum.Dropout;
            } 
            
        }
        return StatusEnum.Graduated;
    }



    override public string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.Append("{Id: ");
        sb.Append(id);
        sb.Append("} ");
        sb.Append("{Given name: ");
        sb.Append(GivenName);
        sb.Append("} ");
        sb.Append("{SurName: ");
        sb.Append(SurName);
        sb.Append("} ");
        sb.Append("{Status: ");
        sb.Append(Status);
        sb.Append("} ");
        sb.Append("{Startdate: ");
        sb.Append(StartDate);
        sb.Append("} ");
        sb.Append("{Enddate: ");
        sb.Append(EndDate);
        sb.Append("} ");
        sb.Append("{Graduationdate: ");
        sb.Append(GraduationDate);
        sb.Append("} ");
        return sb.ToString();
        
        

        
    }

    public enum StatusEnum
{

    
    New,
    Active,
    Dropout,
    Graduated,

    

}

}

