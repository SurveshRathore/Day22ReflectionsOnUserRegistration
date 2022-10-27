using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationProblem
{
    internal class UC1ValidateFirstName
    {
        //method to validate the first name
        public void CheckFirstName()
        {
            //first name regex
            String nameRegex = "^[A-Z][a-zA-Z]{2,}"; 
            Console.Write("Enter the First Name: ");
            String userName = Console.ReadLine();
            //compare the name regex with the user entered first name
            bool valid = Regex.IsMatch(userName, nameRegex);
            Console.WriteLine(valid);
        }
    }
}
