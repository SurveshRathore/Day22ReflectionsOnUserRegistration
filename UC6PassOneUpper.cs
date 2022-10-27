using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationProblem
{
    internal class UC6PassOneUpper
    {
        public void CheckUpperCaseInPassword()
        {
            //one character in uppercase password regex
            String nameRegex = "(?=.*[A-Z]).{8}";
            Console.Write("Enter the password with minimum 8 characters: ");
            String passChar = Console.ReadLine();
            //compare the password regex with the user entered password
            bool valid = Regex.IsMatch(passChar, nameRegex);
            Console.WriteLine(valid);
        }
    }
}
