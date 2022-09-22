using System.Text;
namespace Assignment2.Tests;

public class DelegatesTests
{

    delegate string func(string s);



    static string reverseorder(string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
    }




    [Fact]
    public void ReverseOrderTest()
    {
        // Given

        // When
        var result = reverse("asdf");
        // Then
        result.Should().Be("fdsa");
    }


    Func<double, double, double> product = Multiply;

    public static double Multiply(double a, double b) => a * b;
    func reverse = reverseorder;

    [Fact]
    public void ProductTest()
    {
        // Given
        double a = 7.5;
        double b = 1.5;

        // When
        double result = product(a, b);
        // Then
        result.Should().Be(11.25);
    }

    Func<string, int, bool> NumericallyEqual = testValuesLam;


    public static bool testValuesLam(string s, int i) => int.Parse(s) == i;


    [Fact]
    public void NumericallyEqualTest()
    {
        // Given
        string numberString = "        000001234";
        int number = 1234;
        // When
        var result = NumericallyEqual(numberString, number);
        // Then
        result.Should().Be(true);
    }
}
