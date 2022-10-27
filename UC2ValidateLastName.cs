using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationProblem
{
    internal class UC2ValidateLastName
    {
        public void CheckLastName()
        {
            //last name regex
            String nameRegex = "^[A-Z][a-zA-Z]{2,}"; 
            Console.Write("Enter the Last Name: ");
            String LastName = Console.ReadLine();
            //compare the last name regex with the user entered last name
            bool valid = Regex.IsMatch(LastName, nameRegex);
            Console.WriteLine(valid);
        }
    }
}
