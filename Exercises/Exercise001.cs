using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Replace the exception statement below with your code!
            if(word.Length > 0)
            {
                return $"{char.ToUpper(word[0])}{word[1..]}";
            }
            // If string is empty
            return string.Empty;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Replace the exception statement below with your code!
            return $"{firstName[0]}.{lastName[0]}";
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            return Math.Round(originalPrice * ( 1 + (vatRate / 100)), 2);
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            if(sentence.Length > 0)
            {
                string reversed = "";
                for (int i = sentence.Length - 1; i > -1; i--)
                {
                    reversed += sentence[i];
                }
                return reversed;
            };
            // Empty sentence
            return string.Empty;
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            int linuxUsers = 0;
            foreach (User user in users)
            {
                if (user.Type =="Linux")
                    {
                        linuxUsers++;
                    }
            }
            return linuxUsers;
        }
    }
}
