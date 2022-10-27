using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationProblem
{
    internal class UC8PassSpecialChar
    {
        public void CheckSpecialCharInPassword()
        {
            //one character in uppercase + one number + one special character password regex
            String nameRegex = "(?=.*\\W)(?=.*[A-Z])(?=.*[0-9]).{8}";
            //here \\w for non-word character
            Console.Write("Enter the password with minimum 8 characters: ");
            String passChar = Console.ReadLine();
            //compare the password regex with the user entered password
            bool valid = Regex.IsMatch(passChar, nameRegex);
            Console.WriteLine(valid);
        }
    }
}
