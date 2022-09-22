namespace Assignment2;

public static class delegates{
     public delegate void rev(string s);
    

    public static void reverseOrder(string s){
        for (int i = s.Length; i > 0; i--)
        {
            Console.Write(s[i]);
        }
    }

    

    

}