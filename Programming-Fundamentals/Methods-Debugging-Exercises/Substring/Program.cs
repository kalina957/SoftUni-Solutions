using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        count += 1;

        char search = (char)112;
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == search)
            {
                hasMatch = true;

                int endIndex = count;

                if (endIndex > text.Length-i)
                {
                    endIndex = text.Length-i;
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += count - 1;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
