using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationProblem
{
    internal class UC5PassMin8Char
    {
        public void CheckCharacterInPassword()
        {
            //password regex
            String nameRegex = "[A-Za-z0-9]{8}";
            //here \\s for space
            //^[a-zA-Z]{7}$ fix length
            //^[a-zA-Z]{3,7}$ length range
            Console.Write("Enter the password with minimum 8 characters: ");
            String passChar = Console.ReadLine();
            //compare the password regex with the user entered password
            bool valid = Regex.IsMatch(passChar, nameRegex);
            Console.WriteLine(valid);
        }
    }
}
