namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri uri)
    {
        return (uri.Scheme == "https");
    }

    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' },
                         StringSplitOptions.RemoveEmptyEntries).Length;
    }

}
