using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    public static string ConvertCharToString(string input)
    {
        char prevWord = ' ';
        int count = 0;
        StringBuilder result = new StringBuilder();
        foreach (char c in input)
        {
            if (c == prevWord)
            {
                count++;
            }
            else
            {
                // checking it is last of word of reperated word
                if (count > 0)
                {
                    result.Append(count + "" + prevWord + " ");
                }
                count = 1;
            }
            prevWord = c;
        }

        // add for the last word
        if (count > 0)
        {
            result.Append(count + "" + prevWord);
        }

        return result.ToString();
    }

    public static void Main(string[] args)
    {
        string input = "aaabbbcc";
        string result = ConvertCharToString(input);
        Console.WriteLine(result); // Output: a3 b3 c2
    }
}
