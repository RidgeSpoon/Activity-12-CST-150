using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        // Two int for tracking total 't' or 'e' count and char placement in while loop.
        int letterCount = 0, charPlace = 0;

        string input = "A paragraph is defined as “a group of sentences or a single sentence that forms a unit” (Lunsford and Connors 116).\r\nLength and appearance do not determine whether a section in a paper is a paragraph.\r\nFor instance, in some styles of writing, particularly journalistic styles, a paragraph can be just one sentence long.";

        // Loop through string.
        while (charPlace <= input.Length - 1)
        {
            // If the character in the loop is a character used to indicate the end of a word & the character before that is a 't' or 'e'.
            if ((
                input[charPlace] == '.' ||
                input[charPlace] == ' ' ||
                input[charPlace] == '?' ||
                input[charPlace] == '!' ||
                input[charPlace] == ',' ||
                input[charPlace] == '\t' || // tab
                input[charPlace] == '\n') && // new line
                (input[charPlace - 1] == 't' || input[charPlace - 1] == 'e'))
            {
                letterCount++; // Increment if 't' or 'e' at the end of a word.
            }
            charPlace++; // Increment character placement in loop.
        }

        // Print results.
        Console.WriteLine("There are " + letterCount + " words ending in t or e");
    }
}