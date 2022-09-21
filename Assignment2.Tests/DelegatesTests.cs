using System.Collections;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.Win32;

namespace Assignment2.Tests;

public class DelegatesTests
{
    Func<string, string> reverse = reverseString;


    static string reverseString(string str){
        StringBuilder sb = new StringBuilder();
        
        for (int i = str.Length-1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }


    [Fact]
    public void ReverseStringTest()
    {
        // Given
        string testString = "abcd";
        // When
        var result = reverse(testString);
        // Then
        result.Should().Be("dcba");
    }   

    Func<double,double,double> product = multiply;

    static double multiply (double a, double b) => a*b;

    [Fact]
    public void TestProduct()
    {
        // Given
        double a = 7.5;
        double b = 1.5;
        // When
        var result = product(a,b);
        // Then
        result.Should().Be(11.25);
    }
}
