using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Assignment2.Tests;

public class StudentTests{
    [Fact]
    public void ToStringTest()
    {
        // Given
        Student st = new Student{id = 1, GivenName = "Freddo", StartDate = new DateTime(2000, 12, 01), SurName = "Fredson", EndDate = new DateTime(2005,12,1), GraduationDate = new DateTime(2006,12,1)};
        

        
        // When
        var ouput = st.ToString();
        // Then

        ouput.Should().Be("{Id: 1} {Given name: Freddo} {SurName: Fredson} {Status: Dropout} {Startdate: " + new DateTime(2000, 12, 01).ToString() + "} {Enddate: " + new DateTime(2005, 12, 1).ToString() + "} {Graduationdate: " + new DateTime(2006, 12, 1).ToString() + "} ");
        }
    
    [Fact]
    public void TestImmutableStudentTostring()
    {
        // Given
        ImmutableStudent immutableStudent = new ImmutableStudent{id =  1, GivenName = "Freddo",
         StartDate = new DateTime(2000, 12, 01),
         SurName = "Fredson", 
         EndDate = new DateTime(2005,12,1),
         GraduationDate = new DateTime(2005,12,1),
        
        };
              
        
        // When
        var output = immutableStudent.GivenName.ToString();
        // Then

        output.Should().Be("Freddo");
        //output.Should().Be("ImmutableStudent { id = 1, GivenName = Freddo, SurName = Fredson, Status = , StartDate = 01/12/2000 00.00.00, EndDate = 01/12/2005 00.00.00, GraduationDate = 01/12/2005 00.00.00 }");
    }

    
}