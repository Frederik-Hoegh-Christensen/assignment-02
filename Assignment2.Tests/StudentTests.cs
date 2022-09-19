using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Student.Tests;

public class StudentTests{
    [Fact]
    public void ToStringTest()
    {
        // Given
        Student st = new Student{id = 1, GivenName = "Freddo", StartDate = new DateTime(2000, 12, 01), SurName = "Fredson", EndDate = new DateTime(2005,12,1), GraduationDate = new DateTime(2005,12,1)};
        

        
        // When
        var ouput = st.ToString();
        // Then

        ouput.Should().Be("{Id: 1} {Given name: Freddo} {SurName: Fredson} {Status: } {Startdate: 01/12/2000 00.00.00} {Enddate: 01/12/2005 00.00.00} {Graduationdate: 01/12/2005 00.00.00} ");
    }
}