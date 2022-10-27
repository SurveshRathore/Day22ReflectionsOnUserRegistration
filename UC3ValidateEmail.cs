using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationProblem
{
    internal class UC3ValidateEmail
    {
        public void CheckEmail()
        {
            //email regex
            String nameRegex = "^[A-Za-z][A-Za-z0-9]{2,}([.]([A-Za-z0-9]{3,}))?@[a-z]{2,}[.][a-z]{2,}([.][a-z]{2,})?";
            //starts with A-Za-z then must have two or more A-Za-z0-9
            //([.]([A-Za-z0-9]{3,}))? optional
            //([.][a-z]{2})? optional
            Console.Write("Enter the Email: ");
            String email = Console.ReadLine();
            //compare the email regex with the user entered email
            bool valid = Regex.IsMatch(email, nameRegex);
            Console.WriteLine(valid);
        }
    }
}
