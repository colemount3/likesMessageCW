// See https://aka.ms/new-console-template for more information
using System;

// this code uses if statements to determine which format the sentence will be in

public static class Kata
{
   
    public static string Likes(string[] likers)
    {
        string output = "";
        if (likers.Length == 0 || likers[0] == null)
        { output = "no one likes this"; }
        else if (likers.Length == 1 && likers[0] != null)
        {
            output = $"{likers[0]} likes this";
        }

        else if (likers.Length == 2)
        {
            output = $"{likers[0]} and {likers[1]} like this";

        }

        else if (likers.Length == 3)
        {

            output = $"{likers[0]}, {likers[1]} and {likers[2]} like this";
        }
        else if (likers.Length >= 4)
        {
            int others = likers.Length - 2;
            output = $"{likers[0]}, {likers[1]} and {others} others like this";

        }
           return output;
    }
    public static void Main()
    {
        
        string[] likers = { "Cole", "Maddy" };
       string output = Likes(likers);
        Console.WriteLine(output);
        
    }

}