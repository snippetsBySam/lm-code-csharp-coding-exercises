using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            // Replace the exception statement below with your code!
            // counter for letters found
            int lettersFound = 0;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            // set the input to lower case
            string phrase = input.ToLower();
            foreach(char letter in alphabet)
            {
                if (phrase.IndexOf(letter) > -1)
                {
                    // add 1 to number of letters found
                    lettersFound++;
                }
            }
            // returns true if all 26 letters are found, otherwise false
            return lettersFound == 26;
        }
    }
}
