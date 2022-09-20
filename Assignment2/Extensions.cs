namespace Assignment2;

public static class Extensions
{
    public static int[] Divisble_By_7_Greater_Than_42 (this int[] items)
    {
        var temp = new List<int>();
        foreach (var item in items)
        {
            if (item % 7 == 0 && item > 42)
            {
                temp.Add(item);
            }
        }
        return temp.ToArray();
    }

    public static int[] Find_Leap_Years(this int[] items)
    {
        var temp = new List<int>();
        foreach (var item in items)
        {
            if (DateTime.IsLeapYear(item))
                temp.Add(item);
        }
        return temp.ToArray();
    }
}
